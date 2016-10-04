Public Class FrmConfiguation

    Private Sub btnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim x As Integer = MsgBox("Voulez-vous vraiment quitter??", MsgBoxStyle.YesNo, "Merci et au revoir")
        If x = vbYes Then
            Me.Close()
        End If

    End Sub

    Private Sub FrmConfiguation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GetResolution(Me)

        ProgressBar1.Hide()

        'Fermer_Form(Me)

     
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False

    End Sub

    Private Sub btnCaissier_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCaissier.Click

        Timer1.Start()
        ProgressBar1.Show()

        Fermer_Form(Me)
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False

    End Sub

    Private Sub btnCaisse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCaisse.Click

        Timer2.Start()
        ProgressBar1.Show()

        Fermer_Form(Me)
        PictureBox1.Visible = False
        PictureBox2.Visible = True
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False

    End Sub

    Private Sub btnClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClient.Click

        Timer3.Start()
        ProgressBar1.Show()

        Fermer_Form(Me)
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = True
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False

    End Sub

    Private Sub btnVente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVente.Click

        Timer4.Start()
        ProgressBar1.Show()

        Fermer_Form(Me)
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = True
        PictureBox5.Visible = False
        PictureBox6.Visible = False

    End Sub

    Private Sub btnArticle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArticle.Click

        Timer5.Start()
        ProgressBar1.Show()

        Fermer_Form(Me)
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = True
        PictureBox6.Visible = False

    End Sub

    Private Sub btnCodeBare_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCodeBare.Click

        Timer6.Start()
        ProgressBar1.Show()

        Fermer_Form(Me)
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = True

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(6)

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            ProgressBar1.Hide()

            FrmListeCaissier.Show()



        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        ProgressBar1.Increment(6)

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer2.Stop()
            ProgressBar1.Hide()

            FrmListeCaisse.Show()


        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        ProgressBar1.Increment(6)

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer3.Stop()
            ProgressBar1.Hide()

            FrmListeClients.Show()

        End If

    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        ProgressBar1.Increment(6)

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer4.Stop()
            ProgressBar1.Hide()

            FrmListeVente.Show()


        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        ProgressBar1.Increment(6)

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer5.Stop()
            ProgressBar1.Hide()

            FrmListeArticle.Show()


        End If
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        ProgressBar1.Increment(6)

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer6.Stop()
            ProgressBar1.Hide()
            Fermer_Form(Me)

            FrmListeCodeBarre.Show()

        End If
    End Sub

    Private Sub cmdFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class