Imports System.IO
Public Class FrmRappelerTicket

    Private Sub cmdFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFermer.Click
        Me.Close()
        FrmCaisse.Show()

    End Sub


    Private Sub BtnValiderTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnValiderTicket.Click
        Try
            Dim sr As New StreamReader("Attente.txt")
            Dim chaine As String
            Dim chaines() As String

            For i As Integer = 0 To LblCompteur.Text - 1

                Dim dr As DataRow = dt.NewRow
                chaine = sr.ReadLine
                chaines = chaine.Split(";")
                dr(0) = chaines(0)
                dr(1) = chaines(1)
                dr(2) = chaines(2)
                dr(3) = chaines(3)
                dr(4) = chaines(4)
                dr(5) = chaines(5)
                dr(6) = chaines(6)
                dt.Rows.Add(dr)
            Next
            MsgBox(" Ticket Rappelé")
            dt4.Rows.Clear()
            sr.Close()
            FrmCaisse.BtnMettreEnAttente.Enabled = True
            If FrmCaisse.DgvCommande.Rows.Count > 1 Then
                FrmCaisse.BtnEncaisser.Enabled = True

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       

    End Sub

    Private Sub FrmRappelerTicket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dt4.Columns.Clear()
        dt4.Rows.Clear()
        DgvRappelDuTicket.DataSource = CreerDatatableRappelerTicket()
        LblCompteur.Visible = False

    End Sub

    Private Sub DgvRappelDuTicket_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvRappelDuTicket.CellContentClick

    End Sub

End Class