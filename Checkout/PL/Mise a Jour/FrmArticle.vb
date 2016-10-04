Imports System.IO
Imports System.Data
Imports System.Drawing.Image


Public Class FrmArticle

    

    Private Sub FrmArticle_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            FrmListeArticle.Show()
            dt.Columns.Clear()
            dt2.Columns.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmArticle_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            dt.Rows.Clear()
            dt.Columns.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Sub FrmArticle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cmb_Type.DataSource = charger_liste("TA.txt")

            If Me.LblArticle.Text = "Modifier Un Article" Then



                '---------------------------------------------------------------------
                Dim O_Article As New ARTICLE
                Dim listeArticles As New List(Of ARTICLE)
                listeArticles = O_Article.Actualiser_Liste
                '---------------------------------------------------------------------


                Dim O_CodeBarre As New CODE_BARE
                Dim listeCodeBarre As New List(Of CODE_BARE)
                listeCodeBarre = O_CodeBarre.Actualiser_Liste

                '---------------------------------------------------------------------
                Dim O_Sf As New SOUS_FAMILLE
                Dim ListeSousFamille As New List(Of SOUS_FAMILLE)
                ListeSousFamille = O_Sf.Actualiser_Liste

                LstSousFamille.DisplayMember = "Sf_Lib"
                LstSousFamille.ValueMember = "SF_ID"
                LstSousFamille.DataSource = ListeSousFamille

                '--------------------------------------------------------------------


                '---------------------------------------------------------------------
                Dim O_Marque As New MARQUE
                Dim ListeMarques As New List(Of MARQUE)
                ListeMarques = O_Marque.Actualiser_Liste


                '--------------------------------------------------------------------

                LstMarque.Items.Clear()
                '---------------------------------------------------
                ' CmbTva.Items.Clear()
                Dim O_Tva As New TVA
                Dim listTva As New List(Of TVA)
                listTva = O_Tva.RetournerListe_TVA

                CmbTva.DisplayMember = "TVA_Taux"
                CmbTva.ValueMember = "Tva_ID"
                CmbTva.DataSource = listTva

                ''--------------------------------------------------

                '---------------------------------------------------------------------

                '---------------------------------------------------------------------

                For i As Integer = 0 To listeArticles.Count - 1

                    If FrmListeArticle.DGVArticle.CurrentRow.Cells(0).Value = listeArticles.Item(i).ART_ID Then


                        For j As Integer = 0 To listeCodeBarre.Count - 1

                            If listeCodeBarre.Item(j).CB_ID = listeArticles.Item(i).CodeBarOfArticle.CB_ID Then
                                Me.txtCodeBarre.Tag = listeArticles.Item(i).CodeBarOfArticle.CB_ID
                                Me.txtCodeBarre.Text = listeCodeBarre.Item(j).Lib_CB
                                Me.Pbx_CB.Image = ByteArrayToImage(listeCodeBarre.Item(j).Img_CB)

                            End If

                        Next

                        For k As Integer = 0 To ListeMarques.Count - 1
                            If ListeMarques.Item(k).Mrq_Id = listeArticles.Item(i).MarqueOfArticle.Mrq_Id Then
                                Me.LstMarque.Items.Add(ListeMarques.Item(k).Mrq_Lib)
                            End If

                        Next
                        Me.CmbTva.SelectedValue = listeArticles.Item(i).TvaOfArticle.TVA_ID

                        Me.txtRef.Text = listeArticles.Item(i).ART_REF
                        Me.dtpDateEntré.Text = listeArticles.Item(i).ART_DATEENT
                        Me.txtPrixUnitaireHT.Text = listeArticles.Item(i).ART_PRIXUHT
                        Me.txttauxTVA.Text = listeArticles.Item(i).ART_TAUXTVA
                        Me.RTbDescription.Text = listeArticles.Item(i).ART_DESCRIPTION
                        Me.txtstockmin.Text = listeArticles.Item(i).ART_STOCKMIN
                        Me.dtpDatePeremtion.Text = listeArticles.Item(i).ART_DATEPEREMTION
                        Me.txtstockmax.Text = listeArticles.Item(i).ART_STOCKMAX

                        Me.PBXPhotos.Image = ByteArrayToImage(listeArticles.Item(i).ART_PHOTO)
                        Me.Cmb_Type.Text = listeArticles.Item(i).ART_TYPE
                        Me.cbStockable.Checked = listeArticles.Item(i).ART_STOCKABLE
                        Me.txtstockreel.Text = listeArticles.Item(i).ART_STOCKREEL
                        Me.txtstockalerte.Text = listeArticles.Item(i).ART_STOCKALERT
                        Me.txtstockReserve.Text = listeArticles.Item(i).ART_STOCKRESERVE
                        Me.CbConsomable.Checked = listeArticles.Item(i).ART_CONSOMABLE
                        Me.txtNatureArticle.Text = listeArticles.Item(i).ART_NATURE
                        Me.dtpDateModification.Text = listeArticles.Item(i).ART_DATEMODIFICATION
                        Me.txtMotifModification.Text = listeArticles.Item(i).ART_MOTIFMODIFICATION

                    End If
                Next
                For i As Integer = 0 To ds.TARIF_OF_ARTICLE.Count - 1

                    If ds.TARIF_OF_ARTICLE.Item(i).ART_ID <> Me.Tag Then
                        BtnChoixTarif.Visible = True
                        Exit For
                    End If
                Next


                DgvTarifOfArticle.DataSource = datatable_tarif_of_article_Modifier()
            ElseIf Me.LblArticle.Text = "Ajouter Un Article" Then

                ViderForm(Me)
                RTbDescription.Select()
                '---------------------------------------------------
                DgvTarifOfArticle.DataSource = Creerdatabletarif_of_article()
                ''---------------------------------------------------


                LstMarque.Items.Clear()
                PBXPhotos.Image = Nothing
                ''---------------------------------------------------


                Dim O_Sf As New SOUS_FAMILLE
                Dim ListeSousFamille As New List(Of SOUS_FAMILLE)
                ListeSousFamille = O_Sf.Actualiser_Liste

                LstSousFamille.DisplayMember = "Sf_Lib"
                LstSousFamille.ValueMember = "SF_ID"
                LstSousFamille.DataSource = ListeSousFamille

                ''---------------------------------------------------


                ''---------------------------------------------------
                CmbTva.DataSource = Nothing
                CmbTva.Items.Add("Faite ")
                Dim O_Tva As New TVA
                Dim listTva As New List(Of TVA)
                listTva = O_Tva.RetournerListe_TVA

                CmbTva.DisplayMember = "TVA_Taux"
                CmbTva.ValueMember = "Tva_ID"
                CmbTva.DataSource = listTva

                ''---------------------------------------------------


                txtMotifModification.Text = "Aucun"

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub






    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim ofd As New OpenFileDialog
            If ofd.ShowDialog = MsgBoxResult.Ok Then
                TXTPIC.Text = ofd.FileName
                PBXPhotos.Image = Image.FromFile(TXTPIC.Text)
            Else
                PBXPhotos.Image = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdFermer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Close()
            FrmListeArticle.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btAjoModMarque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAjouterCodeBarre.Click
        Try

            If txtRef.Text <> Nothing Then

                Frm_Générer_CB.TXB_INCODE.Text = txtRef.Text
                Frm_Générer_CB.Show()

            Else
                MsgBox(" Vous devez Saisir Une Reference Pour Votre Article", MsgBoxStyle.Information)
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub BtnAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Close()
            FrmListeArticle.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



 

    Private Sub LstSousFamille_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstSousFamille.DoubleClick

        Try
            LstMarque.Items.Clear()

            Dim O_Marque As New MARQUE
            Dim sf As New SOUS_FAMILLE
            sf = LstSousFamille.SelectedItem
            Dim listeM As New List(Of MARQUE)
            listeM = O_Marque.Actualiser_Liste



            For i As Integer = 0 To listeM.Count - 1

                If listeM.Item(i).SousFamilleofMarques.SF_ID = sf.SF_ID Then

                    O_Marque = LstMarque.SelectedItem
                    LstMarque.DisplayMember = "Mrq_Lib"
                    LstMarque.ValueMember = "Mrq_ID"
                    LstMarque.Items.Add(listeM.Item(i))

                End If


            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


     
        Try
            If LblArticle.Text = "Ajouter Un Article" Then

                Dim O_Article As New ARTICLE
                Dim O_Tarif As New TARIF
                '--------------------------------------------------------------
                Dim O_Tva As New TVA
                Dim Id_Tva As Integer
                O_Tva = CmbTva.SelectedItem
                Id_Tva = O_Tva.TVA_ID


                Dim O_CodeBarre As New CODE_BARE
                O_CodeBarre.CB_TYPE = Frm_Générer_CB.txtTypeCB.Text
                O_CodeBarre.CB_ACTIVE = Frm_Générer_CB.CKBActive.Checked
                O_CodeBarre.Img_CB = ImageToByteArray(Pbx_CB.Image)
                O_CodeBarre.Lib_CB = txtCodeBarre.Text

                O_CodeBarre.Ajouter()

                '--------------------------------------------------------------
                O_Article.CodeBarOfArticle.CB_ID = lblCodeBarre.Tag
                O_Article.TvaOfArticle.TVA_ID = Id_Tva
                '--------------------------------------------------------------

                Dim O_Mrq As New MARQUE
                Dim Id_Mrq As Integer
                O_Mrq = LstMarque.SelectedItem
                Id_Mrq = O_Mrq.Mrq_Id

                '--------------------------------------------------------------
                O_Article.MarqueOfArticle.Mrq_Id = Id_Mrq
                O_Article.ART_REF = txtRef.Text
                O_Article.ART_DATEENT = dtpDateEntré.Text
                O_Article.ART_PRIXUHT = txtPrixUnitaireHT.Text
                O_Article.ART_TAUXTVA = txttauxTVA.Text
                O_Article.ART_DESCRIPTION = RTbDescription.Text
                O_Article.ART_STOCKMIN = txtstockmin.Text
                O_Article.ART_DATEPEREMTION = dtpDatePeremtion.Text
                O_Article.ART_STOCKMAX = txtstockmax.Text
                O_Article.ART_PHOTO = ImageToByteArray(PBXPhotos.Image)
                O_Article.ART_TYPE = Cmb_Type.Text
                If cbStockable.Checked = True Then
                    O_Article.ART_STOCKABLE = True
                Else
                    O_Article.ART_STOCKABLE = False
                End If

                O_Article.ART_STOCKREEL = txtstockreel.Text
                O_Article.ART_STOCKALERT = txtstockalerte.Text
                O_Article.ART_STOCKRESERVE = txtstockReserve.Text
                If cbStockable.Checked = True Then
                    O_Article.ART_CONSOMABLE = True
                Else
                    O_Article.ART_CONSOMABLE = False
                End If
                O_Article.ART_NATURE = txtNatureArticle.Text
                O_Article.ART_DATEMODIFICATION = dtpDateModification.Text
                O_Article.ART_MOTIFMODIFICATION = txtMotifModification.Text
                O_Article.Ajouter()

                For i As Integer = 0 To DgvTarifOfArticle.Rows.Count - 1

                    O_Article.TarifOfArticleOfArticle.PrixAchat = DgvTarifOfArticle.Rows(i).Cells(2).Value
                    O_Article.TarifOfArticleOfArticle.PrixVente = DgvTarifOfArticle.Rows(i).Cells(3).Value

                    O_Tarif.Trf_ID = DgvTarifOfArticle.Rows(i).Cells(0).Value

                    O_Article.TarifOfArticleOfArticle.ArticleOfTarifeOfArticle.Add(O_Article)


                    O_Article.TarifOfArticleOfArticle.TarifofTarifOfArticle.Add(O_Tarif)
                    O_Article.TarifOfArticleOfArticle.Ajouter()

                Next

                MsgBox("Ajouter Avce Succes", MsgBoxStyle.Information)

                FrmListeArticle.DGVArticle.DataSource = Nothing
                FrmListeArticle.DGVArticle.DataSource = O_Article.Actualiser_Liste

            ElseIf LblArticle.Text = "Modifier Un Article" Then

                Dim O_Article As New ARTICLE
                Dim O_Tarif As New TARIF
                O_Article.ART_ID = Me.Tag

                '--------------------------------------------------------------
                '  If CmbTva.SelectedItem = True Then
                Dim O_Tva As New TVA
                Dim Id_Tva As Integer
                O_Tva = CmbTva.SelectedItem
                Id_Tva = O_Tva.TVA_ID
                O_Article.TvaOfArticle.TVA_ID = Id_Tva
                ' End If

                '--------------------------------------------------------------



                Dim listsArticles As New List(Of ARTICLE)
                Dim O_CodeBarre As New CODE_BARE
                Dim listsCodeBarres As New List(Of CODE_BARE)



                '----------------------------------------------------------------
                O_CodeBarre.CB_ID = txtCodeBarre.Tag
                O_CodeBarre.CB_TYPE = Frm_Générer_CB.txtTypeCB.Text
                O_CodeBarre.CB_ACTIVE = Frm_Générer_CB.CKBActive.Checked
                O_CodeBarre.Img_CB = ImageToByteArray(Pbx_CB.Image)
                O_CodeBarre.Lib_CB = txtCodeBarre.Text
                O_CodeBarre.Modifier()
                '----------------------------------------------------------------




                '-----------------------------------------------------------------
                Dim O_Mrq As New MARQUE

                Dim Id_Mrq As Integer
                If LstMarque.SelectedItem = True Then

                    O_Mrq = LstMarque.SelectedItem
                    Id_Mrq = O_Mrq.Mrq_Id
                    O_Article.MarqueOfArticle.Mrq_Id = Id_Mrq

                Else

                    Dim listesMarque As New List(Of MARQUE)
                    Dim listeArti As New List(Of ARTICLE)
                    listeArti = O_Article.Actualiser_Liste
                    listesMarque = O_Mrq.Actualiser_Liste

                    For i As Integer = 0 To listesMarque.Count - 1
                        For j As Integer = 0 To listeArti.Count - 1
                            If listeArti.Item(j).MarqueOfArticle.Mrq_Id = listesMarque.Item(i).Mrq_Id Then
                                O_Article.MarqueOfArticle.Mrq_Id = listesMarque.Item(i).Mrq_Id
                            End If
                        Next
                    Next

                End If
                '-----------------------------------------------------------------






                '--------------------------------------------------------------
                O_Article.CodeBarOfArticle.CB_ID = txtCodeBarre.Tag
                O_Article.ART_REF = txtRef.Text
                O_Article.ART_DATEENT = dtpDateEntré.Text
                O_Article.ART_PRIXUHT = txtPrixUnitaireHT.Text
                O_Article.ART_TAUXTVA = txttauxTVA.Text
                O_Article.ART_DESCRIPTION = RTbDescription.Text
                O_Article.ART_STOCKMIN = txtstockmin.Text
                O_Article.ART_DATEPEREMTION = dtpDatePeremtion.Text
                O_Article.ART_STOCKMAX = txtstockmax.Text
                O_Article.ART_PHOTO = ImageToByteArray(PBXPhotos.Image)
                O_Article.ART_TYPE = Cmb_Type.Text
                If cbStockable.Checked = True Then
                    O_Article.ART_STOCKABLE = True
                Else
                    O_Article.ART_STOCKABLE = False
                End If

                O_Article.ART_STOCKREEL = txtstockreel.Text
                O_Article.ART_STOCKALERT = txtstockalerte.Text
                O_Article.ART_STOCKRESERVE = txtstockReserve.Text
                If cbStockable.Checked = True Then
                    O_Article.ART_CONSOMABLE = True
                Else
                    O_Article.ART_CONSOMABLE = False
                End If
                O_Article.ART_NATURE = txtNatureArticle.Text
                O_Article.ART_DATEMODIFICATION = dtpDateModification.Text
                O_Article.ART_MOTIFMODIFICATION = txtMotifModification.Text
                O_Article.Modifier()
                O_Article.TarifOfArticleOfArticle.Supprimer()


                For i As Integer = 0 To DgvTarifOfArticle.Rows.Count - 1

                    '----------------------------------------------------------------------------
                    O_Article.TarifOfArticleOfArticle.PrixAchat = DgvTarifOfArticle.Rows(i).Cells(2).Value
                    O_Article.TarifOfArticleOfArticle.PrixVente = DgvTarifOfArticle.Rows(i).Cells(3).Value
                    '----------------------------------------------------------------------------

                    O_Tarif.Trf_ID = DgvTarifOfArticle.Rows(i).Cells(1).Value

                    '----------------------------------------------------------------------------
                    O_Article.TarifOfArticleOfArticle.ArticleOfTarifeOfArticle.Add(O_Article)
                    O_Article.TarifOfArticleOfArticle.TarifofTarifOfArticle.Add(O_Tarif)
                    '----------------------------------------------------------------------------
                    O_Article.TarifOfArticleOfArticle.Ajouter()
                Next

                FrmListeArticle.DGVArticle.DataSource = Nothing
                FrmListeArticle.DGVArticle.DataSource = O_Article.Actualiser_Liste
                MsgBox("Modifier Avec Succes", MsgBoxStyle.Information, "Modification")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub BtnAnnuler_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnnuler.Click
        Try
            Me.Close()
            FrmListeArticle.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnChoixTarif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChoixTarif.Click
        Try
            DgvTarifOfArticle.DataSource = Creerdatabletarif_of_article()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


  
    Private Sub btnVider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVider.Click

    End Sub
End Class