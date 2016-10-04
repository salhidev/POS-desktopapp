Public Class EcranDemarrage

 
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Me.Hide()
        FrmPrincipal.Show()
        Timer1.Enabled = False

    End Sub

    
    Private Sub EcranDemarrage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class