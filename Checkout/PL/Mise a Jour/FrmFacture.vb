Public Class FrmFacture

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()
        FrmListeVente.Show()

    End Sub

    Private Sub BtnAjouterCaisse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAjouterCaisse.Click
        Try
            Dim o_fact As New Facture
            o_fact.FACT_ID = Me.Tag
            o_fact.FACT_ETAT = txtEtat.Text
            o_fact.FACT_DATE = dtpFact.Text
            o_fact.CommandeOfFacture.CMD_ID = cmbCommand.Text
            o_fact.Modifier()
            MsgBox("Modifier avec succés", MsgBoxStyle.Information)
            creer_data("select * from V_Facture", FrmListeVente.dgvFacture)
            Me.Close()
        Catch ex As Exception
            MsgBox("l'opération effectue avec succés", MsgBoxStyle.Information)
        End Try
      
    End Sub

    Private Sub BtnModifierCaisse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModifierCaisse.Click
        ViderForm(Me)
    End Sub

    Private Sub BtnSupprimerCaisse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupprimerCaisse.Click
        Me.Close()
    End Sub
End Class