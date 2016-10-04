Public Class FrmFamille

    Private Sub btnEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim O_famille As New FAMILLE
            Dim IdRayon As Integer
            O_famille = CmbRay_ID.SelectedItem
            IdRayon = O_famille.Fml_Id


            O_famille.Fml_Id = IdRayon
            O_famille.Fml_Lib = txtFml_Lib.Text
            O_famille.FamilleofRayon.Ray_ID = IdRayon

            O_famille.Ajouter()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    


    Private Sub cmdFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Close()
            FrmListeArticle.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmFamille_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If lblFamille.Text = "Ajouter Une Famille:" Then

                Dim O_Rayon As New RAYON
                Dim ListeRayon As New List(Of RAYON)
                ListeRayon = O_Rayon.Actualiser_Liste

                CmbRay_ID.DisplayMember = "Ray_Lib"
                CmbRay_ID.ValueMember = "Ray_Id"

                CmbRay_ID.DataSource = ListeRayon

            Else

                Dim O_Rayon As New RAYON
                Dim ListeRayon As New List(Of RAYON)
                ListeRayon = O_Rayon.Actualiser_Liste

                CmbRay_ID.DisplayMember = "Ray_Lib"
                CmbRay_ID.ValueMember = "Ray_Id"

                CmbRay_ID.DataSource = ListeRayon

                Dim O_Famille As New FAMILLE
                Dim listFamille As New List(Of FAMILLE)
                listFamille = O_Famille.Actualiser_Liste


                For i As Integer = 0 To listFamille.Count - 1

                    If FrmListeArticle.DGVFamille.CurrentRow.Cells(0).Value = listFamille.Item(i).Fml_Id Then
                        Me.CmbRay_ID.SelectedValue = listFamille.Item(i).FamilleofRayon.Ray_ID
                        Me.txtFml_Lib.Text = listFamille.Item(i).Fml_Lib

                        Exit For

                    End If

                Next
            End If






        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnVider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVider.Click
        Try
            ViderForm(Me)
            CmbRay_ID.Text = "faite votre choix"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnnuler.Click
        Try
            Me.Close()
            FrmListeArticle.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnSupprimer_a_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim O_famille As New FAMILLE
            O_famille.Fml_Id = Me.Tag

            O_famille.Supprimer()

            '--------------------------------------------------
            CmbRay_ID.Text = "faite votre choix"
            txtFml_Lib.ResetText()
            txtFml_Lib.Select()
            '--------------------------------------------------
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnModifier_a_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim O_Rayon As New RAYON
            Dim O_Famille As New FAMILLE
            Dim IdRayon As Integer

            O_Famille.Fml_Id = Me.Tag

            O_Rayon = CmbRay_ID.SelectedItem
            IdRayon = O_Rayon.Ray_ID



            O_Famille.Fml_Lib = txtFml_Lib.Text
            O_Famille.FamilleofRayon.Ray_ID = IdRayon

            O_Famille.Modifier()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEnregistrer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim O_Rayon As New RAYON
            Dim O_Famille As New FAMILLE
            Dim IdRayon As Integer

            'O_Famille.Fml_Id = Me.Tag
            O_Rayon = CmbRay_ID.SelectedItem
            IdRayon = O_Rayon.Ray_ID



            O_Famille.Fml_Lib = txtFml_Lib.Text
            O_Famille.FamilleofRayon.Ray_ID = IdRayon

            O_Famille.Ajouter()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try



            If lblFamille.Text = "Modifier Une Famille" Then

                Dim O_Rayon As New RAYON
                Dim O_Famille As New FAMILLE
                Dim IdRayon As Integer

                O_Famille.Fml_Id = Me.Tag

                O_Rayon = CmbRay_ID.SelectedItem
                IdRayon = O_Rayon.Ray_ID



                O_Famille.Fml_Lib = txtFml_Lib.Text
                O_Famille.FamilleofRayon.Ray_ID = IdRayon

                O_Famille.Modifier()
                MsgBox("Modifier Avec Succes ")
                FrmListeArticle.DGVFamille.DataSource = Nothing
                FrmListeArticle.DGVFamille.DataSource = O_Famille.Actualiser_Liste
            ElseIf lblFamille.Text = "Ajouter Une Famille:" Then

                Dim O_Rayon As New RAYON
                Dim O_Famille As New FAMILLE
                Dim IdRayon As Integer

                'O_Famille.Fml_Id = Me.Tag
                O_Rayon = CmbRay_ID.SelectedItem
                IdRayon = O_Rayon.Ray_ID


                O_Famille.FamilleofRayon.Ray_ID = IdRayon
                O_Famille.Fml_Lib = txtFml_Lib.Text


                O_Famille.Ajouter()
                MsgBox("Ajouter Avec Succes ")
                FrmListeArticle.DGVFamille.DataSource = Nothing
                FrmListeArticle.DGVFamille.DataSource = O_Famille.Actualiser_Liste
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Quitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class