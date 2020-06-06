<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHospedagem
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnVisualizar = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.lblHospede = New System.Windows.Forms.Label()
        Me.cboSituacao = New System.Windows.Forms.ComboBox()
        Me.lblSituacao = New System.Windows.Forms.Label()
        Me.cboTipo_Hospedagem = New System.Windows.Forms.ComboBox()
        Me.lblTipo_Hospedagem = New System.Windows.Forms.Label()
        Me.lblTipo_Acomodacao = New System.Windows.Forms.Label()
        Me.lblData2 = New System.Windows.Forms.Label()
        Me.cboTipo_Acomodacao = New System.Windows.Forms.ComboBox()
        Me.txtData2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtData1 = New System.Windows.Forms.MaskedTextBox()
        Me.lblData1 = New System.Windows.Forms.Label()
        Me.txtHospede = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grdLista_Hospedagens = New System.Windows.Forms.DataGridView()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnAcomodacao = New System.Windows.Forms.Button()
        Me.btnHospedes = New System.Windows.Forms.Button()
        Me.Data_Inicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data_Final = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hospede = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_Hospedagem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_Acomodacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Situacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.grdLista_Hospedagens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnVisualizar)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.lblTelefone)
        Me.Panel1.Controls.Add(Me.txtTelefone)
        Me.Panel1.Controls.Add(Me.lblHospede)
        Me.Panel1.Controls.Add(Me.cboSituacao)
        Me.Panel1.Controls.Add(Me.lblSituacao)
        Me.Panel1.Controls.Add(Me.cboTipo_Hospedagem)
        Me.Panel1.Controls.Add(Me.lblTipo_Hospedagem)
        Me.Panel1.Controls.Add(Me.lblTipo_Acomodacao)
        Me.Panel1.Controls.Add(Me.lblData2)
        Me.Panel1.Controls.Add(Me.cboTipo_Acomodacao)
        Me.Panel1.Controls.Add(Me.txtData2)
        Me.Panel1.Controls.Add(Me.txtData1)
        Me.Panel1.Controls.Add(Me.lblData1)
        Me.Panel1.Controls.Add(Me.txtHospede)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(942, 80)
        Me.Panel1.TabIndex = 0
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnVisualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisualizar.ForeColor = System.Drawing.Color.White
        Me.btnVisualizar.Location = New System.Drawing.Point(838, 44)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(97, 23)
        Me.btnVisualizar.TabIndex = 9
        Me.btnVisualizar.Text = "VISUALIZAR"
        Me.btnVisualizar.UseVisualStyleBackColor = False
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(576, 51)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(38, 13)
        Me.lblEmail.TabIndex = 15
        Me.lblEmail.Text = "E-mail:"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(621, 46)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(133, 18)
        Me.txtEmail.TabIndex = 8
        '
        'lblTelefone
        '
        Me.lblTelefone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefone.Location = New System.Drawing.Point(417, 49)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(50, 13)
        Me.lblTelefone.TabIndex = 13
        Me.lblTelefone.Text = "Telefone:"
        '
        'txtTelefone
        '
        Me.txtTelefone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefone.Location = New System.Drawing.Point(470, 46)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(100, 18)
        Me.txtTelefone.TabIndex = 7
        '
        'lblHospede
        '
        Me.lblHospede.AutoSize = True
        Me.lblHospede.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHospede.Location = New System.Drawing.Point(3, 49)
        Me.lblHospede.Name = "lblHospede"
        Me.lblHospede.Size = New System.Drawing.Size(52, 13)
        Me.lblHospede.TabIndex = 11
        Me.lblHospede.Text = "Hóspede:"
        '
        'cboSituacao
        '
        Me.cboSituacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSituacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSituacao.FormattingEnabled = True
        Me.cboSituacao.Location = New System.Drawing.Point(817, 20)
        Me.cboSituacao.Name = "cboSituacao"
        Me.cboSituacao.Size = New System.Drawing.Size(118, 20)
        Me.cboSituacao.TabIndex = 5
        '
        'lblSituacao
        '
        Me.lblSituacao.AutoSize = True
        Me.lblSituacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSituacao.Location = New System.Drawing.Point(760, 23)
        Me.lblSituacao.Name = "lblSituacao"
        Me.lblSituacao.Size = New System.Drawing.Size(51, 13)
        Me.lblSituacao.TabIndex = 9
        Me.lblSituacao.Text = "Situação:"
        '
        'cboTipo_Hospedagem
        '
        Me.cboTipo_Hospedagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo_Hospedagem.FormattingEnabled = True
        Me.cboTipo_Hospedagem.Location = New System.Drawing.Point(636, 18)
        Me.cboTipo_Hospedagem.Name = "cboTipo_Hospedagem"
        Me.cboTipo_Hospedagem.Size = New System.Drawing.Size(118, 20)
        Me.cboTipo_Hospedagem.TabIndex = 4
        '
        'lblTipo_Hospedagem
        '
        Me.lblTipo_Hospedagem.AutoSize = True
        Me.lblTipo_Hospedagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo_Hospedagem.Location = New System.Drawing.Point(515, 23)
        Me.lblTipo_Hospedagem.Name = "lblTipo_Hospedagem"
        Me.lblTipo_Hospedagem.Size = New System.Drawing.Size(104, 13)
        Me.lblTipo_Hospedagem.TabIndex = 7
        Me.lblTipo_Hospedagem.Text = "Tp. de Hospedagem:"
        '
        'lblTipo_Acomodacao
        '
        Me.lblTipo_Acomodacao.AutoSize = True
        Me.lblTipo_Acomodacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo_Acomodacao.Location = New System.Drawing.Point(282, 23)
        Me.lblTipo_Acomodacao.Name = "lblTipo_Acomodacao"
        Me.lblTipo_Acomodacao.Size = New System.Drawing.Size(103, 13)
        Me.lblTipo_Acomodacao.TabIndex = 6
        Me.lblTipo_Acomodacao.Text = "Tp. de Acomodação:"
        '
        'lblData2
        '
        Me.lblData2.AutoSize = True
        Me.lblData2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData2.Location = New System.Drawing.Point(149, 23)
        Me.lblData2.Name = "lblData2"
        Me.lblData2.Size = New System.Drawing.Size(69, 13)
        Me.lblData2.TabIndex = 5
        Me.lblData2.Text = "Dt. de Saída:"
        '
        'cboTipo_Acomodacao
        '
        Me.cboTipo_Acomodacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo_Acomodacao.FormattingEnabled = True
        Me.cboTipo_Acomodacao.Location = New System.Drawing.Point(391, 20)
        Me.cboTipo_Acomodacao.Name = "cboTipo_Acomodacao"
        Me.cboTipo_Acomodacao.Size = New System.Drawing.Size(118, 20)
        Me.cboTipo_Acomodacao.TabIndex = 3
        '
        'txtData2
        '
        Me.txtData2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData2.Location = New System.Drawing.Point(220, 20)
        Me.txtData2.Mask = "00/00/0000"
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(56, 18)
        Me.txtData2.TabIndex = 2
        Me.txtData2.ValidatingType = GetType(Date)
        '
        'txtData1
        '
        Me.txtData1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData1.Location = New System.Drawing.Point(87, 20)
        Me.txtData1.Mask = "00/00/0000"
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(56, 18)
        Me.txtData1.TabIndex = 1
        Me.txtData1.ValidatingType = GetType(Date)
        '
        'lblData1
        '
        Me.lblData1.AutoSize = True
        Me.lblData1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData1.Location = New System.Drawing.Point(3, 23)
        Me.lblData1.Name = "lblData1"
        Me.lblData1.Size = New System.Drawing.Size(82, 13)
        Me.lblData1.TabIndex = 1
        Me.lblData1.Text = "Dt. de Entrada: "
        '
        'txtHospede
        '
        Me.txtHospede.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHospede.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHospede.Location = New System.Drawing.Point(87, 46)
        Me.txtHospede.Name = "txtHospede"
        Me.txtHospede.Size = New System.Drawing.Size(324, 18)
        Me.txtHospede.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.grdLista_Hospedagens)
        Me.Panel2.Location = New System.Drawing.Point(12, 98)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(942, 355)
        Me.Panel2.TabIndex = 17
        '
        'grdLista_Hospedagens
        '
        Me.grdLista_Hospedagens.AllowUserToAddRows = False
        Me.grdLista_Hospedagens.AllowUserToDeleteRows = False
        Me.grdLista_Hospedagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLista_Hospedagens.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Data_Inicial, Me.Data_Final, Me.Hospede, Me.Telefone, Me.Email, Me.Tipo_Hospedagem, Me.Tipo_Acomodacao, Me.Situacao})
        Me.grdLista_Hospedagens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdLista_Hospedagens.Location = New System.Drawing.Point(0, 0)
        Me.grdLista_Hospedagens.Name = "grdLista_Hospedagens"
        Me.grdLista_Hospedagens.ReadOnly = True
        Me.grdLista_Hospedagens.RowHeadersWidth = 20
        Me.grdLista_Hospedagens.Size = New System.Drawing.Size(940, 353)
        Me.grdLista_Hospedagens.TabIndex = 0
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.ForeColor = System.Drawing.Color.White
        Me.btnNovo.Location = New System.Drawing.Point(12, 459)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(97, 23)
        Me.btnNovo.TabIndex = 10
        Me.btnNovo.Text = "NOVO"
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'btnAlterar
        '
        Me.btnAlterar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAlterar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.ForeColor = System.Drawing.Color.White
        Me.btnAlterar.Location = New System.Drawing.Point(115, 459)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(97, 23)
        Me.btnAlterar.TabIndex = 11
        Me.btnAlterar.Text = "ALTERAR"
        Me.btnAlterar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Location = New System.Drawing.Point(218, 459)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(97, 23)
        Me.btnExcluir.TabIndex = 12
        Me.btnExcluir.Text = "EXCLUIR"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Location = New System.Drawing.Point(857, 459)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(97, 23)
        Me.btnSair.TabIndex = 13
        Me.btnSair.Text = "SAIR"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'btnAcomodacao
        '
        Me.btnAcomodacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAcomodacao.BackColor = System.Drawing.Color.Gray
        Me.btnAcomodacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcomodacao.ForeColor = System.Drawing.Color.White
        Me.btnAcomodacao.Location = New System.Drawing.Point(321, 459)
        Me.btnAcomodacao.Name = "btnAcomodacao"
        Me.btnAcomodacao.Size = New System.Drawing.Size(119, 23)
        Me.btnAcomodacao.TabIndex = 18
        Me.btnAcomodacao.Text = "Nova Acomodação"
        Me.btnAcomodacao.UseVisualStyleBackColor = False
        '
        'btnHospedes
        '
        Me.btnHospedes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHospedes.BackColor = System.Drawing.Color.Gray
        Me.btnHospedes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHospedes.ForeColor = System.Drawing.Color.White
        Me.btnHospedes.Location = New System.Drawing.Point(446, 459)
        Me.btnHospedes.Name = "btnHospedes"
        Me.btnHospedes.Size = New System.Drawing.Size(142, 23)
        Me.btnHospedes.TabIndex = 19
        Me.btnHospedes.Text = "Listagem de Hóspedes"
        Me.btnHospedes.UseVisualStyleBackColor = False
        '
        'Data_Inicial
        '
        Me.Data_Inicial.DataPropertyName = "Data_Inicial"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Data_Inicial.DefaultCellStyle = DataGridViewCellStyle7
        Me.Data_Inicial.HeaderText = "Dt. de Entrada"
        Me.Data_Inicial.Name = "Data_Inicial"
        Me.Data_Inicial.ReadOnly = True
        Me.Data_Inicial.Width = 80
        '
        'Data_Final
        '
        Me.Data_Final.DataPropertyName = "Data_Final"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Data_Final.DefaultCellStyle = DataGridViewCellStyle8
        Me.Data_Final.HeaderText = "Dt. de Saída"
        Me.Data_Final.Name = "Data_Final"
        Me.Data_Final.ReadOnly = True
        Me.Data_Final.Width = 80
        '
        'Hospede
        '
        Me.Hospede.DataPropertyName = "Hospede"
        Me.Hospede.HeaderText = "Hóspede"
        Me.Hospede.Name = "Hospede"
        Me.Hospede.ReadOnly = True
        Me.Hospede.Width = 250
        '
        'Telefone
        '
        Me.Telefone.DataPropertyName = "Telefone"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Telefone.DefaultCellStyle = DataGridViewCellStyle9
        Me.Telefone.HeaderText = "Telefone"
        Me.Telefone.Name = "Telefone"
        Me.Telefone.ReadOnly = True
        Me.Telefone.Width = 90
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "E-mail"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 120
        '
        'Tipo_Hospedagem
        '
        Me.Tipo_Hospedagem.DataPropertyName = "Tipo_Hospedagem"
        Me.Tipo_Hospedagem.HeaderText = "Tipo de Hospedagem"
        Me.Tipo_Hospedagem.Name = "Tipo_Hospedagem"
        Me.Tipo_Hospedagem.ReadOnly = True
        Me.Tipo_Hospedagem.Width = 120
        '
        'Tipo_Acomodacao
        '
        Me.Tipo_Acomodacao.DataPropertyName = "Tipo_Acomodacao"
        Me.Tipo_Acomodacao.HeaderText = "Tipo de Acomodação"
        Me.Tipo_Acomodacao.Name = "Tipo_Acomodacao"
        Me.Tipo_Acomodacao.ReadOnly = True
        Me.Tipo_Acomodacao.Width = 120
        '
        'Situacao
        '
        Me.Situacao.DataPropertyName = "Situacao"
        Me.Situacao.HeaderText = "Situação"
        Me.Situacao.Name = "Situacao"
        Me.Situacao.ReadOnly = True
        Me.Situacao.Width = 120
        '
        'frmHospedagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(961, 489)
        Me.Controls.Add(Me.btnHospedes)
        Me.Controls.Add(Me.btnAcomodacao)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmHospedagem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Hospedagens"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.grdLista_Hospedagens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtData2 As MaskedTextBox
    Friend WithEvents txtData1 As MaskedTextBox
    Friend WithEvents lblData1 As Label
    Friend WithEvents txtHospede As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblTelefone As Label
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents lblHospede As Label
    Friend WithEvents cboSituacao As ComboBox
    Friend WithEvents lblSituacao As Label
    Friend WithEvents cboTipo_Hospedagem As ComboBox
    Friend WithEvents lblTipo_Hospedagem As Label
    Friend WithEvents lblTipo_Acomodacao As Label
    Friend WithEvents lblData2 As Label
    Friend WithEvents cboTipo_Acomodacao As ComboBox
    Friend WithEvents btnVisualizar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents grdLista_Hospedagens As DataGridView
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents btnAcomodacao As Button
    Friend WithEvents btnHospedes As Button
    Friend WithEvents Data_Inicial As DataGridViewTextBoxColumn
    Friend WithEvents Data_Final As DataGridViewTextBoxColumn
    Friend WithEvents Hospede As DataGridViewTextBoxColumn
    Friend WithEvents Telefone As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Tipo_Hospedagem As DataGridViewTextBoxColumn
    Friend WithEvents Tipo_Acomodacao As DataGridViewTextBoxColumn
    Friend WithEvents Situacao As DataGridViewTextBoxColumn
End Class
