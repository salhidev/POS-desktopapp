Public Class FrmListeClients


    Private Sub BtnNvClient_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        FrmAjoutClient.ShowDialog()

    End Sub

    Private Sub cmdFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        FrmConfiguation.Show()

    End Sub

    Private Sub FrmListeClients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MdiParent = FrmConfiguation
        Me.Dock = DockStyle.Fill

        Dim o_client As New Client

        DgvClients.DataSource = o_client.RetournerListeClient

        DgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvClients.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue
        DgvClients.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
        DgvClients.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Orange
        DgvClients.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black

        BtnChoisiClient.Visible = False

    End Sub

    Private Sub BtnChoisiClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChoisiClient.Click

        Encaissement.txtchoisirClient.Text = DgvClients.CurrentRow.Cells(1).Value
        Encaissement.txtchoisirClient.Tag = DgvClients.CurrentRow.Cells(0).Value

    End Sub

    Private Sub btnEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNvClient.Click

        FrmAjoutClient.Show()
        FrmAjoutClient.lbltitre.Text = "**Ajouter un client**"

    End Sub

    Private Sub Btn_Modifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modifier.Click

        If DgvClients.SelectedRows.Count = 0 Then
            MsgBox("Vous dever séléctionner un client à modifier", MsgBoxStyle.Information)
            Exit Sub
        End If

        Try
            FrmAjoutClient.Show()
            FrmAjoutClient.lbltitre.Text = "**Modifier un client**"

        Catch ex As Exception
            MsgBox("l'opération a été effectue avec succés", MsgBoxStyle.Information)
        End Try


    End Sub

    Private Sub Btn_Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Supprimer.Click

        If DgvClients.SelectedRows.Count = 0 Then
            MsgBox("Vous dever séléctionner un client à modifier", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim o_client As New Client
        Conex.Open()
        Try

            Dim msg As MsgBoxStyle = MsgBox("   Si vous supprimer ce client ==> vous risquez de perdre tout les commandes de ce client  :" & vbNewLine & vbNewLine & "     ==> alors si voulez-vous vraiment le supprimer définitivement avec tout ces relations Appuyez sur oui ==>" & vbNewLine & vbNewLine & "  ==> sinon si voulez-vous supprimer seulement ce client appuyez sur Non ==>", MsgBoxStyle.YesNoCancel, "** Lisez ce message attentivement avant de supprimer **")

            If msg = vbYes Then


                o_client.CLT_MAT = DgvClients.CurrentRow.Cells(0).Value

                cmd.Connection = Conex

                cmd.CommandText = "exec SP_SupprimerClient '" & o_client.CLT_MAT & "'"

                cmd.ExecuteNonQuery()

                MsgBox("Ce client à été supprimé avec succés", MsgBoxStyle.Information)



            ElseIf msg = vbNo Then

                o_client.CLT_MAT = DgvClients.CurrentRow.Cells(0).Value

                cmd.Connection = Conex
                cmd.CommandText = "exec SP_SuppClientSeul '" & o_client.CLT_MAT & "'"

                cmd.ExecuteNonQuery()

                MsgBox("Ce client à été supprimé seulement avec succés", MsgBoxStyle.Information)

            End If

            Conex.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DgvClients_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvClients.CellDoubleClick

        If BtnChoisiClient.Visible = True Then
            Encaissement.txtchoisirClient.Text = DgvClients.CurrentRow.Cells(1).Value
            Encaissement.txtchoisirClient.Tag = DgvClients.CurrentRow.Cells(0).Value
            Me.Close()
        End If

    End Sub

    Private Sub DgvClients_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvClients.DoubleClick

        If BtnChoisiClient.Visible = True Then

            Encaissement.txtchoisirClient.Text = DgvClients.CurrentRow.Cells(1).Value
            Encaissement.txtchoisirClient.Tag = DgvClients.CurrentRow.Cells(0).Value
            Me.Close()

        End If
    End Sub

    Private Sub txtNomClient_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomClient.TextChanged

        If txtNomClient.TextLength <> 0 And txtPrenomClient.TextLength <> 0 And txtCINClient.TextLength <> 0 Or txtNomClient.TextLength <> 0 And txtPrenomClient.TextLength <> 0 Or txtNomClient.TextLength <> 0 And txtCINClient.TextLength <> 0 Then

            DgvClients.DataSource = (New Client).Rechercher_Par_tout(txtNomClient.Text, txtPrenomClient.Text, txtCINClient.Text)

        End If

        If txtPrenomClient.Text = "" And txtCINClient.Text = "" And txtNomClient.Text = "" Then
            DgvClients.DataSource = (New Client).RetournerListeClient
        End If

        If txtNomClient.Text = "" And txtCINClient.Text <> "" Then

            DgvClients.DataSource = (New Client).Rechercher_Par_CIN(txtCINClient.Text)

        ElseIf txtNomClient.Text = "" And txtPrenomClient.Text <> "" Then

            DgvClients.DataSource = (New Client).Rechercher_Par_Prenom(txtPrenomClient.Text)

        ElseIf txtNomClient.Text <> "" And txtPrenomClient.Text = "" And txtCINClient.Text = "" Then

            DgvClients.DataSource = (New Client).Rechercher_Par_Nom(txtNomClient.Text)

        End If
    End Sub

    Private Sub txtPrenomClient_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrenomClient.TextChanged
        If txtNomClient.TextLength <> 0 And txtPrenomClient.TextLength <> 0 And txtCINClient.TextLength <> 0 Or txtPrenomClient.TextLength <> 0 And txtCINClient.TextLength <> 0 Or txtPrenomClient.TextLength <> 0 And txtNomClient.TextLength <> 0 Then

            DgvClients.DataSource = (New Client).Rechercher_Par_tout(txtNomClient.Text, txtPrenomClient.Text, txtCINClient.Text)

        End If
        If txtPrenomClient.Text = "" And txtCINClient.Text = "" And txtNomClient.Text = "" Then
            DgvClients.DataSource = (New Client).RetournerListeClient
        End If

        If txtPrenomClient.Text = "" And txtCINClient.Text <> "" Then

            DgvClients.DataSource = (New Client).Rechercher_Par_CIN(txtCINClient.Text)

        ElseIf txtPrenomClient.Text = "" And txtNomClient.Text <> "" Then

            DgvClients.DataSource = (New Client).Rechercher_Par_Nom(txtNomClient.Text)

        ElseIf txtPrenomClient.Text <> "" And txtNomClient.Text = "" And txtCINClient.Text = "" Then

            DgvClients.DataSource = (New Client).Rechercher_Par_Prenom(txtPrenomClient.Text)

        End If
    End Sub

    Private Sub txtCINClient_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCINClient.TextChanged

        If txtCINClient.TextLength <> 0 And txtNomClient.TextLength <> 0 And txtPrenomClient.TextLength <> 0 Or txtCINClient.TextLength <> 0 And txtPrenomClient.TextLength <> 0 Or txtCINClient.TextLength <> 0 And txtNomClient.TextLength <> 0 Then

            DgvClients.DataSource = (New Client).Rechercher_Par_tout(txtNomClient.Text, txtPrenomClient.Text, txtCINClient.Text)

        End If

        If txtPrenomClient.Text = "" And txtCINClient.Text = "" And txtNomClient.Text = "" Then

            DgvClients.DataSource = (New Client).RetournerListeClient

        End If

        If txtCINClient.Text = "" And txtNomClient.Text <> "" Then

            DgvClients.DataSource = (New Client).Rechercher_Par_Nom(txtNomClient.Text)

        ElseIf txtCINClient.Text = "" And txtPrenomClient.Text <> "" Then

            DgvClients.DataSource = (New Client).Rechercher_Par_Prenom(txtPrenomClient.Text)

        ElseIf txtCINClient.Text <> "" And txtNomClient.Text = "" And txtPrenomClient.Text = "" Then

            DgvClients.DataSource = (New Client).Rechercher_Par_CIN(txtCINClient.Text)

        End If

    End Sub
End Class