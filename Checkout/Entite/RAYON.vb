Public Class RAYON



#Region "Declaration..."



    Private Shared Rayons As New List(Of RAYON)

    Private _FamillesofRayon As List(Of FAMILLE)

    Private _Ray_ID As Integer
    Private _Ray_Lib As String



#End Region



#Region "Propriété..."



    Public Property Ray_ID() As Integer
        Get
            Return _Ray_ID
        End Get
        Set(ByVal value As Integer)
                _Ray_ID = value
        End Set
    End Property





    Public Property Ray_Lib() As String
        Get
            Return _Ray_Lib
        End Get
        Set(ByVal value As String)
                _Ray_Lib = value
        End Set
    End Property



    Public Property FamilleofRayo() As List(Of FAMILLE)
        Get
            Return _FamillesofRayon
        End Get
        Set(ByVal value As List(Of FAMILLE))
            _FamillesofRayon = value
        End Set
    End Property




#End Region



#Region "Contructeur / Destructeur..."


    Public Sub New()

        Ray_ID = 0
        Ray_Lib = ""
        FamilleofRayo = New List(Of FAMILLE)

    End Sub


    Public Sub New(ByVal P_Ray_ID As Integer, ByVal P_Ray_Lib As String)

        Ray_ID = P_Ray_ID
        Ray_Lib = P_Ray_Lib

        FamilleofRayo = New List(Of FAMILLE)

    End Sub


#End Region



#Region "BAL..."



    Public Sub Ajouter()

        Actualiser()

        Ray_ID = Generer_ID(ds.RAYON, "Ray_ID")
        Rayons.Add(Me)
        Me.Ajouter_DAL()

        Enregistrer(Da_Rayon, Ds.RAYON)


    End Sub


    Public Sub Modifier()

        Actualiser()

        Rayons(Rechercher_Par_Id(Me.Ray_ID)) = Me
        Me.Modifier_DAL()

        Enregistrer(Da_Rayon, Ds.RAYON)

    End Sub


    Public Sub Supprimer()

        Actualiser()

        Rayons.RemoveAt(Rechercher_Par_Id(Me.Ray_ID))
        Me.Supprimer_DAL()

        Enregistrer(Da_Rayon, Ds.RAYON)

    End Sub




#End Region



#Region "DAL..."


    Private Sub Ajouter_DAL()

        Dim Dr As DataRow = Ds.RAYON.NewRow

        Dr(0) = Me.Ray_ID
        Dr(1) = Me.Ray_Lib
        Ds.RAYON.Rows.Add(Dr)

    End Sub



    Private Sub Modifier_DAL()

        Dim Dr As DataRow = Ds.RAYON.Select("RAY_ID=" & Me.Ray_ID)(0)

        Dr(1) = Me.Ray_Lib

    End Sub



    Private Sub Supprimer_DAL()

        Dim Dr As DataRow = Ds.RAYON.Select("RAY_ID=" & Me.Ray_ID)(0)

        Dr.Delete()

    End Sub


#End Region



#Region "Methodes"


    'Recherche Rayon Par ID
    Private Function Rechercher_Par_Id(ByVal P_Id As Integer) As Integer

        If Rayons.Count <> 0 Then
            For i As Integer = 0 To Rayons.Count - 1
                If Rayons(i).Ray_ID = P_Id Then
                    Return i
                End If
            Next
        End If
        Return -1

    End Function




    'Actualiser Col
    Public Function Actualiser_Liste() As List(Of RAYON)

        Actualiser_DataTable(Da_Rayon, "SELECT * FROM  RAYON", Ds.RAYON)

        If Ds.RAYON.Rows.Count = 0 Then
            Return Nothing
        End If
        Rayons.Clear()

        For i As Integer = 0 To Ds.RAYON.Rows.Count - 1

            Dim O_Rayon As New RAYON

            O_Rayon.Ray_ID = ds.RAYON.Item(i).RAY_ID
            O_Rayon.Ray_Lib = ds.RAYON.Item(i).RAY_LIB

            Rayons.Add(O_Rayon)

        Next

        Return Rayons

    End Function




    'Actualiser DT & Col
    Private Sub Actualiser()

        Actualiser_DataTable(Da_Rayon, "SELECT * FROM  RAYON", Ds.RAYON)
        Actualiser_Liste()

    End Sub

    Public Function Rechercher_Par_Libelé(ByVal P_Libelé As String) As List(Of RAYON)

        Actualiser_Liste()

        Dim O_Rayon As New List(Of RAYON)

        If Rayons.Count <> 0 Then

            For i As Integer = 0 To Rayons.Count - 1

                If Rayons(i).Ray_Lib.Length >= P_Libelé.Length Then

                    If Rayons(i).Ray_Lib.Substring(0, P_Libelé.Length).ToLower = P_Libelé.ToLower Then

                        O_Rayon.Add(Rayons(i))
                    End If

                End If
            Next

        End If

        Return O_Rayon

    End Function


#End Region




End Class
