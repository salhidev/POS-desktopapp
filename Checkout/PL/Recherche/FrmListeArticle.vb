Imports System.Drawing.Image
Public Class FrmListeArticle

    Private Sub btnEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnregistrer.Click
        Try
            FrmRayon.LblRayon.Text = "Ajouter un Rayon:"
            ViderForm(FrmRayon)

            FrmRayon.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       

    End Sub

    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        FrmSousFamille.LblSousFamille.Text = "Ajouter Une Sous Famille"
        FrmSousFamille.txtSF_LIB.ResetText()
        FrmSousFamille.txtSF_LIB.Select()

        FrmSousFamille.ShowDialog()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        FrmMarque.txtMrq_Lib.ResetText()
        FrmMarque.txtMrq_Lib.Select()
        FrmMarque.LblMarque.Text = "Ajouter Une Marque"
        FrmMarque.ShowDialog()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FrmArticle.lblArticle.Text = "Ajouter Un Article"
        'ViderForm(FrmArticle)
        FrmArticle.Pbx_CB.Image = Nothing
        FrmArticle.ShowDialog()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ViderForm(FrmTarif)
        FrmTarif.LblTarif.Text = "Ajouter Un  Tarif"

        FrmTarif.ShowDialog()

    End Sub

    Private Sub FrmListeArticle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cmb_Type.DataSource = charger_liste("TA.txt")
        DGVArticle.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.MdiParent = FrmConfiguation
        Me.Dock = DockStyle.Fill


        'Pour  Remplire  les DataGridView  Apartir d'un Collection 
        '-----------------------------------------------------------------------------
        Dim O_Rayon As New RAYON
        Dim O_Famille As New FAMILLE
        Dim O_SousFamille As New SOUS_FAMILLE
        Dim O_Marque As New MARQUE
        Dim O_Article As New ARTICLE
        Dim O_Tarif As New TARIF

        DGVRayon.DataSource = O_Rayon.Actualiser_Liste
        DGVFamille.DataSource = O_Famille.Actualiser_Liste
        DGVSousFamille.DataSource = O_SousFamille.Actualiser_Liste
        DGVMarque.DataSource = O_Marque.Actualiser_Liste
        DGVArticle.DataSource = O_Article.Actualiser_Liste
        DGVTarif.DataSource = O_Tarif.Actualiser_Liste

        '-----------------------------------------------------------------------------


        'Pour  Remplire  les DataGridViews  avec  DataSet
        '-----------------------------------------------------------------------------

        'Da_Article.Fill(ds.ARTICLE)
        'Da_Rayon.Fill(ds.RAYON)
        'Da_Famille.Fill(ds.FAMILLE)
        'Da_SousFamille.Fill(ds.SOUS_FAMILLE)
        'Da_Marque.Fill(ds.MARQUE)
        'Da_Tarif.Fill(ds.TARIF)


        'DGVRayon.DataSource = ds.RAYON
        'DGVFamille.DataSource = ds.FAMILLE
        'DGVSousFamille.DataSource = ds.SOUS_FAMILLE
        'DGVMarque.DataSource = ds.MARQUE
        'DGVArticle.DataSource = ds.ARTICLE
        'DGVTarif.DataSource = ds.TARIF

        '-----------------------------------------------------------------------------


    End Sub


    


    Private Sub cmdFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFermer.Click
        Try
            Me.Close()
            FrmConfiguation.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

   


   

   




    

    Private Sub Btn_Modifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modifier.Click
        Try
            If DGVRayon.SelectedRows.Count = 0 Then
                MsgBox("Vous Devez Selectionnez le Rayon a modifier !!", MsgBoxStyle.Information)
                Exit Sub
            End If

            FrmRayon.LblRayon.Text = "Modifier un Rayon"


            Dim O_Rayon As New RAYON
            Dim listRayon As New List(Of RAYON)
            listRayon = O_Rayon.Actualiser_Liste


            For i As Integer = 0 To listRayon.Count - 1

                If DGVRayon.CurrentRow.Cells(0).Value = listRayon.Item(i).Ray_ID Then

                    FrmRayon.txtRay_Lib.Text = listRayon.Item(i).Ray_Lib

                    Exit For

                End If

            Next

            FrmRayon.Tag = DGVRayon.CurrentRow.Cells(0).Value
            FrmRayon.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Btn_Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Supprimer.Click
        Try

            If DGVRayon.SelectedRows.Count = 0 Then
                MsgBox("Vous Devez Selectionnez le Rayon a Supprimer !!", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim O_Rayon As New RAYON
            Try

                Conex.Open()
                Dim msg As Integer = MsgBox("Si Vous Supprimer Ce Rayon  ==> Vous risquez de perdre tout identification de Ce Rayon plus que les Familles,SousFamille ..." & vbNewLine & vbNewLine & "     ==> alors si voulez-vous vraiment le supprimer définitivement avec tout ces relations Appuyez sur oui ==>" & vbNewLine & vbNewLine & "  ==> sinon si voulez-vous Supprimer Seulement Ce Rayon appuyez sur Non ==>", MsgBoxStyle.YesNoCancel, "** Lisez ce message attentivement avant de supprimer **")
                If msg = vbYes Then
                    O_Rayon.Ray_ID = DGVRayon.CurrentRow.Cells(0).Value

                    cmd.Connection = Conex

                    cmd.CommandText = "exec SP_SupprimerRayon '" & O_Rayon.Ray_ID & "'"

                    cmd.ExecuteNonQuery()

                    MsgBox("Ce Rayon à été Supprimé avec succés", MsgBoxStyle.Information)
                    DGVRayon.DataSource = Nothing
                    DGVRayon.DataSource = O_Rayon.Actualiser_Liste

                ElseIf msg = vbNo Then

                    O_Rayon.Ray_ID = DGVRayon.CurrentRow.Cells(0).Value

                    cmd.Connection = Con()

                    cmd.CommandText = "exec SP_SuppRayonSeul '" & O_Rayon.Ray_ID & "'"

                    cmd.ExecuteNonQuery()

                    MsgBox("Ce Rayon à été Supprimé seulement avec succés", MsgBoxStyle.Information)
                    DGVRayon.DataSource = Nothing
                    DGVRayon.DataSource = O_Rayon.Actualiser_Liste
                End If

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try


            Conex.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click

        If DGVFamille.SelectedRows.Count = 0 Then
            MsgBox("Vous devez Selectionnez la Famille a Supprimer !!", MsgBoxStyle.Information)
            Exit Sub
        End If



        Dim O_Famille As New FAMILLE
        Try

            Conex.Open()
            Dim msg As Integer = MsgBox("Si Vous Supprimer Cette Famille  ==> Vous risquez de perdre tout identification de Cette Famille plus que les Sous-Familles,Marque,Article ..." & vbNewLine & vbNewLine & "     ==> alors si voulez-vous vraiment le supprimer définitivement avec tout ces relations Appuyez sur oui ==>" & vbNewLine & vbNewLine & "  ==> sinon si voulez-vous Supprimer Seulement Cette Famille appuyez sur Non ==>", MsgBoxStyle.YesNoCancel, "** Lisez ce message attentivement avant de supprimer **")
            If msg = vbYes Then
                O_Famille.Fml_Id = DGVFamille.CurrentRow.Cells(0).Value

                cmd.Connection = Conex

                cmd.CommandText = "exec SP_SuppFamilleSeul '" & O_Famille.Fml_Id & "'"

                cmd.ExecuteNonQuery()

                MsgBox("Cette Famille à été Supprimé avec succés", MsgBoxStyle.Information)
                DGVFamille.DataSource = Nothing
                DGVFamille.DataSource = O_Famille.Actualiser_Liste

            ElseIf msg = vbNo Then

                O_Famille.Fml_Id = DGVFamille.CurrentRow.Cells(0).Value

                cmd.Connection = Con()

                cmd.CommandText = "exec SP_SuppRayonSeul '" & O_Famille.Fml_Id & "'"

                cmd.ExecuteNonQuery()

                MsgBox("Cette  Famille  à été Supprimé seulement avec succés", MsgBoxStyle.Information)
                DGVFamille.DataSource = Nothing
                DGVFamille.DataSource = O_Famille.Actualiser_Liste
            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        Conex.Close()
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click

        If DGVFamille.SelectedRows.Count = 0 Then
            MsgBox("Vous Devez Selectionnez la Famille a Modifier !!", MsgBoxStyle.Information)
            Exit Sub
        End If


        FrmFamille.lblFamille.Text = "Modifier Une Famille"

        FrmFamille.Tag = DGVFamille.CurrentRow.Cells(0).Value
        FrmFamille.ShowDialog()


    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click

        If DGVSousFamille.SelectedRows.Count = 0 Then
            MsgBox("Vous Devez Selectionnez la Sous Famille a Supprimer !!", MsgBoxStyle.Information)
            Exit Sub
        End If


        If MsgBox("Etes-Vous Sur De  Vouloir Supprimer Cette  Sous Famille", MsgBoxStyle.YesNo, "Suppression") = MsgBoxResult.Yes Then

            Dim O_SousFamille As New SOUS_FAMILLE

            O_SousFamille.SF_ID = DGVSousFamille.CurrentRow.Cells(0).Value

            O_SousFamille.Supprimer()
            MsgBox("Supprimer  Avec Succes", MsgBoxStyle.Information)
            DGVSousFamille.DataSource = O_SousFamille.Actualiser_Liste
        Else


        End If
        

    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click

        If DGVMarque.SelectedRows.Count = 0 Then
            MsgBox("Vous Devez Selectionnez la Marque a Supprimer !!", MsgBoxStyle.Information)
            Exit Sub
        End If


        If MsgBox("Etes-Vous Sur De  Vouloir Supprimer Cette  Marque", MsgBoxStyle.YesNo, "Suppression") = MsgBoxResult.Yes Then

            Dim O_Marque As New MARQUE
            O_Marque.Mrq_Id = DGVMarque.CurrentRow.Cells(0).Value
            O_Marque.Suppimer()

            MsgBox("Supprimer Avec Succes ", MsgBoxStyle.Information)
            DGVMarque.DataSource = Nothing
            DGVMarque.DataSource = O_Marque.Actualiser_Liste
        Else

        End If

        
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        'Con.Open()
        Try
            If DGVArticle.SelectedRows.Count = 0 Then
                MsgBox("Vous Devez Selectionnez l'article a Supprimer !!", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim code As Integer
            '------------------------------------------------------------------
            Dim o_Article As New ARTICLE
            Dim listsArticles As New List(Of ARTICLE)
            Dim O_CodeBarre As New CODE_BARE
            Dim listsCodeBarres As New List(Of CODE_BARE)
            '------------------------------------------------------------------

            '------------------------------------------------------------------
            listsArticles = o_Article.Actualiser_Liste
            listsCodeBarres = O_CodeBarre.Actualiser_Liste
            '------------------------------------------------------------------



            For i As Integer = 0 To listsCodeBarres.Count - 1

                For j As Integer = 0 To listsArticles.Count - 1
                    If listsArticles.Item(j).CodeBarOfArticle.CB_ID = listsCodeBarres.Item(i).CB_ID Then
                        code = listsCodeBarres.Item(i).CB_ID

                        Exit For

                    End If
                Next
            Next
            If MsgBox("Etes-Vous Sur De  Vouloir Supprimer ", MsgBoxStyle.YesNo, "Suppression") = MsgBoxResult.Yes Then
                o_Article.ART_ID = DGVArticle.CurrentRow.Cells(0).Value
                O_CodeBarre.CB_ID = code
                o_Article.Supprimer()
                O_CodeBarre.Supprimer()


                MsgBox(" l'article à été Supprimé Avec Succés", MsgBoxStyle.Information)
            Else

            End If
            DGVArticle.DataSource = Nothing
            DGVArticle.DataSource = o_Article.Actualiser_Liste

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        'Conex.Close()



    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        Try
            If DGVTarif.SelectedRows.Count = 0 Then
                MsgBox("Vous Devez Selectionnez le Tarif a Supprimer !!", MsgBoxStyle.Information)
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            FrmFamille.lblFamille.Text = "Ajouter Une Famille:"
            FrmFamille.txtFml_Lib.ResetText()
            FrmFamille.txtFml_Lib.Select()

            FrmFamille.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click


        Try
            If DGVSousFamille.SelectedRows.Count = 0 Then
                MsgBox("Vous Devez Selectionnez la Sous Famille a Modifier !!", MsgBoxStyle.Information)
                Exit Sub
            End If
            'If MsgBox("Etes-Vous Sur De  Vouloir Supprimer Cette  Sous Famille", MsgBoxStyle.YesNo, "Suppression") = MsgBoxResult.Yes Then
            FrmSousFamille.LblSousFamille.Text = "Modifier Une Sous Famille"

            FrmSousFamille.Tag = DGVSousFamille.CurrentRow.Cells(0).Value
            FrmSousFamille.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        Try
            If DGVMarque.SelectedRows.Count = 0 Then
                MsgBox("Vous Devez Selectionnez la Marque a Modifier !!", MsgBoxStyle.Information)
                Exit Sub
            End If

            'If MsgBox("Etes-Vous Sur De  Vouloir Supprimer Cette  Marque", MsgBoxStyle.YesNo, "Suppression") = MsgBoxResult.Yes Then

            FrmMarque.LblMarque.Text = "Modifier Une Marque"

            FrmMarque.Tag = DGVMarque.CurrentRow.Cells(0).Value
            FrmMarque.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        Try
            Dim O_Tarif As New TARIF
            Dim ListeTarifs As New List(Of TARIF)

            ListeTarifs = O_Tarif.Actualiser_Liste

            If DGVTarif.SelectedRows.Count = 0 Then
                MsgBox("Vous Devez Selectionnez le Tarif a Modifier !!", MsgBoxStyle.Information)
                Exit Sub
            End If


            FrmTarif.LblTarif.Text = "Modifier Un Tarif"

            For i As Integer = 0 To ListeTarifs.Count - 1

                If DGVTarif.CurrentRow.Cells(0).Value = ListeTarifs.Item(i).Trf_ID Then


                    FrmTarif.txtTRF_Libelle.Text = ListeTarifs.Item(i).Trf_Libelle
                    FrmTarif.txtTrf_Coefficient.Text = ListeTarifs.Item(i).Trf_Coefficient

                    Exit For

                End If

            Next

            FrmTarif.Tag = DGVTarif.CurrentRow.Cells(0).Value
            FrmTarif.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        Try
            If DGVArticle.SelectedRows.Count = 0 Then
                MsgBox("Vous Devez Selectionnez l'article a Modifier !!", MsgBoxStyle.Information)
                Exit Sub
            End If
            FrmArticle.Tag = DGVArticle.CurrentRow.Cells(0).Value

            FrmArticle.LblArticle.Text = "Modifier Un Article"
            FrmArticle.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGVArticle_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVArticle.CellContentClick

    End Sub

    
    Private Sub txtTarif_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTarif.TextChanged
        Try
            Dim O_Tarif As New TARIF

            If txtTarif.Text = "" Then

                DGVTarif.DataSource = O_Tarif.Actualiser_Liste
            Else

                DGVTarif.DataSource = O_Tarif.Rechercher_Par_Libelle(txtTarif.Text)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtRayonLibelle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRayonLibelle.TextChanged
        Try
            Dim O_Rayon As New RAYON

            If txtRayonLibelle.Text = "" Then

                DGVRayon.DataSource = O_Rayon.Actualiser_Liste
            Else

                DGVRayon.DataSource = O_Rayon.Rechercher_Par_Libelé(txtRayonLibelle.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFamilleLibelle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFamilleLibelle.TextChanged
        Try
            Dim O_Famille As New FAMILLE

            If txtFamilleLibelle.Text = "" Then

                DGVFamille.DataSource = O_Famille.Actualiser_Liste
            Else

                DGVFamille.DataSource = O_Famille.Rechercher_Par_Libelé(txtFamilleLibelle.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSousFamilleLibelle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSousFamilleLibelle.TextChanged
        Try
            Dim O_SousFAmille As New SOUS_FAMILLE

            If txtSousFamilleLibelle.Text = "" Then

                DGVSousFamille.DataSource = O_SousFAmille.Actualiser_Liste
            Else

                DGVSousFamille.DataSource = O_SousFAmille.Rechercher_Par_Libelle(txtSousFamilleLibelle.Text)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtMarqueLibelle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMarqueLibelle.TextChanged
        Try
            Dim O_Marque As New MARQUE

            If txtMarqueLibelle.Text = "" Then

                DGVMarque.DataSource = O_Marque.Actualiser_Liste
            Else

                DGVMarque.DataSource = O_Marque.Rechercher_Par_Libelle(txtMarqueLibelle.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtCoefficient_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCoefficient.TextChanged
        Try
            Dim O_Tarif As New TARIF

            If txtCoefficient.Text = "" Then

                DGVTarif.DataSource = O_Tarif.Actualiser_Liste
            Else

                DGVTarif.DataSource = O_Tarif.Rechercher_Par_COEFFICIENT(txtCoefficient.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescription.TextChanged
        Try
            Dim O_Article As New ARTICLE

            If txtDescription.Text = "" Then

                DGVArticle.DataSource = O_Article.Actualiser_Liste
            Else

                DGVArticle.DataSource = O_Article.Rechercher_Par_DESCRIPTION(txtDescription.Text)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtRef_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Cmb_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Type.SelectedIndexChanged
        Try
            If Cmb_Type.SelectedIndex <> 0 And Cmb_Type.SelectedText <> "---Faites votre choix---" And txtDescription.Text <> "" Then

                DGVArticle.DataSource = (New ARTICLE).Rechercher_Par_Description_Et_Type(txtDescription.Text, Cmb_Type.Text)
            ElseIf Cmb_Type.SelectedIndex = 0 And Cmb_Type.SelectedText = "---Faites votre choix---" And txtDescription.Text <> "" Then
                DGVArticle.DataSource = (New ARTICLE).Rechercher_Par_DESCRIPTION(txtDescription.Text)
            ElseIf Cmb_Type.SelectedIndex <> 0 And Cmb_Type.SelectedText <> "---Faites votre choix---" And txtDescription.Text = "" Then
                DGVArticle.DataSource = (New ARTICLE).Rechercher_Par_Type(Cmb_Type.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TabPageArticle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPageArticle.Click

    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        Try
            Etat_imprimer.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class