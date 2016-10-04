Public Class Etat_imprimer

    Dim Etat As New EtatArticle

    Private Sub Etat_imprimer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetResolution(Me)
        Etat.SetParameterValue("IdArticle", FrmListeArticle.DGVArticle.CurrentRow.Cells(0).Value)
        Etat.SetParameterValue("codeArticle", FrmListeArticle.DGVArticle.CurrentRow.Cells(0).Value, "SR_TEST")
        'MsgBox(FrmListeArticle.DGVArticle.CurrentRow.Cells(0).Value)
        CrystalReportViewer1.ReportSource = Etat

      
    End Sub
    Public Function CreeDataTable(ByVal SQL As String) As DataTable
        Connecter()
        Cmd.Connection = Con
        Cmd.CommandText = SQL
        Da_Article.SelectCommand = cmd
        Da_Article.Fill(ds, "DtSql")
        Deconnecter()
        Return Ds.Tables("DtSql")
    End Function
End Class