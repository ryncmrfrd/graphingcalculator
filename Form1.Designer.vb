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
        Me.txtLowerBound = New System.Windows.Forms.TextBox()
        Me.lblUpperBound = New System.Windows.Forms.Label()
        Me.txtUpperBound = New System.Windows.Forms.TextBox()
        Me.chkAntialiasing = New System.Windows.Forms.CheckBox()
        CType(Me.pbxGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEquation
        '
        Me.txtEquation.Location = New System.Drawing.Point(518, 445)
        Me.txtEquation.Name = "txtEquation"
        Me.txtEquation.Size = New System.Drawing.Size(100, 20)
        Me.txtEquation.TabIndex = 5
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
        Me.lblLowerBound.Size = New System.Drawing.Size(73, 13)
        Me.lblLowerBound.TabIndex = 0
        Me.lblLowerBound.Text = "Lower Bound:"
        '
        'txtLowerBound
        '
        Me.txtLowerBound.Location = New System.Drawing.Point(518, 25)
        Me.txtLowerBound.Name = "txtLowerBound"
        Me.txtLowerBound.Size = New System.Drawing.Size(100, 20)
        Me.txtLowerBound.TabIndex = 1
        Me.txtLowerBound.Text = "-25"
        '
        'lblUpperBound
        '
        Me.lblUpperBound.AutoSize = True
        Me.lblUpperBound.Location = New System.Drawing.Point(515, 48)
        Me.lblUpperBound.Name = "lblUpperBound"
        Me.lblUpperBound.Size = New System.Drawing.Size(73, 13)
        Me.lblUpperBound.TabIndex = 2
        Me.lblUpperBound.Text = "Upper Bound:"
        '
        'txtUpperBound
        '
        Me.txtUpperBound.Location = New System.Drawing.Point(518, 64)
        Me.txtUpperBound.Name = "txtUpperBound"
        Me.txtUpperBound.Size = New System.Drawing.Size(100, 20)
        Me.txtUpperBound.TabIndex = 3
        Me.txtUpperBound.Text = "25"
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
        'graphForm
        '
        Me.AcceptButton = Me.btnGraph
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 521)
        Me.Controls.Add(Me.chkAntialiasing)
        Me.Controls.Add(Me.lblUpperBound)
        Me.Controls.Add(Me.txtUpperBound)
        Me.Controls.Add(Me.lblLowerBound)
        Me.Controls.Add(Me.txtLowerBound)
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
    Friend WithEvents txtLowerBound As TextBox
    Friend WithEvents lblUpperBound As Label
    Friend WithEvents txtUpperBound As TextBox
    Friend WithEvents chkAntialiasing As CheckBox
End Class
