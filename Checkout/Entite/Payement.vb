Imports System.Data.SqlClient
Imports System.Data

Public Class Payement

#Region " Attributs..."

    Private Shared Payements As New List(Of Payement)

    Private _PAYM_ID As Integer
    Private _PAYM_MONTANT As Double
    Private _FactureOfPayement As List(Of Facture)
    Private _TicketOfPayement As List(Of Ticket)
    Private _ModeReglementOfPayement As Mode_Reglement

#End Region

#Region " Property ..."

    Public Property PAYM_ID As Integer
        Get
            Return _PAYM_ID
        End Get
        Set(ByVal value As Integer)
            _PAYM_ID = value
        End Set
    End Property

    Public Property PAYM_MONTANT As Double
        Get
            Return _PAYM_MONTANT
        End Get
        Set(ByVal value As Double)
            _PAYM_MONTANT = value
        End Set
    End Property

    Public Property ModeReglementOfPayement As Mode_Reglement
        Get
            Return _ModeReglementOfPayement
        End Get
        Set(ByVal value As Mode_Reglement)
            _ModeReglementOfPayement = value
        End Set
    End Property

    Public Property FactureOfPayement As List(Of Facture)
        Get
            Return _FactureOfPayement
        End Get
        Set(ByVal value As List(Of Facture))
            _FactureOfPayement = value
        End Set
    End Property

    Public Property TicketOfPayement As List(Of Ticket)
        Get
            Return _TicketOfPayement
        End Get
        Set(ByVal value As List(Of Ticket))
            _TicketOfPayement = value
        End Set
    End Property


#End Region

#Region " Constructeur "

    Public Sub New()

        TicketOfPayement = New List(Of Ticket)
        FactureOfPayement = New List(Of Facture)
        ModeReglementOfPayement = New Mode_Reglement

    End Sub

    Public Sub New(ByVal p_id As Integer, ByVal p_Montant As Double)

        Me.PAYM_ID = p_id
        Me.PAYM_MONTANT = p_Montant
        TicketOfPayement = New List(Of Ticket)
        FactureOfPayement = New List(Of Facture)
        ModeReglementOfPayement = New Mode_Reglement

    End Sub

#End Region

#Region "  BAL..."

    Public Sub Ajouter()

        Actualiser()
        Me.PAYM_ID = Generer_ID(ds.PAYEMENT, "PAYM_ID")
        Payements.Add(Me)
        Me.Ajouter_DAL()
        Enregistrer(Da_Payement, ds.PAYEMENT)

    End Sub

    Public Sub Modifier()

        Actualiser()
        Payements(RechercherPosPayement(PAYM_ID)) = Me
        Me.Modifier_DAL()
        Enregistrer(da_Payement, ds.PAYEMENT)

    End Sub

    Public Sub Supprimer()
        Actualiser()
        Payements.RemoveAt(RechercherPosPayement(PAYM_ID))
        Me.Supprimer_Dal()
        Enregistrer(da_Payement, ds.PAYEMENT)
    End Sub

#End Region

#Region "   DAL... "

    Public Sub Ajouter_DAL()

        Dim dr As DataRow = ds.PAYEMENT.NewRow

        dr(0) = Me.PAYM_ID
        dr(1) = Me.ModeReglementOfPayement.MDRG_ID
        dr(2) = Me.PAYM_MONTANT

        ds.PAYEMENT.Rows.Add(dr)

    End Sub

    Public Sub Modifier_DAL()

        Dim dr As DataRow = ds.PAYEMENT.Select("PAYM_ID=" & Me.PAYM_ID)(0)
        dr(1) = Me.ModeReglementOfPayement.MDRG_ID
        dr(2) = Me.PAYM_MONTANT
        ds.PAYEMENT.Rows.Add(dr)

    End Sub

    Public Sub Supprimer_Dal()

        Dim dr As DataRow = ds.PAYEMENT.Select("PAYM_ID=" & Me.PAYM_ID)(0)
        dr.Delete()

    End Sub


#End Region

#Region " Function "

    Private Function RechercherPosPayement(ByVal p_ID As Integer) As Integer

        For i As Integer = 0 To Payements.Count - 1
            If Payements(i).PAYM_ID = p_ID Then
                Return i
            End If
        Next
        Return -1

    End Function

    Public Function RetournerListePayement() As List(Of Payement)

        Actualiser_DataTable(Da_Payement, "SELECT * FROM Payement", ds.PAYEMENT)

        Payements.Clear()

        If ds.PAYEMENT.Rows.Count = 0 Then

            Return Nothing

        End If

        For i As Integer = 0 To ds.PAYEMENT.Rows.Count - 1

            Dim o_payement As New Payement

            o_payement.PAYM_ID = ds.PAYEMENT.Item(i).PAYM_ID
            o_payement.ModeReglementOfPayement.MDRG_ID = ds.PAYEMENT.Item(i).MDRG_ID
            o_payement.PAYM_MONTANT = ds.PAYEMENT.Item(i).PAYM_MONTANT
            Payements.Add(o_payement)

        Next



        Return Payements

    End Function

    Public Sub actualiser_PAYEMENT()

        Actualiser_DataTable(Da_Payement, "SELECT * FROM Payement", ds.PAYEMENT)

        Payements.Clear()

        If ds.PAYEMENT.Rows.Count = 0 Then

            Exit Sub

        End If

        For i As Integer = 0 To ds.PAYEMENT.Rows.Count - 1

            Dim o_payement As New Payement

            o_payement.PAYM_ID = ds.PAYEMENT.Item(i).PAYM_ID
            o_payement.ModeReglementOfPayement.MDRG_ID = ds.PAYEMENT.Item(i).MDRG_ID
            o_payement.PAYM_MONTANT = ds.PAYEMENT.Item(i).PAYM_MONTANT
            Payements.Add(o_payement)

        Next


    End Sub

    Public Sub Actualiser()

        Actualiser_DataTable(Da_Payement, "SELECT * FROM PAYEMENT", ds.PAYEMENT)
        actualiser_PAYEMENT()

    End Sub


#End Region

End Class
