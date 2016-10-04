Public Class FrmListeVente

    Private Sub txtMontantreçcu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontantreçu.TextChanged
        If Not IsNumeric(txtMontantreçu.Text) And txtMontantreçu.Text <> "" Then
            MsgBox("Tu doit entrer une valeur numérique SVP!!!", MsgBoxStyle.Information, "Attention")
            txtMontantreçu.Focus()
            txtMontantreçu.SelectAll()
        End If
    End Sub

    Private Sub lblRefCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRefCom.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmCommande.ShowDialog()
    End Sub

    Private Sub btnMiseJour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmTicket.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmFacture.ShowDialog()
    End Sub

    Private Sub cmdFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()
        FrmConfiguation.Show()

    End Sub

    Private Sub FrmListeVente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      

        Me.MdiParent = FrmConfiguation
        Me.Dock = DockStyle.Fill

        Creer_Data("select * from V_Ticket", dgvtickets)
        Creer_Data("select * from V_Facture", dgvFacture)
        Creer_Data("select * from V_Commande", dgvCommande)

        dgvtickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvtickets.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue
        dgvtickets.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
        dgvtickets.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Orange
        dgvtickets.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black

        dgvFacture.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvFacture.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue
        dgvFacture.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
        dgvFacture.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Orange
        dgvFacture.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black


        dgvCommande.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCommande.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue
        dgvCommande.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
        dgvCommande.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Orange
        dgvCommande.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black

        'Dim o_ticket As New Ticket
        'Dim o_facture As New Facture
        'Dim o_commande As New Commande

        'dgvtickets.DataSource = o_ticket.RetournerListeTICKET
        'dgvFacture.DataSource = o_facture.RetournerListeFacture
        'dgvCommande.DataSource = o_commande.RetournerListeCommande

        'Da_Ticket.Fill(ds.TICKET)
        'Da_Facture.Fill(ds.FACTURE)
        'Da_Commande.Fill(ds.COMMANDE)
        'Da_ModeReglement.Fill(ds.MODE_REGLEMENT)


        'dgvtickets.DataSource = ds.TICKET
        'dgvFacture.DataSource = ds.FACTURE
        'dgvCommande.DataSource = ds.COMMANDE
        'dgvModeReglement.DataSource = ds.MODE_REGLEMENT
      


    End Sub

    Private Sub NouveauTick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        FrmTicket.Show()
        FrmTicket.lblTitre.Text = "**Ajouter une facture**"

    End Sub

    Private Sub btnNouveauFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        FrmFacture.Show()
        FrmFacture.lblTitre.Text = "**Ajouter une facture**"

    End Sub

    Private Sub btnNouveau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        FrmCommande.Show()
        FrmCommande.lblTitre.Text = "**Ajouter une commande**"

    End Sub

    Private Sub btnModifierTick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If dgvtickets.SelectedRows.Count = 0 Then
            MsgBox("Vous devez séléctionner une ticket à modifier SVP!!", MsgBoxStyle.Information)
        End If

        FrmTicket.Show()

    End Sub

    Private Sub btnSupprimerTick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If dgvtickets.SelectedRows.Count = 0 Then
            MsgBox("Vous devez séléctionner une ticket à supprimer SVP!!", MsgBoxStyle.Information)
        End If

        Dim o_ticket As New Ticket

        Try
            o_ticket.TIK_ID = dgvtickets.CurrentRow.Cells(0).Value
            o_ticket.Supprimer()

        Catch ex As Exception
            MsgBox("erreur!!!!!!!!!!!!")
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            If dgvtickets.SelectedRows.Count = 0 Then
                MsgBox("Vous Devez Selectionnez une ticket a modifier !!", MsgBoxStyle.Information)
                Exit Sub
            End If

            FrmRayon.LblRayon.Text = "Modifier une ticket"


            Dim O_ticket As New Ticket
            Dim listticket As New List(Of Ticket)
            listticket = O_ticket.RetournerListeTICKET


            FrmTicket.txtype.Text = dgvtickets.CurrentRow.Cells(2).Value
            FrmTicket.dtpTick.Text = dgvtickets.CurrentRow.Cells(3).Value
            FrmTicket.txtMontRecu.Text = dgvtickets.CurrentRow.Cells(4).Value

            FrmTicket.Tag = dgvtickets.CurrentRow.Cells(0).Value
            FrmRayon.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Try

            FrmFacture.lblTitre.Text = "** Modifier votre facture **"
            FrmFacture.Tag = dgvFacture.CurrentRow.Cells(0).Value
            FrmFacture.DtpFact.Text = dgvtickets.CurrentRow.Cells(1).Value
            FrmFacture.txtEtat.Text = dgvtickets.CurrentRow.Cells(2).Value
            FrmFacture.cmbCommand.Text = dgvtickets.CurrentRow.Cells(3).Value
            FrmFacture.Show()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
       
    End Sub
End Class