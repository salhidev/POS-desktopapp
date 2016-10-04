Public Class Commande

#Region " Attributs..."

    Private Shared Commandes As New List(Of Commande)

    Private _CMD_ID As Integer
    Private _CMD_DATEC As Date
    Private _CMD_REMISEGLOBAL As Boolean
    Private _CMD_MONTANTTOTAL As Double

    Private _CaissierOfCommande As Caissier
    Private _ClientOfCommande As Client

    Private _FacturesOfCommandes As List(Of Facture)
    Private _TicketOfCommandes As List(Of Ticket)
    Private _CommandeOfArticleOfCommande As COMMANDE_OF_ARTICLE

#End Region

#Region " Property..."

    Public Property CMD_ID As Integer
        Get
            Return _CMD_ID
        End Get
        Set(ByVal value As Integer)
            _CMD_ID = value
        End Set
    End Property

    Public Property CMD_DATEC As Date
        Get
            Return _CMD_DATEC
        End Get
        Set(ByVal value As Date)
            _CMD_DATEC = value
        End Set
    End Property

    Public Property CMD_REMISEGLOBAL As Boolean
        Get
            Return _CMD_REMISEGLOBAL
        End Get
        Set(ByVal value As Boolean)
            _CMD_REMISEGLOBAL = value
        End Set
    End Property

    Public Property CMD_MONTANTTOTAL As Double
        Get
            Return _CMD_MONTANTTOTAL
        End Get
        Set(ByVal value As Double)
            _CMD_MONTANTTOTAL = value
        End Set
    End Property

    Public Property CaissierOfCommande As Caissier
        Get
            Return _CaissierOfCommande

        End Get
        Set(ByVal value As Caissier)
            _CaissierOfCommande = value
        End Set
    End Property

    Public Property ClientsOfCommandes As Client
        Get
            Return _ClientOfCommande
        End Get
        Set(ByVal value As Client)
            _ClientOfCommande = value
        End Set
    End Property

    Public Property TicketOfCommandes As List(Of Ticket)
        Get
            Return _TicketOfCommandes
        End Get
        Set(ByVal value As List(Of Ticket))
            _TicketOfCommandes = value
        End Set
    End Property

    Public Property FacturesOfCommandes As List(Of Facture)
        Get
            Return _FacturesOfCommandes
        End Get
        Set(ByVal value As List(Of Facture))
            _FacturesOfCommandes = value
        End Set
    End Property

    Public Property CommandeOfArticleOfCommande As COMMANDE_OF_ARTICLE
        Get
            Return _CommandeOfArticleOfCommande
        End Get
        Set(ByVal value As COMMANDE_OF_ARTICLE)
            _CommandeOfArticleOfCommande = value
        End Set
    End Property

#End Region

#Region " Constructeurs..."

    Public Sub New(ByVal p_Id As Integer, ByVal p_DateC As Date, ByVal p_RemiseGlobal As Boolean, ByVal p_Montant As Double)

        Me.CMD_ID = p_Id
        Me.CMD_DATEC = p_DateC
        Me.CMD_REMISEGLOBAL = p_RemiseGlobal
        Me.CMD_MONTANTTOTAL = p_Montant
        CaissierOfCommande = New Caissier
        ClientsOfCommandes = New Client
        FacturesOfCommandes = New List(Of Facture)
        TicketOfCommandes = New List(Of Ticket)
        CommandeOfArticleOfCommande = New COMMANDE_OF_ARTICLE

    End Sub

    Public Sub New()

        CaissierOfCommande = New Caissier
        ClientsOfCommandes = New Client
        FacturesOfCommandes = New List(Of Facture)
        TicketOfCommandes = New List(Of Ticket)
        CommandeOfArticleOfCommande = New COMMANDE_OF_ARTICLE

    End Sub

#End Region

#Region " BAL..."

    Public Sub Ajouter()

        Actualiser()
        Me.CMD_ID = Generer_ID(ds.COMMANDE, "CMD_ID")
        Commandes.Add(Me)
        Me.Ajouter_DAL()
        Enregistrer(Da_Commande, ds.COMMANDE)
    End Sub

    Public Sub Modifier()
        Actualiser()
        Commandes(RechercherPoscommande(CMD_ID)) = Me
        Me.Modifier_DAL()
        Enregistrer(da_Commande, ds.COMMANDE)
    End Sub

    Public Sub Supprimer()
        Actualiser()
        Commandes.RemoveAt(RechercherPoscommande(CMD_ID))
        Me.Supprimer_Dal()
        Enregistrer(da_Commande, ds.COMMANDE)
    End Sub

