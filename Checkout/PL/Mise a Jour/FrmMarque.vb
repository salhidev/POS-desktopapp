Public Class FrmMarque

    

 

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Close()
            FrmListeArticle.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmMarque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If LblMarque.Text = "Ajouter Une Marque" Then

                Dim O_SF As New SOUS_FAMILLE
                Dim ListeSF As New List(Of SOUS_FAMILLE)

                ListeSF = O_SF.Actualiser_Liste

                CmbSF_id.DataSource = Nothing



                ListeSF = O_SF.Actualiser_Liste

                CmbSF_id.DisplayMember = "SF_Lib"
                CmbSF_id.ValueMember = "Sf_ID"


                CmbSF_id.DataSource = ListeSF

            Else

                Dim O_SousFamille As New SOUS_FAMILLE
                Dim ListeSousFamilles As New List(Of SOUS_FAMILLE)

                CmbSF_id.DataSource = Nothing

                ListeSousFamilles = O_SousFamille.Actualiser_Liste

                CmbSF_id.DisplayMember = "SF_Lib"
                CmbSF_id.ValueMember = "Sf_ID"

                CmbSF_id.DataSource = ListeSousFamilles

                Dim O_Marque As New MARQUE
                Dim listeMarque As New List(Of MARQUE)
                listeMarque = O_Marque.Actualiser_Liste

                For i As Integer = 0 To listeMarque.Count - 1

                    If FrmListeArticle.DGVMarque.CurrentRow.Cells(0).Value = listeMarque.Item(i).Mrq_Id Then

                        Me.CmbSF_id.SelectedValue = listeMarque.Item(i).SousFamilleofMarques.SF_ID
                        Me.txtMrq_Lib.Text = listeMarque.Item(i).Mrq_Lib

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

    Private Sub btnVider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVider.Click
        Try
            'CmbSf_ID.Items.Add("faite votre choix")
            txtMrq_Lib.ResetText()
            txtMrq_Lib.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If LblMarque.Text = "Modifier Une Marque" Then

                Dim O_Marque As New MARQUE
                Dim O_SousFamille As New SOUS_FAMILLE
                Dim IdSousFamille As Integer

                O_SousFamille = CmbSF_id.SelectedItem
                IdSousFamille = O_SousFamille.SF_ID
                O_Marque.Mrq_Id = Me.Tag
                O_Marque.SousFamilleofMarques.SF_ID = IdSousFamille
                O_Marque.Mrq_Lib = txtMrq_Lib.Text

                O_Marque.Modifier()

                MsgBox("Modifier Avec Succes", MsgBoxStyle.Information)

                FrmListeArticle.DGVMarque.DataSource = Nothing
                FrmListeArticle.DGVMarque.DataSource = O_Marque.Actualiser_Liste

            ElseIf LblMarque.Text = "Ajouter Une Marque" Then
                If VerifierVide(Me) = False Then
                    Exit Sub
                End If

                Dim O_Marque As New MARQUE
                Dim O_SousFamille As New SOUS_FAMILLE
                Dim IdSousFamille As Integer

                O_SousFamille = CmbSF_id.SelectedItem
                IdSousFamille = O_SousFamille.SF_ID
                O_Marque.Mrq_Id = Me.Tag
                O_Marque.SousFamilleofMarques.SF_ID = IdSousFamille
                O_Marque.Mrq_Lib = txtMrq_Lib.Text

                O_Marque.Ajouter()

                MsgBox("Ajouter Avec Succes", MsgBoxStyle.Information)

                FrmListeArticle.DGVMarque.DataSource = Nothing
                FrmListeArticle.DGVMarque.DataSource = O_Marque.Actualiser_Liste
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class