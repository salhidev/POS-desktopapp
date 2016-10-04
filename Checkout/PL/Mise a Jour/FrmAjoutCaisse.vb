Public Class FrmAjoutCaisse

    Private Sub FrmAjoutCaisse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim o_caisse As New CAISSE
        'txtCAISSIER_ID.Text = o_caisse.CAISSE_ID

        Me.MdiParent = FrmConfiguation
        Me.Dock = DockStyle.Fill

    End Sub

    Private Sub Valider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim O_caisse As New Caise()

        If lblTitre.Text = "**Ajouter Une Caisse**" Then

            If VerifierVide(GroupBox2) = False Then

                O_caisse.CAISSE_LIB = TxtCAISSE_LIB.Text
                O_caisse.CAISSE_ETAT = TxtCAISSE_ETAT.Text

                O_caisse.Ajouter()
                MsgBox("**Cette caisse à été ajouté avec succés**", MsgBoxStyle.Information, "Information d'ajout")

                FrmListeCaisse.DgvCaisse.DataSource = O_caisse.RetournerListeCaisse
                Me.Close()

            End If

        End If

        If lblTitre.Text = "**Modifier Une Caisse**" Then

            If VerifierVide(GroupBox2) = False Then

                O_caisse.CAISSE_ID = txtCAISSe_ID.Text
                O_caisse.CAISSE_LIB = TxtCAISSE_LIB.Text
                O_caisse.CAISSE_ETAT = TxtCAISSE_ETAT.Text

                O_caisse.Modifier()

                MsgBox("**Cette caisse à été Modifié avec succés**", MsgBoxStyle.Information, "Information de modification")

                FrmListeCaisse.DgvCaisse.DataSource = O_caisse.RetournerListeCaisse
                Me.Close()

            End If

        End If

    End Sub

    Private Sub Vider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ViderForm(Me)
    End Sub

    Private Sub Btn_Quitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Quitter.Click

        Dim o_caisse As New Caise

        FrmListeCaisse.DgvCaisse.DataSource = o_caisse.RetournerListeCaisse
        Me.Close()

    End Sub

End Class