Public Class Form1

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            painGraphFromExpression(e, PictureBox1.Size, -250, 250, -250, 250)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Invalidate()
    End Sub

    Public Sub painGraphFromExpression(
        ByVal painObject As PaintEventArgs,
        ByVal boxControlSize As Size,
        ByVal xLowerBound As Integer,
        ByVal xHigherBound As Integer,
        ByVal yLowerBound As Integer,
        ByVal yHigherBound As Integer
    )
        Dim xDifference As Integer = xHigherBound - xLowerBound
        Dim yDifference As Integer = yHigherBound - yLowerBound

        Dim arrGraphPoints(xDifference) As Point,
            bluePen As Pen = New Pen(Color.Red, 1)

        Dim i As Integer = 0
        For x = xLowerBound To xHigherBound

            Dim y As Integer = tryCalcYValue(TextBox1.Text, x)

            Dim xAdj As Integer = (xDifference / 2) - ((x / xDifference) * boxControlSize.Width),
                yAdj As Integer = (yDifference / 2) - ((y / yDifference) * boxControlSize.Height)

            arrGraphPoints(i) = New Point(xAdj, yAdj)

            i += 1
        Next

        painObject.Graphics.DrawCurve(bluePen, arrGraphPoints)
    End Sub

    Public Function tryCalcYValue(
        ByVal fn As String,
        ByVal x As Integer
    )
        Dim y As Integer

        Try
            y = New DataTable().Compute(fn.ToLower().Replace("x", Str(-x)), Nothing) ' graphic function
        Catch ex As Exception
            MsgBox("Invalid function. Close application")
            Return False
        End Try

        Return y
    End Function

End Class
