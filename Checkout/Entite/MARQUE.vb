Public Class MARQUE



#Region "Declaration..."


    Private Shared Marques As New List(Of MARQUE)

    Private _Mrq_Id As Integer
    Private _SousFamilleofMarques As SOUS_FAMILLE
    Private _Mrq_Lib As String

    Private _MarqueOfArticle As List(Of ARTICLE)

#End Region



#Region "Propriété..."



    Public Property Mrq_Id() As Integer
        Get
            Return _Mrq_Id
        End Get
        Set(ByVal value As Integer)
            _Mrq_Id = value
        End Set
    End Property





    Public Property SousFamilleofMarques() As SOUS_FAMILLE
        Get
            Return _SousFamilleofMarques
        End Get
        Set(ByVal value As SOUS_FAMILLE)
            _SousFamilleofMarques = value
        End Set

    End Property





    Public Property Mrq_Lib() As String
        Get
            Return _Mrq_Lib
        End Get
        Set(ByVal value As String)
            _Mrq_Lib = value
        End Set
    End Property




    Public Property MarqueOfArticle() As List(Of ARTICLE)
        Get
            Return _MarqueOfArticle
        End Get
        Set(ByVal value As List(Of ARTICLE))
            _MarqueOfArticle = value
        End Set
    End Property




#End Region



#Region "Contructeur / Destructeur..."



    Public Sub New()

        Mrq_Id = 0
        Mrq_Lib = ""
        MarqueOfArticle = New List(Of ARTICLE)
        SousFamilleofMarques = New SOUS_FAMILLE

    End Sub



    Public Sub New(ByVal P_MRQ_ID As Integer, ByVal P_Mrq_Lib As String)

        MRQ_ID = P_MRQ_ID
        Mrq_Lib = P_Mrq_Lib
        MarqueOfArticle = New List(Of ARTICLE)
        SousFamilleofMarques = New SOUS_FAMILLE

    End Sub



#End Region



#Region "BAL..."


    Public Sub Ajouter()

        Actualiser()

        Me.Mrq_Id = Generer_ID(ds.MARQUE, "MRQ_ID")
        Marques.Add(Me)
        Ajouter_DAL()

        Enregistrer(Da_Marque, Ds.MARQUE)
    End Sub


    Public Sub Modifier()

        Actualiser()

        Marques(Rechercher_Par_Id(Me.Mrq_Id)) = Me

        Modifier_DAL()

        Enregistrer(Da_Marque, Ds.MARQUE)
    End Sub


    Public Sub Suppimer()

        Actualiser()

        Marques.RemoveAt(Rechercher_Par_Id(Me.Mrq_Id))
        Supprimer_DAL()

        Enregistrer(Da_Marque, Ds.MARQUE)

    End Sub


#End Region



#Region "DAL..."




    Private Sub Ajouter_DAL()

        Dim Dr As DataRow = Ds.MARQUE.NewRow

        Dr(0) = Me.Mrq_Id
        Dr(1) = Me.SousFamilleofMarques.SF_ID
        Dr(2) = Me.Mrq_Lib

        Ds.MARQUE.Rows.Add(Dr)

    End Sub



    Private Sub Modifier_DAL()

        Dim Dr As DataRow = Ds.MARQUE.Select("MRQ_ID=" & Me.Mrq_Id)(0)
        Dr(1) = Me.SousFamilleofMarques.SF_ID
        Dr(2) = Me.Mrq_Lib

    End Sub


    Private Sub Supprimer_DAL()

        Dim Dr As DataRow = Ds.MARQUE.Select("MRQ_ID=" & Me.Mrq_Id)(0)
        Dr.Delete()

    End Sub


#End Region



#Region "Methodes"


  

    Public Function Rechercher_Par_Id(ByVal P_Id As Integer) As Integer

        If Marques.Count <> 0 Then
            For i As Integer = 0 To Marques.Count - 1
                If Marques(i).Mrq_Id = P_Id Then
                    Return i
                End If
            Next
        End If
        Return -1

    End Function



    Public Function Actualiser_Liste() As List(Of MARQUE)

        Actualiser_DataTable(Da_Marque, "SELECT * FROM MARQUE", ds.MARQUE)

        If Ds.MARQUE.Rows.Count = 0 Then
            Return Nothing
        End If

        Marques.Clear()

     
        For i As Integer = 0 To Ds.MARQUE.Rows.Count - 1


            Dim O_Marque As New MARQUE

            O_Marque.Mrq_Id = ds.MARQUE.Item(i).MRQ_ID
            O_Marque.SousFamilleofMarques.SF_ID = ds.MARQUE.Item(i).SF_ID
            O_Marque.Mrq_Lib = ds.MARQUE.Item(i).MRQ_LIB

            Marques.Add(O_Marque)

        Next

        Return Marques

    End Function



    Public Sub Actualiser()

        Actualiser_DataTable(Da_Marque, "SELECT * FROM MARQUE", Ds.MARQUE)
        Actualiser_Liste()

    End Sub


    Public Function Rechercher_Par_Libelle(ByVal P_Libelle As String) As List(Of MARQUE)

        Actualiser_Liste()

        Dim ListeOfMarque As New List(Of MARQUE)

        If Marques.Count <> Nothing Then

            For i As Integer = 0 To Marques.Count - 1
                If Marques(i).Mrq_Lib.Length >= P_Libelle.Length Then

                    If Marques(i).Mrq_Lib.Substring(0, P_Libelle.Length).ToLower = P_Libelle.ToLower Then
                        ListeOfMarque.Add(Marques(i))
                    End If

                End If
            Next

        End If

        Return ListeOfMarque

    End Function

#End Region



End Class
