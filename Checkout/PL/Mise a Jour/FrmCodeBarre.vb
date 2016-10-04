Public Class FrmCodeBarre

    

    Private Sub BtnAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnnuler.Click

        Try
            Me.Close()
            FrmListeCodeBarre.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnVider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVider.Click
        Try
            ViderForm(Me)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnValider.Click
        Try
            If lblCodeBarre.Text = "Ajouter Un Code Barre :" Then


                Dim O_CodeBarre As New CODE_BARE
                O_CodeBarre.CB_TYPE = txtType.Text
                O_CodeBarre.CB_ACTIVE = Ckb_active.Checked
                O_CodeBarre.Ajouter()

                MsgBox("Ajouter Avec Succes", MsgBoxStyle.Information)
                FrmListeCodeBarre.DgvCodeBarre.DataSource = Nothing
                FrmListeCodeBarre.DgvCodeBarre.DataSource = O_CodeBarre.Actualiser_Liste

            ElseIf lblCodeBarre.Text = "Modifier Un Code Barre" Then


                Dim O_CodeBarre As New CODE_BARE
                O_CodeBarre.CB_TYPE = txtType.Text
                O_CodeBarre.CB_ACTIVE = Ckb_active.Checked
                O_CodeBarre.Modifier()

                MsgBox("Modifier Avec Succes", MsgBoxStyle.Information)
                'FrmListeCodeBarre.DgvCodeBarre.DataSource = ""
                'FrmListeCodeBarre.DgvCodeBarre.DataSource = O_CodeBarre.Actualiser_Liste
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmCodeBarre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim O_CodeBarre As New CODE_BARE
        'Dim listCodeBarre As New List(Of CODE_BARE)
        'listCodeBarre = O_CodeBarre.Actualiser_Liste

        'Cmb_Type.DisplayMember = "CB_id"
        'Cmb_Type.ValueMember = "CB_Type"

        'Cmb_Type.DataSource = listCodeBarre

    End Sub
End Class