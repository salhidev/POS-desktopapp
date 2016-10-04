Public Class FrmAjoutClient

    Private Sub FrmAjoutClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MdiParent = FrmConfiguation
        Me.Dock = DockStyle.Fill

        da_Client.Fill(ds, "client")

        Dim o_client As New Client
        Dim list_client As New List(Of Client)

        list_client = o_client.RetournerListeClient

        For i As Integer = 0 To list_client.Count - 1

            If FrmListeClients.DgvClients.CurrentRow.Cells(0).Value = list_client.Item(i).CLT_MAT Then

                Me.TxtCLT_NOM.Text = list_client.Item(i).CLT_NOM
                Me.TxtCLT_PRENOM.Text = list_client.Item(i).CLT_PRENOM
                Me.TxtCLT_REF.Text = list_client.Item(i).CLT_REF
                Me.CmbCLT_PAYS.SelectedItem = list_client.Item(i).CLT_PAYS
                Me.CmbCLT_VILLE.SelectedItem = list_client.Item(i).CLT_VILLE
                Me.TxtCLT_CP.Text = list_client.Item(i).CLT_CP
                Me.RTBCLT_ADRESSE.Text = list_client.Item(i).CLT_ADRESSE
                Me.TxtCLT_FAX.Text = list_client.Item(i).CLT_FAX
                Me.TxtCLT_TELPRO.Text = list_client.Item(i).CLT_TELPRO
                Me.TxtCLT_TYPE.Text = list_client.Item(i).CLT_TYPE
                Me.TxtCLT_TEL2.Text = list_client.Item(i).CLT_TEL2
                Me.TxtCLT_ETAT.Text = list_client.Item(i).CLT_ETAT
                Me.TxtCLT_CIN.Text = list_client.Item(i).CLT_CIN
                Me.TxtCLT_EMAIL.Text = list_client.Item(i).CLT_EMAIL
                Me.TxtCLT_SITEWEB.Text = list_client.Item(i).CLT_SITEWEB
                Me.dtpDateNaissance.Text = list_client.Item(i).CLT_DATENAISSE
                Me.DtpCLT_DTIM.Text = list_client.Item(i).CLT_DTIM

                If list_client.Item(i).CLT_SEX = "M" Then
                    Me.RdbCLT_SEX.Checked = True
                Else
                    Me.RbbCLT_SEX.Checked = True
                End If

                Exit For

            End If

        Next

    End Sub

    Private Sub Valider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValider.Click

        Dim o_client As New Client

        If lbltitre.Text = "**Ajouter un client**" Then

            If VerifierVide(GroupBox3) = False Then

                If EstNumeric(TxtCLT_TEL2, GroupBox3) = True And EstNumeric(TxtCLT_TELPRO, GroupBox3) = True And EstNumeric(TxtCLT_CP, GroupBox3) = True And EstNumeric(TxtCLT_FAX, GroupBox3) = True Then

                    o_client.CLT_NOM = TxtCLT_NOM.Text
                    o_client.CLT_PRENOM = TxtCLT_PRENOM.Text
                    o_client.CLT_REF = TxtCLT_REF.Text
                    o_client.CLT_VILLE = CmbCLT_VILLE.Text
                    o_client.CLT_CP = TxtCLT_CP.Text
                    o_client.CLT_ADRESSE = RTBCLT_ADRESSE.Text
                    o_client.CLT_EMAIL = TxtCLT_EMAIL.Text
                    o_client.CLT_FAX = TxtCLT_FAX.Text
                    o_client.CLT_TELPRO = TxtCLT_TELPRO.Text
                    o_client.CLT_PAYS = CmbCLT_PAYS.Text
                    o_client.CLT_TEL2 = TxtCLT_TEL2.Text

                    If RbbCLT_SEX.Checked = True Then
                        o_client.CLT_SEX = RbbCLT_SEX.Tag
                    Else
                        o_client.CLT_SEX = RdbCLT_SEX.Tag
                    End If

                    o_client.CLT_CIN = TxtCLT_CIN.Text
                    o_client.CLT_SITEWEB = TxtCLT_SITEWEB.Text
                    o_client.CLT_ETAT = TxtCLT_ETAT.Text
                    o_client.CLT_TYPE = TxtCLT_TYPE.Text
                    o_client.CLT_DATENAISSE = dtpDateNaissance.Text
                    o_client.CLT_DTIM = DtpCLT_DTIM.Text

                    o_client.Ajouter()

                    MsgBox("**Ce client à été ajouté avec succés**", MsgBoxStyle.Information, "Information d'ajout")

                    FrmListeCaissier.DgvCaissier.DataSource = o_client.RetournerListeClient
                    Me.Close()

                End If
            End If

        End If

        If lbltitre.Text = "**Modifier un client**" Then

            If VerifierVide(GroupBox3) = False Then
                If EstNumeric(TxtCLT_TEL2, GroupBox3) = True And EstNumeric(TxtCLT_TELPRO, GroupBox3) = True And EstNumeric(TxtCLT_CP, GroupBox3) = True And EstNumeric(TxtCLT_FAX, GroupBox3) = True Then

                    o_client.CLT_MAT = TxtCLT_MAT.Text
                    o_client.CLT_NOM = TxtCLT_NOM.Text
                    o_client.CLT_PRENOM = TxtCLT_PRENOM.Text
                    o_client.CLT_REF = TxtCLT_REF.Text
                    o_client.CLT_VILLE = CmbCLT_VILLE.Text
                    o_client.CLT_CP = TxtCLT_CP.Text
                    o_client.CLT_ADRESSE = RTBCLT_ADRESSE.Text
                    o_client.CLT_EMAIL = TxtCLT_EMAIL.Text
                    o_client.CLT_FAX = TxtCLT_FAX.Text
                    o_client.CLT_TELPRO = TxtCLT_TELPRO.Text
                    o_client.CLT_PAYS = CmbCLT_PAYS.Text
                    o_client.CLT_TEL2 = TxtCLT_TEL2.Text

                    If RbbCLT_SEX.Checked = True Then
                        o_client.CLT_SEX = RbbCLT_SEX.Tag
                    Else
                        o_client.CLT_SEX = RdbCLT_SEX.Tag
                    End If

                    o_client.CLT_CIN = TxtCLT_CIN.Text
                    o_client.CLT_SITEWEB = TxtCLT_SITEWEB.Text
                    o_client.CLT_ETAT = TxtCLT_ETAT.Text
                    o_client.CLT_TYPE = TxtCLT_TYPE.Text
                    'o_clientCLT_DATENAISSE = DtpDateNaisseC.Text
                    o_client.CLT_DTIM = DtpCLT_DTIM.Text

                    o_client.Ajouter()

                    MsgBox("**Ce caissier à été modifié avec succés**", MsgBoxStyle.Information, " ** Information de modification **")

                    FrmListeCaissier.DgvCaissier.DataSource = o_client.RetournerListeClient

                End If
            End If

        End If

    End Sub
End Class