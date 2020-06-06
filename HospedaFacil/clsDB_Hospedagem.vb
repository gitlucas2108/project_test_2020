Imports System.Data.SqlClient
Public Class clsDB_Hospedagem

    Public Property ID As Long
    Public Property Data_Inicial As Date
    Public Property Data_Final As Date
    Public Property Tipo_Hospedagem As Integer
    '0 = Individual
    '1 = Casal
    '2 = Familia

    Public Property Tipo_Acomodacao As Integer
    '0 = Apartamento
    '1 = Camping

    Public Property Hospede As String
    Public Property Situacao As String
    Public Property Valor As Double

    Public Sub New()
        MyBase.New
    End Sub

    Public Sub New(_ID As Long, _Data_Inicial As Date, _Data_Final As Date, _Tipo_Hospedagem As Integer, _Tipo_Acomodacao As Integer,
                   _Hospede As String, _Situacao As String, _Valor As Double)

        Me.ID = _ID
        Me.Data_Inicial = _Data_Inicial
        Me.Data_Final = _Data_Final
        Me.Tipo_Hospedagem = _Tipo_Hospedagem
        Me.Tipo_Acomodacao = _Tipo_Acomodacao
        Me.Hospede = _Hospede
        Me.Situacao = _Situacao
        Me.Valor = _Valor
    End Sub

    Public Shared Function Carregar_Dados() As DataTable

        Dim Sql As String = ""

        Try
            adapt = New SqlDataAdapter
            Carregar_Dados = New DataTable



            Sql = "SELECT * FROM tblHospedagem"

            cn = New SqlConnection(strcon)
            cn.Open()

            cm = New SqlCommand(Sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            adapt.Fill(Carregar_Dados)

            Return Carregar_Dados

        Catch ex As Exception
            MessageBox.Show("Erro em Carregar_Dados: " & ex.Message)
        End Try
    End Function

    Public Shared Function Inserir(oRegsitro As clsDB_Hospedagem) As String

        Dim Sql As String = ""

        Try


            Sql = " INSERT INTO tblHospedagem (ID, Data_Inicial, Data_Final, Tipo_Hospedagem, Tipo_Acomodacao, Hospede, Situacao, Valor"
            Sql &= ") VALUES ("
            Sql &= oRegsitro.ID & ","
            Sql &= "'" & oRegsitro.Data_Inicial & "', "
            Sql &= "'" & oRegsitro.Data_Final & "', "
            Sql &= oRegsitro.Tipo_Hospedagem & ","
            Sql &= oRegsitro.Tipo_Acomodacao & ", "
            Sql &= "'" & oRegsitro.Hospede & "', "
            Sql &= "'" & oRegsitro.Situacao & "', "
            Sql &= oRegsitro.Valor
            Sql &= ")"

            cn = New SqlConnection(strcon)
            cn.Open()

            cm = New SqlCommand(Sql, cn)
            cm.ExecuteNonQuery()

            Inserir = "Registro salvo com sucesso!"



        Catch ex As Exception
            MessageBox.Show("Erro : " & ex.Message)
        End Try

    End Function
End Class
