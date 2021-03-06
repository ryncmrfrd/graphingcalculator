<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class graphForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtEquation = New System.Windows.Forms.TextBox()
        Me.btnGraph = New System.Windows.Forms.Button()
        Me.pbxGraph = New System.Windows.Forms.PictureBox()
        Me.lblEquation = New System.Windows.Forms.Label()
        Me.lblLowerBound = New System.Windows.Forms.Label()
        Me.txtXLowerBound = New System.Windows.Forms.TextBox()
        Me.lblUpperBound = New System.Windows.Forms.Label()
        Me.txtXUpperBound = New System.Windows.Forms.TextBox()
        Me.chkAntialiasing = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtYUpperBound = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtYLowerBound = New System.Windows.Forms.TextBox()
        CType(Me.pbxGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEquation
        '
        Me.txtEquation.Location = New System.Drawing.Point(518, 445)
        Me.txtEquation.Name = "txtEquation"
        Me.txtEquation.Size = New System.Drawing.Size(100, 20)
        Me.txtEquation.TabIndex = 5
        Me.txtEquation.Text = "x"
        '
        'btnGraph
        '
        Me.btnGraph.Location = New System.Drawing.Point(518, 487)
        Me.btnGraph.Name = "btnGraph"
        Me.btnGraph.Size = New System.Drawing.Size(100, 23)
        Me.btnGraph.TabIndex = 7
        Me.btnGraph.Text = "Graph"
        Me.btnGraph.UseVisualStyleBackColor = True
        '
        'pbxGraph
        '
        Me.pbxGraph.Location = New System.Drawing.Point(10, 10)
        Me.pbxGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxGraph.Name = "pbxGraph"
        Me.pbxGraph.Size = New System.Drawing.Size(500, 500)
        Me.pbxGraph.TabIndex = 3
        Me.pbxGraph.TabStop = False
        '
        'lblEquation
        '
        Me.lblEquation.AutoSize = True
        Me.lblEquation.Location = New System.Drawing.Point(515, 429)
        Me.lblEquation.Name = "lblEquation"
        Me.lblEquation.Size = New System.Drawing.Size(52, 13)
        Me.lblEquation.TabIndex = 4
        Me.lblEquation.Text = "Equation:"
        '
        'lblLowerBound
        '
        Me.lblLowerBound.AutoSize = True
        Me.lblLowerBound.Location = New System.Drawing.Point(515, 9)
        Me.lblLowerBound.Name = "lblLowerBound"
        Me.lblLowerBound.Size = New System.Drawing.Size(83, 13)
        Me.lblLowerBound.TabIndex = 0
        Me.lblLowerBound.Text = "X Lower Bound:"
        '
        'txtXLowerBound
        '
        Me.txtXLowerBound.Location = New System.Drawing.Point(518, 25)
        Me.txtXLowerBound.Name = "txtXLowerBound"
        Me.txtXLowerBound.Size = New System.Drawing.Size(100, 20)
        Me.txtXLowerBound.TabIndex = 1
        Me.txtXLowerBound.Text = "-5"
        '
        'lblUpperBound
        '
        Me.lblUpperBound.AutoSize = True
        Me.lblUpperBound.Location = New System.Drawing.Point(515, 48)
        Me.lblUpperBound.Name = "lblUpperBound"
        Me.lblUpperBound.Size = New System.Drawing.Size(83, 13)
        Me.lblUpperBound.TabIndex = 2
        Me.lblUpperBound.Text = "X Upper Bound:"
        '
        'txtXUpperBound
        '
        Me.txtXUpperBound.Location = New System.Drawing.Point(518, 64)
        Me.txtXUpperBound.Name = "txtXUpperBound"
        Me.txtXUpperBound.Size = New System.Drawing.Size(100, 20)
        Me.txtXUpperBound.TabIndex = 3
        Me.txtXUpperBound.Text = "20"
        '
        'chkAntialiasing
        '
        Me.chkAntialiasing.AutoSize = True
        Me.chkAntialiasing.Checked = True
        Me.chkAntialiasing.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAntialiasing.Location = New System.Drawing.Point(518, 468)
        Me.chkAntialiasing.Name = "chkAntialiasing"
        Me.chkAntialiasing.Size = New System.Drawing.Size(85, 17)
        Me.chkAntialiasing.TabIndex = 6
        Me.chkAntialiasing.Text = "Antialiasing?"
        Me.chkAntialiasing.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(515, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Y Upper Bound:"
        '
        'txtYUpperBound
        '
        Me.txtYUpperBound.Location = New System.Drawing.Point(518, 168)
        Me.txtYUpperBound.Name = "txtYUpperBound"
        Me.txtYUpperBound.Size = New System.Drawing.Size(100, 20)
        Me.txtYUpperBound.TabIndex = 11
        Me.txtYUpperBound.Text = "25"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(515, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Y Lower Bound:"
        '
        'txtYLowerBound
        '
        Me.txtYLowerBound.Location = New System.Drawing.Point(518, 129)
        Me.txtYLowerBound.Name = "txtYLowerBound"
        Me.txtYLowerBound.Size = New System.Drawing.Size(100, 20)
        Me.txtYLowerBound.TabIndex = 9
        Me.txtYLowerBound.Text = "-25"
        '
        'graphForm
        '
        Me.AcceptButton = Me.btnGraph
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 521)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtYUpperBound)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtYLowerBound)
        Me.Controls.Add(Me.chkAntialiasing)
        Me.Controls.Add(Me.lblUpperBound)
        Me.Controls.Add(Me.txtXUpperBound)
        Me.Controls.Add(Me.lblLowerBound)
        Me.Controls.Add(Me.txtXLowerBound)
        Me.Controls.Add(Me.lblEquation)
        Me.Controls.Add(Me.pbxGraph)
        Me.Controls.Add(Me.btnGraph)
        Me.Controls.Add(Me.txtEquation)
        Me.Name = "graphForm"
        Me.Text = "Graph Equation"
        CType(Me.pbxGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEquation As TextBox
    Friend WithEvents btnGraph As Button
    Friend WithEvents pbxGraph As PictureBox
    Friend WithEvents lblEquation As Label
    Friend WithEvents lblLowerBound As Label
    Friend WithEvents txtXLowerBound As TextBox
    Friend WithEvents lblUpperBound As Label
    Friend WithEvents txtXUpperBound As TextBox
    Friend WithEvents chkAntialiasing As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtYUpperBound As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtYLowerBound As TextBox
End Class
