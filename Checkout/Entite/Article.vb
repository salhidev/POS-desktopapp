Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Image
Public Class ARTICLE


#Region "Declaration..."

    Private Shared Articles As New List(Of ARTICLE)

    Private _ART_ID As Integer
    Private _CodeBarOfArticle As CODE_BARE
    Private _TvaOfArticle As TVA
    Private _MarqueOfArticle As MARQUE
    Private _ART_REF As String
    Private _ART_DATEENT As Date
    Private _ART_PRIXUHT As Double
    Private _ART_TAUXTVA As Double
    Private _ART_DESCRIPTION As String
    Private _ART_STOCKMIN As Double
    Private _ART_DATEPEREMTION As Date
    Private _ART_STOCKMAX As Double
    Private _ART_PHOTO As Byte()
    Private _ART_TYPE As String
    Private _ART_STOCKABLE As Boolean
    Private _ART_STOCKREEL As Double
    Private _ART_STOCKALERT As Double
    Private _ART_STOCKRESERVE As Double
    Private _ART_CONSOMABLE As Boolean
    Private _ART_NATURE As String
    Private _ART_DATEMODIFICATION As Date
    Private _ART_MOTIFMODIFICATION As String



    Private _TarifOfArticleOfArticle As TARIF_OF_ARTICLE

#End Region


#Region "Propriétés"






    Public Property TarifOfArticleOfArticle() As TARIF_OF_ARTICLE
        Get
            Return _TarifOfArticleOfArticle
        End Get
        Set(ByVal value As TARIF_OF_ARTICLE)
            _TarifOfArticleOfArticle = value
        End Set
    End Property




    Public Property ART_REF() As String
        Get
            Return _ART_REF
        End Get
        Set(ByVal value As String)
            _ART_REF = value
        End Set
    End Property





    Public Property TvaOfArticle() As TVA
        Get
            Return _TvaOfArticle
        End Get
        Set(ByVal value As TVA)
            _TvaOfArticle = value
        End Set
    End Property



    Public Property CodeBarOfArticle() As CODE_BARE
        Get
            Return _CodeBarOfArticle
        End Get
        Set(ByVal value As CODE_BARE)
            _CodeBarOfArticle = value
        End Set
    End Property




    Public Property ART_ID() As Integer
        Get
            Return _ART_ID
        End Get
        Set(ByVal value As Integer)
            _ART_ID = value
        End Set
    End Property




    Public Property MarqueOfArticle() As MARQUE
        Get
            Return _MarqueOfArticle
        End Get
        Set(ByVal value As MARQUE)
            _MarqueOfArticle = value
        End Set
    End Property




    Public Property ART_DATEENT() As Date
        Get
            Return _ART_DATEENT
        End Get
        Set(ByVal value As Date)
            _ART_DATEENT = value
        End Set
    End Property



    Public Property ART_PRIXUHT() As Double
        Get
            Return _ART_PRIXUHT
        End Get
        Set(ByVal value As Double)
            _ART_PRIXUHT = value
        End Set
    End Property





    Public Property ART_TAUXTVA() As Double
        Get
            Return _ART_TAUXTVA
        End Get
        Set(ByVal value As Double)
            _ART_TAUXTVA = value
        End Set
    End Property



    Public Property ART_DESCRIPTION() As String
        Get
            Return _ART_DESCRIPTION
        End Get
        Set(ByVal value As String)
            _ART_DESCRIPTION = value
        End Set
    End Property




    Public Property ART_STOCKMIN() As Double
        Get
            Return _ART_STOCKMIN
        End Get
        Set(ByVal value As Double)
            _ART_STOCKMIN = value
        End Set
    End Property




    Public Property ART_DATEPEREMTION() As Date
        Get
            Return _ART_DATEPEREMTION
        End Get
        Set(ByVal value As Date)
            _ART_DATEPEREMTION = value
        End Set
    End Property




    Public Property ART_STOCKMAX() As Double
        Get
            Return _ART_STOCKMAX
        End Get
        Set(ByVal value As Double)
            _ART_STOCKMAX = value
        End Set
    End Property




    Public Property ART_PHOTO() As Byte()
        Get
            Return _ART_PHOTO
        End Get
        Set(ByVal value As Byte())
            _ART_PHOTO = value
        End Set
    End Property




    Public Property ART_TYPE() As String
        Get
            Return _ART_TYPE
        End Get
        Set(ByVal value As String)
            _ART_TYPE = value
        End Set
    End Property






    Public Property ART_STOCKABLE() As Boolean
        Get
            Return _ART_STOCKABLE
        End Get
        Set(ByVal value As Boolean)
            _ART_STOCKABLE = value
        End Set
    End Property




    Public Property ART_STOCKREEL() As Double
        Get
            Return _ART_STOCKREEL
        End Get
        Set(ByVal value As Double)
            _ART_STOCKREEL = value
        End Set
    End Property





    Public Property ART_STOCKALERT() As Double
        Get
            Return _ART_STOCKALERT
        End Get
        Set(ByVal value As Double)
            _ART_STOCKALERT = value
        End Set
    End Property





    Public Property ART_STOCKRESERVE() As Double
        Get
            Return _ART_STOCKRESERVE
        End Get
        Set(ByVal value As Double)
            _ART_STOCKRESERVE = value
        End Set
    End Property






    Public Property ART_CONSOMABLE() As Boolean
        Get
            Return _ART_CONSOMABLE
        End Get
        Set(ByVal value As Boolean)
            _ART_CONSOMABLE = value
        End Set
    End Property





    Public Property ART_NATURE() As String
        Get
            Return _ART_NATURE
        End Get
        Set(ByVal value As String)
            _ART_NATURE = value
        End Set
    End Property





    Public Property ART_DATEMODIFICATION() As Date
        Get
            Return _ART_DATEMODIFICATION
        End Get
        Set(ByVal value As Date)
            _ART_DATEMODIFICATION = value
        End Set
    End Property






    Public Property ART_MOTIFMODIFICATION() As String
        Get
            Return _ART_MOTIFMODIFICATION
        End Get
        Set(ByVal value As String)
            _ART_MOTIFMODIFICATION = value
        End Set
    End Property






