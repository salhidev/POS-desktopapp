Public Class FAMILLE



#Region "Declaration..."



    Private Shared Familles As New List(Of FAMILLE)

    Private _SousFamilleOFamille As List(Of SOUS_FAMILLE)
    Private _Fml_Id As Integer
    Private _FamilleofRayon As RAYON
    Private _Fml_Lib As String


#End Region



#Region "Propriété..."



    Public Property Fml_Id() As Integer
        Get
            Return _Fml_Id
        End Get
        Set(ByVal value As Integer)
            If (_Fml_Id <> value) Then
                _Fml_Id = value
            End If

        End Set
    End Property





    Public Property FamilleofRayon() As RAYON
        Get
            Return _FamilleofRayon
        End Get
        Set(ByVal value As RAYON)
            _FamilleofRayon = value
        End Set
    End Property




    Public Property Fml_Lib() As String
        Get
            Return _Fml_Lib
        End Get
        Set(ByVal value As String)
            If (_Fml_Lib <> value) Then
                _Fml_Lib = value
            End If

        End Set
    End Property




    Public Property SousFamilleofFamille() As List(Of SOUS_FAMILLE)
        Get
            Return _SousFamilleOFamille
        End Get
        Set(ByVal value As List(Of SOUS_FAMILLE))
            _SousFamilleOFamille = value
        End Set
    End Property





#End Region



#Region "Contructeur / Destructeur..."



    Public Sub New()

        Fml_Id = 0
        Fml_Lib = ""

        SousFamilleofFamille = New List(Of SOUS_FAMILLE)
        FamilleofRayon = New RAYON

    End Sub


    Public Sub New(ByVal P_Fml_Id As Integer, ByVal P_Fml_Lib As String)

        Fml_Id = P_Fml_Id
        Fml_Lib = P_Fml_Lib

        SousFamilleofFamille = New List(Of SOUS_FAMILLE)
        FamilleofRayon = New RAYON

    End Sub


#End Region



#Region "BAL..."



    Public Sub Ajouter()

        Actualiser()

        Me.Fml_Id = Generer_ID(ds.FAMILLE, "Fml_Id")
        Familles.Add(Me)
        Ajouter_DAL()

        Enregistrer(Da_Famille, Ds.FAMILLE)


    End Sub


    Public Sub Modifier()

        Actualiser()

        Familles(Rechercher_Par_Id(Me.Fml_Id)) = Me
        Modifier_DAL()

        Enregistrer(Da_Famille, Ds.FAMILLE)

    End Sub


    Public Sub Supprimer()

        Actualiser()

        Familles.RemoveAt(Rechercher_Par_Id(Me.Fml_Id))
        Supprimer_DAL()

        Enregistrer(Da_Famille, Ds.FAMILLE)

    End Sub



#End Region



#Region "DAL..."



    Private Sub Ajouter_DAL()

        Dim Dr As DataRow = Ds.FAMILLE.NewRow

        Dr(0) = Me.Fml_Id
        Dr(1) = Me.FamilleofRayon.Ray_ID
        Dr(2) = Me.Fml_Lib

        Ds.FAMILLE.Rows.Add(Dr)

    End Sub


    Private Sub Modifier_DAL()

        Dim Dr As DataRow = Ds.FAMILLE.Select("FML_ID=" & Me.Fml_Id)(0)

        Dr(1) = Me.FamilleofRayon.Ray_ID
        Dr(2) = Me.Fml_Lib

    End Sub


    Private Sub Supprimer_DAL()


        Dim Dr As DataRow = Ds.FAMILLE.Select("FML_ID=" & Me.Fml_Id)(0)
        Dr.Delete()

    End Sub



#End Region



#Region "Methodes"







    'Rechercher Une Famille Par ID
    Private Function Rechercher_Par_Id(ByVal P_Id As Integer) As Integer

        If Familles.Count <> 0 Then
            For i As Integer = 0 To Familles.Count - 1
                If Familles(i).Fml_Id = P_Id Then
                    Return i
                End If
            Next
        End If
        Return -1

    End Function




    'Actualiser La  Liste
    Public Function Actualiser_Liste() As List(Of FAMILLE)

        Actualiser_DataTable(Da_Famille, "SELECT * FROM FAMILLE", Ds.FAMILLE)

        If Ds.RAYON.Rows.Count = 0 Then
            Return Nothing
        End If
        Familles.Clear()

        For i As Integer = 0 To Ds.FAMILLE.Rows.Count - 1



            Dim O_Famille As New FAMILLE

            O_Famille.Fml_Id = ds.FAMILLE.Item(i).FML_ID
            O_Famille.FamilleofRayon.Ray_ID = ds.FAMILLE.Item(i).RAY_ID
            O_Famille.Fml_Lib = ds.FAMILLE.Item(i).FML_LIB

            Familles.Add(O_Famille)

        Next

        Return Familles

    End Function




    'Actualiser DT & Col
    Public Sub Actualiser()

        Actualiser_DataTable(Da_Famille, "SELECT * FROM FAMILLE", Ds.FAMILLE)
        Actualiser_Liste()

    End Sub

    Public LibelleOfRayon As String
    Public Function Rechercher_Par_Libelé(ByVal P_Libelé As String) As List(Of FAMILLE)

        Actualiser_Liste()

        Dim O_Famille As New List(Of FAMILLE)

        Dim O_rayon As New RAYON
        Dim Rayons As New List(Of RAYON)
        Rayons = O_rayon.Actualiser_Liste
        Dim id_Rayon As Integer
        If Familles.Count <> 0 Then

            For i As Integer = 0 To Familles.Count - 1

                If Familles(i).Fml_Lib.Length >= P_Libelé.Length Then

                    If Familles(i).Fml_Lib.Substring(0, P_Libelé.Length).ToLower = P_Libelé.ToLower Then

                        O_Famille.Add(Familles(i))

                        id_Rayon = Familles(i).FamilleofRayon.Ray_ID
                    End If

                End If
            Next

        End If

        If Rayons.Count <> 0 Then

            For j As Integer = 0 To Rayons.Count - 1

                If Rayons.Item(j).Ray_ID = id_Rayon Then
                    LibelleOfRayon = Rayons.Item(j).Ray_Lib

                End If
            Next

        End If

        Return O_Famille

    End Function





#End Region



End Class
