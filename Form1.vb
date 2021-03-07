Public Class graphForm

    ' Set default graphics pen colours.
    Dim brdrPen As Pen = New Pen(Color.Gray, 1),
        axisPen As Pen = New Pen(Color.Red, 1),
        gridPen As Pen = New Pen(Color.LightGray, 1),
        mainPen As Pen = New Pen(Color.Blue, 1)

    ' Set default axis bounds.
    Dim xSetLowerBound As Integer = -25,
        xSetUpperBound As Integer = 25,
        ySetLowerBound As Integer = -25,
        ySetUpperBound As Integer = 25

    ' Handle move axis buttons (btn{X/Y}{Plus/Minus})
    Private Sub boundButtons_Click(sender As Object, e As EventArgs) Handles btnXPlus.Click, btnXMinus.Click, btnYPlus.Click, btnYMinus.Click
        Dim controlName As String = DirectCast(sender, System.Windows.Forms.Button).Name
        Select Case controlName
            Case "btnXPlus"
                txtXLowerBound.Text = Val(txtXLowerBound.Text) + 1
                txtXUpperBound.Text = Val(txtXUpperBound.Text) + 1
            Case "btnYPlus"
                txtYLowerBound.Text = Val(txtYLowerBound.Text) + 1
                txtYUpperBound.Text = Val(txtYUpperBound.Text) + 1
            Case "btnXMinus"
                txtXLowerBound.Text = Val(txtXLowerBound.Text) - 1
                txtXUpperBound.Text = Val(txtXUpperBound.Text) - 1
            Case "btnYMinus"
                txtYLowerBound.Text = Val(txtYLowerBound.Text) - 1
                txtYUpperBound.Text = Val(txtYUpperBound.Text) - 1
        End Select
        pbxGraph.Invalidate() ' Force graph repaint.
    End Sub

    ' Handle axis scale buttons (btn{X/Y}{Plus/Minus})
    Private Sub scaleButtons_Click(sender As Object, e As EventArgs) Handles btnXScalePlus.Click, btnXScaleMinus.Click, btnYScalePlus.Click, btnYScaleMinus.Click
        Dim controlName As String = DirectCast(sender, System.Windows.Forms.Button).Name
        Select Case controlName
            Case "btnXScalePlus"
                txtXLowerBound.Text = Val(txtXLowerBound.Text) + 1
                txtXUpperBound.Text = Val(txtXUpperBound.Text) - 1
            Case "btnYScalePlus"
                txtYLowerBound.Text = Val(txtYLowerBound.Text) + 1
                txtYUpperBound.Text = Val(txtYUpperBound.Text) - 1
            Case "btnXScaleMinus"
                txtXLowerBound.Text = Val(txtXLowerBound.Text) - 1
                txtXUpperBound.Text = Val(txtXUpperBound.Text) + 1
            Case "btnYScaleMinus"
                txtYLowerBound.Text = Val(txtYLowerBound.Text) - 1
                txtYUpperBound.Text = Val(txtYUpperBound.Text) + 1
        End Select
        pbxGraph.Invalidate() ' Force graph repaint.
    End Sub

    ' Validate bounds to avoid potential arithmetic errors.
    Private Sub boundsTextBoxes_TextChanged(sender As Object, e As EventArgs) Handles txtXLowerBound.TextChanged, txtXUpperBound.TextChanged, txtYLowerBound.TextChanged, txtYUpperBound.TextChanged
        If txtXLowerBound.Text = txtXUpperBound.Text Then
            txtXLowerBound.Text = "-1"
            txtXUpperBound.Text = "1"
        End If

        If txtYLowerBound.Text = txtYUpperBound.Text Then
            txtYLowerBound.Text = "-1"
            txtYUpperBound.Text = "1"
        End If
    End Sub

    ' Handle graph panel paint event.
    Private Sub pbxGraph_Paint(sender As Object, e As PaintEventArgs) Handles pbxGraph.Paint
        If Not String.IsNullOrEmpty(txtEquation.Text) Then
            e.Graphics.SmoothingMode = If(chkAntialiasing.Checked, Drawing2D.SmoothingMode.AntiAlias, Drawing2D.SmoothingMode.None)

            ' TODO make more elegent
            Try
                xSetLowerBound = Integer.Parse(txtXLowerBound.Text)
                xSetUpperBound = Integer.Parse(txtXUpperBound.Text)
                ySetLowerBound = Integer.Parse(txtYLowerBound.Text)
                ySetUpperBound = Integer.Parse(txtYUpperBound.Text)
            Catch ex As Exception
                Return ' Returns if bound cannot be parsed as an integer
            End Try

            If xSetLowerBound = xSetUpperBound Or ySetLowerBound = ySetUpperBound Then
                Return
            End If

            paintAxisGridLines(e, pbxGraph.Size, xSetLowerBound, xSetUpperBound, ySetLowerBound, ySetUpperBound)
            painGraphFromExpression(txtEquation.Text, e, pbxGraph.Size, xSetLowerBound, xSetUpperBound, ySetLowerBound, ySetUpperBound)
        End If

        e.Graphics.DrawRectangle(brdrPen, 0, 0, pbxGraph.Width - 1, pbxGraph.Height - 1)
    End Sub

    ' Handle click event of "graph" button.
    Private Sub btnGraph_Click(sender As Object, e As EventArgs) Handles btnGraph.Click
        ' TODO make automatic?
        pbxGraph.Invalidate() ' Force graph repaint.
    End Sub

    ' "Gracefully" handles incorrect/invalid graphical functions.
    Public Sub handleInvalidExpression()
        txtEquation.Text = ""
    End Sub

    ' Paint grey + red axis lines based on axis bounds.
    Public Sub paintAxisGridLines(
        ByVal painObject As PaintEventArgs,
        ByVal boxControlSize As Size,
        ByVal xLowerBound As Integer,
        ByVal xUpperBound As Integer,
        ByVal yLowerBound As Integer,
        ByVal yUpperBound As Integer
    )
        Dim xDifference As Integer = xUpperBound - xLowerBound
        Dim yDifference As Integer = yUpperBound - yLowerBound

        Dim ixwhenzero As Integer ' Terrible solution for saving iterator at zero.

        Dim ix = 0
        For x = xLowerBound To xUpperBound Step 1
            Dim xAdj As Integer = ((1 / xDifference) * ix) * boxControlSize.Width
            painObject.Graphics.DrawLine(Me.gridPen, xAdj, 0, xAdj, boxControlSize.Height)
            If x = 0 Then
                ixwhenzero = ix
            End If
            ix += 1
        Next

        Dim iywhenzero As Integer ' Terrible solution for saving iterator at zero.

        Dim iy = 0
        For y = yUpperBound To yLowerBound Step -1
            Dim yAdj As Integer = ((1 / yDifference) * iy) * boxControlSize.Height
            painObject.Graphics.DrawLine(Me.gridPen, 0, yAdj, boxControlSize.Width, yAdj)
            If y = 0 Then
                iywhenzero = iy
            End If
            iy += 1
        Next

        ' Paint red "axis" lines over all grey "grid" lines.
        Dim xAdjWhenZero As Integer = ((1 / xDifference) * ixwhenzero) * boxControlSize.Width
        Dim yAdjWhenZero As Integer = ((1 / yDifference) * iywhenzero) * boxControlSize.Height
        painObject.Graphics.DrawLine(Me.axisPen, xAdjWhenZero, 0, xAdjWhenZero, boxControlSize.Height)
        painObject.Graphics.DrawLine(Me.axisPen, 0, yAdjWhenZero, boxControlSize.Width, yAdjWhenZero)
    End Sub

    ' Create array of x,y points then draw curve based on array.
    Public Sub painGraphFromExpression(
        ByVal expression As String,
        ByVal painObject As PaintEventArgs,
        ByVal boxControlSize As Size,
        ByVal xLowerBound As Integer,
        ByVal xUpperBound As Integer,
        ByVal yLowerBound As Integer,
        ByVal yUpperBound As Integer
    )
        Dim xDifference As Integer = xUpperBound - xLowerBound
        Dim yDifference As Integer = yUpperBound - yLowerBound

        Dim arrGraphPoints(xDifference) As Point

        Dim i As Integer = 0
        For x = xLowerBound To xUpperBound

            Dim y As Integer = tryCalcYValue(expression, x)

            Dim xAdj As Integer = adjustPointValue(x, "x", xLowerBound, xUpperBound, boxControlSize.Width),
                yAdj As Integer = adjustPointValue(y, "y", yLowerBound, yUpperBound, boxControlSize.Height)

            arrGraphPoints(i) = New Point(xAdj, yAdj)

            i += 1
        Next

        painObject.Graphics.DrawCurve(Me.mainPen, arrGraphPoints)
    End Sub

    ' Try structure wrapping call of mcCalc class to evaluate string as mathematical expression.
    Public Function tryCalcYValue(
        ByVal fn As String,
        ByVal x As Integer
    )
        Dim y As Integer

        Try
            Dim calc As New mcCalc()
            y = calc.evaluate(fn.ToLower().Replace("x", x)) ' Evaluate expression using mcCalc imported class.
        Catch ex As Exception
            Me.handleInvalidExpression()
        End Try

        Return y
    End Function

    ' Adjust x/y values as percentage of control width + relative location of axes.
    Public Function adjustPointValue(
        ByVal val As Integer,
        ByVal axis As String,
        ByVal axisLowerBound As Integer,
        ByVal axisUpperBound As Integer,
        ByVal controlAxisSize As Integer
    )
        Dim axisDifference As Integer = axisUpperBound - axisLowerBound,
            numerator As Integer,
            res As Integer

        If axis = "x" Then
            numerator = axisUpperBound - (axisUpperBound + axisLowerBound)
            res = ((val / axisDifference) * controlAxisSize) + ((numerator / axisDifference) * controlAxisSize)
        ElseIf axis = "y" Then
            numerator = axisDifference - (axisUpperBound - (axisUpperBound + axisLowerBound))
            res = ((-val / axisDifference) * controlAxisSize) + ((numerator / axisDifference) * controlAxisSize)
        End If

        Return res
    End Function

