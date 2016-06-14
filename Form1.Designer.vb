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
        Me.LabelPrueba = New System.Windows.Forms.Label()
        Me.LabelUna = New System.Windows.Forms.Label()
        Me.LabelEs = New System.Windows.Forms.Label()
        Me.LabelEsto = New System.Windows.Forms.Label()
        Me.lbl_dicho = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LabelPrueba
        '
        Me.LabelPrueba.AutoSize = True
        Me.LabelPrueba.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrueba.Location = New System.Drawing.Point(367, 112)
        Me.LabelPrueba.Name = "LabelPrueba"
        Me.LabelPrueba.Size = New System.Drawing.Size(135, 42)
        Me.LabelPrueba.TabIndex = 5
        Me.LabelPrueba.Text = "prueba"
        '
        'LabelUna
        '
        Me.LabelUna.AutoSize = True
        Me.LabelUna.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUna.Location = New System.Drawing.Point(280, 112)
        Me.LabelUna.Name = "LabelUna"
        Me.LabelUna.Size = New System.Drawing.Size(81, 42)
        Me.LabelUna.TabIndex = 6
        Me.LabelUna.Text = "una"
        '
        'LabelEs
        '
        Me.LabelEs.AutoSize = True
        Me.LabelEs.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEs.Location = New System.Drawing.Point(200, 112)
        Me.LabelEs.Name = "LabelEs"
        Me.LabelEs.Size = New System.Drawing.Size(58, 42)
        Me.LabelEs.TabIndex = 4
        Me.LabelEs.Text = "es"
        '
        'LabelEsto
        '
        Me.LabelEsto.AutoSize = True
        Me.LabelEsto.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEsto.Location = New System.Drawing.Point(101, 112)
        Me.LabelEsto.Name = "LabelEsto"
        Me.LabelEsto.Size = New System.Drawing.Size(93, 42)
        Me.LabelEsto.TabIndex = 3
        Me.LabelEsto.Text = "Esto"
        '
        'lbl_dicho
        '
        Me.lbl_dicho.AutoSize = True
        Me.lbl_dicho.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dicho.Location = New System.Drawing.Point(64, 242)
        Me.lbl_dicho.Name = "lbl_dicho"
        Me.lbl_dicho.Size = New System.Drawing.Size(30, 42)
        Me.lbl_dicho.TabIndex = 3
        Me.lbl_dicho.Text = "-"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(254, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(167, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(262, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 424)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelPrueba)
        Me.Controls.Add(Me.LabelUna)
        Me.Controls.Add(Me.LabelEs)
        Me.Controls.Add(Me.lbl_dicho)
        Me.Controls.Add(Me.LabelEsto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelPrueba As System.Windows.Forms.Label
    Friend WithEvents LabelUna As System.Windows.Forms.Label
    Friend WithEvents LabelEs As System.Windows.Forms.Label
    Friend WithEvents LabelEsto As System.Windows.Forms.Label
    Friend WithEvents lbl_dicho As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox

End Class
