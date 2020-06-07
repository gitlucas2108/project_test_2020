Public Class frmHospedagem

#Region "Eventos de Controles"

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        Dim oForm As frmHospedagem_Incluir_Editar

        Try


            oForm = New frmHospedagem_Incluir_Editar
            'Me.Hide()
            oForm.Setar_Dados(-1)
            oForm.ShowDialog()

        Catch ex As Exception
            MsgBox("Erro em [BtnNovo_Click]", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub BtnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

    End Sub

    Private Sub BtnHospedes_Click(sender As Object, e As EventArgs) Handles btnHospedes.Click

        Dim oForm As frmHospedes

        Try


            oForm = New frmHospedes
            'Me.Hide()
            'oForm.Setar_Dados(-1)
            oForm.ShowDialog()

        Catch ex As Exception
            MsgBox("Erro em [BtnHospedes_Click]", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub frmHospedagem_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try

            Setar_Dados()

        Catch ex As Exception
            MsgBox("Erro em [BtnNovo_Click]", MsgBoxStyle.Exclamation)
        End Try
    End Sub

#End Region

#Region "Métodos / Funções"

    Public Sub Setar_Dados()

        Try
            Preenche_GRID()

            txtTelefone.Text = "99254-7273"
            txtEmail.Text = "email@email.com"
            cboSituacao.SelectedIndex = 1

        Catch ex As Exception
            MsgBox("Erro em [Setar_Dados]", MsgBoxStyle.Exclamation)
        End Try

    End Sub
    Private Sub Preenche_GRID()

        Dim oDT As DataTable



        Try

            oDT = New DataTable
            oDT = clsDB_Hospedagem.Carregar_Dados


            If Not oDT Is Nothing AndAlso oDT.Rows.Count > 0 Then


                For Each oRow As DataGridViewRow In grdLista_Hospedagens.Rows

                    'If oDT("Tipo_Hospedagem").ToString = 0 Then
                    '    oRow.Cells("Tipo_Hospedagem") = ""
                    'ElseIf oDT("Tipo_Hospedagem").ToString = 1 Then
                    '    oRow("Tipo_Hospedagem") = "Casal"
                    'Else
                    '    grdLista_Hospedagens.Columns("Tipo_Hospedagem").Name = "Familia"

                    'End If
                Next


                grdLista_Hospedagens.AutoGenerateColumns = False
                grdLista_Hospedagens.DataSource = oDT
            End If

        Catch ex As Exception
            MsgBox("Erro em [Preenche_GRID]", MsgBoxStyle.Exclamation)
        End Try
    End Sub

#End Region

End Class
