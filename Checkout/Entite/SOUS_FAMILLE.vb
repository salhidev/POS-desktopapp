Public Class SOUS_FAMILLE



#Region "Declaration..."


    Private Shared SousFamilles As New List(Of SOUS_FAMILLE)

    Private _SF_ID As Integer
    Private _FamilleofSousFamille As FAMILLE
    Private _Sf_Lib As String

    Private _MarqueofSousFamille As List(Of Marque)




#End Region



#Region "Propriété..."




    Public Property SF_ID() As Integer
        Get
            Return _SF_ID
        End Get
        Set(ByVal value As Integer)
            If (_SF_ID <> value) Then
                _SF_ID = value
            End If
        End Set
    End Property





    Public Property FamilleofSousFamille() As FAMILLE
        Get
            Return _FamilleofSousFamille
        End Get
        Set(ByVal value As FAMILLE)
            _FamilleofSousFamille = value
        End Set
    End Property




    Public Property Sf_Lib() As String
        Get
            Return _Sf_Lib
        End Get
        Set(ByVal value As String)
            If (_Sf_Lib <> value) Then
                _Sf_Lib = value
            End If

        End Set
    End Property





    Public Property MarqueofSousFamille() As List(Of Marque)
        Get
            Return _MarqueofSousFamille
        End Get
        Set(ByVal value As List(Of Marque))
            _MarqueofSousFamille = value
        End Set
    End Property






#End Region



#Region "Contructeur / Destructeur..."



    Public Sub New()

        SF_ID = 0
        Sf_Lib = ""

        MarqueofSousFamille = New List(Of MARQUE)
        FamilleofSousFamille = New FAMILLE

    End Sub



    Public Sub New(ByVal P_SF_ID As Integer, ByVal P_Sf_Lib As String)

        SF_ID = P_SF_ID
        Sf_Lib = P_Sf_Lib

        MarqueofSousFamille = New List(Of MARQUE)
        FamilleofSousFamille = New FAMILLE

    End Sub



#End Region



#Region "BAL..."


    Public Sub Ajouter()

        Actualiser()

        Me.SF_ID = Generer_ID(ds.SOUS_FAMILLE, "SF_ID")
        SousFamilles.Add(Me)
        Ajouter_DAL()

        Enregistrer(Da_SousFamille, Ds.SOUS_FAMILLE)

    End Sub


    Public Sub Modifier()

        Actualiser()

        SousFamilles(Rechercher_Par_Id(Me.SF_ID)) = Me
        Modifier_DAL()

        Enregistrer(Da_SousFamille, Ds.SOUS_FAMILLE)

    End Sub


    Public Sub Supprimer()

        Actualiser()


        SousFamilles.RemoveAt(Rechercher_Par_Id(Me.SF_ID))
        Supprimer_DAL()

        Enregistrer(Da_SousFamille, Ds.SOUS_FAMILLE)

    End Sub

#End Region




#Region "DAL..."



    Private Sub Ajouter_DAL()

        Dim Dr As DataRow = Ds.SOUS_FAMILLE.NewRow

        Dr(0) = Me.SF_ID
        Dr(1) = Me.FamilleofSousFamille.Fml_Id
        Dr(2) = Me.Sf_Lib

        Ds.SOUS_FAMILLE.Rows.Add(Dr)

    End Sub



    Private Sub Modifier_DAL()

        Dim Dr As DataRow = Ds.SOUS_FAMILLE.Select("SF_ID=" & Me.SF_ID)(0)

        Dr(1) = Me.FamilleofSousFamille.Fml_Id
        Dr(2) = Me.Sf_Lib

    End Sub




    Private Sub Supprimer_DAL()

        Dim Dr As DataRow = Ds.SOUS_FAMILLE.Select("SF_ID=" & Me.SF_ID)(0)

        Dr.Delete()

    End Sub



#End Region



#Region "Methodes"




    Private Function Rechercher_Par_Id(ByVal P_Id As Integer) As Integer

        If SousFamilles.Count <> 0 Then
            For i As Integer = 0 To SousFamilles.Count - 1
                If SousFamilles(i).SF_ID = P_Id Then
                    Return i
                End If
            Next
        End If
        Return -1

    End Function

    Public Function Rechercher_Par_Libelle(ByVal P_Libelle As String) As List(Of SOUS_FAMILLE)

        Actualiser_Liste()
        Dim ListeOfSousFamilles As New List(Of SOUS_FAMILLE)

        If SousFamilles.Count <> Nothing Then

            For i As Integer = 0 To SousFamilles.Count - 1
                If SousFamilles(i).Sf_Lib.Length >= P_Libelle.Length Then

                    If SousFamilles(i).Sf_Lib.Substring(0, P_Libelle.Length).ToLower = P_Libelle.ToLower Then
                        ListeOfSousFamilles.Add(SousFamilles(i))
                    End If

                End If
            Next

        End If
        Return ListeOfSousFamilles
    End Function



    Public Function Actualiser_Liste() As List(Of SOUS_FAMILLE)

        Actualiser_DataTable(Da_SousFamille, "SELECT * FROM SOUS_FAMILLE", ds.SOUS_FAMILLE)

        If ds.SOUS_FAMILLE.Rows.Count = 0 Then
            Return Nothing
        End If

        SousFamilles.Clear()

        For i As Integer = 0 To ds.SOUS_FAMILLE.Rows.Count - 1

            Dim O_SousFamille As New SOUS_FAMILLE

            O_SousFamille.SF_ID = ds.SOUS_FAMILLE.Item(i).SF_ID
            O_SousFamille.FamilleofSousFamille.Fml_Id = ds.SOUS_FAMILLE.Item(i).FML_ID
            O_SousFamille.Sf_Lib = ds.SOUS_FAMILLE.Item(i).SF_LIB

            SousFamilles.Add(O_SousFamille)

        Next

        Return SousFamilles

    End Function



    Public Sub Actualiser()

        Actualiser_DataTable(Da_SousFamille, "SELECT * FROM SOUS_FAMILLE", ds.SOUS_FAMILLE)
        Actualiser_Liste()

    End Sub


#End Region



End Class
