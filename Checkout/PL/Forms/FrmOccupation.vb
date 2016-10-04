Public Class FrmOccupation

    Private Sub btnNvCaisse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmAjoutCaisse.ShowDialog()
    End Sub

    Private Sub btnNvCaissier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmCaissier.ShowDialog()
    End Sub



    Private Sub btValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        FrmCaisse.Show()

    End Sub

    Private Sub lblAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        FrmConfiguation.Show()

    End Sub

    Private Sub btValider_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btValider.Click
        Try
            Dim o_caissier As New CAISSIER
            Dim lst_caissier As New List(Of CAISSIER)

            lst_caissier = o_caissier.RetournerListeCaissier

            Dim indice As Integer

            For i As Integer = 0 To lst_caissier.Count - 1

                If lst_caissier.Item(i).CAISSIER_ID = cmbCaissier.SelectedValue Then

                    indice = i

                End If
            Next

            If txtPassword.Text <> lst_caissier.Item(indice).CAISSIER_MOTDEPASSE Then

                MsgBox("Mot de pass incorrect!!!", MsgBoxStyle.Critical)
                txtPassword.Focus()
                txtPassword.SelectAll()
                Exit Sub

            End If

            Dim O_Occupation As New OCCUPATION

            O_Occupation.O_Caisse.CAISSE_ID = cmbCaisse.SelectedValue
            O_Occupation.O_Caissier.CAISSIER_ID = cmbCaissier.SelectedValue

            O_Occupation.OCP_DATED = Date.Now
            O_Occupation.OCP_DATEF = Date.Now

            FrmCaisse.LblNomCaissierInfo.Text = cmbCaissier.Text
            FrmCaisse.LblNomCaissierInfo.Tag = O_Occupation.O_Caissier.CAISSIER_ID

            FrmCaisse.LblCaisseInfo.Text = cmbCaisse.Text
            FrmCaisse.LblCaisseInfo.Tag = O_Occupation.O_Caisse.CAISSE_ID

            Dim datedebut As Date = O_Occupation.OCP_DATED
            FrmCaisse.DtpDateDebutCaissier.Value = datedebut

            O_Occupation.Ajouter()

            Dim Id_Occupation As Integer = O_Occupation.OCP_ID
            FrmCaisse.LblOccupation.Text = Id_Occupation

            Me.Hide()
            Me.Close()
            FrmCaisse.Show()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub FrmOccupation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbCaissier.Items.Clear()
        Dim o_Caissier As New CAISSIER
        Dim list_Caissier As New List(Of CAISSIER)

        list_Caissier = o_Caissier.RetournerListeCaissier

        cmbCaissier.DataSource = list_Caissier
        cmbCaissier.DisplayMember = "CAISSIER_NOM"
        cmbCaissier.ValueMember = "CAISSIER_ID"

        'MsgBox(cmbCaissier.ValueMember & cmbCaisse.ValueMember)

        cmbCaisse.Items.Clear()
        Dim o_Caisse As New Caise
        Dim list_Caisse As New List(Of Caise)

        list_Caisse = o_Caisse.RetournerListeCaisse

        cmbCaisse.DataSource = list_Caisse
        cmbCaisse.DisplayMember = "CAISSE_LIB"
        cmbCaisse.ValueMember = "CAISSE_ID"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmAjoutCaisse.ShowDialog()
    End Sub

    Private Sub btnNvCaissier_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNvCaissier.Click
        FrmCaissier.ShowDialog()
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress

        Dim o_caissier As New CAISSIER
        Dim lst_caissier As New List(Of CAISSIER)

        lst_caissier = o_caissier.RetournerListeCaissier

        Dim indice As Integer

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then

            For i As Integer = 0 To lst_caissier.Count - 1

                If lst_caissier.Item(i).CAISSIER_ID = cmbCaissier.SelectedValue Then

                    indice = i

                End If
            Next

            If txtPassword.Text <> lst_caissier.Item(indice).CAISSIER_MOTDEPASSE Then

                MsgBox("Mot de pass incorrect!!!", MsgBoxStyle.Critical)
                txtPassword.Focus()
                txtPassword.SelectAll()
                Exit Sub

            End If

            Dim O_Occupation As New OCCUPATION

            O_Occupation.O_Caisse.CAISSE_ID = cmbCaisse.SelectedValue
            O_Occupation.O_Caissier.CAISSIER_ID = cmbCaissier.SelectedValue

            O_Occupation.OCP_DATED = Date.Now
            O_Occupation.OCP_DATEF = Date.Now

            FrmCaisse.LblNomCaissierInfo.Text = cmbCaissier.Text
            FrmCaisse.LblNomCaissierInfo.Tag = O_Occupation.O_Caissier.CAISSIER_ID

            FrmCaisse.LblCaisseInfo.Text = cmbCaisse.Text
            FrmCaisse.LblCaisseInfo.Tag = O_Occupation.O_Caisse.CAISSE_ID

            Dim datedebut As Date = O_Occupation.OCP_DATED
            FrmCaisse.DtpDateDebutCaissier.Value = datedebut

            O_Occupation.Ajouter()

            Dim Id_Occupation As Integer = O_Occupation.OCP_ID
            FrmCaisse.LblOccupation.Text = Id_Occupation

            Me.Hide()
            FrmCaisse.Show()

        End If

    End Sub

   
    Private Sub lblAnnuler_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAnnuler.Click
        Me.Close()

    End Sub
End Class