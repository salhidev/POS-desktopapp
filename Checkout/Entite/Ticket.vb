Imports System.Data.SqlClient
Imports System.Data

Public Class Ticket

#Region " Attributs..."

    Private Shared Tickets As New List(Of Ticket)

    Private _TIK_ID As Integer
    Private _TIK_DATECREATION As Date
    Private _TIK_TYPE As String
    Private _TIK_MONTANTRECU As Double

    Private _PayementOfTicket As List(Of Payement)
    Private _CommandeOfTicket As Commande

#End Region

#Region " Property..."

    Public Property TIK_ID() As Integer
        Get
            Return _TIK_ID
        End Get
        Set(ByVal value As Integer)
            _TIK_ID = value
        End Set
    End Property

    Public Property TIK_DATECREATION() As Date
        Get
            Return _TIK_DATECREATION
        End Get
        Set(ByVal value As Date)
            _TIK_DATECREATION = value
        End Set
    End Property

    Public Property TIK_TYPE() As String
        Get
            Return _TIK_TYPE
        End Get
        Set(ByVal value As String)
            _TIK_TYPE = value
        End Set
    End Property

    Public Property TIK_MONTANTRECU() As Double
        Get
            Return _TIK_MONTANTRECU
        End Get
        Set(ByVal value As Double)
            _TIK_MONTANTRECU = value
        End Set
    End Property

    Public Property CommandeOfTicket() As Commande
        Get
            Return _CommandeOfTicket
        End Get
        Set(ByVal value As Commande)
            _CommandeOfTicket = value
        End Set
    End Property

    Public Property PayementOfTicket() As List(Of Payement)

        Get
            Return _PayementOfTicket
        End Get

        Set(ByVal value As List(Of Payement))
            _PayementOfTicket = value
        End Set

    End Property


#End Region

#Region "Constructeur..."

    Public Sub New(ByVal p_id As Integer, ByVal p_Datee As Date, ByVal p_Type As String, ByVal p_Montant As Double)

        Me.TIK_ID = p_id
        Me.TIK_DATECREATION = p_Datee
        Me.TIK_TYPE = p_Type
        Me.TIK_MONTANTRECU = p_Montant
        CommandeOfTicket = New Commande
        PayementOfTicket = New List(Of Payement)

    End Sub

    Public Sub New()

        CommandeOfTicket = New Commande
        PayementOfTicket = New List(Of Payement)

    End Sub

#End Region

#Region "  BAL..."

    Public Sub Ajouter()
        Actualiser()
        Me.TIK_ID = Generer_ID(ds.TICKET, "TIK_ID")
        Tickets.Add(Me)
        Me.Ajouter_DAL()
        Enregistrer(Da_Ticket, ds.TICKET)
    End Sub

    Public Sub Modifier()

        Actualiser()
        Tickets(RechercherPosTicket(TIK_ID)) = Me
        Me.Modifier_DAL()
        Enregistrer(Da_Ticket, ds.TICKET)

    End Sub

    Public Sub Supprimer()
        Actualiser()
        Tickets.RemoveAt(RechercherPosTicket(TIK_ID))
        Me.Supprimer_Dal()
        Enregistrer(Da_Ticket, ds.TICKET)
    End Sub

#End Region

#Region "   DAL... "


    Public Sub Ajouter_DAL()

        Dim dr As DataRow = ds.TICKET.NewRow
        dr(0) = Me.TIK_ID
        dr(1) = Me.CommandeOfTicket.CMD_ID
        dr(2) = Me.TIK_DATECREATION
        dr(3) = Me.TIK_TYPE
        dr(4) = Me.TIK_MONTANTRECU
        ds.TICKET.Rows.Add(dr)

    End Sub

    Public Sub Modifier_DAL()

        Dim dr As DataRow = ds.TICKET.Select("TIK_ID=" & Me.TIK_ID)(0)
        dr(1) = Me.CommandeOfTicket.CMD_ID
        dr(2) = Me.TIK_DATECREATION
        dr(3) = Me.TIK_TYPE
        dr(4) = Me.TIK_MONTANTRECU
        ds.TICKET.Rows.Add(dr)

    End Sub

    Public Sub Supprimer_Dal()

        Dim dr As DataRow = ds.TICKET.Select("TIK_ID=" & Me.TIK_ID)(0)
        dr.Delete()

    End Sub

#End Region

#Region " Function "

    Private Function RechercherPosTicket(ByVal p_ID As Integer) As Integer

        For i As Integer = 0 To Tickets.Count - 1
            If Tickets(i).TIK_ID = p_ID Then
                Return i
            End If
        Next
        Return -1

    End Function

    Sub AjouterPayementOfTicket(ByVal IdPayement As Integer, ByVal IdTicket As Integer)

        Dim dr As DataRow
        dr = ds.PAYEMENT_OF_TICKET.NewRow
        dr(0) = IdTicket
        dr(1) = IdPayement
        ds.PAYEMENT_OF_TICKET.Rows.Add(dr)
        Enregistrer(Da_Payement_Of_Ticket, ds.PAYEMENT_OF_TICKET)

    End Sub

    Public Function RetournerListeTICKET() As List(Of Ticket)

        Actualiser_DataTable(Da_Ticket, "SELECT * FROM TICKET", ds.TICKET)

        Tickets.Clear()

        If ds.TICKET.Rows.Count = 0 Then

            Return Nothing

        End If

        For i As Integer = 0 To ds.TICKET.Rows.Count - 1

            Dim o_ticket As New Ticket

            o_ticket.TIK_ID = ds.TICKET.Item(i).TIK_ID
            o_ticket.CommandeOfTicket.CMD_ID = ds.TICKET.Item(i).CMD_ID
            o_ticket.TIK_DATECREATION = ds.TICKET.Item(i).TIK_DATECREATION
            o_ticket.TIK_TYPE = ds.TICKET.Item(i).TIK_TYPE
            o_ticket.TIK_MONTANTRECU = ds.TICKET.Item(i).TIK_MONTANTRECU
            Tickets.Add(o_ticket)

        Next

        Return Tickets

    End Function

    Public Sub actualiser_TICKET()

        Actualiser_DataTable(Da_Ticket, "SELECT * FROM TICKET", ds.TICKET)

        Tickets.Clear()

        If ds.TICKET.Rows.Count = 0 Then

            Exit Sub

        End If

        For i As Integer = 0 To ds.TICKET.Rows.Count - 1

            Dim o_ticket As New Ticket

            o_ticket.TIK_ID = ds.TICKET.Item(i).TIK_ID
            o_ticket.CommandeOfTicket.CMD_ID = ds.TICKET.Item(i).CMD_ID
            o_ticket.TIK_DATECREATION = ds.TICKET.Item(i).TIK_DATECREATION
            o_ticket.TIK_TYPE = ds.TICKET.Item(i).TIK_TYPE
            o_ticket.TIK_MONTANTRECU = ds.TICKET.Item(i).TIK_MONTANTRECU
            Tickets.Add(o_ticket)

        Next


    End Sub

    Public Sub Actualiser()

        Actualiser_DataTable(Da_Payement, "SELECT * FROM PAYEMENT", ds.PAYEMENT)
        actualiser_TICKET()

    End Sub

#End Region

End Class
