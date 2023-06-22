<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbtSydney = New System.Windows.Forms.RadioButton()
        Me.rbtkuching = New System.Windows.Forms.RadioButton()
        Me.rbtPenang = New System.Windows.Forms.RadioButton()
        Me.rbtLondon = New System.Windows.Forms.RadioButton()
        Me.rbtDubai = New System.Windows.Forms.RadioButton()
        Me.rbtSeoul = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'rbtSydney
        '
        Me.rbtSydney.AutoSize = True
        Me.rbtSydney.Location = New System.Drawing.Point(8, 55)
        Me.rbtSydney.Name = "rbtSydney"
        Me.rbtSydney.Size = New System.Drawing.Size(161, 24)
        Me.rbtSydney.TabIndex = 2
        Me.rbtSydney.TabStop = True
        Me.rbtSydney.Text = "Sydney (RM1499)"
        Me.rbtSydney.UseVisualStyleBackColor = True
        '
        'rbtkuching
        '
        Me.rbtkuching.AutoSize = True
        Me.rbtkuching.Location = New System.Drawing.Point(202, 171)
        Me.rbtkuching.Name = "rbtkuching"
        Me.rbtkuching.Size = New System.Drawing.Size(157, 24)
        Me.rbtkuching.TabIndex = 3
        Me.rbtkuching.TabStop = True
        Me.rbtkuching.Text = "Kuching (RM399)"
        Me.rbtkuching.UseVisualStyleBackColor = True
        '
        'rbtPenang
        '
        Me.rbtPenang.AutoSize = True
        Me.rbtPenang.Location = New System.Drawing.Point(8, 171)
        Me.rbtPenang.Name = "rbtPenang"
        Me.rbtPenang.Size = New System.Drawing.Size(155, 24)
        Me.rbtPenang.TabIndex = 4
        Me.rbtPenang.TabStop = True
        Me.rbtPenang.Text = "Penang (RM199)"
        Me.rbtPenang.UseVisualStyleBackColor = True
        '
        'rbtLondon
        '
        Me.rbtLondon.AutoSize = True
        Me.rbtLondon.Location = New System.Drawing.Point(8, 113)
        Me.rbtLondon.Name = "rbtLondon"
        Me.rbtLondon.Size = New System.Drawing.Size(163, 24)
        Me.rbtLondon.TabIndex = 5
        Me.rbtLondon.TabStop = True
        Me.rbtLondon.Text = "London (RM1899)"
        Me.rbtLondon.UseVisualStyleBackColor = True
        '
        'rbtDubai
        '
        Me.rbtDubai.AutoSize = True
        Me.rbtDubai.Location = New System.Drawing.Point(202, 55)
        Me.rbtDubai.Name = "rbtDubai"
        Me.rbtDubai.Size = New System.Drawing.Size(151, 24)
        Me.rbtDubai.TabIndex = 6
        Me.rbtDubai.TabStop = True
        Me.rbtDubai.Text = "Dubai (RM1299)"
        Me.rbtDubai.UseVisualStyleBackColor = True
        '
        'rbtSeoul
        '
        Me.rbtSeoul.AutoSize = True
        Me.rbtSeoul.Location = New System.Drawing.Point(202, 113)
        Me.rbtSeoul.Name = "rbtSeoul"
        Me.rbtSeoul.Size = New System.Drawing.Size(150, 24)
        Me.rbtSeoul.TabIndex = 7
        Me.rbtSeoul.TabStop = True
        Me.rbtSeoul.Text = "Seoul (RM1499)"
        Me.rbtSeoul.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtSydney)
        Me.GroupBox1.Controls.Add(Me.rbtkuching)
        Me.GroupBox1.Controls.Add(Me.rbtSeoul)
        Me.GroupBox1.Controls.Add(Me.rbtLondon)
        Me.GroupBox1.Controls.Add(Me.rbtDubai)
        Me.GroupBox1.Controls.Add(Me.rbtPenang)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 248)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Destinations"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rbtSydney As RadioButton
    Friend WithEvents rbtkuching As RadioButton
    Friend WithEvents rbtPenang As RadioButton
    Friend WithEvents rbtLondon As RadioButton
    Friend WithEvents rbtDubai As RadioButton
    Friend WithEvents rbtSeoul As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
End Class
