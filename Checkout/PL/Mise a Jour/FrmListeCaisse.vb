Public Class FrmListeCaisse

    Private Sub FrmLstCaisse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.MdiParent = FrmConfiguation
            Me.Dock = DockStyle.Fill
            Me.StartPosition = FormStartPosition.CenterParent

            creer_data("select * from V_Caisse", DgvCaisse)

            DgvCaisse.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DgvCaisse.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue
            DgvCaisse.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
            DgvCaisse.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Orange
            DgvCaisse.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black

            Dim list_caisseEtat As New List(Of Caise)
            list_caisseEtat = (New Caise).RetournerListeCaisse(True)
            '-------------------------------------------------

            CmbRechCaisseParEtat.Items.Clear()

            CmbRechCaisseParEtat.Sorted = True
            CmbRechCaisseParEtat.DataSource = list_caisseEtat
            CmbRechCaisseParEtat.DisplayMember = "CAISSE_ETAT"
            CmbRechCaisseParEtat.ValueMember = "CAISSE_ID"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnregistrer.Click

        FrmAjoutCaisse.Show()
        FrmAjoutCaisse.lblTitre.Text = "**Ajouter Une Caisse**"
    End Sub

    Private Sub Btn_Modifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modifier.Click
        If DgvCaisse.SelectedRows.Count = 0 Then
            MsgBox("Vous Devez Selectionnez une caisse a modifier !!", MsgBoxStyle.Information)
            Exit Sub
        End If

        AfficherDansForm(DgvCaisse, FrmAjoutCaisse.GroupBox2)
        FrmAjoutCaisse.Show()
        FrmAjoutCaisse.lblTitre.Text = "**Modifier Une Caisse**"
    End Sub

    Private Sub Btn_Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Supprimer.Click
        If DgvCaisse.SelectedRows.Count = 0 Then
            MsgBox("Vous Devez Selectionnez une caisse a supprimer !!", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim o_caisse As New Caise

        Conex.Open()

        Try
            Dim msg As MsgBoxStyle = MsgBox("  Si vous supprimer cette caisse ==> vous risquez de perdre tout identification de cette caisse plus que les caissier afféctés à ce dernier et les clôtures tracés :" & vbNewLine & vbNewLine & "     ==> alors si voulez-vous vraiment le supprimer définitivement avec tout ces relations Appuyez sur oui ==>" & vbNewLine & vbNewLine & "  ==> sinon si voulez-vous supprimer seulement cette caisse appuyez sur Non ==>", MsgBoxStyle.YesNoCancel, "**Lisez ce message attentivement avant de supprimer**")

            If msg = vbYes Then


                o_caisse.CAISSE_ID = DgvCaisse.CurrentRow.Cells(0).Value

                cmd.Connection = Conex

                cmd.CommandText = "exec SP_SupprimerCaisse '" & o_caisse.CAISSE_ID & "'"

                cmd.ExecuteNonQuery()

                MsgBox("Cette caisse à été supprimé avec succés", MsgBoxStyle.Information)



            ElseIf msg = vbNo Then

                o_caisse.CAISSE_ID = DgvCaisse.CurrentRow.Cells(0).Value

                cmd.Connection = Conex
                cmd.CommandText = "exec SP_SuppCaisseSeul '" & o_caisse.CAISSE_ID & "'"

                cmd.ExecuteNonQuery()

                MsgBox("Cette caisse à été supprimé seulement avec succés", MsgBoxStyle.Information)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        Conex.Close()

        DgvCaisse.DataSource = o_caisse.RetournerListeCaisse
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmRapport_Caisse.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class