#End Region



#Region "Constructeurs"



    Public Sub New()


        TarifOfArticleOfArticle = New TARIF_OF_ARTICLE
        CodeBarOfArticle = New CODE_BARE
        TvaOfArticle = New TVA
        MarqueOfArticle = New MARQUE


    End Sub



    Public Sub New(ByVal P_ART_ID As Integer, ByVal P_ART_REF As String, ByVal P_ART_DATEENT As Date, ByVal P_ART_PRIXUHT As Double, ByVal P_ART_TAUXTVA As Double, ByVal P_ART_DESCRIPTION As String, ByVal P_ART_STOCKMIN As Double, ByVal P_ART_DATEPEREMTION As Date, ByVal P_ART_STOCKMAX As Double, ByVal P_ART_PHOTO As Byte(), ByVal P_ART_TYPE As String, ByVal P_ART_STOCKABLE As Boolean, ByVal P_ART_STOCKREEL As Double, ByVal P_ART_STOCKALERT As Double, ByVal P_ART_STOCKRESERVE As Double, ByVal P_ART_CONSOMABLE As Boolean, ByVal P_ART_NATUR As String, ByVal P_ART_DATEMODIFICATION As Date, ByVal P_ART_MOTIFMODIFICATION As String)

        ART_ID = P_ART_ID
        ART_DATEENT = P_ART_DATEENT
        ART_PRIXUHT = P_ART_PRIXUHT
        ART_REF = P_ART_REF
        ART_TAUXTVA = P_ART_TAUXTVA
        ART_DESCRIPTION = P_ART_DESCRIPTION
        ART_STOCKMIN = P_ART_STOCKMIN
        ART_DATEPEREMTION = P_ART_DATEPEREMTION
        ART_STOCKMAX = P_ART_STOCKMAX
        ART_PHOTO = P_ART_PHOTO
        ART_TYPE = P_ART_TYPE
        ART_STOCKABLE = P_ART_STOCKABLE
        ART_STOCKREEL = P_ART_STOCKREEL
        ART_STOCKALERT = P_ART_STOCKALERT
        ART_STOCKRESERVE = P_ART_STOCKRESERVE
        ART_CONSOMABLE = P_ART_CONSOMABLE
        ART_NATURE = P_ART_NATUR


        ART_DATEMODIFICATION = P_ART_DATEMODIFICATION
        ART_MOTIFMODIFICATION = P_ART_MOTIFMODIFICATION

        TarifOfArticleOfArticle = New TARIF_OF_ARTICLE
        CodeBarOfArticle = New CODE_BARE
        TvaOfArticle = New TVA
        MarqueOfArticle = New MARQUE


    End Sub


#End Region



