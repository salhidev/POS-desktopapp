Imports System.IO

Public Class FrmThemes

    Private Sub RdbDefault_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbDefault.CheckedChanged

        If RdbDefault.Checked = True Then

            Dim rep As String = MsgBox(" Pour Appliquer ce theme vous devez redemmarer Le Programme Voulez Vous Continuez ?? ", MsgBoxStyle.YesNo)

            If rep = MsgBoxResult.Yes Then

                Application.Restart()

            End If

        End If
    End Sub

    Private Sub BtnAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnnuler.Click

        Me.Close()

    End Sub


    Private Sub rdbCalmness_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCalmness.CheckedChanged

        If rdbCalmness.Checked = True Then

            Dim chemin As String = Application.StartupPath & "\Calmness.ssk"
            EcranDemarrage.SkinEngine1.SkinFile = chemin

        End If

    End Sub

    Private Sub Calmnesse2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calmnesse2.CheckedChanged
        If Calmnesse2.Checked = True Then
            Dim chemin As String = Application.StartupPath & "\CalmnessColor2.ssk"
            EcranDemarrage.SkinEngine1.SkinFile = chemin
        End If
    End Sub


    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked = True Then

            Dim chemin As String = Application.StartupPath & "\DeepCyan.ssk"
            EcranDemarrage.SkinEngine1.SkinFile = chemin

        End If

    End Sub


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        If RadioButton1.Checked = True Then

            Dim chemin As String = Application.StartupPath & "\DeepGreen.ssk"
            EcranDemarrage.SkinEngine1.SkinFile = chemin

        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged

        If RadioButton3.Checked = True Then

            Dim chemin As String = Application.StartupPath & "\DeepOrange.ssk"
            EcranDemarrage.SkinEngine1.SkinFile = chemin

        End If

    End Sub


    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged

        If RadioButton8.Checked = True Then

            Dim chemin As String = Directory.GetCurrentDirectory & "\DiamondBlue.ssk"
            EcranDemarrage.SkinEngine1.SkinFile = chemin

        End If

    End Sub


    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged

        If RadioButton9.Checked = True Then

            Dim chemin As String = Directory.GetCurrentDirectory & "\DiamondPurple.ssk"
            EcranDemarrage.SkinEngine1.SkinFile = chemin

        End If

    End Sub



    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then

            Dim chemin As String = Application.StartupPath & "\DiamondRed.ssk"
            EcranDemarrage.SkinEngine1.SkinFile = chemin

        End If
    End Sub



    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then

            Dim chemin As String = Application.StartupPath & "\Eighteen.ssk"
            EcranDemarrage.SkinEngine1.SkinFile = chemin

        End If
    End Sub


    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then

            Dim chemin As String = Application.StartupPath & "\Emerald.ssk"
            EcranDemarrage.SkinEngine1.SkinFile = chemin

        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then

            Dim chemin As String = Application.StartupPath & "\GlassBrown.ssk"
            EcranDemarrage.SkinEngine1.SkinFile = chemin

        End If
    End Sub



    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged

        If RadioButton10.Checked = True Then

            Dim chemin As String = Application.StartupPath & "\GlassOrange.ssk"
            EcranDemarrage.SkinEngine1.SkinFile = chemin

        End If

    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged

        If RadioButton11.Checked = True Then

            Dim chemin As String = Application.StartupPath & "\Longhorn.ssk"
            EcranDemarrage.SkinEngine1.SkinFile = chemin

        End If

    End Sub


    Private Sub RadioButton14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton14.CheckedChanged

        If RadioButton14.Checked = True Then

            Dim chemin As String = Application.StartupPath & "\MacOS.ssk"
            EcranDemarrage.SkinEngine1.SkinFile = chemin

        End If

    End Sub

    Private Sub RadioButton15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton15.CheckedChanged
        If RadioButton15.Checked = True Then

            Dim chemin As String = Application.StartupPath & "\Midsummer.ssk"
            EcranDemarrage.SkinEngine1.SkinFile = chemin

        End If

    End Sub

    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then

            Dim chemin As String = Application.StartupPath & "\Silver.ssk"
            EcranDemarrage.SkinEngine1.SkinFile = chemin

        End If
    End Sub

    Private Sub RadioButton13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked = True Then

            Dim chemin As String = Application.StartupPath & "\vista.ssk"
            EcranDemarrage.SkinEngine1.SkinFile = chemin

        End If
    End Sub


    Private Sub RadioButton16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton16.CheckedChanged
        If RadioButton16.Checked = True Then

            Dim chemin As String = Application.StartupPath & "\Warm.ssk"
            EcranDemarrage.SkinEngine1.SkinFile = chemin

        End If
    End Sub

    Private Sub RadioButton17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton17.CheckedChanged
        If RadioButton17.Checked = True Then

            Dim chemin As String = Application.StartupPath & "\Wave.ssk"
            EcranDemarrage.SkinEngine1.SkinFile = chemin

        End If
    End Sub

End Class