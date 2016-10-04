Public Class FrmCommande

    Private Sub FrmCommande_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEffectuCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmCaisse.ShowDialog()
    End Sub

    Private Sub cmdFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()
        FrmListeVente.Show()

    End Sub

End Class