Imports System.IO

Public Class FrmCaisse

    Public bool As Boolean = False
    Dim un As Integer
    Dim dat As Date
    Dim Mont As Double
    Public x As Integer
    Public y As Date
    Public z As Double

    Private Sub FrmCaisse_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Dim srw As New StreamWriter("Attente.txt")
        Dim chaine As String = ""
        srw.WriteLine(chaine)
        MsgBox("Fichier Vide")

    End Sub

    Private Sub FrmCaisse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dt.Rows.Clear()
        dt.Columns.Clear()
        GetResolution(Me)

        BtnAnnulerTicket.Enabled = False
        BtnFondCaisse.Enabled = False
        BtnRappelerTicket.Enabled = False
        BtnCloturerCaisse.Enabled = False
        BtnQteGlobal.Enabled = False
        BtnRemiseGlobal.Enabled = False
        BtnMettreEnAttente.Enabled = False
        BtnEncaisser.Enabled = False
        BtnCloturerCaisse.Enabled = False
        LblOccupation.Visible = False
        DtpDateDebutCaissier.Enabled = False
        LblDateInfo.Text = "Aujourdhui Le : " & Today
        LblHeurInfo.Text = TimeOfDay


        'FrmRappelerTicket.DgvRappelDuTicket.DataSource = CreerDatatableRappelerTicket()
        'FrmTicketEnAttente.DgvTicketEnAttente.DataSource = CreerDatatableTicketEnAttente()
        DgvCommande.DataSource = creerdatatableCommande()

        '-------------------------------------

        '--------- Masquer Les Buttons Au demarrage--------
        For Each ctl As Button In FlpSF.Controls
            ctl.Visible = False
        Next

        For Each ctl As Button In FlpMarque.Controls
            ctl.Visible = False
        Next
        '------------------------------------------------
        Dim o_sf As New SOUS_FAMILLE
        Dim listSF As New List(Of SOUS_FAMILLE)
        listSF = o_sf.Actualiser_Liste

        For i As Integer = 0 To listSF.Count - 1

            FlpSF.Controls.Item(i).Text = listSF.Item(i).Sf_Lib
            FlpSF.Controls.Item(i).Tag = listSF.Item(i).SF_ID
            FlpSF.Controls.Item(i).Visible = True

        Next



    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        FrmListeClients.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        FrmListeClients.MdiParent = Nothing
        FrmListeClients.StartPosition = FormStartPosition.CenterScreen

        FrmListeClients.Show()

    End Sub

    Private Sub btnPlusmoinPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        TxtPavé.Text = TxtPavé.Text * -1

    End Sub

    Private Sub BtnRemiseGlobal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For i As Integer = 0 To DgvCommande.Rows.Count - 2

            DgvCommande.Rows(i).Cells(2).Value = DgvCommande.Rows(i).Cells(2).Value - (DgvCommande.Rows(i).Cells(2).Value * (DgvCommande.Rows(i).Cells(3).Value / 100))
            DgvCommande.Rows(i).Cells(5).Value = DgvCommande.Rows(i).Cells(2).Value * DgvCommande.Rows(i).Cells(4).Value

        Next

        LblMontantApayerInfo.Text = RecalculerPrix()

    End Sub

    Private Sub cmdFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()
        FrmPrincipal.Show()

    End Sub

    Private Sub DgvCommande_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs)
        If DgvCommande.Rows.Count > 1 Then

            BtnAnnulerTicket.Enabled = True
            BtnEffacerLigne.Enabled = True

        End If
    End Sub

    Private Sub DgvCommande_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs)
        If DgvCommande.Rows.Count <= 1 Then

            BtnAnnulerTicket.Enabled = False
            BtnEffacerLigne.Enabled = False


        End If
    End Sub

    Private Sub BtnLesCaissiers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        FrmListeCaissier.Show()

    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click

        For Each ctl As Button In FlpMarque.Controls
            ctl.Visible = False
        Next

        Dim o_maruqe As New MARQUE
        Dim Listmarque As New List(Of MARQUE)
        Listmarque = o_maruqe.Actualiser_Liste


        For i As Integer = 0 To Listmarque.Count - 1

            If sender.Tag = Listmarque.Item(i).SousFamilleofMarques.SF_ID Then

                FlpMarque.Controls(i).Text = Listmarque.Item(i).Mrq_Lib
                FlpMarque.Controls(i).Tag = Listmarque.Item(i).Mrq_Id
                FlpMarque.Controls(i).Visible = True

            End If

        Next

        For Each ctl As Control In FlpMarque.Controls

            If ctl.Text = "DEMO" Then
                ctl.Visible = False
            End If

        Next
    End Sub

    Private Sub Button13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

        Button12_Click_1(sender, e)

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Button12_Click_1(sender, e)
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Button12_Click_1(sender, e)
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Button12_Click_1(sender, e)
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Button12_Click_1(sender, e)
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Button12_Click_1(sender, e)
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Button12_Click_1(sender, e)
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Button12_Click_1(sender, e)
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Button12_Click_1(sender, e)
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Button12_Click_1(sender, e)
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Button12_Click_1(sender, e)
    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        Button12_Click_1(sender, e)
    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        Button12_Click_1(sender, e)
    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        Button12_Click_1(sender, e)
    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        Button12_Click_1(sender, e)
    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        Button12_Click_1(sender, e)
    End Sub

    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button45.Click
        Button12_Click_1(sender, e)
    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        Button12_Click_1(sender, e)
    End Sub

    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        Button12_Click_1(sender, e)
    End Sub

    Private Sub Button25_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click

        Dim o_art As New ARTICLE
        Dim listart As New List(Of ARTICLE)
        listart = o_art.Actualiser_Liste

        For i As Integer = 0 To listart.Count - 1

            If sender.Tag = listart.Item(i).MarqueOfArticle.Mrq_Id Then

                For j As Integer = 0 To FlpMarque.Controls.Count - 1

                    Tous_Les_Articles.FlpArticles.Controls(i).Text = listart.Item(i).ART_DESCRIPTION
                    Tous_Les_Articles.FlpArticles.Controls(i).Tag = listart.Item(i).ART_ID
                    Tous_Les_Articles.FlpArticles.Controls(i).BackgroundImage = ByteArrayToImage(listart.Item(i).ART_PHOTO)
                    Tous_Les_Articles.FlpArticles.Controls(i).Visible = True

                Next

            End If

        Next

        For Each ctl As Control In Tous_Les_Articles.FlpArticles.Controls

            If ctl.Text = "DEMO" Then
                ctl.Visible = False
            End If

        Next

        Tous_Les_Articles.Show()

    End Sub

    Private Sub Button26_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click

        Button25_Click_1(sender, e)

    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button48.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button50.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button51.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button52.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button53.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button54.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button55.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button56.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button57.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button58.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub Button59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button59.Click
        Button25_Click_1(sender, e)
    End Sub

    Private Sub BtnEffacerLigne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEffacerLigne.Click
        For i As Integer = 0 To DgvCommande.Rows.Count - 1

            If DgvCommande.Rows(i).Selected = True Then

                DgvCommande.Rows.Remove(DgvCommande.Rows(i))

                Exit For

            End If
        Next

        LblMontantApayerInfo.Text = RecalculerPrix()
    End Sub

    Private Sub BtnAnnulerTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnnulerTicket.Click

        Dim rep As String = MsgBox(" Estes Vous Sur de Vouloire Annuler Cette Ticket?? ", MsgBoxStyle.YesNo)

        If rep = MsgBoxResult.Yes Then

            dt.Rows.Clear()
            MsgBox(" Ticket Annulé ")
        Else

        End If

        LblMontantApayerInfo.Text = RecalculerPrix()

    End Sub

    Private Sub BtnMettreEnAttente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMettreEnAttente.Click

        FrmRappelerTicket.Show()
        FrmRappelerTicket.Visible = False
        BtnRappelerTicket.Enabled = True

        If FrmRappelerTicket.DgvRappelDuTicket.Rows(0).Cells(0).Value Is Nothing Then

            Dim srw As New StreamWriter("Attente.txt")
            Dim total As Double
            Dim id As Integer
            Dim conteur As Integer

            For i As Integer = 0 To DgvCommande.Rows.Count - 2

                Dim chaine As String = DgvCommande.Rows(i).Cells(0).Value & ";" & DgvCommande.Rows(i).Cells(1).Value & ";" & DgvCommande.Rows(i).Cells(2).Value & ";" & DgvCommande.Rows(i).Cells(3).Value & ";" & DgvCommande.Rows(i).Cells(4).Value & ";" & DgvCommande.Rows(i).Cells(5).Value & ";" & DgvCommande.Rows(i).Cells(6).Value
                srw.WriteLine(chaine)
                id = DgvCommande.Rows(i).Cells(6).Value
                total = total + DgvCommande.Rows(i).Cells(5).Value
                conteur = conteur + 1

            Next

            FrmRappelerTicket.DgvRappelDuTicket.Rows(0).Cells(0).Value = "Ticket Numero 1"
            FrmRappelerTicket.DgvRappelDuTicket.Rows(0).Cells(1).Value = total
            FrmRappelerTicket.DgvRappelDuTicket.Rows(0).Cells(2).Value = Date.Now
            MsgBox("Ticket Enregistré")

            srw.Close()
            dt.Rows.Clear()

            BtnAnnulerTicket.Enabled = False
            BtnEffacerLigne.Enabled = False
            BtnEncaisser.Enabled = False
            FrmRappelerTicket.LblCompteur.Text = conteur


        Else
            MsgBox("Vous Avez Le Droit De Mettre Seulment Un Tickét en Attente", MsgBoxStyle.Information)
            Exit Sub

        End If
    End Sub

    Private Sub BtnRappelerTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRappelerTicket.Click
        FrmRappelerTicket.Show()

        Dim sr As New StreamReader("Attente.txt")
        Dim chaine As String
        Dim chaines() As String
        chaine = sr.ReadLine
        chaines = chaine.Split(";")

        sr.Close()
        BtnMettreEnAttente.Enabled = True
    End Sub

    Private Sub BtnEncaisser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEncaisser.Click
        Encaissement.Show()
    End Sub

    Private Sub BtnLesClients_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLesClients.Click
        
        FrmListeClients.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        FrmListeClients.MdiParent = Nothing
        FrmListeClients.StartPosition = FormStartPosition.CenterScreen

        FrmListeClients.Show()
    End Sub

    Private Sub BtnLesArticles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLesArticles.Click

        FrmListeArticle.MdiParent = Nothing
        FrmListeArticle.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        FrmListeArticle.WindowState = FormWindowState.Maximized
        FrmListeArticle.Show()
       
    End Sub

    Private Sub BtnLesCaissiers_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLesCaissiers.Click
        FrmListeCaissier.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        FrmListeCaissier.Show()
       
    End Sub

    Private Sub BtnCloturerCaisse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCloturerCaisse.Click

        FrmFondCaisse.Show()
        FrmFondCaisse.Visible = False

        FrmCloturerLaCaisse.TxtCBcloture.Text = FrmFondCaisse.TxtCarteBancaireFD.Text
        FrmCloturerLaCaisse.txtChequeCloture.Text = FrmFondCaisse.TxtCheQueFD.Text
        FrmCloturerLaCaisse.TxtEspeceCloture.Text = FrmFondCaisse.TxtEspeceFD.Text
        FrmCloturerLaCaisse.TxtRemiseCloture.Text = 0
        FrmCloturerLaCaisse.TxtTickResCloture.Text = FrmFondCaisse.TxtTiquetRestoFD.Text
        FrmCloturerLaCaisse.TxtFondCaisseCloture.Text = FrmFondCaisse.TxtFondDeCaisseFD.Text

        FrmCloturerLaCaisse.Show()

    End Sub

    Private Sub BtnQteGlobal_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQteGlobal.Click

        For i As Integer = 0 To DgvCommande.Rows.Count - 2

            DgvCommande.Rows(i).Cells(4).Value = TxtPavé.Text

            DgvCommande.Rows(i).Cells(5).Value = DgvCommande.Rows(i).Cells(2).Value * DgvCommande.Rows(i).Cells(4).Value

        Next
        LblMontantApayerInfo.Text = RecalculerPrix()

    End Sub

    Private Sub BtnRemiseGlobal_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemiseGlobal.Click
        For i As Integer = 0 To DgvCommande.Rows.Count - 2

            DgvCommande.Rows(i).Cells(2).Value = DgvCommande.Rows(i).Cells(2).Value - (DgvCommande.Rows(i).Cells(2).Value * (DgvCommande.Rows(i).Cells(3).Value / 100))
            DgvCommande.Rows(i).Cells(5).Value = DgvCommande.Rows(i).Cells(2).Value * DgvCommande.Rows(i).Cells(4).Value

        Next

        LblMontantApayerInfo.Text = RecalculerPrix()
    End Sub

    Private Sub BtnFondCaisse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFondCaisse.Click
        FrmFondCaisse.Show()
    End Sub

    Private Sub BtnQuiter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuiter.Click

        Dim rep As String = MsgBox(" Voulez Vraiment Quiter L'application ?? ", MsgBoxStyle.YesNo)

        If rep = MsgBoxResult.Yes Then

            Dim srw As New StreamWriter("FondCaisse.txt")
            Dim chaine As String
            chaine = 0 & ";" & 0 & ";" & 0 & ";" & 0 & ";" & 0 & ";" & 0 & ";" & 0
            srw.WriteLine(chaine)
            srw.Close()

            Dim o_occupation As New OCCUPATION
            o_occupation.OCP_ID = LblOccupation.Text
            o_occupation.O_Caissier.CAISSIER_ID = LblNomCaissierInfo.Tag
            o_occupation.O_Caisse.CAISSE_ID = LblCaisseInfo.Tag
            o_occupation.OCP_DATED = DtpDateDebutCaissier.Value
            o_occupation.OCP_DATEF = Date.Now
            o_occupation.Modifier()
            Me.Close()

        Else

        End If
    End Sub

    Private Sub btnPlusmoinPave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlusmoinPave.Click
        TxtPavé.Text = TxtPavé.Text * -1
    End Sub

    Private Sub BtnpointPave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnpointPave.Click
        TxtPavé.Text = TxtPavé.Text & "."
    End Sub

    Private Sub BtnEffacerPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEffacerPave.Click
        TxtPavé.Text = ""
    End Sub

    Private Sub BtnUnPave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUnPave.Click
        TxtPavé.Text = TxtPavé.Text & "1"
    End Sub

    Private Sub BtnDeuxPave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeuxPave.Click
        TxtPavé.Text = TxtPavé.Text & "2"
    End Sub

    Private Sub BtnTroisPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtPavé.Text = TxtPavé.Text & "3"
    End Sub

    Private Sub BtnQuatrePave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuatrePave.Click
        TxtPavé.Text = TxtPavé.Text & "4"
    End Sub

    Private Sub BtnCinqPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCinqPave.Click
        TxtPavé.Text = TxtPavé.Text & "5"
    End Sub

    Private Sub BtnSixPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSixPave.Click
        TxtPavé.Text = TxtPavé.Text & "6"
        
    End Sub

    Private Sub BtnSeptPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeptPave.Click
        TxtPavé.Text = TxtPavé.Text & "7"
      
    End Sub

    Private Sub BtnhuitPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnhuitPave.Click
        TxtPavé.Text = TxtPavé.Text & "8"

    End Sub

    Private Sub BtnNeufPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNeufPave.Click
        TxtPavé.Text = TxtPavé.Text & "9"
    End Sub

    Private Sub BtnZeroPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnZeroPave.Click
        TxtPavé.Text = TxtPavé.Text & "0"
    End Sub

    Private Sub BtnQtePave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQtePave.Click

        '---btnQtePavé
        DgvCommande.CurrentRow.Cells(4).Value = TxtPavé.Text
        DgvCommande.CurrentRow.Cells(5).Value = DgvCommande.CurrentRow.Cells(2).Value * DgvCommande.CurrentRow.Cells(4).Value
        TxtPavé.Text = ""
        LblMontantApayerInfo.Text = RecalculerPrix()
       
       

    End Sub

    Private Sub BtnPUPave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '--------BtnPU
        DgvCommande.CurrentRow.Cells(2).Value = TxtPavé.Text
        DgvCommande.CurrentRow.Cells(5).Value = DgvCommande.CurrentRow.Cells(2).Value * DgvCommande.CurrentRow.Cells(4).Value

        TxtPavé.Text = ""
        LblMontantApayerInfo.Text = RecalculerPrix()
    End Sub

    Private Sub BtnRemisePave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemisePave.Click
        '---------BtnRemise
        DgvCommande.CurrentRow.Cells(3).Value = TxtPavé.Text
        DgvCommande.CurrentRow.Cells(2).Value = DgvCommande.CurrentRow.Cells(2).Value - (DgvCommande.CurrentRow.Cells(2).Value * (DgvCommande.CurrentRow.Cells(3).Value / 100))
        DgvCommande.CurrentRow.Cells(5).Value = DgvCommande.CurrentRow.Cells(2).Value * DgvCommande.CurrentRow.Cells(4).Value
        TxtPavé.Text = ""
        LblMontantApayerInfo.Text = RecalculerPrix()
        '-----------
    End Sub

End Class
