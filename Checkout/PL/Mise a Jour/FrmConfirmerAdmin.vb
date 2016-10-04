Public Class FrmConfirmerAdmin

    Private Sub btnValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValider.Click

        If txtMotDePasse.Text = "FBA" Or txtMotDePasse.Text = "fba" Then

            TimerProgresse.Start()
            ProgressBar1.Show()
            ' FrmConfiguation.Show()

        Else

            MsgBox(" Mots de passe Incorect Resseyez", MsgBoxStyle.Information)
            txtMotDePasse.ResetText()
            txtMotDePasse.Select()

        End If

    End Sub

    Private Sub TimerProgresse_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerProgresse.Tick

        ProgressBar1.Increment(10)
        If ProgressBar1.Value = ProgressBar1.Maximum Then

            TimerProgresse.Stop()
            FrmConfiguation.ShowDialog()
            Refresh()
            txtMotDePasse.Text = ""

        End If

    End Sub


    Private Sub FrmConfirmerAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtMotDePasse.ResetText()
        txtMotDePasse.Select()

        ProgressBar1.Hide()

    End Sub

    Private Sub txtMotDePasse_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMotDePasse.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then

            btnValider_Click(sender, e)

        End If
    End Sub


    Private Sub btnAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuler.Click

        Me.Close()
        FrmPrincipal.Show()

    End Sub

    Private Sub BtnA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA.Click

        txtMotDePasse.Text = txtMotDePasse.Text & BtnA.Text
        txtMotDePasse.Focus()

    End Sub

    Private Sub BtnB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnB.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnB.Text
        txtMotDePasse.Focus()

    End Sub

    Private Sub BtnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnC.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnC.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnD.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnD.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnE.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnE.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnF.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnF.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnG.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnG.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnH.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnH.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnI.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnI.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJ.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnJ.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnK.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnK.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnL.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnL.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnM.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnM.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnN.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnN.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnO.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnO.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnP.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnP.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQ.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnQ.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnR.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnR.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnS.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnS.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnT.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnT.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnU.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnU.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnV.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnV.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnW.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnW.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnX.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnX.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnY.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnY.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnZ.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnZ.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnZERO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnZERO.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnZERO.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnUN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUN.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnUN.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnDEUX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDEUX.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnDEUX.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnTROIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTROIS.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnTROIS.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnQUATRE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQUATRE.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnQUATRE.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnCINQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCINQ.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnCINQ.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnSIX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSIX.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnSIX.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnSEPT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSEPT.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnSEPT.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnHUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHUIT.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnHUIT.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnNEUF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNEUF.Click
        txtMotDePasse.Text = txtMotDePasse.Text & BtnNEUF.Text
        txtMotDePasse.Focus()
    End Sub

    Private Sub BtnUperToLower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUperToLower.Click

        For Each ctl As Button In GrbLettreMotsDepass.Controls

            Dim tag As String = ctl.Tag
            Dim text As String = ctl.Text

            ctl.Text = tag
            ctl.Tag = text

        Next

    End Sub

    Private Sub BtnVIDER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVIDER.Click

        txtMotDePasse.Text = ""

    End Sub

    Private Sub BtnSpace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSpace.Click
        txtMotDePasse.Text = txtMotDePasse.Text & " "
    End Sub


  
    Private Sub txtMotDePasse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMotDePasse.TextChanged

    End Sub
End Class