Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Image
Public Class CODE_BARE

#Region "Attributs"

    Private Shared CodeBarres As New List(Of CODE_BARE)

    Private _CB_ID As Integer
    Private _CB_TYPE As String
    Private _CB_ACTIVE As Boolean
    Private _Img_CB As Byte()
    Private _Lib_CB As String
    Private _ArticlesOfCodeBarre As List(Of ARTICLE)

#End Region

#Region "Propriété"

    Public Property CB_ID() As Integer
        Get
            Return _CB_ID
        End Get
        Set(ByVal value As Integer)
            _CB_ID = value
        End Set
    End Property



    Public Property CB_TYPE() As String
        Get
            Return _CB_TYPE
        End Get
        Set(ByVal value As String)
            _CB_TYPE = value
        End Set
    End Property

    Public Property CB_ACTIVE() As Boolean
        Get
            Return _CB_ACTIVE
        End Get
        Set(ByVal value As Boolean)
            _CB_ACTIVE = value
        End Set
    End Property



    Public Property Img_CB() As Byte()
        Get
            Return _Img_CB
        End Get
        Set(ByVal value As Byte())
            _Img_CB = value
        End Set
    End Property





    Public Property Lib_CB() As String
        Get
            Return _Lib_CB
        End Get
        Set(ByVal value As String)
            _Lib_CB = value
        End Set
    End Property




    Public Property ArticlesOfCodeBarre() As List(Of ARTICLE)
        Get
            Return _ArticlesOfCodeBarre
        End Get
        Set(ByVal value As List(Of ARTICLE))
            _ArticlesOfCodeBarre = value
        End Set
    End Property

#End Region

#Region "Constructeur"

    Public Sub New()

        Me.CB_ID = 0
        Me.CB_TYPE = ""
        Me.CB_ACTIVE = False
        ArticlesOfCodeBarre = New List(Of ARTICLE)
    End Sub

    Public Sub New(ByVal P_CB_ID As Integer, ByVal P_CB_TYPE As String, ByVal P_CB_ACTIVE As Boolean)
        Me.CB_ID = P_CB_ID
        Me.CB_TYPE = P_CB_TYPE
        Me.CB_ACTIVE = P_CB_ACTIVE
        ArticlesOfCodeBarre = New List(Of ARTICLE)
    End Sub

#End Region

#Region "DAL"

    Private Sub Ajouter_DAL()

        Dim dr As DataRow = ds.CODE_BARE.NewRow

        dr(0) = Me.CB_ID
        dr(1) = Me.CB_TYPE
        dr(2) = Me.CB_ACTIVE
        dr(3) = Me.Img_CB
        dr(4) = Me.Lib_CB

        ds.CODE_BARE.Rows.Add(dr)

    End Sub

    Private Sub Modifier_DAL()

        Dim dr As DataRow = ds.CODE_BARE.Select("CB_ID=" & Me.CB_ID)(0)

        dr(1) = Me.CB_TYPE
        dr(2) = Me.CB_ACTIVE
        dr(3) = Me.Img_CB
        dr(4) = Me.Lib_CB
    End Sub

    Private Sub supprimer_DAL()

        Dim dr As DataRow = ds.CODE_BARE.Select("CB_ID=" & Me.CB_ID)(0)
        dr.Delete()

    End Sub


#End Region

#Region "BAL"

    Public Sub Ajouter()

        Actualiser()
        Me.CB_ID = Generer_ID(ds.CODE_BARE, "CB_ID")
        FrmArticle.lblCodeBarre.Tag = Me.CB_ID
        CodeBarres.Add(Me)
        Me.Ajouter_DAL()
        Enregistrer(Da_Code_Bare, ds.CODE_BARE)

    End Sub

    Public Sub Modifier()

        Actualiser()
        'Me.CB_ID = Generer_ID(ds.CODE_BARE, "CB_ID")
        CodeBarres(RechercherPosCode_Barre(CB_ID)) = Me
        Me.Modifier_DAL()
        Enregistrer(Da_Code_Bare, ds.CODE_BARE)

    End Sub

    Public Sub Supprimer()

        Actualiser()
        CodeBarres.RemoveAt(RechercherPosCode_Barre(CB_ID))
        Me.supprimer_DAL()
        Enregistrer(Da_Code_Bare, ds.CODE_BARE)

    End Sub

#End Region

#Region "Function"

    Private Function RechercherPosCode_Barre(ByVal CB_ID As Integer) As Integer

        For i As Integer = 0 To CodeBarres.Count - 1
            If CodeBarres(i).CB_ID = CB_ID Then
                Return i
            End If
        Next
        Return -1

    End Function

    Public Function Actualiser_Liste() As List(Of CODE_BARE)

        Actualiser_DataTable(Da_Code_Bare, "SELECT * FROM Code_Bare", ds.CODE_BARE)

        If ds.CODE_BARE.Rows.Count = 0 Then
            Return Nothing
        End If
        CodeBarres.Clear()

        Dim O_CodeBare As CODE_BARE

        For i As Integer = 0 To ds.CODE_BARE.Rows.Count - 1

            O_CodeBare = New CODE_BARE

            O_CodeBare.CB_ID = ds.CODE_BARE.Item(i).CB_ID
            O_CodeBare.CB_TYPE = ds.CODE_BARE.Item(i).CB_TYPE
            O_CodeBare.CB_ACTIVE = ds.CODE_BARE.Item(i).CB_ACTIVE
            O_CodeBare.Img_CB = ds.CODE_BARE.Item(i).Img_CB
            O_CodeBare.Lib_CB = ds.CODE_BARE.item(i).Lib_CB
            CodeBarres.Add(O_CodeBare)
        Next

        Return CodeBarres

    End Function


    Public Sub Actualiser()

        Actualiser_DataTable(Da_Code_Bare, "SELECT * FROM CODE_BARE", ds.CODE_BARE)
        Actualiser_Liste()

    End Sub


    Public Function Rechercher_Par_type(ByVal P_Type As String) As List(Of CODE_BARE)

        Actualiser_Liste()

        Dim ListeCodeBarres As New List(Of CODE_BARE)

        If CodeBarres.Count <> 0 Then

            For i As Integer = 0 To CodeBarres.Count - 1
                If CodeBarres(i).CB_TYPE.Length >= P_Type.Length Then

                    If CodeBarres(i).CB_TYPE.Substring(0, P_Type.Length).ToLower = P_Type.ToLower Then

                        ListeCodeBarres.Add(CodeBarres(i))

                    End If

                End If
            Next

        End If

        Return ListeCodeBarres

    End Function


    Public Function Rechercher_Par_CodeBarre_Active(ByVal P_Active As String) As List(Of CODE_BARE)

        Actualiser_Liste()

        Dim ListeCodeBarres As New List(Of CODE_BARE)

        If CodeBarres.Count <> 0 Then

            For i As Integer = 0 To CodeBarres.Count - 1


                If CodeBarres(i).CB_TYPE = P_Active Then

                    ListeCodeBarres.Add(CodeBarres(i))

                End If


            Next

        End If

        Return ListeCodeBarres

    End Function
#End Region


End Class
