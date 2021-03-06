Public Class graphForm

    Dim brdrPen As Pen = New Pen(Color.Gray, 1),
        axisPen As Pen = New Pen(Color.Red, 1),
        gridPen As Pen = New Pen(Color.LightGray, 1),
        mainPen As Pen = New Pen(Color.Blue, 1)

    Private Sub pbxGraph_Paint(sender As Object, e As PaintEventArgs) Handles pbxGraph.Paint
        If Not String.IsNullOrEmpty(txtEquation.Text) Then
            e.Graphics.SmoothingMode = If(chkAntialiasing.Checked, Drawing2D.SmoothingMode.AntiAlias, Drawing2D.SmoothingMode.None)

            Dim xSetLowerBound As Integer = Integer.Parse(txtLowerBound.Text),
                xSetUpperBound As Integer = Integer.Parse(txtUpperBound.Text)

            paintAxisGridLines(e, pbxGraph.Size, xSetLowerBound, xSetUpperBound, xSetLowerBound, xSetUpperBound)
            painGraphFromExpression(txtEquation.Text, e, pbxGraph.Size, xSetLowerBound, xSetUpperBound, xSetLowerBound, xSetUpperBound)
        End If

        e.Graphics.DrawRectangle(brdrPen, 0, 0, pbxGraph.Width - 1, pbxGraph.Height - 1)
    End Sub

    Private Sub txtLowerBound_TextChanged(sender As Object, e As EventArgs) Handles txtLowerBound.TextChanged
        txtUpperBound.Text = Math.Abs(Integer.Parse(txtLowerBound.Text))
    End Sub

    Private Sub btnGraph_Click(sender As Object, e As EventArgs) Handles btnGraph.Click
        pbxGraph.Invalidate()
    End Sub

    Public Sub paintAxisGridLines(
        ByVal painObject As PaintEventArgs,
        ByVal boxControlSize As Size,
        ByVal xLowerBound As Integer,
        ByVal xHigherBound As Integer,
        ByVal yLowerBound As Integer,
        ByVal yHigherBound As Integer
    )
        Dim xDifference As Integer = xHigherBound - xLowerBound
        Dim yDifference As Integer = yHigherBound - yLowerBound

        For x = xLowerBound To xHigherBound
            Dim xAdj As Integer = adjustPointValue(x, xDifference, boxControlSize.Width)
            painObject.Graphics.DrawLine(If(x = 0, Me.axisPen, Me.gridPen), xAdj, 0, xAdj, boxControlSize.Height)
        Next

        For y = yLowerBound To yHigherBound
            Dim yAdj As Integer = adjustPointValue(y, yDifference, boxControlSize.Height)
            painObject.Graphics.DrawLine(If(y = 0, Me.axisPen, Me.gridPen), 0, yAdj, boxControlSize.Width, yAdj)
        Next

        ' AXIS LINES
        painObject.Graphics.DrawLine(Me.axisPen, adjustPointValue(0, xDifference, boxControlSize.Width), 0, adjustPointValue(0, xDifference, boxControlSize.Width), boxControlSize.Height)
        painObject.Graphics.DrawLine(Me.axisPen, 0, adjustPointValue(0, yDifference, boxControlSize.Height), boxControlSize.Width, adjustPointValue(0, yDifference, boxControlSize.Height))
    End Sub

    Public Sub painGraphFromExpression(
        ByVal expression As String,
        ByVal painObject As PaintEventArgs,
        ByVal boxControlSize As Size,
        ByVal xLowerBound As Integer,
        ByVal xHigherBound As Integer,
        ByVal yLowerBound As Integer,
        ByVal yHigherBound As Integer
    )
        Dim xDifference As Integer = xHigherBound - xLowerBound
        Dim yDifference As Integer = yHigherBound - yLowerBound

        Dim arrGraphPoints(xDifference) As Point

        Dim i As Integer = 0
        For x = xLowerBound To xHigherBound

            Dim y As Integer = tryCalcYValue(expression, x)

            Dim xAdj As Integer = adjustPointValue(x, xDifference, boxControlSize.Width),
                yAdj As Integer = adjustPointValue(y, yDifference, boxControlSize.Height)

            arrGraphPoints(i) = New Point(xAdj, yAdj)

            i += 1
        Next

        painObject.Graphics.DrawCurve(Me.mainPen, arrGraphPoints)
    End Sub

    Public Function adjustPointValue(
        ByVal val As Integer,
        ByVal axisDifference As Integer,
        ByVal controlAxisSize As Integer
    )
        Dim res As Integer = (controlAxisSize / 2) - ((val / axisDifference) * controlAxisSize)
        Return res
    End Function

    Public Function tryCalcYValue(
        ByVal fn As String,
        ByVal x As Integer
    )
        Dim y As Integer

        Try
            y = New DataTable().Compute(fn.ToLower().Replace("x", Str(-x)), Nothing)
        Catch ex As Exception
            MsgBox("Invalid function. TEMP action: Closing application") ' TEMP FIXME please
            End
            Return False
        End Try

        Return y
    End Function

End Class