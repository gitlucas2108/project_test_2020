Imports System.Data.SqlClient

Module mdlConexaoBD

    Public cn As SqlConnection
    Public cm As SqlCommand
    Public dr As SqlDataReader
    Public strcon As String = "Server=DESKTOP-NBU4I31\SQLEXPRESS;DataBase=HOSPEDA_FACIL;Integrated Security=SSPI"
    Public adapt As SqlDataAdapter
    Public tbl As DataTable
    Public sql As String
    Public ds As New DataSet
    Public clr As String = ""

    ' Public Usuario As String
    'Public conexao As New SqlConnection("Server=DESKTOP-NBU4I31\SQLEXPRESS;DataBase=HOSPEDA_FACIL;Integrated Security=SSPI")
    'Sub Abrir()
    '    Try
    '        If conexao.State = 0 Then
    '            conexao.Open()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    'Sub Fechar()
    '    Try
    '        If conexao.State = 1 Then
    '            conexao.Close()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub


End Module