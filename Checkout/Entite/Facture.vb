Imports System.Data.SqlClient
Imports System.Data

Public Class Facture

    '----------- Attribus -----------

#Region " Attributs..."

    Private Shared Factures As New List(Of Facture)

    Private _FACT_ID As Integer
    Private _FACT_DATE As Date
    Private _FACT_ETAT As Boolean

    Private _PayementOfFacture As List(Of Payement)
    Private _CommandeOfFacture As Commande


#End Region

#Region " Property..."

    Public Property FACT_ID As Integer
        Get
            Return _FACT_ID
        End Get
        Set(ByVal value As Integer)
            _FACT_ID = value
        End Set
    End Property


    Public Property FACT_DATE As Date
        Get
            Return _FACT_DATE
        End Get
        Set(ByVal value As Date)
            _FACT_DATE = value
        End Set
    End Property

    Public Property FACT_ETAT As Boolean
        Get
            Return _FACT_ETAT
        End Get
        Set(ByVal value As Boolean)
            _FACT_ETAT = value
        End Set
    End Property

    Public Property CommandeOfFacture As Commande
        Get
            Return _CommandeOfFacture
        End Get
        Set(ByVal value As Commande)
            _CommandeOfFacture = value
        End Set

    End Property

    Public Property PayementOfFacture As List(Of Payement)
        Get
            Return _PayementOfFacture
        End Get
        Set(ByVal value As List(Of Payement))
            _PayementOfFacture = value
        End Set
    End Property
  

#End Region

#Region "Constructeurs"

    Public Sub New()

        CommandeOfFacture = New Commande
        PayementOfFacture = New List(Of Payement)

    End Sub

    Public Sub New(ByVal p_id As Integer, ByVal p_dat As Date, ByVal p_etat As Boolean)

        Me.FACT_ID = p_id
        Me.FACT_DATE = p_dat
        Me.FACT_ETAT = p_etat
        CommandeOfFacture = New Commande
        PayementOfFacture = New List(Of Payement)

    End Sub

#End Region

#Region "  BAL..."

    Public Sub Ajouter()

        actualiser()
        Me.FACT_ID = Generer_ID(ds.FACTURE, "FACT_ID")
        Factures.Add(Me)
        Me.Ajouter_DAL()
        Enregistrer(Da_Facture, ds.FACTURE)
    End Sub

    Public Sub Modifier()
        actualiser()
        Factures(RechercherPosFacture(FACT_ID)) = Me
        Me.Modifier_DAL()
        Enregistrer(Da_Facture, ds.FACTURE)
    End Sub

    Public Sub Supprimer()
        actualiser()
        Factures.RemoveAt(RechercherPosFacture(FACT_ID))
        Me.Supprimer_Dal()
        Enregistrer(Da_Facture, ds.FACTURE)
    End Sub

#End Region

#Region "   DAL... "

    Public Sub Ajouter_DAL()

        Dim dr As DataRow = ds.FACTURE.NewRow
        dr(0) = Me.FACT_ID
        dr(1) = Me.CommandeOfFacture.CMD_ID
        dr(2) = Me.FACT_DATE
        dr(3) = Me.FACT_ETAT
        ds.FACTURE.Rows.Add(dr)

    End Sub

    Public Sub Modifier_DAL()

        Dim dr As DataRow = ds.FACTURE.Select("FACT_ID=" & Me.FACT_ID)(0)
        dr(1) = Me.CommandeOfFacture.CMD_ID
        dr(2) = Me.FACT_DATE
        dr(3) = Me.FACT_ETAT
        ds.FACTURE.Rows.Add(dr)

    End Sub

    Public Sub Supprimer_Dal()

        Dim dr As DataRow = ds.FACTURE.Select("FACT_ID=" & Me.FACT_ID)(0)
        dr.Delete()

    End Sub


#End Region

#Region " Function "

    Private Function RechercherPosFacture(ByVal ID As Integer) As Integer

        For i As Integer = 0 To Factures.Count - 1
            If Factures(i).FACT_ID = ID Then
                Return i
            End If
        Next
        Return -1

    End Function

    Public Sub AjouterFactutreOfPayement(ByVal IDPayement As Integer, ByVal IDFacture As Integer)

        Dim dr As DataRow
        dr = ds.PAYEMENT_OF_FACTURE.NewRow
        dr(0) = IDFacture
        dr(1) = IDPayement
        ds.PAYEMENT_OF_FACTURE.Rows.Add(dr)
        Enregistrer(Da_Payement_Of_Facture, ds.PAYEMENT_OF_FACTURE)
        MsgBox("Facture Of Payement Ajouté")

    End Sub


    Public Function RetournerListeFacture() As List(Of Facture)

        Actualiser_DataTable(Da_Facture, "SELECT * FROM FACTURE", ds.FACTURE)

        Factures.Clear()

        If ds.FACTURE.Rows.Count = 0 Then

            Return Nothing

        End If

        For i As Integer = 0 To ds.FACTURE.Rows.Count - 1

            Dim o_facture As New Facture

            o_facture.FACT_ID = ds.FACTURE.Item(i).FACT_ID
            o_facture.CommandeOfFacture.CMD_ID = ds.FACTURE.Item(i).CMD_ID
            o_facture.FACT_DATE = ds.FACTURE.Item(i).FACT_DATE
            o_facture.FACT_ETAT = ds.FACTURE.Item(i).FACT_ETAT

            Factures.Add(o_facture)

        Next

        Return Factures

    End Function

    Public Sub actualiser_Facture()

        Actualiser_DataTable(Da_Facture, "SELECT * FROM FACTURE", ds.FACTURE)

        Factures.Clear()

        If ds.FACTURE.Rows.Count = 0 Then

            Exit Sub

        End If

        For i As Integer = 0 To ds.FACTURE.Rows.Count - 1

            Dim o_facture As New Facture

            o_facture.FACT_ID = ds.FACTURE.Item(i).FACT_ID
            o_facture.CommandeOfFacture.CMD_ID = ds.FACTURE.Item(i).CMD_ID
            o_facture.FACT_DATE = ds.FACTURE.Item(i).FACT_DATE
            o_facture.FACT_ETAT = ds.FACTURE.Item(i).FACT_ETAT

            Factures.Add(o_facture)

        Next


    End Sub

    Public Sub actualiser()

        Actualiser_DataTable(Da_Facture, " SELECT * FROM FACTURE ", ds.FACTURE)
        actualiser_Facture()

    End Sub

#End Region

End Class
