Public Class FrmListeCloture

    Private Sub FrmListeCloture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Creer_Data("select * from V_Cloture", DgvCloture)

        DgvCloture.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvCloture.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue
        DgvCloture.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
        DgvCloture.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Orange
        DgvCloture.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black

    End Sub

End Class