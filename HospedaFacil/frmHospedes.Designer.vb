<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHospedes
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnVisualizar = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.lblHospede = New System.Windows.Forms.Label()
        Me.cboSituacao = New System.Windows.Forms.ComboBox()
        Me.lblSituacao = New System.Windows.Forms.Label()
        Me.txtHospede = New System.Windows.Forms.TextBox()
        Me.txtData1 = New System.Windows.Forms.MaskedTextBox()
        Me.lblData1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grdLista_Hospedagens = New System.Windows.Forms.DataGridView()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.grdLista_Hospedagens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtData1)
        Me.Panel1.Controls.Add(Me.lblData1)
        Me.Panel1.Controls.Add(Me.btnVisualizar)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.lblTelefone)
        Me.Panel1.Controls.Add(Me.txtTelefone)
        Me.Panel1.Controls.Add(Me.lblHospede)
        Me.Panel1.Controls.Add(Me.cboSituacao)
        Me.Panel1.Controls.Add(Me.lblSituacao)
        Me.Panel1.Controls.Add(Me.txtHospede)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(617, 68)
        Me.Panel1.TabIndex = 1
        '
        'btnVisualizar
        '
        Me.btnVisualizar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnVisualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisualizar.ForeColor = System.Drawing.Color.White
        Me.btnVisualizar.Location = New System.Drawing.Point(513, 36)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(97, 23)
        Me.btnVisualizar.TabIndex = 9
        Me.btnVisualizar.Text = "VISUALIZAR"
        Me.btnVisualizar.UseVisualStyleBackColor = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(167, 40)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(38, 13)
        Me.lblEmail.TabIndex = 15
        Me.lblEmail.Text = "E-mail:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(211, 37)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(133, 18)
        Me.txtEmail.TabIndex = 8
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefone.Location = New System.Drawing.Point(5, 39)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(50, 13)
        Me.lblTelefone.TabIndex = 13
        Me.lblTelefone.Text = "Telefone:"
        '
        'txtTelefone
        '
        Me.txtTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefone.Location = New System.Drawing.Point(61, 37)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(100, 18)
        Me.txtTelefone.TabIndex = 7
        '
        'lblHospede
        '
        Me.lblHospede.AutoSize = True
        Me.lblHospede.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHospede.Location = New System.Drawing.Point(3, 16)
        Me.lblHospede.Name = "lblHospede"
        Me.lblHospede.Size = New System.Drawing.Size(52, 13)
        Me.lblHospede.TabIndex = 11
        Me.lblHospede.Text = "Hóspede:"
        '
        'cboSituacao
        '
        Me.cboSituacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSituacao.FormattingEnabled = True
        Me.cboSituacao.Items.AddRange(New Object() {"Ambos", "Feminino", "Masculino"})
        Me.cboSituacao.Location = New System.Drawing.Point(389, 38)
        Me.cboSituacao.Name = "cboSituacao"
        Me.cboSituacao.Size = New System.Drawing.Size(118, 20)
        Me.cboSituacao.TabIndex = 5
        '
        'lblSituacao
        '
        Me.lblSituacao.AutoSize = True
        Me.lblSituacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSituacao.Location = New System.Drawing.Point(350, 41)
        Me.lblSituacao.Name = "lblSituacao"
        Me.lblSituacao.Size = New System.Drawing.Size(34, 13)
        Me.lblSituacao.TabIndex = 9
        Me.lblSituacao.Text = "Sexo:"
        '
        'txtHospede
        '
        Me.txtHospede.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHospede.Location = New System.Drawing.Point(61, 13)
        Me.txtHospede.Name = "txtHospede"
        Me.txtHospede.Size = New System.Drawing.Size(324, 18)
        Me.txtHospede.TabIndex = 6
        '
        'txtData1
        '
        Me.txtData1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData1.Location = New System.Drawing.Point(430, 13)
        Me.txtData1.Mask = "000.000.000-00"
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(77, 18)
        Me.txtData1.TabIndex = 16
        '
        'lblData1
        '
        Me.lblData1.AutoSize = True
        Me.lblData1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData1.Location = New System.Drawing.Point(391, 16)
        Me.lblData1.Name = "lblData1"
        Me.lblData1.Size = New System.Drawing.Size(33, 13)
        Me.lblData1.TabIndex = 17
        Me.lblData1.Text = "CPF: "
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.grdLista_Hospedagens)
        Me.Panel2.Location = New System.Drawing.Point(12, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(617, 297)
        Me.Panel2.TabIndex = 2
        '
        'grdLista_Hospedagens
        '
        Me.grdLista_Hospedagens.AllowUserToAddRows = False
        Me.grdLista_Hospedagens.AllowUserToDeleteRows = False
        Me.grdLista_Hospedagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLista_Hospedagens.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nome, Me.CPF, Me.Telefone, Me.Email, Me.Sexo})
        Me.grdLista_Hospedagens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdLista_Hospedagens.Location = New System.Drawing.Point(0, 0)
        Me.grdLista_Hospedagens.Name = "grdLista_Hospedagens"
        Me.grdLista_Hospedagens.ReadOnly = True
        Me.grdLista_Hospedagens.RowHeadersWidth = 20
        Me.grdLista_Hospedagens.Size = New System.Drawing.Size(615, 295)
        Me.grdLista_Hospedagens.TabIndex = 1
        '
        'Nome
        '
        Me.Nome.DataPropertyName = "Nome"
        Me.Nome.HeaderText = "Hóspede"
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = True
        Me.Nome.Width = 250
        '
        'CPF
        '
        Me.CPF.DataPropertyName = "CPF"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CPF.DefaultCellStyle = DataGridViewCellStyle5
        Me.CPF.HeaderText = "CPF"
        Me.CPF.Name = "CPF"
        Me.CPF.ReadOnly = True
        '
        'Telefone
        '
        Me.Telefone.DataPropertyName = "Telefone"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Telefone.DefaultCellStyle = DataGridViewCellStyle6
        Me.Telefone.HeaderText = "Telefone"
        Me.Telefone.Name = "Telefone"
        Me.Telefone.ReadOnly = True
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "E-mail"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 180
        '
        'Sexo
        '
        Me.Sexo.DataPropertyName = "Sexo"
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        Me.Sexo.ReadOnly = True
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Location = New System.Drawing.Point(531, 389)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(97, 23)
        Me.btnSair.TabIndex = 14
        Me.btnSair.Text = "SAIR"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Location = New System.Drawing.Point(218, 389)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(97, 23)
        Me.btnExcluir.TabIndex = 17
        Me.btnExcluir.Text = "EXCLUIR"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnAlterar
        '
        Me.btnAlterar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.ForeColor = System.Drawing.Color.White
        Me.btnAlterar.Location = New System.Drawing.Point(115, 389)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(97, 23)
        Me.btnAlterar.TabIndex = 16
        Me.btnAlterar.Text = "ALTERAR"
        Me.btnAlterar.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.ForeColor = System.Drawing.Color.White
        Me.btnNovo.Location = New System.Drawing.Point(12, 389)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(97, 23)
        Me.btnNovo.TabIndex = 15
        Me.btnNovo.Text = "NOVO"
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'frmHospedes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 418)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmHospedes"
        Me.Text = "frmHospedes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.grdLista_Hospedagens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVisualizar As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblTelefone As Label
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents lblHospede As Label
    Friend WithEvents cboSituacao As ComboBox
    Friend WithEvents lblSituacao As Label
    Friend WithEvents txtHospede As TextBox
    Friend WithEvents txtData1 As MaskedTextBox
    Friend WithEvents lblData1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents grdLista_Hospedagens As DataGridView
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents Telefone As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents btnSair As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnNovo As Button
End Class