End Class

' --------------------- Mathematical Expression Evaluator ---------------------
' Credit to Michael Combs https://www.codeproject.com/Members/Michael-Combs
' Article: https://www.codeproject.com/Articles/3886/A-Math-Expression-Evaluator

Public Class mcCalc


    Public Class mcSymbol
        Implements IComparer

        Public Token As String
        Public Cls As mcCalc.TOKENCLASS
        Public PrecedenceLevel As PRECEDENCE
        Public tag As String

        Public Delegate Function compare_function(ByVal x As Object, ByVal y As Object) As Integer


        Public Overridable Overloads Function compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare

            Dim asym, bsym As mcSymbol
            asym = CType(x, mcSymbol)
            bsym = CType(y, mcSymbol)


            If asym.Token > bsym.Token Then Return 1

            If asym.Token < bsym.Token Then Return -1

            If asym.PrecedenceLevel = -1 Or bsym.PrecedenceLevel = -1 Then Return 0

            If asym.PrecedenceLevel > bsym.PrecedenceLevel Then Return 1

            If asym.PrecedenceLevel < bsym.PrecedenceLevel Then Return -1

            Return 0

        End Function

    End Class

    Public Enum PRECEDENCE
        NONE = 0
        LEVEL0 = 1
        LEVEL1 = 2
        LEVEL2 = 3
        LEVEL3 = 4
        LEVEL4 = 5
        LEVEL5 = 6
    End Enum

    Public Enum TOKENCLASS
        KEYWORD = 1
        IDENTIFIER = 2
        NUMBER = 3
        [OPERATOR] = 4
        PUNCTUATION = 5
    End Enum

    Public m_tokens As Collection
    Public m_State(,) As Integer
    Public m_KeyWords() As String
    Public m_colstring As String
    Public Const ALPHA As String = "_ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Public Const DIGITS As String = "#0123456789"

    Public m_funcs() As String = {"sin", "cos", "tan", "arcsin", "arccos",
                                 "arctan", "sqrt", "max", "min", "floor",
                                 "ceiling", "log", "log10",
                                 "ln", "round", "abs", "neg", "pos"}

    Public m_operators As ArrayList

    Public m_stack As New Stack()

    Public Sub init_operators()

        Dim op As mcSymbol

        m_operators = New ArrayList()

        op = New mcSymbol()
        op.Token = "-"
        op.Cls = TOKENCLASS.[OPERATOR]
        op.PrecedenceLevel = PRECEDENCE.LEVEL1
        m_operators.Add(op)

        op = New mcSymbol()
        op.Token = "+"
        op.Cls = TOKENCLASS.[OPERATOR]
        op.PrecedenceLevel = PRECEDENCE.LEVEL1
        m_operators.Add(op)

        op = New mcSymbol()
        op.Token = "*"
        op.Cls = TOKENCLASS.[OPERATOR]
        op.PrecedenceLevel = PRECEDENCE.LEVEL2
        m_operators.Add(op)

        op = New mcSymbol()
        op.Token = "/"
        op.Cls = TOKENCLASS.[OPERATOR]
        op.PrecedenceLevel = PRECEDENCE.LEVEL2
        m_operators.Add(op)

        op = New mcSymbol()
        op.Token = "\"
        op.Cls = TOKENCLASS.[OPERATOR]
        op.PrecedenceLevel = PRECEDENCE.LEVEL2
        m_operators.Add(op)

        op = New mcSymbol()
        op.Token = "%"
        op.Cls = TOKENCLASS.[OPERATOR]
        op.PrecedenceLevel = PRECEDENCE.LEVEL2
        m_operators.Add(op)

        op = New mcSymbol()
        op.Token = "^"
        op.Cls = TOKENCLASS.[OPERATOR]
        op.PrecedenceLevel = PRECEDENCE.LEVEL3
        m_operators.Add(op)

        op = New mcSymbol()
        op.Token = "!"
        op.Cls = TOKENCLASS.[OPERATOR]
        op.PrecedenceLevel = PRECEDENCE.LEVEL5
        m_operators.Add(op)

        op = New mcSymbol()
        op.Token = "&"
        op.Cls = TOKENCLASS.[OPERATOR]
        op.PrecedenceLevel = PRECEDENCE.LEVEL5
        m_operators.Add(op)

        op = New mcSymbol()
        op.Token = "-"
        op.Cls = TOKENCLASS.[OPERATOR]
        op.PrecedenceLevel = PRECEDENCE.LEVEL4
        m_operators.Add(op)

        op = New mcSymbol()
        op.Token = "+"
        op.Cls = TOKENCLASS.[OPERATOR]
        op.PrecedenceLevel = PRECEDENCE.LEVEL4
        m_operators.Add(op)

        op = New mcSymbol()
        op.Token = "("
        op.Cls = TOKENCLASS.[OPERATOR]
        op.PrecedenceLevel = PRECEDENCE.LEVEL5
        m_operators.Add(op)

        op = New mcSymbol()
        op.Token = ")"
        op.Cls = TOKENCLASS.[OPERATOR]
        op.PrecedenceLevel = PRECEDENCE.LEVEL0
        m_operators.Add(op)

        m_operators.Sort(op)
    End Sub


    Public Function evaluate(ByVal expression As String) As Double

        Dim symbols As Queue


        Try
            If IsNumeric(expression) Then Return CType(expression, Double)

            calc_scan(expression, symbols)

            Return level0(symbols)

        Catch
            graphForm.handleInvalidExpression()
        End Try

    End Function

    Public Function calc_op(ByVal op As mcSymbol, ByVal operand1 As Double, Optional ByVal operand2 As Double = Nothing) As Double


        Select Case op.Token.ToLower

            Case "&" ' sample to show addition of custom operator
                Return 5

            Case "^"
                Return (operand1 ^ operand2)

            Case "+"

                Select Case op.PrecedenceLevel
                    Case PRECEDENCE.LEVEL1
                        Return (operand2 + operand1)
                    Case PRECEDENCE.LEVEL4
                        Return operand1
                End Select

            Case "-"
                Select Case op.PrecedenceLevel
                    Case PRECEDENCE.LEVEL1
                        Return (operand1 - operand2)
                    Case PRECEDENCE.LEVEL4
                        Return -1 * operand1
                End Select


            Case "*"
                Return (operand2 * operand1)

            Case "/"
                Return (operand1 / operand2)

            Case "\"
                Return (CLng(operand1) \ CLng(operand2))

            Case "%"
                Return (operand1 Mod operand2)

            Case "!"
                Dim i As Integer
                Dim res As Double = 1

                If operand1 > 1 Then
                    For i = CInt(operand1) To 1 Step -1
                        res = res * i
                    Next

                End If
                Return (res)

        End Select

    End Function

    Public Function calc_function(ByVal func As String, ByVal args As Collection) As Double

        Select Case func.ToLower

            Case "cos"
                Return (Math.Cos(CDbl(args(1))))

            Case "sin"
                Return (Math.Sin(CDbl(args(1))))

            Case "tan"
                Return (Math.Tan(CDbl(args(1))))

            Case "floor"
                Return (Math.Floor(CDbl(args(1))))

            Case "ceiling"
                Return (Math.Ceiling(CDbl(args(1))))

            Case "max"
                Return (Math.Max(CDbl(args(1)), CDbl(args(2))))

            Case "min"
                Return (Math.Min(CDbl(args(1)), CDbl(args(2))))

            Case "arcsin"
                Return (Math.Asin(CDbl(args(1))))


            Case "arccos"
                Return (Math.Acos(CDbl(args(1))))

            Case "arctan"
                Return (Math.Atan(CDbl(args(1))))


            Case "sqrt"
                Return (Math.Sqrt(CDbl(args(1))))

            Case "log"
                Return (Math.Log10(CDbl(args(1))))


            Case "log10"
                Return (Math.Log10(CDbl(args(1))))


            Case "abs"
                Return (Math.Abs(CDbl(args(1))))


            Case "round"
                Return (Math.Round(CDbl(args(1))))

            Case "ln"
                Return (Math.Log(CDbl(args(1))))

            Case "neg"
                Return (-1 * CDbl(args(1)))

            Case "pos"
                Return (+1 * CDbl(args(1)))

        End Select

    End Function

    Public Function identifier(ByVal token As String) As Double

        Select Case token.ToLower

            Case "e"
                Return Math.E
            Case "pi"
                Return Math.PI
            Case Else
                ' look in symbol table....?
        End Select
    End Function

    Public Function is_operator(ByVal token As String, Optional ByVal level As PRECEDENCE = CType(-1, PRECEDENCE), Optional ByRef [operator] As mcSymbol = Nothing) As Boolean

        Try
            Dim op As New mcSymbol()
            op.Token = token
            op.PrecedenceLevel = level
            op.tag = "test"

            Dim ir As Integer = m_operators.BinarySearch(op, op)

            If ir > -1 Then

                [operator] = CType(m_operators(ir), mcSymbol)
                Return True
            End If

            Return False

        Catch
            Return False
        End Try
    End Function

    Public Function is_function(ByVal token As String) As Boolean

        Try
            Dim lr As Integer = Array.BinarySearch(m_funcs, token.ToLower)

            Return (lr > -1)

        Catch
            Return False
        End Try

    End Function


    Public Function calc_scan(ByVal line As String, ByRef symbols As Queue) As Boolean

        Dim sp As Integer  ' start position marker
        Dim cp As Integer  ' current position marker
        Dim col As Integer ' input column
        Dim lex_state As Integer
        Dim cls As TOKENCLASS
        Dim cc As Char
        Dim token As String

        symbols = New Queue()

        line = line & " " ' add a space as an end marker

        sp = 0
        cp = 0
        lex_state = 1


        Do While cp <= line.Length - 1

            cc = line.Chars(cp)

            ' if cc is not found then IndexOf returns -1 giving col = 2.
            col = m_colstring.IndexOf(cc) + 3

            ' set the input column 
            Select Case col

                Case 2 ' cc wasn't found in the column string

                    If ALPHA.IndexOf(Char.ToUpper(cc)) > 0 Then      ' letter column?
                        col = 1
                    ElseIf DIGITS.IndexOf(Char.ToUpper(cc)) > 0 Then ' number column?
                        col = 2
                    Else ' everything else is assigned to the punctuation column
                        col = 6
                    End If

                Case Is > 5 ' cc was found and is > 5 so must be in operator column
                    col = 7

                    ' case else ' cc was found - col contains the correct column

            End Select

            ' find the new state based on current state and column (determined by input)
            lex_state = m_State(lex_state - 1, col - 1)

            Select Case lex_state

                Case 3 ' function or variable  end state 

                    ' TODO variables aren't supported but substitution 
                    '      could easily be performed here or after
                    '      tokenization

                    Dim sym As New mcSymbol()

                    sym.Token = line.Substring(sp, cp - sp)
                    If is_function(sym.Token) Then
                        sym.Cls = TOKENCLASS.KEYWORD
                    Else
                        sym.Cls = TOKENCLASS.IDENTIFIER
                    End If

                    symbols.Enqueue(sym)

                    lex_state = 1
                    cp = cp - 1

                Case 5 ' number end state
                    Dim sym As New mcSymbol()

                    sym.Token = line.Substring(sp, cp - sp)
                    sym.Cls = TOKENCLASS.NUMBER

                    symbols.Enqueue(sym)

                    lex_state = 1
                    cp = cp - 1

                Case 6 ' punctuation end state
                    Dim sym As New mcSymbol()

                    sym.Token = line.Substring(sp, cp - sp + 1)
                    sym.Cls = TOKENCLASS.PUNCTUATION

                    symbols.Enqueue(sym)

                    lex_state = 1

                Case 7 ' operator end state

                    Dim sym As New mcSymbol()

                    sym.Token = line.Substring(sp, cp - sp + 1)
                    sym.Cls = TOKENCLASS.[OPERATOR]

                    symbols.Enqueue(sym)

                    lex_state = 1

            End Select

            cp += 1
            If lex_state = 1 Then sp = cp

        Loop

        Return True

    End Function

    Public Sub init()

        Dim op As mcSymbol

        Dim state(,) As Integer = {{2, 4, 1, 1, 4, 6, 7},
                                   {2, 3, 3, 3, 3, 3, 3},
                                   {1, 1, 1, 1, 1, 1, 1},
                                   {2, 4, 5, 5, 4, 5, 5},
                                   {1, 1, 1, 1, 1, 1, 1},
                                   {1, 1, 1, 1, 1, 1, 1},
                                   {1, 1, 1, 1, 1, 1, 1}}

        init_operators()


        m_State = state
        m_colstring = Chr(9) & " " & ".()"
        For Each op In m_operators
            m_colstring = m_colstring & op.Token
        Next


        Array.Sort(m_funcs)
        m_tokens = New Collection()

    End Sub


    Public Sub New()

        init()

    End Sub

