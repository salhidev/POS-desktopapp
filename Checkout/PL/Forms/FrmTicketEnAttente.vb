Public Class FrmTicketEnAttente

    'Private Sub FrmTicketEnAttente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




    '    If FrmRappelerTicket.DgvRappelDuTicket.Rows(0).Cells(0).Value > 0 Then

    '        FrmCaisse.BtnMettreEnAttente.Enabled = False

    '    Else

    '        FrmCaisse.BtnMettreEnAttente.Enabled = True

    '    End If

    'End Sub

    Private Sub cmdFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFermer.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DgvTicketEnAttente.SelectedRows.Count = 0 Then
            MsgBox(" Aucune Ligne Selectionné ", MsgBoxStyle.Information, "IN5")
            Exit Sub
        End If
        Try
            If DgvTicketEnAttente.SelectedRows(0).Index <> 0 Then
                DgvTicketEnAttente.Rows(DgvTicketEnAttente.SelectedRows(0).Index - 1).Selected = True
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If DgvTicketEnAttente.SelectedRows.Count = 0 Then
            MsgBox(" Aucune Ligne Selectionné ", MsgBoxStyle.Information, "IN5")
            Exit Sub
        End If
        Try
            If DgvTicketEnAttente.SelectedRows(0).Index <> DgvTicketEnAttente.Rows.Count - 1 Then
                DgvTicketEnAttente.Rows(DgvTicketEnAttente.SelectedRows(0).Index + 1).Selected = True
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class