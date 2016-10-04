Public Class FRM_CODE_128_ABOUT
    '
    '/*========================================================================================================================*/
    '
    Private Sub FRM_CODE_128_ABOUT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
        Try
            PBX_ICON.Image = Me.Owner.Icon.ToBitmap()
            LBL_TIT.Text = My.Application.Info.Title
            LBL_VER.Text = String.Format("Version {0}", My.Application.Info.Version)
            LBL_CPY.Text = My.Application.Info.Copyright
            LBL_DSC.Text = My.Application.Info.Description
            LBL_DIR.Text = My.Application.Info.DirectoryPath
            '
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        '
    End Sub
    '
    '/*========================================================================================================================*/
    '
End Class