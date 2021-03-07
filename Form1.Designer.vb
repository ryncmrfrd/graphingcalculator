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
        Me.components = New System.ComponentModel.Container()
        Me.txtEquation = New System.Windows.Forms.TextBox()
        Me.btnGraph = New System.Windows.Forms.Button()
        Me.pbxGraph = New System.Windows.Forms.PictureBox()
        Me.lblLowerBound = New System.Windows.Forms.Label()
        Me.txtXLowerBound = New System.Windows.Forms.TextBox()
        Me.lblUpperBound = New System.Windows.Forms.Label()
        Me.txtXUpperBound = New System.Windows.Forms.TextBox()
        Me.chkAntialiasing = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtYUpperBound = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtYLowerBound = New System.Windows.Forms.TextBox()
        Me.btnYPlus = New System.Windows.Forms.Button()
        Me.btnYMinus = New System.Windows.Forms.Button()
        Me.btnXMinus = New System.Windows.Forms.Button()
        Me.btnXPlus = New System.Windows.Forms.Button()
        Me.gbxYBounds = New System.Windows.Forms.GroupBox()
        Me.gbxXBounds = New System.Windows.Forms.GroupBox()
        Me.gbxEquation = New System.Windows.Forms.GroupBox()
        Me.gbxScale = New System.Windows.Forms.GroupBox()
        Me.btnYScaleMinus = New System.Windows.Forms.Button()
        Me.btnYScalePlus = New System.Windows.Forms.Button()
        Me.btnXScaleMinus = New System.Windows.Forms.Button()
        Me.lxlXScale = New System.Windows.Forms.Label()
        Me.lxlYScale = New System.Windows.Forms.Label()
        Me.btnXScalePlus = New System.Windows.Forms.Button()
        Me.lblDisclaimer = New System.Windows.Forms.Label()
        Me.ttpAntiAliassing = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.pbxGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxYBounds.SuspendLayout()
        Me.gbxXBounds.SuspendLayout()
        Me.gbxEquation.SuspendLayout()
        Me.gbxScale.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEquation
        '
        Me.txtEquation.Location = New System.Drawing.Point(6, 19)
        Me.txtEquation.Name = "txtEquation"
        Me.txtEquation.Size = New System.Drawing.Size(114, 20)
        Me.txtEquation.TabIndex = 0
        Me.txtEquation.Text = "-(x^2)"
        '
        'btnGraph
        '
        Me.btnGraph.Location = New System.Drawing.Point(6, 63)
        Me.btnGraph.Name = "btnGraph"
        Me.btnGraph.Size = New System.Drawing.Size(114, 23)
        Me.btnGraph.TabIndex = 2
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
        'lblLowerBound
        '
        Me.lblLowerBound.AutoSize = True
        Me.lblLowerBound.Location = New System.Drawing.Point(5, 16)
        Me.lblLowerBound.Name = "lblLowerBound"
        Me.lblLowerBound.Size = New System.Drawing.Size(73, 13)
        Me.lblLowerBound.TabIndex = 0
        Me.lblLowerBound.Text = "Lower Bound:"
        '
        'txtXLowerBound
        '
        Me.txtXLowerBound.Location = New System.Drawing.Point(8, 33)
        Me.txtXLowerBound.Name = "txtXLowerBound"
        Me.txtXLowerBound.Size = New System.Drawing.Size(85, 20)
        Me.txtXLowerBound.TabIndex = 1
        Me.txtXLowerBound.Text = "-25"
        '
        'lblUpperBound
        '
        Me.lblUpperBound.AutoSize = True
        Me.lblUpperBound.Location = New System.Drawing.Point(5, 55)
        Me.lblUpperBound.Name = "lblUpperBound"
        Me.lblUpperBound.Size = New System.Drawing.Size(73, 13)
        Me.lblUpperBound.TabIndex = 2
        Me.lblUpperBound.Text = "Upper Bound:"
        '
        'txtXUpperBound
        '
        Me.txtXUpperBound.Location = New System.Drawing.Point(8, 71)
        Me.txtXUpperBound.Name = "txtXUpperBound"
        Me.txtXUpperBound.Size = New System.Drawing.Size(85, 20)
        Me.txtXUpperBound.TabIndex = 3
        Me.txtXUpperBound.Text = "25"
        '
        'chkAntialiasing
        '
        Me.chkAntialiasing.AutoSize = True
        Me.chkAntialiasing.Checked = True
        Me.chkAntialiasing.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAntialiasing.Location = New System.Drawing.Point(6, 44)
        Me.chkAntialiasing.Name = "chkAntialiasing"
        Me.chkAntialiasing.Size = New System.Drawing.Size(85, 17)
        Me.chkAntialiasing.TabIndex = 1
        Me.chkAntialiasing.Text = "Antialiasing?"
        Me.ttpAntiAliassing.SetToolTip(Me.chkAntialiasing, "Antialiasing smoothes the edges of non-straight lines.")
        Me.chkAntialiasing.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Upper Bound:"
        '
        'txtYUpperBound
        '
        Me.txtYUpperBound.Location = New System.Drawing.Point(8, 71)
        Me.txtYUpperBound.Name = "txtYUpperBound"
        Me.txtYUpperBound.Size = New System.Drawing.Size(85, 20)
        Me.txtYUpperBound.TabIndex = 3
        Me.txtYUpperBound.Text = "25"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Lower Bound:"
        '
        'txtYLowerBound
        '
        Me.txtYLowerBound.Location = New System.Drawing.Point(8, 32)
        Me.txtYLowerBound.Name = "txtYLowerBound"
        Me.txtYLowerBound.Size = New System.Drawing.Size(85, 20)
        Me.txtYLowerBound.TabIndex = 1
        Me.txtYLowerBound.Text = "-25"
        '
        'btnYPlus
        '
        Me.btnYPlus.Location = New System.Drawing.Point(99, 71)
        Me.btnYPlus.Name = "btnYPlus"
        Me.btnYPlus.Size = New System.Drawing.Size(20, 20)
        Me.btnYPlus.TabIndex = 5
        Me.btnYPlus.Text = "-"
        Me.btnYPlus.UseVisualStyleBackColor = True
        '
        'btnYMinus
        '
        Me.btnYMinus.Location = New System.Drawing.Point(99, 32)
        Me.btnYMinus.Name = "btnYMinus"
        Me.btnYMinus.Size = New System.Drawing.Size(20, 20)
        Me.btnYMinus.TabIndex = 4
        Me.btnYMinus.Text = "+"
        Me.btnYMinus.UseVisualStyleBackColor = True
        '
        'btnXMinus
        '
        Me.btnXMinus.Location = New System.Drawing.Point(99, 33)
        Me.btnXMinus.Name = "btnXMinus"
        Me.btnXMinus.Size = New System.Drawing.Size(20, 20)
        Me.btnXMinus.TabIndex = 4
        Me.btnXMinus.Text = "+"
        Me.btnXMinus.UseVisualStyleBackColor = True
        '
        'btnXPlus
        '
        Me.btnXPlus.Location = New System.Drawing.Point(99, 71)
        Me.btnXPlus.Name = "btnXPlus"
        Me.btnXPlus.Size = New System.Drawing.Size(20, 20)
        Me.btnXPlus.TabIndex = 5
        Me.btnXPlus.Text = "-"
        Me.btnXPlus.UseVisualStyleBackColor = True
        '
        'gbxYBounds
        '
        Me.gbxYBounds.Controls.Add(Me.Label2)
        Me.gbxYBounds.Controls.Add(Me.txtYLowerBound)
        Me.gbxYBounds.Controls.Add(Me.Label1)
        Me.gbxYBounds.Controls.Add(Me.btnYPlus)
        Me.gbxYBounds.Controls.Add(Me.btnYMinus)
        Me.gbxYBounds.Controls.Add(Me.txtYUpperBound)
        Me.gbxYBounds.Location = New System.Drawing.Point(520, 116)
        Me.gbxYBounds.Name = "gbxYBounds"
        Me.gbxYBounds.Size = New System.Drawing.Size(125, 100)
        Me.gbxYBounds.TabIndex = 1
        Me.gbxYBounds.TabStop = False
        Me.gbxYBounds.Text = "Bounds (Y Axis)"
        '
        'gbxXBounds
        '
        Me.gbxXBounds.Controls.Add(Me.btnXMinus)
        Me.gbxXBounds.Controls.Add(Me.lblLowerBound)
        Me.gbxXBounds.Controls.Add(Me.btnXPlus)
        Me.gbxXBounds.Controls.Add(Me.lblUpperBound)
        Me.gbxXBounds.Controls.Add(Me.txtXUpperBound)
        Me.gbxXBounds.Controls.Add(Me.txtXLowerBound)
        Me.gbxXBounds.Location = New System.Drawing.Point(520, 10)
        Me.gbxXBounds.Name = "gbxXBounds"
        Me.gbxXBounds.Size = New System.Drawing.Size(125, 100)
        Me.gbxXBounds.TabIndex = 0
        Me.gbxXBounds.TabStop = False
        Me.gbxXBounds.Text = "Bounds (X Axis)"
        '
        'gbxEquation
        '
        Me.gbxEquation.Controls.Add(Me.btnGraph)
        Me.gbxEquation.Controls.Add(Me.chkAntialiasing)
        Me.gbxEquation.Controls.Add(Me.txtEquation)
        Me.gbxEquation.Location = New System.Drawing.Point(520, 418)
        Me.gbxEquation.Name = "gbxEquation"
        Me.gbxEquation.Size = New System.Drawing.Size(125, 92)
        Me.gbxEquation.TabIndex = 2
        Me.gbxEquation.TabStop = False
        Me.gbxEquation.Text = "Equation"
        '
        'gbxScale
        '
        Me.gbxScale.Controls.Add(Me.btnYScaleMinus)
        Me.gbxScale.Controls.Add(Me.btnYScalePlus)
        Me.gbxScale.Controls.Add(Me.btnXScaleMinus)
        Me.gbxScale.Controls.Add(Me.lxlXScale)
        Me.gbxScale.Controls.Add(Me.lxlYScale)
        Me.gbxScale.Controls.Add(Me.btnXScalePlus)
        Me.gbxScale.Location = New System.Drawing.Point(520, 222)
        Me.gbxScale.Name = "gbxScale"
        Me.gbxScale.Size = New System.Drawing.Size(125, 100)
        Me.gbxScale.TabIndex = 6
        Me.gbxScale.TabStop = False
        Me.gbxScale.Text = "Scale"
        '
        'btnYScaleMinus
        '
        Me.btnYScaleMinus.Location = New System.Drawing.Point(65, 71)
        Me.btnYScaleMinus.Name = "btnYScaleMinus"
        Me.btnYScaleMinus.Size = New System.Drawing.Size(54, 20)
        Me.btnYScaleMinus.TabIndex = 8
        Me.btnYScaleMinus.Text = "-"
        Me.btnYScaleMinus.UseVisualStyleBackColor = True
        '
        'btnYScalePlus
        '
        Me.btnYScalePlus.Location = New System.Drawing.Point(8, 71)
        Me.btnYScalePlus.Name = "btnYScalePlus"
        Me.btnYScalePlus.Size = New System.Drawing.Size(54, 20)
        Me.btnYScalePlus.TabIndex = 7
        Me.btnYScalePlus.Text = "+"
        Me.btnYScalePlus.UseVisualStyleBackColor = True
        '
        'btnXScaleMinus
        '
        Me.btnXScaleMinus.Location = New System.Drawing.Point(65, 32)
        Me.btnXScaleMinus.Name = "btnXScaleMinus"
        Me.btnXScaleMinus.Size = New System.Drawing.Size(54, 20)
        Me.btnXScaleMinus.TabIndex = 6
        Me.btnXScaleMinus.Text = "-"
        Me.btnXScaleMinus.UseVisualStyleBackColor = True
        '
        'lxlXScale
        '
        Me.lxlXScale.AutoSize = True
        Me.lxlXScale.Location = New System.Drawing.Point(5, 16)
        Me.lxlXScale.Name = "lxlXScale"
        Me.lxlXScale.Size = New System.Drawing.Size(39, 13)
        Me.lxlXScale.TabIndex = 0
        Me.lxlXScale.Text = "X Axis:"
        '
        'lxlYScale
        '
        Me.lxlYScale.AutoSize = True
        Me.lxlYScale.Location = New System.Drawing.Point(5, 55)
        Me.lxlYScale.Name = "lxlYScale"
        Me.lxlYScale.Size = New System.Drawing.Size(39, 13)
        Me.lxlYScale.TabIndex = 2
        Me.lxlYScale.Text = "Y Axis:"
        '
        'btnXScalePlus
        '
        Me.btnXScalePlus.Location = New System.Drawing.Point(8, 32)
        Me.btnXScalePlus.Name = "btnXScalePlus"
        Me.btnXScalePlus.Size = New System.Drawing.Size(54, 20)
        Me.btnXScalePlus.TabIndex = 4
        Me.btnXScalePlus.Text = "+"
        Me.btnXScalePlus.UseVisualStyleBackColor = True
        '
        'lblDisclaimer
        '
        Me.lblDisclaimer.AutoSize = True
        Me.lblDisclaimer.Location = New System.Drawing.Point(7, 514)
        Me.lblDisclaimer.Name = "lblDisclaimer"
        Me.lblDisclaimer.Size = New System.Drawing.Size(355, 13)
        Me.lblDisclaimer.TabIndex = 6
        Me.lblDisclaimer.Text = "This calculator is not fully accurate. Please don't rely on it, I'm only human."
        '
        'ttpAntiAliassing
        '
        Me.ttpAntiAliassing.AutomaticDelay = 400
        Me.ttpAntiAliassing.IsBalloon = True
        '
        'graphForm
        '
        Me.AcceptButton = Me.btnGraph
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 533)
        Me.Controls.Add(Me.lblDisclaimer)
        Me.Controls.Add(Me.gbxScale)
        Me.Controls.Add(Me.gbxEquation)
        Me.Controls.Add(Me.gbxXBounds)
        Me.Controls.Add(Me.gbxYBounds)
        Me.Controls.Add(Me.pbxGraph)
        Me.Name = "graphForm"
        Me.Text = "Graph Equation"
        CType(Me.pbxGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxYBounds.ResumeLayout(False)
        Me.gbxYBounds.PerformLayout()
        Me.gbxXBounds.ResumeLayout(False)
        Me.gbxXBounds.PerformLayout()
        Me.gbxEquation.ResumeLayout(False)
        Me.gbxEquation.PerformLayout()
        Me.gbxScale.ResumeLayout(False)
        Me.gbxScale.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEquation As TextBox
    Friend WithEvents btnGraph As Button
    Friend WithEvents pbxGraph As PictureBox
    Friend WithEvents lblLowerBound As Label
    Friend WithEvents txtXLowerBound As TextBox
    Friend WithEvents lblUpperBound As Label
    Friend WithEvents txtXUpperBound As TextBox
    Friend WithEvents chkAntialiasing As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtYUpperBound As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtYLowerBound As TextBox
    Friend WithEvents btnYPlus As Button
    Friend WithEvents btnYMinus As Button
    Friend WithEvents btnXMinus As Button
    Friend WithEvents btnXPlus As Button
    Friend WithEvents gbxYBounds As GroupBox
    Friend WithEvents gbxXBounds As GroupBox
    Friend WithEvents gbxEquation As GroupBox
    Friend WithEvents gbxScale As GroupBox
    Friend WithEvents btnYScaleMinus As Button
    Friend WithEvents btnYScalePlus As Button
    Friend WithEvents btnXScaleMinus As Button
    Friend WithEvents lxlXScale As Label
    Friend WithEvents lxlYScale As Label
    Friend WithEvents btnXScalePlus As Button
    Friend WithEvents lblDisclaimer As Label
    Friend WithEvents ttpAntiAliassing As ToolTip
End Class
