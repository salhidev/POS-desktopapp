Imports System.Xml
Imports System.IO
Public Class Encaissement

    Public Sub RefreshFrmFondCaisse()



        Dim fondCaisse As Double

        For j As Integer = 0 To DgvReglement.Rows.Count - 1

            If DgvReglement.Rows(j).Cells(0).Value = "Espece" Then

                FrmFondCaisse.TxtEspeceFD.Text = Val(FrmFondCaisse.TxtEspeceFD.Text) + DgvReglement.Rows(j).Cells(1).Value
                FrmFondCaisse.TxtFondDeCaisseFD.Text = Val(FrmFondCaisse.TxtFondDeCaisseFD.Text) + DgvReglement.Rows(j).Cells(1).Value
                FrmFondCaisse.TxtCarteBancaireFD.Text = Val(FrmFondCaisse.TxtCarteBancaireFD.Text) + 0
                FrmFondCaisse.TxtTiquetRestoFD.Text = Val(FrmFondCaisse.TxtTiquetRestoFD.Text) + 0
                FrmFondCaisse.TxtCheQueFD.Text = Val(FrmFondCaisse.TxtCheQueFD.Text) + 0

            ElseIf DgvReglement.Rows(j).Cells(0).Value = "Carte Bancaire" Then

                FrmFondCaisse.TxtCarteBancaireFD.Text = Val(FrmFondCaisse.TxtCarteBancaireFD.Text) + 1
                FrmFondCaisse.TxtFondDeCaisseFD.Text = Val(FrmFondCaisse.TxtFondDeCaisseFD.Text) + DgvReglement.Rows(j).Cells(1).Value
                FrmFondCaisse.TxtEspeceFD.Text = Val(FrmFondCaisse.TxtEspeceFD.Text) + 0
                FrmFondCaisse.TxtTiquetRestoFD.Text = Val(FrmFondCaisse.TxtTiquetRestoFD.Text) + 0
                FrmFondCaisse.TxtCheQueFD.Text = Val(FrmFondCaisse.TxtCheQueFD.Text) + 0

            ElseIf DgvReglement.Rows(j).Cells(0).Value = "Tickét" Then

                FrmFondCaisse.TxtTiquetRestoFD.Text = Val(FrmFondCaisse.TxtTiquetRestoFD.Text) + 1
                FrmFondCaisse.TxtFondDeCaisseFD.Text = Val(FrmFondCaisse.TxtFondDeCaisseFD.Text) + DgvReglement.Rows(j).Cells(1).Value
                FrmFondCaisse.TxtCarteBancaireFD.Text = Val(FrmFondCaisse.TxtCarteBancaireFD.Text) + 0
                FrmFondCaisse.TxtEspeceFD.Text = Val(FrmFondCaisse.TxtEspeceFD.Text) + 0
                FrmFondCaisse.TxtCheQueFD.Text = Val(FrmFondCaisse.TxtCheQueFD.Text) + 0

            ElseIf DgvReglement.Rows(j).Cells(0).Value = "Chéque" Then

                FrmFondCaisse.TxtCheQueFD.Text = Val(FrmFondCaisse.TxtCheQueFD.Text) + 1
                FrmFondCaisse.TxtCarteBancaireFD.Text = Val(FrmFondCaisse.TxtCarteBancaireFD.Text) + 0
                FrmFondCaisse.TxtEspeceFD.Text = Val(FrmFondCaisse.TxtEspeceFD.Text) + 0
                FrmFondCaisse.TxtTiquetRestoFD.Text = Val(FrmFondCaisse.TxtTiquetRestoFD.Text) + 0
                FrmFondCaisse.TxtFondDeCaisseFD.Text = Val(FrmFondCaisse.TxtFondDeCaisseFD.Text) + DgvReglement.Rows(j).Cells(1).Value

            End If

        Next
        FrmFondCaisse.TxtTotalFD.Text = Val(FrmFondCaisse.TxtFondDeCaisseFD.Text)
        FrmFondCaisse.TxtFondDeCaisseFD.Text = Val(FrmFondCaisse.TxtFondDeCaisseFD.Text) + fondCaisse
        FrmFondCaisse.TxtMouvementFD.Text = 0
        FrmCaisse.LblMontantApayerInfo.Text = 0

        MsgBox(" Fond de Caisse Rempli")

    End Sub

    Private Sub BtnImprimerFactureClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimerFacture.Click
        If DgvReglement.Rows(0).Cells(0).Value = "" Then
            MsgBox(" Vous N'avez Pas Choisis le Mode de Payement ", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim o_commande As New Commande
        Dim o_facture As New Facture
        Dim o_payement As New Payement
        Dim o_article As New ARTICLE


        '---------------------------------------------
        For i As Integer = 0 To FrmCaisse.DgvCommande.Rows.Count - 2

            o_article.ART_ID = FrmCaisse.DgvCommande.Rows(i).Cells(6).Value
            If txtchoisirClient.Text = "" Then
                o_commande.ClientsOfCommandes.CLT_MAT = 0
            Else
                o_commande.ClientsOfCommandes.CLT_MAT = txtchoisirClient.Tag
            End If
            o_commande.CaissierOfCommande.CAISSIER_ID = FrmCaisse.LblNomCaissierInfo.Tag
            o_commande.CMD_DATEC = Date.Now

            If LblRemiseGlobal.Text = "Yes" Then
                o_commande.CMD_REMISEGLOBAL = True
            Else
                o_commande.CMD_REMISEGLOBAL = False
            End If

            o_commande.CMD_MONTANTTOTAL = Lbl_A_Payer.Text

        Next

        o_commande.Ajouter()

        For i As Integer = 0 To FrmCaisse.DgvCommande.Rows.Count - 2

            o_commande.CommandeOfArticleOfCommande.CommandeOfArticleOfCommande.Add(o_commande)
            '-------------------------------------
            o_article.ART_ID = FrmCaisse.DgvCommande.Rows(i).Cells(6).Value
            o_commande.CommandeOfArticleOfCommande.CommandeOfArticleOfArticle.Add(o_article)
            '--------------------------------------
            o_commande.CommandeOfArticleOfCommande.QTE = FrmCaisse.DgvCommande.Rows(i).Cells(4).Value

            If FrmCaisse.DgvCommande.Rows(i).Cells(3).Value > 0 Then

                o_commande.CommandeOfArticleOfCommande.REMISEPARARTICLE = True
                o_commande.CommandeOfArticleOfCommande.TAUXREMISE = FrmCaisse.DgvCommande.Rows(i).Cells(3).Value
            Else
                o_commande.CommandeOfArticleOfCommande.REMISEPARARTICLE = False
                o_commande.CommandeOfArticleOfCommande.TAUXREMISE = 0
            End If


            o_commande.CommandeOfArticleOfCommande.ISOFFERE = False
            o_commande.CommandeOfArticleOfCommande.QTEOFFERE = "0"
            o_commande.CommandeOfArticleOfCommande.ISRETOUR = False
            o_commande.CommandeOfArticleOfCommande.QTERETROUR = "0"
            o_commande.CommandeOfArticleOfCommande.Ajouter()

        Next

        o_payement.ModeReglementOfPayement.MDRG_ID = DgvReglement.Rows(0).Cells(3).Value
        o_payement.PAYM_MONTANT = DgvReglement.Rows(0).Cells(1).Value
        o_payement.Ajouter()

        Dim id_payement As Integer = o_payement.PAYM_ID
        o_facture.CommandeOfFacture.CMD_ID = o_commande.CMD_ID
        o_facture.FACT_DATE = Now.Date
        o_facture.FACT_ETAT = True
        o_facture.Ajouter()


        o_payement.FactureOfPayement.Add(o_facture)
        o_facture.PayementOfFacture.Add(o_payement)

        o_facture.AjouterFactutreOfPayement(o_payement.PAYM_ID, o_facture.FACT_ID)

        FrmCaisse.LblMontantApayerInfo.Text = 0
        RefreshFrmFondCaisse()

        MsgBox(" Commande Réussite ", MsgBoxStyle.Information)

        FrmImprimerFacture.Show()
        Dim etat As New Rpt_Imprimer_Facture

        etat.SetParameterValue("@IDCom", o_commande.CMD_ID)
        FrmImprimerFacture.CrystalReportViewer1.ReportSource = etat

        Me.Close()
        FrmCaisse.Show()

    End Sub

    Private Sub Encaissement_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        FrmCaisse.Show()

    End Sub

    Private Sub Encaissement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Lbl_Reste_A_Payer.Visible = False
        Lbl_A_Rendre.Visible = False
        Lbl_Montant_Reçu.Visible = False
        Lbl_A_Payer.Visible = False

        dt2.Columns.Clear()
        dt2.Rows.Clear()
        DgvReglement.DataSource = Creerdatabletarif_of_Reglement()

        LblNomVendeur.Text = FrmCaisse.LblNomCaissierInfo.Text

        Lbl_A_Payer.Text = FrmCaisse.LblMontantApayerInfo.Text
        Lbl_A_Payer.Visible = True



    End Sub

    Private Sub cmdFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()
        FrmCaisse.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        FrmListeClients.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        FrmListeClients.MdiParent = Nothing
        FrmListeClients.StartPosition = FormStartPosition.CenterScreen
        FrmListeClients.Show()

        FrmListeClients.BtnChoisiClient.Visible = True
        FrmListeClients.BtnNvClient.Visible = False

    End Sub

    Private Sub BtnZeroPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnZeroPave.Click

        TxtPavé.Text = TxtPavé.Text & BtnZeroPave.Text

    End Sub

    Private Sub btnPlusmoinPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlusmoinPave.Click
        TxtPavé.Text = TxtPavé.Text * (-1)

    End Sub

    Private Sub BtnUnPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUnPave.Click

        TxtPavé.Text = TxtPavé.Text & BtnUnPave.Text

    End Sub

    Private Sub BtnDeuxPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeuxPave.Click
        TxtPavé.Text = TxtPavé.Text & BtnDeuxPave.Text

    End Sub

    Private Sub BtnTroisPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTroisPave.Click
        TxtPavé.Text = TxtPavé.Text & BtnTroisPave.Text

    End Sub

    Private Sub BtnQuatrePave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuatrePave.Click
        TxtPavé.Text = TxtPavé.Text & BtnQuatrePave.Text

    End Sub

    Private Sub BtnCinqPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCinqPave.Click
        TxtPavé.Text = TxtPavé.Text & BtnCinqPave.Text

    End Sub

    Private Sub BtnSixPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSixPave.Click
        TxtPavé.Text = TxtPavé.Text & BtnSixPave.Text
    End Sub

    Private Sub BtnSeptPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeptPave.Click

        TxtPavé.Text = TxtPavé.Text & BtnSeptPave.Text

    End Sub

    Private Sub BtnhuitPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnhuitPave.Click
        TxtPavé.Text = TxtPavé.Text & BtnhuitPave.Text
    End Sub

    Private Sub BtnNeufPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNeufPave.Click

        TxtPavé.Text = TxtPavé.Text & BtnNeufPave.Text

    End Sub

    Private Sub BtnpointPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnpointPave.Click

        TxtPavé.Text = TxtPavé.Text & BtnpointPave.Text

    End Sub

    Private Sub BtnEffacerPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtPavé.Text = ""
    End Sub

    Private Sub BtnImprimerTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimerTicket.Click
        Try
            '------------ Sans Ticket Et Sans Facture ---------------------------
            Dim o_commande As New Commande
            Dim o_Ticket As New Ticket
            Dim o_payement As New Payement
            Dim o_article As New ARTICLE
            '---------------------------------------------
            For i As Integer = 0 To FrmCaisse.DgvCommande.Rows.Count - 2

                o_article.ART_ID = FrmCaisse.DgvCommande.Rows(i).Cells(6).Value
                o_commande.ClientsOfCommandes.CLT_MAT = txtchoisirClient.Tag
                o_commande.CaissierOfCommande.CAISSIER_ID = FrmCaisse.LblNomCaissierInfo.Tag
                o_commande.CMD_DATEC = Now.Date

                If LblRemiseGlobal.Text = "Yes" Then
                    o_commande.CMD_REMISEGLOBAL = True
                Else
                    o_commande.CMD_REMISEGLOBAL = False
                End If

                o_commande.CMD_MONTANTTOTAL = Lbl_A_Payer.Text

            Next

            o_commande.Ajouter()

            For i As Integer = 0 To FrmCaisse.DgvCommande.Rows.Count - 2

                o_commande.CommandeOfArticleOfCommande.CommandeOfArticleOfCommande.Add(o_commande)
                '-------------------------------------
                o_article.ART_ID = FrmCaisse.DgvCommande.Rows(i).Cells(6).Value
                o_commande.CommandeOfArticleOfCommande.CommandeOfArticleOfArticle.Add(o_article)
                '--------------------------------------
                o_commande.CommandeOfArticleOfCommande.QTE = FrmCaisse.DgvCommande.Rows(i).Cells(4).Value

                If FrmCaisse.DgvCommande.Rows(i).Cells(3).Value > 0 Then

                    o_commande.CommandeOfArticleOfCommande.REMISEPARARTICLE = True
                    o_commande.CommandeOfArticleOfCommande.TAUXREMISE = FrmCaisse.DgvCommande.Rows(i).Cells(3).Value
                Else
                    o_commande.CommandeOfArticleOfCommande.REMISEPARARTICLE = False
                    o_commande.CommandeOfArticleOfCommande.TAUXREMISE = 0
                End If


                o_commande.CommandeOfArticleOfCommande.ISOFFERE = False
                o_commande.CommandeOfArticleOfCommande.QTEOFFERE = "0"
                o_commande.CommandeOfArticleOfCommande.ISRETOUR = False
                o_commande.CommandeOfArticleOfCommande.QTERETROUR = "0"
                o_commande.CommandeOfArticleOfCommande.Ajouter()

            Next

            o_payement.ModeReglementOfPayement.MDRG_ID = DgvReglement.Rows(0).Cells(3).Value
            o_payement.PAYM_MONTANT = DgvReglement.Rows(0).Cells(1).Value
            o_payement.Ajouter()
            '--------------------- Avec Ticket Ou Avec Facture-----------------------
            Dim id_payement As Integer = o_payement.PAYM_ID
            o_Ticket.CommandeOfTicket.CMD_ID = o_commande.CMD_ID
            o_Ticket.TIK_DATECREATION = Now.Date
            o_Ticket.TIK_TYPE = True
            o_Ticket.TIK_MONTANTRECU = Lbl_A_Payer.Text
            o_Ticket.Ajouter()

            o_Ticket.PayementOfTicket.Add(o_payement)
            o_payement.TicketOfPayement.Add(o_Ticket)

            o_Ticket.AjouterPayementOfTicket(o_payement.PAYM_ID, o_Ticket.TIK_ID)

            FrmCaisse.LblMontantApayerInfo.Text = 0

            RefreshFrmFondCaisse()

            MsgBox(" Commande Reussite ", MsgBoxStyle.Information)

            Me.Close()

            FrmImprimerFacture.Show()
            Dim etat As New Rpt_Imprimer_Ticket
            etat.SetParameterValue("@IDCom", o_commande.CMD_ID)
            FrmImprimerFacture.CrystalReportViewer1.ReportSource = etat
            FrmCaisse.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

      


    End Sub

    Private Sub BtnSansImprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSansImprimer.Click

        '------------ Sans Ticket Et Sans Facture ---------------------------
        Dim o_commande As New Commande
        Dim o_Ticket As New Ticket
        Dim o_payement As New Payement
        Dim o_article As New ARTICLE
        '---------------------------------------------
        For i As Integer = 0 To FrmCaisse.DgvCommande.Rows.Count - 2

            o_article.ART_ID = FrmCaisse.DgvCommande.Rows(i).Cells(6).Value
            o_commande.ClientsOfCommandes.CLT_MAT = txtchoisirClient.Tag
            o_commande.CaissierOfCommande.CAISSIER_ID = FrmCaisse.LblNomCaissierInfo.Tag
            o_commande.CMD_DATEC = Now.Date

            If LblRemiseGlobal.Text = "Yes" Then
                o_commande.CMD_REMISEGLOBAL = True
            Else
                o_commande.CMD_REMISEGLOBAL = False
            End If

            o_commande.CMD_MONTANTTOTAL = Lbl_A_Payer.Text

        Next

        o_commande.Ajouter()

        For i As Integer = 0 To FrmCaisse.DgvCommande.Rows.Count - 2

            o_commande.CommandeOfArticleOfCommande.CommandeOfArticleOfCommande.Add(o_commande)
            '-------------------------------------
            o_article.ART_ID = FrmCaisse.DgvCommande.Rows(i).Cells(6).Value
            o_commande.CommandeOfArticleOfCommande.CommandeOfArticleOfArticle.Add(o_article)
            '--------------------------------------
            o_commande.CommandeOfArticleOfCommande.QTE = FrmCaisse.DgvCommande.Rows(i).Cells(4).Value

            If FrmCaisse.DgvCommande.Rows(i).Cells(3).Value > 0 Then

                o_commande.CommandeOfArticleOfCommande.REMISEPARARTICLE = True
                o_commande.CommandeOfArticleOfCommande.TAUXREMISE = FrmCaisse.DgvCommande.Rows(i).Cells(3).Value
            Else
                o_commande.CommandeOfArticleOfCommande.REMISEPARARTICLE = False
                o_commande.CommandeOfArticleOfCommande.TAUXREMISE = 0
            End If


            o_commande.CommandeOfArticleOfCommande.ISOFFERE = False
            o_commande.CommandeOfArticleOfCommande.QTEOFFERE = "0"
            o_commande.CommandeOfArticleOfCommande.ISRETOUR = False
            o_commande.CommandeOfArticleOfCommande.QTERETROUR = "0"
            o_commande.CommandeOfArticleOfCommande.Ajouter()

        Next

        o_payement.ModeReglementOfPayement.MDRG_ID = DgvReglement.Rows(0).Cells(3).Value
        o_payement.PAYM_MONTANT = DgvReglement.Rows(0).Cells(1).Value
        o_payement.Ajouter()

        MsgBox(" Commande Réussite ", MsgBoxStyle.Information)

        FrmCaisse.Show()

    End Sub

    Private Sub TxtPavé_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPavé.TextChanged

        If Val(TxtPavé.Text) > Val(Lbl_A_Payer.Text) Then

            Lbl_A_Rendre.Text = Val(TxtPavé.Text) - Val(Lbl_A_Payer.Text)
            Lbl_A_Rendre.Visible = True

        Else

            Lbl_A_Rendre.Text = ""

        End If

        Lbl_Montant_Reçu.Text = Val(TxtPavé.Text)
        Lbl_Montant_Reçu.Visible = True

        If Val(TxtPavé.Text) < Val(Lbl_A_Payer.Text) Then

            Lbl_Reste_A_Payer.Text = Val(Lbl_A_Payer.Text) - Val(TxtPavé.Text)
            Lbl_Reste_A_Payer.Visible = True

        Else

            Lbl_Reste_A_Payer.Text = ""

        End If



    End Sub

    Private Sub BtnEspece_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEspece.Click


        DgvReglement.Rows(0).Cells(0).Value = sender.Text
        DgvReglement.Rows(0).Cells(1).Value = TxtPavé.Text
        DgvReglement.Rows(0).Cells(2).Value = "AUCUN"
        DgvReglement.Rows(0).Cells(3).Value = sender.Tag

        FrmFondCaisse.Show()
        FrmFondCaisse.Visible = False
        RefreshFrmFondCaisse()

        Dim srw As New StreamWriter("FondCaisse.txt")
        Dim chaine As String
        chaine = FrmFondCaisse.TxtFondDeCaisseFD.Text & ";" & FrmFondCaisse.TxtEspeceFD.Text & ";" & FrmFondCaisse.TxtMouvementFD.Text & ";" & FrmFondCaisse.TxtCheQueFD.Text & ";" & FrmFondCaisse.TxtTiquetRestoFD.Text & ";" & FrmFondCaisse.TxtCarteBancaireFD.Text & ";" & FrmFondCaisse.TxtTotalFD.Text
        srw.WriteLine(chaine)
        srw.Close()
        MsgBox("Fichier FondCaisse Rempli")

    End Sub

    Private Sub BtnCB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCB.Click

        BtnEspece_Click(sender, e)
    End Sub

    Private Sub BtnCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCheque.Click

      BtnEspece_Click(sender, e)

    End Sub

    Private Sub BtnTickResto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTickResto.Click
        BtnEspece_Click(sender, e)

    End Sub

    Private Sub BtnEffacerReglement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEffacerReglement.Click
        Dim rep As String = MsgBox(" Estes Vous Sur de Vouloire Effacer Ce Regelement?? ", MsgBoxStyle.YesNo)

        If rep = MsgBoxResult.Yes Then

            dt2.Rows.Clear()

            MsgBox(" Regelement Annulé ")
        Else

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Me.Close()

    End Sub


End Class