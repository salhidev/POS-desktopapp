Imports System.Data.SqlClient
Imports System.Data

Public Class Mode_Reglement


#Region " Attributs..."

    Private ModesReglements As New List(Of Mode_Reglement)

    Private _MDRG_ID As Integer
    Private _MDRG_LIB As String
    Private _MDRG_COMMANTAIRE As String

    Private _PayementOfModeReglement As List(Of Payement)

#End Region

#Region " Property ..."

    Public Property MDRG_ID As Integer
        Get
            Return _MDRG_ID
        End Get
        Set(ByVal value As Integer)
            _MDRG_ID = value
        End Set
    End Property

    Public Property MDRG_LIB As String
        Get
            Return _MDRG_LIB
        End Get
        Set(ByVal value As String)
            _MDRG_LIB = value
        End Set
    End Property

    Public Property MDRG_COMMANTAURE As String
        Get
            Return _MDRG_COMMANTAIRE
        End Get
        Set(ByVal value As String)
            _MDRG_COMMANTAIRE = value
        End Set
    End Property

    Public Property PayementOfModeReglement As List(Of Payement)
        Get
            Return _PayementOfModeReglement
        End Get
        Set(ByVal value As List(Of Payement))
            _PayementOfModeReglement = value
        End Set
    End Property

#End Region

#Region " Constructeur..."

    Public Sub New()
        PayementOfModeReglement = New List(Of Payement)
    End Sub

    Public Sub New(ByVal p_id As Integer, ByVal p_libe As String, ByVal p_com As String)

        Me.MDRG_ID = p_id
        Me.MDRG_LIB = p_libe
        Me.MDRG_COMMANTAURE = p_com
        PayementOfModeReglement = New List(Of Payement)

    End Sub

#End Region

#Region " BAL..."

    Public Sub Ajouter()
        Actualiser()
        Me.MDRG_ID = Generer_ID(ds.MODE_REGLEMENT, "MDRG_ID")
        ModesReglements.Add(Me)
        Me.Ajouter_DAL()
        Enregistrer(da_ModeReglement, ds.MODE_REGLEMENT)
    End Sub

    Public Sub Modifier()
        Actualiser()
        ModesReglements(RechercherPosMode_Reglement(MDRG_ID)) = Me
        Me.Modifier_DAL()
        Enregistrer(da_ModeReglement, ds.MODE_REGLEMENT)
    End Sub

    Public Sub Supprimer()
        Actualiser()
        ModesReglements.RemoveAt(RechercherPosMode_Reglement(MDRG_ID))
        Me.Supprimer_Dal()
        Enregistrer(da_ModeReglement, ds.MODE_REGLEMENT)
    End Sub

#End Region

#Region " DAL... "

    Public Sub Ajouter_DAL()

        Dim dr As DataRow = ds.MODE_REGLEMENT.NewRow
        dr(0) = Me.MDRG_ID
        dr(1) = Me.MDRG_LIB
        dr(2) = Me.MDRG_COMMANTAURE

        ds.MODE_REGLEMENT.Rows.Add(dr)

    End Sub

    Public Sub Modifier_DAL()

        Dim dr As DataRow = ds.MODE_REGLEMENT.Select("MDRG_ID=" & Me.MDRG_ID)(0)
        dr(1) = Me.MDRG_LIB
        dr(2) = Me.MDRG_COMMANTAURE
        ds.MODE_REGLEMENT.Rows.Add(dr)

    End Sub

    Public Sub Supprimer_Dal()

        Dim dr As DataRow = ds.MODE_REGLEMENT.Select("MDRG_ID=" & Me.MDRG_ID)(0)
        dr.Delete()

    End Sub


#End Region

#Region " Function "

    Private Function RechercherPosMode_Reglement(ByVal p_ID As Integer) As Integer

        For i As Integer = 0 To ModesReglements.Count - 1
            If ModesReglements(i).MDRG_ID = p_ID Then
                Return i
            End If
        Next
        Return -1

    End Function

    Public Function RetournerListeMode_Reglement() As List(Of Mode_Reglement)

        Actualiser_DataTable(Da_ModeReglement, "SELECT * FROM MODE_REGLEMENT", ds.MODE_REGLEMENT)

        ModesReglements.Clear()

        If ds.MODE_REGLEMENT.Rows.Count = 0 Then

            Return Nothing

        End If

        For i As Integer = 0 To ds.MODE_REGLEMENT.Rows.Count - 1

            Dim o_mdg As New Mode_Reglement

            o_mdg.MDRG_ID = ds.MODE_REGLEMENT.Item(i).MDRG_ID
            o_mdg.MDRG_LIB = ds.MODE_REGLEMENT.Item(i).MDRG_LIB
            o_mdg.MDRG_COMMANTAURE = ds.MODE_REGLEMENT.Item(i).MDRG_COMMANTAIRE
            ModesReglements.Add(o_mdg)

        Next


        Return ModesReglements

    End Function

    Public Sub actualiser_Mode_Reglement()

        Actualiser_DataTable(Da_ModeReglement, "SELECT * FROM MODE_REGLEMENT", ds.MODE_REGLEMENT)

        ModesReglements.Clear()

        If ds.MODE_REGLEMENT.Rows.Count = 0 Then

            Exit Sub

        End If

        For i As Integer = 0 To ds.MODE_REGLEMENT.Rows.Count - 1

            Dim o_mdg As New Mode_Reglement

            o_mdg.MDRG_ID = ds.MODE_REGLEMENT.Item(i).MDRG_ID
            o_mdg.MDRG_LIB = ds.MODE_REGLEMENT.Item(i).MDRG_LIB
            o_mdg.MDRG_COMMANTAURE = ds.MODE_REGLEMENT.Item(i).MDRG_COMMANTAIRE
            ModesReglements.Add(o_mdg)

        Next


    End Sub

    Public Sub Actualiser()

        Actualiser_DataTable(Da_ModeReglement, "SELECT * FROM MODE_REGLEMENT", ds.MODE_REGLEMENT)
        actualiser_Mode_Reglement()

    End Sub
#End Region

End Class