#Region "BAL"


    Public Sub Ajouter()

        Actualiser()

        ART_ID = Generer_ID(ds.ARTICLE, "ART_ID")
        Articles.Add(Me)
        Me.Ajouter_DAL()

        Enregistrer(Da_Article, ds.ARTICLE)

    End Sub


    Public Sub Modifier()

        Actualiser()

        Articles(Rechercher_Par_Id(ART_ID)) = Me
        Me.Modifier_DAL()

        Enregistrer(Da_Article, ds.ARTICLE)

    End Sub


    Public Sub Supprimer()

        Actualiser()

        Articles.RemoveAt(Rechercher_Par_Id(Me.ART_ID))
        Me.Supprimer_DAL()

        Enregistrer(Da_Article, ds.ARTICLE)

    End Sub


#End Region



#Region "DAL"



    Private Sub Ajouter_DAL()

        Dim dr As DataRow = ds.ARTICLE.NewRow

        dr(0) = Me.ART_ID
        dr(1) = Me.CodeBarOfArticle.CB_ID
        dr(2) = Me.TvaOfArticle.TVA_ID
        dr(3) = Me.MarqueOfArticle.Mrq_Id
        dr(4) = Me.ART_REF
        dr(5) = Me.ART_DATEENT
        dr(6) = Me.ART_PRIXUHT
        dr(7) = Me.ART_TAUXTVA
        dr(8) = Me.ART_DESCRIPTION
        dr(9) = Me.ART_STOCKMIN
        dr(10) = Me.ART_DATEPEREMTION
        dr(11) = Me.ART_STOCKMAX

        dr(12) = Me.ART_TYPE
        dr(13) = Me.ART_STOCKABLE
        dr(14) = Me.ART_STOCKREEL
        dr(15) = Me.ART_STOCKALERT
        dr(16) = Me.ART_STOCKRESERVE
        dr(17) = Me.ART_CONSOMABLE
        dr(18) = Me.ART_NATURE
        dr(19) = Me.ART_DATEMODIFICATION
        dr(20) = Me.ART_MOTIFMODIFICATION
        dr(21) = Me.ART_PHOTO

        ds.ARTICLE.Rows.Add(dr)

    End Sub




    Private Sub Modifier_DAL()

        Dim dr As DataRow = ds.ARTICLE.Select("ART_ID = " & ART_ID)(0)


        dr(1) = Me.CodeBarOfArticle.CB_ID
        dr(2) = Me.TvaOfArticle.TVA_ID
        dr(3) = Me.MarqueOfArticle.Mrq_Id
        dr(4) = Me.ART_REF
        dr(5) = Me.ART_DATEENT
        dr(6) = Me.ART_PRIXUHT
        dr(7) = Me.ART_TAUXTVA
        dr(8) = Me.ART_DESCRIPTION
        dr(9) = Me.ART_STOCKMIN
        dr(10) = Me.ART_DATEPEREMTION
        dr(11) = Me.ART_STOCKMAX
        dr(12) = Me.ART_TYPE
        dr(13) = Me.ART_STOCKABLE
        dr(14) = Me.ART_STOCKREEL
        dr(15) = Me.ART_STOCKALERT
        dr(16) = Me.ART_STOCKRESERVE
        dr(17) = Me.ART_CONSOMABLE
        dr(18) = Me.ART_NATURE
        dr(19) = Me.ART_DATEMODIFICATION
        dr(20) = Me.ART_MOTIFMODIFICATION
        dr(21) = Me.ART_PHOTO

    End Sub



    Private Sub Supprimer_DAL()

        Dim dr As DataRow = ds.ARTICLE.Select("ART_ID = " & ART_ID)(0)
        dr.Delete()

    End Sub



#End Region





