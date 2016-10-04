Public Class FrmTarif

    

    Private Sub BtnAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnnuler.Click
        Try
            Me.Close()
            FrmListeArticle.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Sub btnEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnregistrer.Click
        Try
            If LblTarif.Text = "Ajouter Un  Tarif" Then

                Dim O_Tarif As New TARIF

                O_Tarif.Trf_Libelle = txtTRF_Libelle.Text
                O_Tarif.Trf_Coefficient = txtTrf_Coefficient.Text

                O_Tarif.Ajouter()

                MsgBox("Ajouter  Avec  Succes", MsgBoxStyle.Information)
                FrmListeArticle.DGVTarif.DataSource = Nothing
                FrmListeArticle.DGVTarif.DataSource = O_Tarif.Actualiser_Liste
            ElseIf LblTarif.Text = "Modifier Un Tarif" Then

                Dim O_Tarif As New TARIF

                O_Tarif.Trf_ID = Me.Tag
                O_Tarif.Trf_Libelle = txtTRF_Libelle.Text
                O_Tarif.Trf_Coefficient = txtTrf_Coefficient.Text

                O_Tarif.Modifier()

                MsgBox("Modifier  Avec  Succes", MsgBoxStyle.Information)
                FrmListeArticle.DGVTarif.DataSource = Nothing
                FrmListeArticle.DGVTarif.DataSource = O_Tarif.Actualiser_Liste
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

  

    Private Sub BtnVider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVider.Click
        Try
            txtTrf_Coefficient.ResetText()
            txtTRF_Libelle.ResetText()
            txtTRF_Libelle.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class