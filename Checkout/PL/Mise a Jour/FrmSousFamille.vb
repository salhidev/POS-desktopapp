Public Class FrmSousFamille



   

    Private Sub FrmSousFamille_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If LblSousFamille.Text = "Ajouter Une Sous Famille" Then

                Dim O_Famille As New FAMILLE
                Dim ListeFamilles As New List(Of FAMILLE)

                ListeFamilles = O_Famille.Actualiser_Liste
                CmbFML_ID.DisplayMember = "Fml_Lib"
                CmbFML_ID.ValueMember = "Fml_ID"
                CmbFML_ID.DataSource = ListeFamilles

            Else

                Dim O_Famille As New FAMILLE
                Dim ListeFamilles As New List(Of FAMILLE)

                ListeFamilles = O_Famille.Actualiser_Liste
                CmbFML_ID.DisplayMember = "Fml_Lib"
                CmbFML_ID.ValueMember = "Fml_ID"
                CmbFML_ID.DataSource = ListeFamilles



                Dim O_SousFamille As New SOUS_FAMILLE
                Dim listSousFamille As New List(Of SOUS_FAMILLE)
                listSousFamille = O_SousFamille.Actualiser_Liste


                For i As Integer = 0 To listSousFamille.Count - 1

                    If FrmListeArticle.DGVSousFamille.CurrentRow.Cells(0).Value = listSousFamille.Item(i).SF_ID Then
                        Me.CmbFML_ID.SelectedValue = listSousFamille.Item(i).FamilleofSousFamille.Fml_Id
                        Me.txtSF_LIB.Text = listSousFamille.Item(i).Sf_Lib

                        Exit For

                    End If

                Next
            End If

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

    

    Private Sub BtnModifier_a_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim O_SousFamille As New SOUS_FAMILLE
            Dim O_Famille As New FAMILLE
            Dim IdFamille As Integer
            O_Famille = CmbFML_ID.SelectedItem
            IdFamille = O_Famille.Fml_Id

            O_SousFamille.SF_ID = Me.Tag

            O_SousFamille.FamilleofSousFamille.Fml_Id = IdFamille
            O_SousFamille.Sf_Lib = txtSF_LIB.Text

            O_SousFamille.Modifier()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEnregistrer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim O_SousFamille As New SOUS_FAMILLE
            Dim O_Famille As New FAMILLE
            Dim IdFamille As Integer
            O_Famille = CmbFML_ID.SelectedItem
            IdFamille = O_Famille.Fml_Id



            O_SousFamille.FamilleofSousFamille.Fml_Id = IdFamille
            O_SousFamille.Sf_Lib = txtSF_LIB.Text
            O_SousFamille.Ajouter()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnVider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVider.Click
        Try
            ViderForm(Me)
            CmbFML_ID.Text = "faite votre choix"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If LblSousFamille.Text = "Modifier Une Sous Famille" Then

                Dim O_SousFamille As New SOUS_FAMILLE
                Dim O_Famille As New FAMILLE
                Dim IdFamille As Integer

                O_Famille = CmbFML_ID.SelectedItem
                IdFamille = O_Famille.Fml_Id

                O_SousFamille.SF_ID = Me.Tag

                O_SousFamille.FamilleofSousFamille.Fml_Id = IdFamille
                O_SousFamille.Sf_Lib = txtSF_LIB.Text

                O_SousFamille.Modifier()

                MsgBox("Modifier Avce Succes", MsgBoxStyle.Information)
                FrmListeArticle.DGVSousFamille.DataSource = Nothing
                FrmListeArticle.DGVSousFamille.DataSource = O_SousFamille.Actualiser_Liste

            ElseIf LblSousFamille.Text = "Ajouter Une Sous Famille" Then

                Dim O_SousFamille As New SOUS_FAMILLE
                Dim O_Famille As New FAMILLE
                Dim IdFamille As Integer
                O_Famille = CmbFML_ID.SelectedItem
                IdFamille = O_Famille.Fml_Id



                O_SousFamille.FamilleofSousFamille.Fml_Id = IdFamille
                O_SousFamille.Sf_Lib = txtSF_LIB.Text
                O_SousFamille.Ajouter()

                MsgBox("Ajouter Avce Succes", MsgBoxStyle.Information)
                FrmListeArticle.DGVSousFamille.DataSource = Nothing
                FrmListeArticle.DGVSousFamille.DataSource = O_SousFamille.Actualiser_Liste
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class