Public Class FrmVisualiseCloture

    Private Sub rdbClotjourn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbClotjourn.CheckedChanged
        If rdbClotjourn.Checked = True Then
            rdbresumclot.Checked = False
            GroupBox3.Enabled = False
            GroupBox4.Enabled = True
        End If
    End Sub

    Private Sub rdbresumclot_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbresumclot.CheckedChanged
        If rdbresumclot.Checked = True Then
            rdbClotjourn.Checked = False
            GroupBox4.Enabled = False
            GroupBox3.Enabled = True
        End If
    End Sub

    Private Sub FrmVisualiseCloture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdbClotjourn.Checked = True
        GroupBox4.Enabled = True
    End Sub

    Private Sub cmdFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFermer.Click

        Me.Close()
        FrmPrincipal.Show()

    End Sub
End Class