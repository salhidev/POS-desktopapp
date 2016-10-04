Public Class FrmListeCaissier


    Private Sub FrmListeCaissier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DgvCaissier.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Dim o_caissier As New CAISSIER
        DgvCaissier.DataSource = o_caissier.RetournerListeCaissier
        '---------------------------------------------------------
      
        Me.MdiParent = FrmConfiguation
        Me.Dock = DockStyle.Fill

    End Sub

    Private Sub btnEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnregistrer.Click


        FrmCaissier.Show()
        FrmCaissier.lblTitre.Text = "**Ajouter un caissier**"

    End Sub

    Private Sub Btn_Modifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modifier.Click

        If DgvCaissier.SelectedRows.Count = 0 Then
            MsgBox("Vous Devez Séléctionner un caissier a modifier", MsgBoxStyle.Information)
            Exit Sub
        End If

        AfficherDansForm(DgvCaissier, FrmCaissier.GroupBox3)
        FrmCaissier.DtpCAISSIER_DATENAISS.Value = DgvCaissier.CurrentRow.Cells(3).Value

        FrmCaissier.Show()
        FrmCaissier.lblTitre.Text = "**Modifier un caissier**"

    End Sub

    Private Sub Btn_Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Supprimer.Click

        If DgvCaissier.SelectedRows.Count = 0 Then
            MsgBox("Vous Devez Séléctionner un caissier a supprimer !!", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim o_caissier As New CAISSIER
        Conex.Open()

        Try

            Dim msg As Integer = MsgBox(vbInformation & "Si vous supprimer ce caissier ==> vous risquez de perdre tout identification de ce caissier plus que les caisse afféctés à ce dernier et les commandes qui l'a fait :" & vbNewLine & vbNewLine & "     ==> alors si voulez-vous vraiment le supprimer définitivement avec tout ces relations Appuyez sur oui ==>" & vbNewLine & vbNewLine & "  ==> sinon si voulez-vous supprimer seulement ce caissier appuyez sur Non ==>", MsgBoxStyle.YesNoCancel, "** Lisez ce message attentivement avant de supprimer **")



            If msg = vbYes Then

                o_caissier.CAISSIER_ID = DgvCaissier.CurrentRow.Cells(0).Value

                cmd.Connection = Conex

                cmd.CommandText = "exec SP_SupprimerCaissier '" & o_caissier.CAISSIER_ID & "'"

                cmd.ExecuteNonQuery()

                MsgBox("Ce caissier à été supprimé avec succés", MsgBoxStyle.Information)



            ElseIf msg = vbNo Then

                o_caissier.CAISSIER_ID = DgvCaissier.CurrentRow.Cells(0).Value

                cmd.Connection = Conex

                cmd.CommandText = "exec SP_SupCaissierSeul '" & o_caissier.CAISSIER_ID & "'"

                cmd.ExecuteNonQuery()

                MsgBox("Ce caissier à été supprimé seulement avec succés", MsgBoxStyle.Information)

            End If



        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        Conex.Close()

        DgvCaissier.DataSource = o_caissier.RetournerListeCaissier

    End Sub

    Private Sub txtNomCaissier_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomCaissier.TextChanged

        If txtNomCaissier.TextLength <> 0 And txtPrenomCaissier.TextLength <> 0 And txtCINCaissier.TextLength <> 0 Or txtNomCaissier.TextLength <> 0 And txtPrenomCaissier.TextLength <> 0 Or txtNomCaissier.TextLength <> 0 And txtCINCaissier.TextLength <> 0 Then

            DgvCaissier.DataSource = (New CAISSIER).Rechercher_Par_tout(txtNomCaissier.Text, txtPrenomCaissier.Text, txtCINCaissier.Text)

            'DgvCaissier.DataSource = (New CAISSIER).Rechercher_Par_tout(txtNomCaissier.Text, txtPrenomCaissier.Text, txtCINCaissier.Text, DgvCaissier)

        End If

        If txtPrenomCaissier.Text = "" And txtCINCaissier.Text = "" And txtNomCaissier.Text = "" Then
            DgvCaissier.DataSource = (New CAISSIER).RetournerListeCaissier
        End If

        If txtNomCaissier.Text = "" And txtCINCaissier.Text <> "" Then

            DgvCaissier.DataSource = (New CAISSIER).Rechercher_Par_CIN(txtCINCaissier.Text)

        ElseIf txtNomCaissier.Text = "" And txtPrenomCaissier.Text <> "" Then

            DgvCaissier.DataSource = (New CAISSIER).Rechercher_Par_Prenom(txtPrenomCaissier.Text)

        ElseIf txtNomCaissier.Text <> "" And txtPrenomCaissier.Text = "" And txtCINCaissier.Text = "" Then

            DgvCaissier.DataSource = (New CAISSIER).Rechercher_Par_Nom(txtNomCaissier.Text)

        End If

    End Sub

    Private Sub txtPrenomCaissier_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrenomCaissier.TextChanged

        If txtNomCaissier.TextLength <> 0 And txtPrenomCaissier.TextLength <> 0 And txtCINCaissier.TextLength <> 0 Or txtPrenomCaissier.TextLength <> 0 And txtCINCaissier.TextLength <> 0 Or txtPrenomCaissier.TextLength <> 0 And txtNomCaissier.TextLength <> 0 Then

            DgvCaissier.DataSource = (New CAISSIER).Rechercher_Par_tout(txtNomCaissier.Text, txtPrenomCaissier.Text, txtCINCaissier.Text)

        End If
        If txtPrenomCaissier.Text = "" And txtCINCaissier.Text = "" And txtNomCaissier.Text = "" Then
            DgvCaissier.DataSource = (New CAISSIER).RetournerListeCaissier
        End If

        If txtPrenomCaissier.Text = "" And txtCINCaissier.Text <> "" Then

            DgvCaissier.DataSource = (New CAISSIER).Rechercher_Par_CIN(txtCINCaissier.Text)

        ElseIf txtPrenomCaissier.Text = "" And txtNomCaissier.Text <> "" Then

            DgvCaissier.DataSource = (New CAISSIER).Rechercher_Par_Nom(txtNomCaissier.Text)

        ElseIf txtPrenomCaissier.Text <> "" And txtNomCaissier.Text = "" And txtCINCaissier.Text = "" Then

            DgvCaissier.DataSource = (New CAISSIER).Rechercher_Par_Prenom(txtPrenomCaissier.Text)

        End If

    End Sub

    Private Sub txtCINCaissier_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCINCaissier.TextChanged


        'DgvCaissier.DataSource = (New CAISSIER).Rechercher_Par_tout(txtNomCaissier.Text, txtPrenomCaissier.Text, txtCINCaissier.Text, DgvCaissier)

        If txtCINCaissier.TextLength <> 0 And txtNomCaissier.TextLength <> 0 And txtPrenomCaissier.TextLength <> 0 Or txtCINCaissier.TextLength <> 0 And txtPrenomCaissier.TextLength <> 0 Or txtCINCaissier.TextLength <> 0 And txtNomCaissier.TextLength <> 0 Then

            DgvCaissier.DataSource = (New CAISSIER).Rechercher_Par_tout(txtNomCaissier.Text, txtPrenomCaissier.Text, txtCINCaissier.Text)
        End If

        If txtPrenomCaissier.Text = "" And txtCINCaissier.Text = "" And txtNomCaissier.Text = "" Then

            DgvCaissier.DataSource = (New CAISSIER).RetournerListeCaissier

        End If

        If txtCINCaissier.Text = "" And txtNomCaissier.Text <> "" Then

            DgvCaissier.DataSource = (New CAISSIER).Rechercher_Par_Nom(txtNomCaissier.Text)

        ElseIf txtCINCaissier.Text = "" And txtPrenomCaissier.Text <> "" Then

            DgvCaissier.DataSource = (New CAISSIER).Rechercher_Par_Prenom(txtPrenomCaissier.Text)

        ElseIf txtCINCaissier.Text <> "" And txtNomCaissier.Text = "" And txtPrenomCaissier.Text = "" Then

            DgvCaissier.DataSource = (New CAISSIER).Rechercher_Par_CIN(txtCINCaissier.Text)

        End If
        
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If dtpDateCaissier.SelectedText <> 0 Then

        '    DgvCaissier.DataSource = (New CAISSIER).Rechercher_Par_Nom_Et_Prenom_Et_CIN_Et_Date(txtNomCaissier.Text, txtPrenomCaissier.Text, txtCINCaissier.Text)

        'Else
        '    DgvCaissier.DataSource = (New CAISSIER).Rechercher_Par_Prenom(txtPrenomCaissier.Text)

        'End If

    End Sub


    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        FrmRapport_Caissier.ShowDialog()
    End Sub

    Private Sub btnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub
End Class