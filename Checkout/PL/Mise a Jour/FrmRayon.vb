Public Class FrmRayon

    Private Sub FrmRayon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim frm As FrmRayon
        'If frm.LblRayon.Text = "Supprimer un Rayon" Then
        '    Bloquer_Formulaire(Me)
        'End If
    End Sub

    

    


    

  

    Private Sub btnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Close()
            FrmListeArticle.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub btnEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim O_ray As New RAYON
            O_ray.Ray_Lib = txtRay_Lib.Text
            O_ray.Ajouter()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnModifier_a_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim O_ray As New RAYON
            O_ray.Ray_ID = Me.Tag
            O_ray.Ray_Lib = txtRay_Lib.Text
            O_ray.Modifier()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnSupprimer_a_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim O_ray As New RAYON

            O_ray.Ray_ID = Me.Tag
            O_ray.Supprimer()

            txtRay_Lib.ResetText()
            txtRay_Lib.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub btnVider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            txtRay_Lib.ResetText()
            txtRay_Lib.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub BtnAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Close()
            FrmListeArticle.TabPageMarque.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            If LblRayon.Text = "Modifier un Rayon" Then

                Dim O_ray As New RAYON
                O_ray.Ray_ID = Me.Tag
                O_ray.Ray_Lib = txtRay_Lib.Text

                O_ray.Modifier()

                MsgBox("Modifier Avec Succes", MsgBoxStyle.Information)
                FrmListeArticle.DGVRayon.DataSource = Nothing
                FrmListeArticle.DGVRayon.DataSource = O_ray.Actualiser_Liste
            ElseIf LblRayon.Text = "Ajouter un Rayon:" Then

                Dim O_ray As New RAYON
                O_ray.Ray_Lib = txtRay_Lib.Text

                O_ray.Ajouter()

                MsgBox("Ajouter Avec Succes", MsgBoxStyle.Information)
                FrmListeArticle.DGVRayon.DataSource = Nothing
                FrmListeArticle.DGVRayon.DataSource = O_ray.Actualiser_Liste
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Quitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Quitter.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            ViderForm(Me)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class