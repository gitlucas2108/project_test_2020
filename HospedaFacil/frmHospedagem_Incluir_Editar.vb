Imports System.Data.SqlClient
Public Class frmHospedagem_Incluir_Editar

    Property oHospede As clsDB_Hospedagem

#Region "Eventos de Controles"

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try
            Preenche_Objeto_com_Dados_da_Tela()

            If Not oHospede Is Nothing AndAlso oHospede.ID > 0 Then
                MsgBox(clsDB_Hospedagem.Inserir(oHospede), MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Erro em: [btnSalvar_Click]", MsgBoxStyle.Exclamation)
        End Try

    End Sub

#End Region

#Region "Métodos / Funções"

    Sub GeraIdentificador()
        Dim pt1, pt2, pt3 As String
        Randomize()
        pt1 = Format(Int(Rnd() * 9999), "0000")
        pt2 = "0" & Year(Now()) - 2000
        pt3 = pt2 & pt1
        txtID.Text = pt3
    End Sub
    Private Sub ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            GeraIdentificador()
            Setar_Dados(-1)

        Catch ex As Exception
            MsgBox("Erro em: [ADD_Load]", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Public Sub Setar_Dados(iID As Long)

        Try
            txtData1.Text = Date.Now
            txtData2.Text = DateAdd(DateInterval.Day, 1, Date.Now)
            cboTipo_Hospedagem.SelectedIndex = 0
            cboTipo_Acomodacao.SelectedIndex = 0

        Catch ex As Exception
            MsgBox("Erro em: [ADD_Load]", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub Preenche_Objeto_com_Dados_da_Tela()

        Try

            oHospede = New clsDB_Hospedagem With {
                .ID = txtID.Text,
                .Hospede = txtHospede.Text,
                .Data_Inicial = CDate(txtData1.Text),
                .Data_Final = CDate(txtData2.Text),
                .Tipo_Hospedagem = cboTipo_Hospedagem.SelectedIndex,
                .Tipo_Acomodacao = cboTipo_Acomodacao.SelectedIndex,
                .Situacao = cboSituacao.Text,
                .Valor = txtValor.Text
            }

            '.Data_Inicial = Format(CDate(txtData1.Text), "dd/MM/yyyy"),
            '.Data_Final = Format(CDate(txtData2.Text), "dd/MM/yyyy"),
        Catch ex As Exception
            MsgBox("Erro em:[Preenche_Objeto_com_Dados_da_Tela]", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txtData1_Leave(sender As Object, e As EventArgs) Handles txtData1.Leave

        Try
            If Not IsDate(txtData1.Text) OrElse Year(txtData1.Text) < 2000 Then
                MsgBox("Prezado Usuário, favor inserir uma data valida!", MsgBoxStyle.Information)
                txtData1.Focus()

            End If

        Catch ex As Exception
            MsgBox("Erro em:[txtData1_Leave]", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txtData2_Leave(sender As Object, e As EventArgs) Handles txtData2.Leave

        Try
            If Not IsDate(txtData2.Text) OrElse Year(txtData2.Text) < 2000 Then
                MsgBox("Prezado Usuário, favor inserir uma data valida!", MsgBoxStyle.Information)
                txtData1.Focus()

            ElseIf IsDate(txtData1.Text) > IsDate(txtData2.Text) Then
                MsgBox("Prezado Usuário, a data final não pode ser anterior a data inicial. Verifique!", MsgBoxStyle.Information)
                txtData1.Focus()

            End If

        Catch ex As Exception
            MsgBox("Erro em:[txtData2_Leave]", MsgBoxStyle.Exclamation)
        End Try
    End Sub

#End Region

End Class