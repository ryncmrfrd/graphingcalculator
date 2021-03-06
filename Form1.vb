Public Class graphForm

    Dim brdrPen As Pen = New Pen(Color.Gray, 1),
        axisPen As Pen = New Pen(Color.Red, 1),
        gridPen As Pen = New Pen(Color.LightGray, 1),
        mainPen As Pen = New Pen(Color.Blue, 1)

    Private Sub pbxGraph_Paint(sender As Object, e As PaintEventArgs) Handles pbxGraph.Paint
        If Not String.IsNullOrEmpty(txtEquation.Text) Then
            e.Graphics.SmoothingMode = If(chkAntialiasing.Checked, Drawing2D.SmoothingMode.AntiAlias, Drawing2D.SmoothingMode.None)

            Dim xSetLowerBound As Integer = Integer.Parse(txtXLowerBound.Text),
                xSetUpperBound As Integer = Integer.Parse(txtXUpperBound.Text)

            Dim ySetLowerBound As Integer = Integer.Parse(txtYLowerBound.Text),
                ySetUpperBound As Integer = Integer.Parse(txtYUpperBound.Text)

            paintAxisGridLines(e, pbxGraph.Size, xSetLowerBound, xSetUpperBound, ySetLowerBound, ySetUpperBound)
            painGraphFromExpression(txtEquation.Text, e, pbxGraph.Size, xSetLowerBound, xSetUpperBound, ySetLowerBound, ySetUpperBound)
        End If

        e.Graphics.DrawRectangle(brdrPen, 0, 0, pbxGraph.Width - 1, pbxGraph.Height - 1)
    End Sub

    Private Sub btnGraph_Click(sender As Object, e As EventArgs) Handles btnGraph.Click
        pbxGraph.Invalidate()
    End Sub

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

        Dim ix = 0
        For x = xLowerBound To xUpperBound Step 1
            Dim xAdj As Integer = ((1 / xDifference) * ix) * boxControlSize.Width
            painObject.Graphics.DrawLine(If(x = 0, Me.axisPen, Me.gridPen), xAdj, 0, xAdj, boxControlSize.Height)
            ix += 1
        Next

        Dim iy = 0
        For y = yUpperBound To yLowerBound Step -1
            Dim yAdj As Integer = ((1 / yDifference) * iy) * boxControlSize.Height
            painObject.Graphics.DrawLine(If(y = 0, Me.axisPen, Me.gridPen), 0, yAdj, boxControlSize.Width, yAdj)
            iy += 1
        Next
    End Sub

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

    Public Function tryCalcYValue(
        ByVal fn As String,
        ByVal x As Integer
    )
        Dim y As Integer

        Try
            y = New DataTable().Compute(fn.ToLower().Replace("x", Str(x)), Nothing)
        Catch ex As Exception
            MsgBox("Invalid function. TEMP action: Closing application") ' TEMP FIXME please
            End
            Return False
        End Try

        Return y
    End Function

    Public Function adjustPointValue(
        ByVal val As Integer,
        ByVal axis As String,
        ByVal axisUpperBound As Integer,
        ByVal axisLowerBound As Integer,
        ByVal controlAxisSize As Integer
    )
        Dim axisDifference As Integer = axisUpperBound - axisLowerBound,
            numerator As Integer,
            res As Integer

        If axis = "x" Then
            numerator = axisUpperBound - (axisUpperBound + axisLowerBound)
            res = (controlAxisSize - ((numerator / axisDifference) * controlAxisSize)) + ((val / axisDifference) * controlAxisSize)
        ElseIf axis = "y" Then
            numerator = axisUpperBound - (axisUpperBound + axisLowerBound)
            res = (controlAxisSize - ((1 - (numerator / axisDifference)) * controlAxisSize)) + ((val / axisDifference) * controlAxisSize)
        End If

        Return res
    End Function

End Class