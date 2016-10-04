Public Class FrmTicket

    Private Sub cmdFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()
        FrmListeVente.Show()

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontRecu.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim o_tick As New Ticket
            o_tick.TIK_ID = Me.Tag
            o_tick.TIK_TYPE = txtype.Text
            o_tick.TIK_MONTANTRECU = txtMontRecu.Text
            o_tick.CommandeOfTicket.CMD_ID = cmbCommand.SelectedItem
            o_tick.Modifier()
            MsgBox("Modifier avec succés", MsgBoxStyle.Information)
            creer_data("select * from V_Ticket", FrmListeVente.dgvFacture)
            Me.Close()
        Catch ex As Exception
            MsgBox("l'opération effectue avec succés", MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ViderForm(Me)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class