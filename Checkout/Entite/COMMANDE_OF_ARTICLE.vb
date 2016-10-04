Public Class COMMANDE_OF_ARTICLE

#Region "Attributs"

    Private _Qte As Double
    Private _RemiseParArticle As Boolean
    Private _TauxRemise As Double
    Private _IsOffre As Boolean
    Private _QteOffre As Double
    Private _IsRetour As Boolean
    Private _QTERETROUR As Double

    Private _CommandeOfArticleOfCommande As List(Of Commande)
    Private _CommandeOfArticleOfArticle As List(Of ARTICLE)

#End Region

#Region "Propriété"


    Public Property QTE() As Double
        Get
            Return _Qte
        End Get
        Set(ByVal value As Double)
            _Qte = value
        End Set
    End Property

    Public Property REMISEPARARTICLE() As Boolean
        Get
            Return _RemiseParArticle
        End Get
        Set(ByVal value As Boolean)
            _RemiseParArticle = value
        End Set
    End Property

    Public Property TAUXREMISE() As Double
        Get
            Return _TauxRemise
        End Get
        Set(ByVal value As Double)
            _TauxRemise = value
        End Set
    End Property

    Public Property ISOFFERE() As Boolean
        Get
            Return _IsOffre
        End Get
        Set(ByVal value As Boolean)
            _IsOffre = value
        End Set
    End Property

    Public Property QTEOFFERE() As Double
        Get
            Return _QteOffre
        End Get
        Set(ByVal value As Double)
            _QteOffre = value
        End Set
    End Property

    Public Property ISRETOUR() As Boolean
        Get
            Return _IsRetour
        End Get
        Set(ByVal value As Boolean)
            _IsRetour = value
        End Set
    End Property

    Public Property QTERETROUR() As Double
        Get
            Return _QTERETROUR
        End Get
        Set(ByVal value As Double)
            _QTERETROUR = value
        End Set
    End Property


    Public Property CommandeOfArticleOfCommande() As List(Of COMMANDE)
        Get
            Return _CommandeOfArticleOfCommande
        End Get
        Set(ByVal value As List(Of COMMANDE))
            _CommandeOfArticleOfCommande = value
        End Set
    End Property

    Public Property CommandeOfArticleOfArticle() As List(Of ARTICLE)
        Get
            Return _CommandeOfArticleOfArticle
        End Get
        Set(ByVal value As List(Of ARTICLE))
            _CommandeOfArticleOfArticle = value
        End Set
    End Property

#End Region

#Region "Constructeurs"

    Public Sub New()

        Me.QTE = 0
        Me.REMISEPARARTICLE = False
        Me.TAUXREMISE = 0
        Me.ISOFFERE = False
        Me.QTEOFFERE = 0
        Me.ISRETOUR = False
        Me.QTERETROUR = 0
        Me.CommandeOfArticleOfCommande = New List(Of COMMANDE)
        Me.CommandeOfArticleOfArticle = New List(Of ARTICLE)

    End Sub

    Public Sub New(ByVal P_QTE As Double, ByVal P_REMISEPARARTICLE As Boolean, ByVal P_TAUXREMISE As Double, ByVal P_IsOffr As Boolean, ByVal P_QteOffr As Double, ByVal P_IsRetr As Boolean, ByVal P_Qteret As Double)

        Me.QTE = P_QTE
        Me.REMISEPARARTICLE = P_REMISEPARARTICLE
        Me.TAUXREMISE = P_TAUXREMISE
        Me.ISOFFERE = P_IsOffr
        Me.QTEOFFERE = P_QteOffr
        Me.ISRETOUR = P_IsRetr
        Me.QTERETROUR = P_Qteret
        Me.CommandeOfArticleOfCommande = New List(Of COMMANDE)
        Me.CommandeOfArticleOfArticle = New List(Of ARTICLE)

    End Sub

#End Region

#Region "DAL"

    Public Sub Ajouter_DAL()

        Dim dr As DataRow = ds.COMMANDE_OF_ARTICLE.NewRow

        dr(0) = Me.CommandeOfArticleOfCommande.Item(0).CMD_ID
        dr(1) = Me.CommandeOfArticleOfArticle.Item(0).ART_ID
        Dr(2) = Me.QTE
        Dr(3) = Me.REMISEPARARTICLE
        Dr(4) = Me.TAUXREMISE
        Dr(5) = Me.ISOFFERE
        Dr(6) = Me.QTEOFFERE
        Dr(7) = Me.ISRETOUR
        Dr(8) = Me.QTERETROUR

        ds.COMMANDE_OF_ARTICLE.Rows.Add(dr)

    End Sub

    Public Sub supprimer_DAL()

        Dim dr As DataRow = ds.COMMANDE_OF_ARTICLE.Select("CMD_ID =" & Me.CommandeOfArticleOfCommande.Item(0).CMD_ID)(0)
        dr.Delete()

    End Sub

#End Region

#Region "BAL"

    Public Sub Ajouter()

        actualiser()
        Me.Ajouter_DAL()
        Enregistrer(Da_Commande_of_Article, ds.COMMANDE_OF_ARTICLE)

    End Sub

    Public Sub Supprimer()

        actualiser()
        Me.supprimer_DAL()
        Enregistrer(Da_Commande_of_Article, ds.COMMANDE_OF_ARTICLE)

    End Sub

#End Region

#Region "Function"

    Private Sub actualiser()

        Actualiser_DataTable(Da_Commande_Of_Article, "SELECT * FROM COMMANDE_OF_ARTICLE", ds.COMMANDE_OF_ARTICLE)

    End Sub

    Public Sub Ajouter_CommandeOfarticle()


        Dim dr As DataRow = ds.COMMANDE_OF_ARTICLE.NewRow

        dr(0) = Me.CommandeOfArticleOfCommande.Item(0).CMD_ID
        dr(1) = Me.CommandeOfArticleOfArticle.Item(0).ART_ID

        dr(2) = Me.QTE
        dr(3) = Me.REMISEPARARTICLE
        dr(4) = Me.TAUXREMISE
        dr(5) = Me.ISOFFERE
        dr(6) = Me.QTEOFFERE
        dr(7) = Me.ISRETOUR
        dr(8) = Me.QTERETROUR

        ds.COMMANDE_OF_ARTICLE.Rows.Add(dr)

    End Sub

#End Region

End Class

