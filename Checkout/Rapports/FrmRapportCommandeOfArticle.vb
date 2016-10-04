Public Class FrmImprimerFacture

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()

    End Sub

    Private Sub FrmImprimerFacture_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        viderGridCommande()

    End Sub

    Private Sub FrmImprimerFacture_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        viderGridCommande()
    End Sub



    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()
        Encaissement.Close()
        FrmCaisse.Show()

    End Sub
End Class