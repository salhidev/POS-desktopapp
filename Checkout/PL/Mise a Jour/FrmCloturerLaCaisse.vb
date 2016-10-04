Public Class FrmCloturerLaCaisse

 
    Private Sub BtnValiderCloture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnValiderCloture.Click

        Dim O_cloture As New CLOTURE

        O_cloture.CAISSE.CAISSE_ID = Val(LblCaisseID.Text)
        O_cloture.CLTR_CAISSE_REMARQUE = TxtRemarque.Text
        O_cloture.CLTR_DATE = Date.Now
        O_cloture.CLTR_ETAT = TxtEtat.Text
        O_cloture.CLTR_FONDCAISSESOIR = TxtFondCaisseCloture.Text
        O_cloture.Ajouter()

        MsgBox(" La Caisse a été Cloturé ", MsgBoxStyle.Information)

        Me.Close()

    End Sub


    Private Sub FrmCloturerLaCaisse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblCaisseID.Text = FrmCaisse.LblCaisseInfo.Tag
        LblCaisseID.Visible = False
    End Sub

    Private Sub BtnAnnulerCloture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnnulerCloture.Click

        Me.Close()

    End Sub
End Class