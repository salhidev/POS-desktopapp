Imports System.Windows.Forms.Screen

Public Class FrmPrincipal


    Private Sub btntache_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntache.Click

        PicTache.Visible = True
        PicTache.Image = PicTache.Image

        PicDemCaisse.Visible = True
        PicDemCaisse.Image = Picdemcaisse1.Image
        PicConfig.Visible = True
        PicConfig.Image = Picconfig1.Image
        PicVisuaClot.Visible = True
        PicVisuaClot.Image = PicvisuaClot1.Image

        PicParaMovStock.Visible = False
        PicParaClot.Visible = False
        PicParaTexte.Visible = False

        EffacerLabel(GroupBox1)
        Label10.Text = "Tâche pour le dossier"
        Label1.Text = "Démarrer la caisse"
        Label2.Text = "Configuration"
        Label3.Text = "Visualiser une clôture"

    End Sub

    Private Sub btndossier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        PicTache.Visible = True
        PicTache.Image = PicDossier.Image

        PicDemCaisse.Visible = True
        PicDemCaisse.Image = PicGéreDossier.Image
        PicConfig.Visible = True
        PicConfig.Image = PicNvDossier.Image
        PicVisuaClot.Visible = True
        PicVisuaClot.Image = PicSupDossier.Image

        PicParaMovStock.Visible = False
        PicParaClot.Visible = False
        PicParaTexte.Visible = False

        EffacerLabel(GroupBox1)
        Label10.Text = "Dossiers"
        Label1.Text = "Gérer un dossier"
        Label2.Text = "Créer un nouveau dossier"
        Label3.Text = "Supprimer un dossier"

    End Sub

    Private Sub btnrestauration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrestauration.Click


        PicVisuaClot.Visible = False
        PicParaMovStock.Visible = False
        PicParaClot.Visible = False
        PicParaTexte.Visible = False

        PicTache.Visible = True
        PicTache.Image = PicSauvRest.Image

        PicDemCaisse.Visible = True
        PicDemCaisse.Image = PicSauvegarde.Image
        PicConfig.Visible = True
        PicConfig.Image = PicRestaure.Image

        EffacerLabel(GroupBox1)
        Label10.Text = "Sauvegarde et restauration"
        Label1.Text = "Sauvegarder les données"
        Label2.Text = "Restaurer les données"

    End Sub

    Private Sub btnparaimpression_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        PicParaMovStock.Visible = True
        PicParaClot.Visible = True
        PicParaTexte.Visible = True

        PicTache.Visible = True
        PicTache.Image = PicParaImp.Image

        PicDemCaisse.Visible = True
        PicDemCaisse.Image = PicParaTicket.Image
        PicConfig.Visible = True
        PicConfig.Image = PicParPieceV.Image
        PicVisuaClot.Visible = True
        PicVisuaClot.Image = PicParaStock.Image

        EffacerLabel(GroupBox1)
        Label10.Text = "Pramétrage des impressions"
        Label1.Text = "Paramétrer le ticket"
        Label2.Text = "Paramétrer les piéces de vente"
        Label3.Text = "Pramétrer le rapport de stock"
        Label4.Text = "Paramétrer le Rap des mouvements de stock"
        Label5.Text = "Paramétrer le rapport de clôture"
        Label6.Text = "Paramétrer les textes standards"

    End Sub

  

    Private Sub btntheme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntheme.Click


        PicConfig.Visible = False
        PicVisuaClot.Visible = False
        PicParaMovStock.Visible = False
        PicParaClot.Visible = False
        PicParaTexte.Visible = False

        PicTache.Visible = True
        PicTache.Image = PicThéme.Image

        PicDemCaisse.Visible = True
        PicDemCaisse.Image = PicThéme.Image

        EffacerLabel(GroupBox1)
        Label10.Text = "Thémes"
        Label1.Text = "Chisir un théme"
        FrmThemes.Show()

    End Sub

    Private Sub btnmotpasse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        EffacerLabel(GroupBox1)
        Label10.Text = "Mot de passe"
        Label1.Text = "Définir le mot de passe"

    End Sub

    Private Sub btnperipherique_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnperipherique.Click

        PicConfig.Visible = False
        PicVisuaClot.Visible = False
        PicParaMovStock.Visible = False
        PicParaClot.Visible = False
        PicParaTexte.Visible = False

        PicTache.Visible = True
        PicTache.Image = PicPériphérique.Image
        PicDemCaisse.Visible = True
        PicDemCaisse.Image = Picperi.Image

        EffacerLabel(GroupBox1)
        Label10.Text = "Périphérique"
        Label1.Text = "Configurer les périphériques"

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

        If Label1.Text = "Sauvegarder les données" Then
            SaveFileDialog1.ShowDialog()

        End If

        If Label1.Text = "Démarrer la caisse" Then

            FrmOccupation.Show()

        End If

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

        If Label3.Text = "Visualiser une clôture" Then
            FrmVisualiseCloture.ShowDialog()
        End If

       
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

        If Label2.Text = "Configuration" Then
            FrmConfiguation.ShowDialog()
        End If



        If Label2.Text = "Restaurer les données" Then
            OpenFileDialog1.ShowDialog()
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVisualiserUneCaisse.Click
        FrmListeCloture.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDemmarerLaCaisse.Click

        FrmOccupation.Show()

    End Sub

    Private Sub BtnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfig.Click

        FrmConfirmerAdmin.ShowDialog()

    End Sub

    Private Sub FrmPrincipal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub



    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Process.Start(LinkLabel1.Text)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()

    End Sub



    Private Sub cmdFermer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFermer.Click

        Me.Close()
        Application.Exit()

    End Sub

    Private Sub FrmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GetResolution(Me)

    End Sub

    Private Sub btnconfiguration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfiguration.Click

        FrmConfirmerAdmin.Show()

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PnlPrincipal_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlPrincipal.Paint

    End Sub
End Class
