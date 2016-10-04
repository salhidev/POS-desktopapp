Public Class TARIF_OF_ARTICLE


#Region "Declaration..."


   

    Private _ArticleOfTarifeOfArticle As List(Of ARTICLE)
    Private _TarifofTarifOfArticle As List(Of TARIF)

    Private _PrixAchat As Double
    Private _PrixVente As Double

#End Region



#Region "Propriété..."




    Public Property TarifofTarifOfArticle() As List(Of TARIF)
        Get
            Return _TarifofTarifOfArticle
        End Get
        Set(ByVal value As List(Of TARIF))
            _TarifofTarifOfArticle = value
        End Set
    End Property

    Public Property ArticleOfTarifeOfArticle() As List(Of ARTICLE)
        Get
            Return _ArticleOfTarifeOfArticle
        End Get
        Set(ByVal value As List(Of ARTICLE))
            _ArticleOfTarifeOfArticle = value
        End Set
    End Property

    Public Property PrixAchat() As Double
        Get
            Return _PrixAchat
        End Get
        Set(ByVal value As Double)
            If (_PrixAchat <> value) Then
                _PrixAchat = value
            End If

        End Set
    End Property

    Public Property PrixVente() As Double
        Get
            Return _PrixVente
        End Get
        Set(ByVal value As Double)
            If (_PrixVente <> value) Then
                _PrixVente = value
            End If
        End Set
    End Property





#End Region



#Region "Contructeur / Destructeur..."


    Public Sub New()

        PrixVente = 0
        PrixAchat = 0

        ArticleOfTarifeOfArticle = New List(Of ARTICLE)
        TarifofTarifOfArticle = New List(Of TARIF)

    End Sub



    Public Sub New(ByVal P_PrixAchat As Double, ByVal P_PrixVente As Double)


        ArticleOfTarifeOfArticle = New List(Of ARTICLE)
        TarifofTarifOfArticle = New List(Of TARIF)

    End Sub


#End Region



#Region "BAL..."

    Public Sub Ajouter()

        Ajouter_DAL()
        Enregistrer(Da_Tarif_Of_Article, Ds.TARIF_OF_ARTICLE)

    End Sub

   

    Public Sub Supprimer()


        Supprimer_DAL()
        Enregistrer(Da_Tarif_Of_Article, ds.TARIF_OF_ARTICLE)

    End Sub


#End Region



#Region "DAL..."



    Private Sub Ajouter_DAL()

        
        Dim dr As DataRow = Ds.TARIF_OF_ARTICLE.NewRow
       
        dr(0) = Me.ArticleOfTarifeOfArticle.Item(Me.ArticleOfTarifeOfArticle.Count - 1).ART_ID
        dr(1) = Me.TarifofTarifOfArticle.Item(Me.TarifofTarifOfArticle.Count - 1).Trf_ID
        dr(2) = Me.PrixAchat
        dr(3) = Me.PrixVente
        ds.TARIF_OF_ARTICLE.Rows.Add(dr)


    End Sub




    Private Sub Supprimer_DAL()

        For i As Integer = 0 To FrmArticle.DgvTarifOfArticle.Rows.Count - 1

            Dim dr As DataRow = ds.TARIF_OF_ARTICLE.Select("ART_ID = " & FrmArticle.Tag)(0)
            dr.Delete()

        Next



    End Sub



#End Region



#Region "Methodes"



    Public Sub Actualiser_ListeArticle()

        Actualiser_DataTable(Da_Article, "SELECT * FROM ARTICLE", ds.ARTICLE)

        TarifofTarifOfArticle.Clear()

        If ds.ARTICLE.Rows.Count = 0 Then
            Exit Sub
        End If

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

            Me.ArticleOfTarifeOfArticle.Add(O_Article)

        Next

        'MsgBox(Me.ArticleOfTarifeOfArticle.Count)



    End Sub


    'Rechercher  la  Position  du  Tarif d'un Article 
    Public Function Rechercher_Id_Tarif(ByVal P_Id As Integer) As Integer

        If TarifofTarifOfArticle.Count <> 0 Then
            For i As Integer = 0 To TarifofTarifOfArticle.Count - 1
                If TarifofTarifOfArticle(i).Trf_ID = P_Id Then
                    Return i
                End If
            Next
        End If
        Return -1

    End Function


    'Rechercher  la  Position  du  Tarif d'un Article 
    Public Function Rechercher_Id_Article(ByVal P_Id As Integer) As Integer

        If ArticleOfTarifeOfArticle.Count <> 0 Then
            For i As Integer = 0 To ArticleOfTarifeOfArticle.Count - 1
                If ArticleOfTarifeOfArticle(i).ART_ID = P_Id Then
                    Return i
                End If
            Next
        End If
        Return -1

    End Function

    'Public Sub Ajouter_IDOfTarif()

    '    Dim dr As DataRow = Ds.TARIF_OF_ARTICLE.NewRow

    '    Dim O_Tarif As New TARIF
    '    For i As Integer = 0 To TarifofTarifOfArticle.Count - 1

    '        dr(0) = O_Tarif.Trf_ID
    '        dr(1) = TarifofTarifOfArticle.Item(i).Trf_ID

    '    Next

    'End Sub

    'Public Function Actualiser_Liste() As List(Of TARIF)

    '    Actualiser_DataTable(Da_Tarif_Of_Article, "SELECT * FROM TARIF_Of_Article", ds.TARIF_OF_ARTICLE)
    '    'Actualiser_DataTable(Da_Tarif_Of_Article, "SELECT * FROM TARIF_Of_Article", ds.TARIF_OF_ARTICLE)

    '    If ds.TARIF_OF_ARTICLE.Rows.Count = 0 Then
    '        Return Nothing
    '    End If

    '    ArticleOfTarifeOfArticle.Clear()

    '    For i As Integer = 0 To ds.TARIF_OF_ARTICLE.Rows.Count - 1





    '        Me.ArticleOfTarifeOfArticle.Item(i).ART_ID = ds.TARIF_OF_ARTICLE.Item(i).ART_ID
    '        Me.TarifofTarifOfArticle.Item(i).Trf_ID = ds.TARIF_OF_ARTICLE.Item(i).TRF_ID


    '        ArticleOfTarifeOfArticle.Add(Me)

    '    Next

    '    Return ArticleOfTarifeOfArticle

    'End Function


    Public Sub Ajouter_IDOfArticle()

        Dim dr As DataRow = Ds.TARIF_OF_ARTICLE.NewRow

        Dim O_Article As New ARTICLE

        For i As Integer = 0 To ds.TARIF_OF_ARTICLE.Count - 1

            dr(0) = O_Article.ART_ID
            dr(1) = Me.ArticleOfTarifeOfArticle.Item(i).ART_ID

        Next

    End Sub

    Public Sub Ajouter_tarifOfarticle()


        Dim dr As DataRow = Ds.TARIF_OF_ARTICLE.NewRow
        dr(0) = Me.TarifofTarifOfArticle(0).Trf_ID
        dr(1) = Me.ArticleOfTarifeOfArticle(0).ART_ID
        dr(2) = Me.PrixAchat
        dr(3) = Me.PrixVente
        Ds.TARIF_OF_ARTICLE.Rows.Add(dr)

        MsgBox("Bien Ajouter")

    End Sub
   





   

#End Region



End Class