#End Region

#Region " DAL... "

    Public Sub Ajouter_DAL()

        Dim dr As DataRow = ds.COMMANDE.NewRow

        dr(0) = Me.CMD_ID
        dr(1) = Me.ClientsOfCommandes.CLT_MAT
        dr(2) = Me.CaissierOfCommande.CAISSIER_ID
        dr(3) = Me.CMD_DATEC
        dr(4) = Me.CMD_REMISEGLOBAL
        dr(5) = Me.CMD_MONTANTTOTAL

        ds.COMMANDE.Rows.Add(dr)

    End Sub

    Public Sub Modifier_DAL()

        Dim dr As DataRow = ds.COMMANDE.Select("CMD_ID=" & Me.CMD_ID)(0)

        dr(1) = Me.ClientsOfCommandes.CLT_MAT
        dr(2) = Me.CaissierOfCommande.CAISSIER_ID
        dr(3) = Me.CMD_DATEC
        dr(4) = Me.CMD_REMISEGLOBAL
        dr(5) = Me.CMD_MONTANTTOTAL

    End Sub

    Public Sub Supprimer_Dal()

        Dim dr As DataRow = ds.COMMANDE.Select("CMD_ID=" & Me.CMD_ID)(0)
        dr.Delete()

    End Sub
#End Region

#Region " Function "

    Private Function RechercherPoscommande(ByVal p_ID As Integer) As Integer

        For i As Integer = 0 To Commandes.Count - 1
            If Commandes(i).CMD_ID = p_ID Then
                Return i
            End If
        Next
        Return -1

    End Function

    Public Function RetournerListeCommande() As List(Of Commande)

        Actualiser_DataTable(Da_Commande, "SELECT * FROM COMMANDE", ds.COMMANDE)

        If ds.COMMANDE.Rows.Count = 0 Then
            Return Nothing
        End If

        Dim O_Commande As Commande

        For i As Integer = 0 To ds.COMMANDE.Rows.Count - 1

            O_Commande = New Commande

            O_Commande.CMD_ID = ds.COMMANDE.Item(i).CMD_ID

            O_Commande.ClientsOfCommandes.CLT_MAT = ds.COMMANDE.Item(i).CLT_MAT
            O_Commande.CaissierOfCommande.CAISSIER_ID = ds.COMMANDE.Item(i).CAISSIER_ID

            O_Commande.CMD_DATEC = ds.COMMANDE.Item(i).CMD_DATEC
            O_Commande.CMD_REMISEGLOBAL = ds.COMMANDE.Item(i).CMD_REMISEGOLOBAL
            O_Commande.CMD_MONTANTTOTAL = ds.COMMANDE.Item(i).CMD_MONTANTTOTAL

            Commandes.Add(O_Commande)
        Next

        Return Commandes

    End Function

    Public Sub ActualiserListeCommande()

        Actualiser_DataTable(Da_Commande, "SELECT * FROM COMMANDE", ds.COMMANDE)

        If ds.COMMANDE.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim O_Commande As Commande

        For i As Integer = 0 To ds.COMMANDE.Rows.Count - 1

            O_Commande = New Commande

            O_Commande.CMD_ID = ds.COMMANDE.Item(i).CMD_ID

            O_Commande.ClientsOfCommandes.CLT_MAT = ds.COMMANDE.Item(i).CLT_MAT
            O_Commande.CaissierOfCommande.CAISSIER_ID = ds.COMMANDE.Item(i).CAISSIER_ID

            O_Commande.CMD_DATEC = ds.COMMANDE.Item(i).CMD_DATEC
            O_Commande.CMD_REMISEGLOBAL = ds.COMMANDE.Item(i).CMD_REMISEGOLOBAL
            O_Commande.CMD_MONTANTTOTAL = ds.COMMANDE.Item(i).CMD_MONTANTTOTAL

            Commandes.Add(O_Commande)
        Next

    End Sub

    Private Sub Actualiser()

        Actualiser_DataTable(Da_Commande, "SELECT * FROM COMMANDE", ds.COMMANDE)
        ActualiserListeCommande()

    End Sub

#End Region

End Class