#Region "Recusrsive Descent Parsing Functions"



    Public Function level0(ByRef tokens As Queue) As Double

        Return level1(tokens)

    End Function


    Public Function level1_prime(ByRef tokens As Queue, ByVal result As Double) As Double

        Dim symbol, [operator] As mcSymbol

        If tokens.Count > 0 Then
            symbol = CType(tokens.Peek, mcSymbol)
        Else
            Return result
        End If

        ' binary level1 precedence operators....+, -
        If is_operator(symbol.Token, PRECEDENCE.LEVEL1, [operator]) Then

            tokens.Dequeue()
            result = calc_op([operator], result, level2(tokens))
            result = level1_prime(tokens, result)

        End If


        Return result

    End Function

    Public Function level1(ByRef tokens As Queue) As Double

        Return level1_prime(tokens, level2(tokens))

    End Function

    Public Function level2(ByRef tokens As Queue) As Double

        Return level2_prime(tokens, level3(tokens))
    End Function

    Public Function level2_prime(ByRef tokens As Queue, ByVal result As Double) As Double

        Dim symbol, [operator] As mcSymbol

        If tokens.Count > 0 Then
            symbol = CType(tokens.Peek, mcSymbol)
        Else
            Return result
        End If

        ' binary level2 precedence operators....*, /, \, %

        If is_operator(symbol.Token, PRECEDENCE.LEVEL2, [operator]) Then

            tokens.Dequeue()
            result = calc_op([operator], result, level3(tokens))
            result = level2_prime(tokens, result)

        End If

        Return result

    End Function

    Public Function level3(ByRef tokens As Queue) As Double

        Return level3_prime(tokens, level4(tokens))

    End Function

    Public Function level3_prime(ByRef tokens As Queue, ByVal result As Double) As Double

        Dim symbol, [operator] As mcSymbol

        If tokens.Count > 0 Then
            symbol = CType(tokens.Peek, mcSymbol)
        Else
            Return result
        End If

        ' binary level3 precedence operators....^

        If is_operator(symbol.Token, PRECEDENCE.LEVEL3, [operator]) Then

            tokens.Dequeue()
            result = calc_op([operator], result, level4(tokens))
            result = level3_prime(tokens, result)

        End If


        Return result

    End Function

    Public Function level4(ByRef tokens As Queue) As Double

        Return level4_prime(tokens)
    End Function

    Public Function level4_prime(ByRef tokens As Queue) As Double

        Dim symbol, [operator] As mcSymbol

        If tokens.Count > 0 Then
            symbol = CType(tokens.Peek, mcSymbol)
        Else
            Throw New System.Exception("Invalid expression.")
        End If

        ' unary level4 precedence right associative  operators.... +, -

        If is_operator(symbol.Token, PRECEDENCE.LEVEL4, [operator]) Then

            tokens.Dequeue()
            Return calc_op([operator], level5(tokens))
        Else
            Return level5(tokens)
        End If


    End Function

    Public Function level5(ByVal tokens As Queue) As Double

        Return level5_prime(tokens, level6(tokens))

    End Function

    Public Function level5_prime(ByVal tokens As Queue, ByVal result As Double) As Double

        Dim symbol, [operator] As mcSymbol

        If tokens.Count > 0 Then
            symbol = CType(tokens.Peek, mcSymbol)
        Else
            Return result
        End If

        ' unary level5 precedence left associative operators.... !

        If is_operator(symbol.Token, PRECEDENCE.LEVEL5, [operator]) Then

            tokens.Dequeue()
            Return calc_op([operator], result)

        Else
            Return result
        End If

    End Function

    Public Function level6(ByRef tokens As Queue) As Double

        Dim symbol As mcSymbol

        If tokens.Count > 0 Then
            symbol = CType(tokens.Peek, mcSymbol)
        Else
            Throw New System.Exception("Invalid expression.")
            Return 0
        End If

        Dim val As Double


        ' constants, identifiers, keywords, -> expressions
        If symbol.Token = "(" Then ' opening paren of new expression

            tokens.Dequeue()
            val = level0(tokens)

            symbol = CType(tokens.Dequeue, mcSymbol)
            ' closing paren
            If symbol.Token <> ")" Then Throw New System.Exception("Invalid expression.")

            Return val
        Else

            Select Case symbol.Cls

                Case TOKENCLASS.IDENTIFIER
                    tokens.Dequeue()
                    Return identifier(symbol.Token)

                Case TOKENCLASS.KEYWORD
                    tokens.Dequeue()
                    Return calc_function(symbol.Token, arguments(tokens))
                Case TOKENCLASS.NUMBER

                    tokens.Dequeue()
                    m_stack.Push(CDbl(symbol.Token))
                    Return CDbl(symbol.Token)

                Case Else
                    Throw New System.Exception("Invalid expression.")
            End Select
        End If


    End Function

    Public Function arguments(ByVal tokens As Queue) As Collection

        Dim symbol As mcSymbol
        Dim args As New Collection()

        If tokens.Count > 0 Then
            symbol = CType(tokens.Peek, mcSymbol)
        Else
            Throw New System.Exception("Invalid expression.")
            Return Nothing
        End If

        Dim val As Double

        If symbol.Token = "(" Then

            tokens.Dequeue()
            args.Add(level0(tokens))

            symbol = CType(tokens.Dequeue, mcSymbol)
            Do While symbol.Token <> ")"

                If symbol.Token = "," Then
                    args.Add(level0(tokens))
                Else
                    Throw New System.Exception("Invalid expression.")
                    Return Nothing
                End If
                symbol = CType(tokens.Dequeue, mcSymbol)
            Loop

            Return args
        Else
            Throw New System.Exception("Invalid expression.")
            Return Nothing
        End If

    End Function

#End Region


End Class