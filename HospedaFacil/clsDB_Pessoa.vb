Imports System.Data.SqlClient

Public Class clsDB_Pessoa

    Public Property ID As Long
    Public Property Tipo_Hospede As String
    Public Property Nome As String
    Public Property Data_Nascimento As Date
    Public Property Sexo As String
    Public Property RG As String
    Public Property CPF As String
    Public Property Email As String
    Public Property bDependente As Boolean

    Public Sub New()
        MyBase.New
    End Sub

    Public Sub New(_ID As Long, _Tipo_Hospede As String, _Nome As String, _Data_Nascimento As Date, _Sexo As String, _RG As String,
                   _CPF As String, _Email As String, _bDependente As Boolean)

        Me.ID = _ID
        Me.Tipo_Hospede = _Tipo_Hospede
        Me.Nome = _Nome
        Me.Data_Nascimento = _Data_Nascimento
        Me.Sexo = _Sexo
        Me.RG = _RG
        Me.CPF = _CPF
        Me.Email = _Email
        Me.bDependente = _bDependente
    End Sub

    'Public Shared Function Carregar_Dados(ID As Long) As DataTable

    '    Try


    '    Catch ex As Exception
    '        MsgBox("Erro em [Carregar_Dados]" & ex.Message, MsgBoxStyle.Exclamation)
    '    End Try
    'End Function


    '    Sub preencherDados(ByVal SQL As String)

    '        Me.ID.DataBindings.Clear()
    '        txtnome.DataBindings.Clear()
    '        txtendereco.DataBindings.Clear()

    '        Try
    '            cn = New OleDbConnection(strcon)
    '            cn.Open()
    '            adapt = New OleDbDataAdapter
    '            tbl = New DataTable
    '            cm = New OleDbCommand(mysql)
    '            adapt.SelectCommand = cm
    '            adapt.SelectCommand.Connection = cn
    '            adapt.Fill(tbl)
    '            bsource.DataSource = tbl
    '            BNav.BindingSource = bsource

    '            txtid.DataBindings.Add(New Binding("Text", bsource, "ID", True))
    '            txtnome.DataBindings.Add(New Binding("Text", bsource, "name", True))
    '            txtendereco.DataBindings.Add(New Binding("Text", bsource, "address", True))
    '            cn.Close()
    '            cn.Dispose()
    '        Catch ex As Exception
    '            MessageBox.Show("Erro : " & ex.Message)
    '        End Try

    '    End Sub

    Public Shared Function Inserir(oRegsitro As clsDB_Pessoa) As String

        Dim Sql As String = ""

        Try

            Sql = " INSERT INTO tblPessoa (ID, Tipo_Hospede, Nome, Data_Nascimento, Sexo, RG, CPF, Email, bDependente"
            Sql &= ") VALUES ("
            Sql &= oRegsitro.ID & ","
            Sql &= "'" & oRegsitro.Tipo_Hospede & "', "
            Sql &= "'" & oRegsitro.Nome & "', "
            Sql &= oRegsitro.Data_Nascimento & ","
            Sql &= "'" & oRegsitro.Sexo & "', "
            Sql &= "'" & oRegsitro.RG & "', "
            Sql &= "'" & oRegsitro.CPF & "', "
            Sql &= "'" & oRegsitro.Email & "', "
            Sql &= oRegsitro.bDependente
            Sql &= ")"

            cm = New SqlCommand(Sql, cn)
            cm.ExecuteNonQuery()

            Inserir = "Registro salvo com sucesso!"



        Catch ex As Exception

        End Try

    End Function



End Class


