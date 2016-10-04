Imports System.IO
Public Class FrmFondCaisse

    Private Sub FrmFondCaisse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim stw As New StreamReader("FondCaisse.txt")
        Dim chain As String = stw.ReadLine
        Dim chaines() As String = chain.Split(";")
        TxtFondDeCaisseFD.Text = chaines(0)
        TxtEspeceFD.Text = chaines(1)
        TxtMouvementFD.Text = chaines(2)
        TxtCheQueFD.Text = chaines(3)
        TxtTiquetRestoFD.Text = chaines(4)
        TxtCarteBancaireFD.Text = chaines(5)
        TxtTotalFD.Text = chaines(6)

       

        stw.Close()

    End Sub

    Private Sub BtnValiderCloture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub BtnAnnulerCloture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnnulerCloture.Click

        Me.Close()

    End Sub
End Class