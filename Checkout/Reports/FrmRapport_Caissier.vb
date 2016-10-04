Public Class FrmRapport_Caissier

    Private Sub FrmRapport_Caissier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim etat As New Rpt_Imprimer_Caissier

        etat.SetParameterValue("@CAISSIER_ID", FrmListeCaissier.DgvCaissier.CurrentRow.Cells(0).Value)

        etat.SetParameterValue("@CAISSIER_ID", FrmListeCaissier.DgvCaissier.CurrentRow.Cells(0).Value, "SR_OCCUPATION_CAISSIER")
        etat.SetParameterValue("@CAISSIER_ID", FrmListeCaissier.DgvCaissier.CurrentRow.Cells(0).Value, "SR_FACTURE_CAISSIER")
        etat.SetParameterValue("@CAISSIER_ID", FrmListeCaissier.DgvCaissier.CurrentRow.Cells(0).Value, "SR_TICKET_CAISSIER")
        CrystalReportViewer1.ReportSource = etat

    End Sub
End Class