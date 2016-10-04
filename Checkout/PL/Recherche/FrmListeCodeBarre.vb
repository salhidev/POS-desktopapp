Public Class FrmListeCodeBarre

    Private Sub btnValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            FrmArticle.txtCodeBarre.Text = DgvCodeBarre.CurrentRow.Cells(1).Value
            FrmArticle.txtCodeBarre.Tag = DgvCodeBarre.CurrentRow.Cells(0).Value

            Me.Hide()
            FrmArticle.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FrmCodeBarre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.MdiParent = FrmConfiguation
            Me.Dock = DockStyle.Fill

            'Pour  Remplire datagrid apartir d'une dataset
            '-------------------------------------------------------------
            'Da_Code_Bare.Fill(ds.CODE_BARE)
            'DgvCodeBarre.DataSource = ds.CODE_BARE
            'MdiParent = FrmConfiguation
            'Me.Dock = DockStyle.Fill
            '-------------------------------------------------------------


            'Pour Remplire datagrid apartir d'une Collection
            '-------------------------------------------------------------
            Dim O_CodeBarre As New CODE_BARE
            'Dim listCodeBarre As New List(Of CODE_BARE)
            'listCodeBarre = O_CodeBarre.Actualiser_Liste
            'DgvCodeBarre.DataSource = Nothing
            DgvCodeBarre.DataSource = O_CodeBarre.Actualiser_Liste
            '-------------------------------------------------------------
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub



    Private Sub DgvCodeBarre_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvCodeBarre.DoubleClick
        Try
            FrmArticle.txtCodeBarre.Text = DgvCodeBarre.CurrentRow.Cells(1).Value
            FrmArticle.txtCodeBarre.Tag = DgvCodeBarre.CurrentRow.Cells(0).Value
            FrmArticle.DgvTarifOfArticle.DataSource = Creerdatabletarif_of_article()
            Me.Hide()
            FrmArticle.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub BtnNvCB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        FrmCodeBarre.Show()
    '        Me.Hide()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub DgvCodeBarre_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCodeBarre.CellContentClick

    End Sub

    Private Sub Btn_Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            If DgvCodeBarre.SelectedRows.Count = 0 Then
                MsgBox("Vous Devez Selectionnez le Code Barre a Supprimer !!", MsgBoxStyle.Information)
                Exit Sub
            End If


            If MsgBox("Etes-Vous Sur De  Vouloir Supprimer Ce  Code Barre", MsgBoxStyle.YesNo, "Suppression") = MsgBoxResult.Yes Then

                Dim O_CodeBarre As New CODE_BARE
                O_CodeBarre.CB_ID = DgvCodeBarre.CurrentRow.Cells(0).Value

                O_CodeBarre.Supprimer()
                MsgBox("Supprimer Avec Succes", MsgBoxStyle.Information)
                'DgvCodeBarre.DataSource = ""
                'DgvCodeBarre.DataSource = O_CodeBarre.Actualiser_Liste

            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub Btn_Modifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modifier.Click
    '    Try
    '        If DgvCodeBarre.SelectedRows.Count = 0 Then
    '            MsgBox("Vous Devez Selectionnez le Code Barre a Modifier !!", MsgBoxStyle.Information)
    '            Exit Sub
    '        End If

    '        FrmCodeBarre.lblCodeBarre.Text = "Modifier Un Code Barre"


    '        Dim O_CodeBarre As New CODE_BARE
    '        Dim listCodeBarre As New List(Of CODE_BARE)
    '        listCodeBarre = O_CodeBarre.Actualiser_Liste


    '        For i As Integer = 0 To listCodeBarre.Count - 1

    '            If DgvCodeBarre.CurrentRow.Cells(0).Value = listCodeBarre.Item(i).CB_ID Then

    '                FrmCodeBarre.txtType.Text = listCodeBarre.Item(i).CB_TYPE

    '                FrmCodeBarre.Ckb_active.Checked = listCodeBarre.Item(i).CB_ACTIVE
    '                Exit For

    '            End If

    '        Next

    '        FrmCodeBarre.Tag = DgvCodeBarre.CurrentRow.Cells(0).Value
    '        FrmCodeBarre.ShowDialog()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub btnEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnregistrer.Click
    '    Try
    '        FrmCodeBarre.lblCodeBarre.Text = "Ajouter Un Code Barre :"
    '        ViderForm(FrmCodeBarre)
    '        FrmCodeBarre.txtType.Select()
    '        FrmCodeBarre.ShowDialog()

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    

    Private Sub txtTypeCB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTypeCB.TextChanged
        Try
            Dim O_CodeBarre As New CODE_BARE

            'If txtTypeCB.Text = Nothing Then
            '    DgvCodeBarre.DataSource = ""
            '    DgvCodeBarre.DataSource = O_CodeBarre.Actualiser_Liste
            'End If
            ''Else
            ''    DgvCodeBarre.DataSource = Nothing
            DgvCodeBarre.DataSource = O_CodeBarre.Rechercher_Par_type(txtTypeCB.Text)
            ''End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnafficher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnafficher.Click

        Frm_Générer_CB.ShowDialog()

    End Sub
End Class