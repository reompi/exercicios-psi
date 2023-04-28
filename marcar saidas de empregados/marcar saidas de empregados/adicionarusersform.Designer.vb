<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adicionarusersform
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.nome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.passe = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.confirmarpasse = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Silver
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Location = New System.Drawing.Point(9, 163)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 37)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "adicionar users"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(9, 61)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 42)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "selecionador"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(140, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 529)
        Me.Panel1.TabIndex = 19
        '
        'nome
        '
        Me.nome.Location = New System.Drawing.Point(377, 182)
        Me.nome.Name = "nome"
        Me.nome.Size = New System.Drawing.Size(196, 20)
        Me.nome.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(296, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "adicionar conta de usuário"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(366, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 47)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "selecionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(193, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "nome da conta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(193, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "palavra passe"
        '
        'passe
        '
        Me.passe.Location = New System.Drawing.Point(377, 228)
        Me.passe.Name = "passe"
        Me.passe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passe.Size = New System.Drawing.Size(196, 20)
        Me.passe.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(193, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "confirmar palavra passe"
        '
        'confirmarpasse
        '
        Me.confirmarpasse.Location = New System.Drawing.Point(377, 272)
        Me.confirmarpasse.Name = "confirmarpasse"
        Me.confirmarpasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmarpasse.Size = New System.Drawing.Size(196, 20)
        Me.confirmarpasse.TabIndex = 28
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(9, 263)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 37)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "eliminar users"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'adicionarusersform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.confirmarpasse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.passe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nome)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "adicionarusersform"
        Me.Text = "adicionarusersform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents nome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents passe As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents confirmarpasse As TextBox
    Friend WithEvents Button3 As Button
End Class
