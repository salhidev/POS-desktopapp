Public Class Tous_Les_Articles


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Close()
        FrmCaisse.Show()

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click



        Dim o_art As New ARTICLE
        Dim listArt As New List(Of ARTICLE)
        listArt = o_art.Actualiser_Liste

        Dim x As Integer = o_art.Rechercher_Par_Id(sender.Tag)

        For i As Integer = 0 To FrmCaisse.DgvCommande.Rows.Count - 2
            If listArt.Item(x).ART_REF = FrmCaisse.DgvCommande.Rows(i).Cells(0).Value Then

                FrmCaisse.DgvCommande.Rows(i).Cells(4).Value = FrmCaisse.DgvCommande.Rows(i).Cells(4).Value + 1
                FrmCaisse.DgvCommande.Rows(i).Cells(5).Value = FrmCaisse.DgvCommande.Rows(i).Cells(2).Value * FrmCaisse.DgvCommande.Rows(i).Cells(4).Value
                FrmCaisse.LblMontantApayerInfo.Text = RecalculerPrix()

                Exit Sub
            End If
        Next

        Dim dr As DataRow = dt.NewRow
        dr(0) = listArt.Item(x).ART_REF
        dr(1) = listArt.Item(x).ART_DESCRIPTION
        dr(2) = listArt.Item(x).ART_PRIXUHT
        dr(3) = 0
        dr(4) = 1
        dr(5) = dr(2) * dr(4)
        dr(6) = listArt.Item(x).ART_ID
        dt.Rows.Add(dr)
        

        FrmCaisse.LblMontantApayerInfo.Text = RecalculerPrix()

        FrmCaisse.BtnAnnulerTicket.Enabled = True
        FrmCaisse.BtnFondCaisse.Enabled = True
        FrmCaisse.BtnCloturerCaisse.Enabled = True
        FrmCaisse.BtnQuiter.Enabled = True
        FrmCaisse.BtnQteGlobal.Enabled = True
        FrmCaisse.BtnRemiseGlobal.Enabled = True
        FrmCaisse.BtnMettreEnAttente.Enabled = True
        FrmCaisse.BtnEncaisser.Enabled = True
        FrmCaisse.BtnCloturerCaisse.Enabled = True
        FrmCaisse.DgvCommande.Rows(0).Selected = True


    End Sub

    Private Sub Button3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Button2_Click_1(sender, e)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button45.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button48.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button50.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button51.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button52.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button53.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button54.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button55.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button56.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button57.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button58.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button59.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button60.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button61.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button62.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button63.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button64.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button65.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button66.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button67.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button68.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button69.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button70.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button71.Click
        Button2_Click_1(sender, e)
    End Sub

    Private Sub Button30_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        Me.Close()

    End Sub
End Class