#Region "Methodes"





    Public Function Rechercher_Par_Id(ByVal P_Id As Integer) As Integer

        If Articles.Count <> 0 Then
            For i As Integer = 0 To Articles.Count - 1
                If Articles(i).ART_ID = P_Id Then
                    Return i
                End If
            Next
        End If
        Return -1

    End Function






    Public Function Actualiser_Liste() As List(Of ARTICLE)

        Actualiser_DataTable(Da_Article, "SELECT * FROM ARTICLE", ds.ARTICLE)

        If ds.ARTICLE.Rows.Count = 0 Then
            Return Nothing
        End If

        Articles.Clear()

        For i As Integer = 0 To ds.ARTICLE.Rows.Count - 1



            Dim O_Article As New ARTICLE

            O_Article.ART_ID = ds.ARTICLE.Item(i).ART_ID
            O_Article.CodeBarOfArticle.CB_ID = ds.ARTICLE.Item(i).CB_ID
            O_Article.TvaOfArticle.TVA_ID = ds.ARTICLE.Item(i).TVA_ID
            O_Article.MarqueOfArticle.Mrq_Id = ds.ARTICLE.Item(i).MRQ_ID
            O_Article.ART_REF = ds.ARTICLE.Item(i).ART_REF
            O_Article.ART_DATEENT = ds.ARTICLE.Item(i).ART_DATEENT
            O_Article.ART_PRIXUHT = ds.ARTICLE.Item(i).ART_PRIXUHT
            O_Article.ART_TAUXTVA = ds.ARTICLE.Item(i).ART_TAUXTVA
            O_Article.ART_DESCRIPTION = ds.ARTICLE.Item(i).ART_DESCRIPTION


            O_Article.ART_STOCKMIN = ds.ARTICLE.Item(i).ART_STOCKMIN
            O_Article.ART_DATEPEREMTION = ds.ARTICLE.Item(i).ART_DATEPEREMTION
            O_Article.ART_STOCKMAX = ds.ARTICLE.Item(i).ART_STOCKMAX

            O_Article.ART_PHOTO = (ds.ARTICLE.Item(i).ART_Photos)
            O_Article.ART_TYPE = ds.ARTICLE.Item(i).ART_TYPE
            O_Article.ART_STOCKABLE = ds.ARTICLE.Item(i).ART_STOCKABLE
            O_Article.ART_STOCKREEL = ds.ARTICLE.Item(i).ART_STOCKREEL
            O_Article.ART_STOCKALERT = ds.ARTICLE.Item(i).ART_STOCKALERT
            O_Article.ART_STOCKRESERVE = ds.ARTICLE.Item(i).ART_STOCKRESERVE
            O_Article.ART_CONSOMABLE = ds.ARTICLE.Item(i).ART_CONOSOMABLE
            O_Article.ART_NATURE = ds.ARTICLE.Item(i).ART_NATURE
            O_Article.ART_DATEMODIFICATION = ds.ARTICLE.Item(i).ART_DATEMODIFICATION
            O_Article.ART_MOTIFMODIFICATION = ds.ARTICLE.Item(i).ART_MOTIFMODIFICATION

            Articles.Add(O_Article)


            Me.TarifOfArticleOfArticle.ArticleOfTarifeOfArticle.Add(O_Article)

        Next

        Return Articles


    End Function





    Public Sub Actualiser()

        Actualiser_DataTable(Da_Article, "SELECT * FROM ARTICLE", ds.ARTICLE)
        Actualiser_Liste()

    End Sub







    Public Function Rechercher_Par_DESCRIPTION(ByVal P_DESCRIPTION As String) As List(Of ARTICLE)

        Actualiser_Liste()

        Dim ListeOfArticles As New List(Of ARTICLE)

        If Articles.Count <> Nothing Then

            For i As Integer = 0 To Articles.Count - 1
                If Articles(i).ART_DESCRIPTION.Length >= P_DESCRIPTION.Length Then

                    If Articles(i).ART_DESCRIPTION.Substring(0, P_DESCRIPTION.Length).ToLower = P_DESCRIPTION.ToLower Then
                        ListeOfArticles.Add(Articles(i))
                    End If

                End If
            Next

        End If

        Return ListeOfArticles

    End Function







    Public Function Rechercher_Par_Type(ByVal P_Type As String) As List(Of ARTICLE)

        Actualiser_Liste()

        Dim ListeOfArticles As New List(Of ARTICLE)

        If Articles.Count <> Nothing Then

            For i As Integer = 0 To Articles.Count - 1
                If Articles(i).ART_TYPE.Length >= P_Type.Length Then

                    If Articles(i).ART_TYPE.Substring(0, P_Type.Length).ToLower = P_Type.ToLower Then
                        ListeOfArticles.Add(Articles(i))
                    End If

                End If
            Next

        End If

        Return ListeOfArticles
    End Function






    Public Function Rechercher_Par_Description_Et_Type(ByVal P_DESCRIPTION As String, ByVal P_TYPE As String) As List(Of ARTICLE)

        Actualiser_Liste()

        Dim o_ARTICLES As New List(Of ARTICLE)

        If Articles.Count <> 0 Then

            For i As Integer = 0 To Articles.Count - 1
                If Articles(i).ART_DESCRIPTION.Length >= P_DESCRIPTION.Length Then

                    If Articles(i).ART_DESCRIPTION.Substring(0, P_DESCRIPTION.Length).ToLower = P_DESCRIPTION.ToLower Then

                        If Articles(i).ART_TYPE.Length >= P_TYPE.Length Then
                            If Articles(i).ART_TYPE.Substring(0, P_TYPE.Length).ToLower = P_TYPE.ToLower Then
                                o_ARTICLES.Add(Articles(i))
                            End If

                        End If

                    End If

                End If
            Next

        End If

        Return o_ARTICLES

    End Function



#End Region



End Class
