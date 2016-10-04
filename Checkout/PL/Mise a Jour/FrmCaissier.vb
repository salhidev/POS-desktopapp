Public Class FrmCaissier

    Private Sub FrmCaissier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'If lblTitre.Text = "**Modifier un caissier**" Then

        '    CmbCAISSIER_PAYS.SelectedItem = ""
        '    CmbCAISSIER_VILLE.SelectedItem = ""

        'End If

        'Dim o_caissier As New CAISSIER
        'txtCAISSIER_ID.Text = o_caissier.CAISSIER_ID

        'CmbCAISSIER_PAYS.Items.Insert(0, "--Faite votre choix--")
        'CmbCAISSIER_PAYS.SelectedItem = CmbCAISSIER_PAYS.Items(0)

        'CmbCAISSIER_VILLE.Items.Insert(0, "--Faite votre choix--")
        'CmbCAISSIER_VILLE.SelectedItem = CmbCAISSIER_VILLE.Items(0)

        Me.MdiParent = FrmConfiguation
        Me.Dock = DockStyle.Fill


    End Sub

    Private Sub Btn_Quitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Quitter.Click

        Dim o_caissier As New CAISSIER
        FrmListeCaissier.DgvCaissier.DataSource = o_caissier.RetournerListeCaissier

        Me.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim O_Caissier As New CAISSIER

        If lblTitre.Text = "**Ajouter un caissier**" Then

            If VerifierVide(GroupBox3) = False Then
                If EstNumeric(txtCAISSIER_TEL, GroupBox3) = True And EstNumeric(txtCAISSIER_CODEPOSTAL, GroupBox3) = True Then



                    O_Caissier.CAISSIER_DATENAISS = DtpCAISSIER_DATENAISS.Value
                    O_Caissier.CAISSIER_TYPE = TxtCAISSIER_TYPE.Text
                    O_Caissier.CAISSIER_MOTDEPASSE = TxtCAISSIER_MOTDEPASSE.Text
                    O_Caissier.CAISSIER_CIN = TxtCAISSIER_CIN.Text
                    O_Caissier.CAISSIER_VILLE = CmbCAISSIER_VILLE.Text
                    O_Caissier.CAISSIER_PAYS = CmbCAISSIER_PAYS.Text
                    O_Caissier.CAISSIER_ADRESSE = RtbCAISSIER_ADRESSE.Text
                    O_Caissier.CAISSIER_CODEPOSTAL = txtCAISSIER_CODEPOSTAL.Text
                    O_Caissier.CAISSIER_TEL = txtCAISSIER_TEL.Text

                    If RdMCAISSIER_SEX.Checked = True Then
                        O_Caissier.CAISSIER_SEX = RdMCAISSIER_SEX.Tag
                    Else
                        O_Caissier.CAISSIER_SEX = RdFCAISSIER_SEX.Tag
                    End If

                    O_Caissier.CAISSIER_PRENOM = TxtCAISSIER_PRENOM.Text
                    O_Caissier.CAISSIER_NOM = TxtCAISSIER_NOM.Text

                    O_Caissier.Ajouter()

                    MsgBox("**Ce caissier à été ajouté avec succés**", MsgBoxStyle.Information, "Information d'ajout")

                    Me.Close()
                    FrmListeCaissier.DgvCaissier.DataSource = O_Caissier.RetournerListeCaissier

                End If
            End If

        End If

        If lblTitre.Text = "**Modifier un caissier**" Then

            If VerifierVide(GroupBox3) = False Then
                If EstNumeric(txtCAISSIER_TEL, GroupBox3) = True And EstNumeric(txtCAISSIER_CODEPOSTAL, GroupBox3) = True Then

                    O_Caissier.CAISSIER_ID = txtCAISSIER_ID.Text
                    O_Caissier.CAISSIER_DATENAISS = DtpCAISSIER_DATENAISS.Value
                    O_Caissier.CAISSIER_TYPE = TxtCAISSIER_TYPE.Text
                    O_Caissier.CAISSIER_MOTDEPASSE = TxtCAISSIER_MOTDEPASSE.Text
                    O_Caissier.CAISSIER_CIN = TxtCAISSIER_CIN.Text
                    O_Caissier.CAISSIER_VILLE = CmbCAISSIER_VILLE.Text
                    O_Caissier.CAISSIER_PAYS = CmbCAISSIER_PAYS.Text
                    O_Caissier.CAISSIER_ADRESSE = RtbCAISSIER_ADRESSE.Text
                    O_Caissier.CAISSIER_CODEPOSTAL = txtCAISSIER_CODEPOSTAL.Text
                    O_Caissier.CAISSIER_TEL = txtCAISSIER_TEL.Text
                    If RdMCAISSIER_SEX.Checked = True Then
                        O_Caissier.CAISSIER_SEX = RdMCAISSIER_SEX.Tag
                    Else
                        O_Caissier.CAISSIER_SEX = RdFCAISSIER_SEX.Tag
                    End If
                    O_Caissier.CAISSIER_PRENOM = TxtCAISSIER_PRENOM.Text
                    O_Caissier.CAISSIER_NOM = TxtCAISSIER_NOM.Text

                    O_Caissier.Modifier()

                    Me.Close()

                    MsgBox("**Ce caissier à été modifié avec succés**", MsgBoxStyle.Information, "Information de modification")

                    FrmListeCaissier.DgvCaissier.DataSource = O_Caissier.RetournerListeCaissier
                End If
            End If

        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        ViderForm(Me)

    End Sub

End Class