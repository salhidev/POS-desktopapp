Public Class TARIF



#Region "Declaration..."




    Private Shared Tarifs As New List(Of TARIF)


    Private _Trf_ID As Integer
    Private _Trf_Libelle As String
    Private _Trf_Coefficient As Double



    Private _TarifOfArticleOfTarif As TARIF_OF_ARTICLE



#End Region



#Region "Propriété..."



    Public Property Trf_ID() As Integer
        Get
            Return _Trf_ID
        End Get
        Set(ByVal value As Integer)

            _Trf_ID = value

        End Set
    End Property





    Public Property Trf_Libelle() As String
        Get
            Return _Trf_Libelle
        End Get
        Set(ByVal value As String)

            _Trf_Libelle = value

        End Set
    End Property





    Public Property Trf_Coefficient() As Double
        Get
            Return _Trf_Coefficient
        End Get
        Set(ByVal value As Double)
            _Trf_Coefficient = value
        End Set
    End Property





    Public Property TarifOfArticleOfTarif() As TARIF_OF_ARTICLE
        Get
            Return _TarifOfArticleOfTarif
        End Get
        Set(ByVal value As TARIF_OF_ARTICLE)
            _TarifOfArticleOfTarif = value
        End Set
    End Property




#End Region



#Region "Contructeur / Destructeur..."



    Public Sub New()
        Trf_ID = 0
        Trf_Libelle = ""
        Trf_Coefficient = 0

        TarifOfArticleOfTarif = New TARIF_OF_ARTICLE

    End Sub


    Public Sub New(ByVal P_Trf_ID As Integer, ByVal P_Trf_Libelle As String, ByVal P_Trf_Coefficient As Double)

        Trf_ID = P_Trf_ID
        Trf_Libelle = P_Trf_Libelle
        Trf_Coefficient = P_Trf_Coefficient


        TarifOfArticleOfTarif = New TARIF_OF_ARTICLE

    End Sub


#End Region



#Region "BAL..."



    Public Sub Ajouter()

        Actualiser()

        Me.Trf_ID = Generer_ID(ds.TARIF, "TRF_ID")
        Me.TarifOfArticleOfTarif.TarifofTarifOfArticle.Add(Me)
        Tarifs.Add(Me)
        Me.Ajouter_DAL()

        Enregistrer(Da_Tarif, Ds.TARIF)

    End Sub


    Public Sub Modifier()

        Actualiser()

        Tarifs(Rechercher_Par_Id(Me.Trf_ID)) = Me

        Me.Modifier_DAL()

        Enregistrer(Da_Tarif, Ds.TARIF)

    End Sub


    Public Sub Supprimer()

        Actualiser()

        Tarifs.RemoveAt(Rechercher_Par_Id(Me.Trf_ID))

        Me.Supprimer_DAL()

        Enregistrer(Da_Tarif, Ds.TARIF)

    End Sub



#End Region




#Region "DAL..."




    Private Sub Ajouter_DAL()

        Dim Dr As DataRow = Ds.TARIF.NewRow

        Dr(0) = Me.Trf_ID
        Dr(1) = Me.Trf_Libelle
        Dr(2) = Me.Trf_Coefficient

        Ds.TARIF.Rows.Add(Dr)

    End Sub




    Private Sub Modifier_DAL()

        Dim Dr As DataRow = Ds.TARIF.Select("TRF_ID=" & Me.Trf_ID)(0)

        Dr(1) = Me.Trf_Libelle
        Dr(2) = Me.Trf_Coefficient

    End Sub




    Private Sub Supprimer_DAL()

        Dim Dr As DataRow = Ds.TARIF.Select("TRF_ID=" & Me.Trf_ID)(0)

        Dr.Delete()

    End Sub




#End Region



#Region "Methodes"


    Public Sub Actualiser()

        Actualiser_DataTable(Da_Tarif, "SELECT * FROM TARIF", Ds.TARIF)
        Actualiser_Liste()

    End Sub

    Public Function Rechercher_Par_Id(ByVal P_Id As Integer) As Integer

        If Tarifs.Count <> 0 Then
            For i As Integer = 0 To Tarifs.Count - 1
                If Tarifs(i).Trf_ID = P_Id Then
                    Return i
                End If
            Next
        End If
        Return -1

    End Function


    Public Function Actualiser_Liste() As List(Of TARIF)

        Actualiser_DataTable(Da_Tarif, "SELECT * FROM TARIF", ds.TARIF)

        If ds.TARIF.Rows.Count = 0 Then
            Return Nothing
        End If

        Tarifs.Clear()

        For i As Integer = 0 To ds.TARIF.Rows.Count - 1



            Dim O_TARIF As New TARIF

            O_TARIF.Trf_ID = ds.TARIF.Item(i).TRF_ID
            O_TARIF.Trf_Libelle = ds.TARIF.Item(i).TRF_LIBELE
            O_TARIF.Trf_Coefficient = ds.TARIF.Item(i).TRF_COEFFICIENT

            Tarifs.Add(O_TARIF)

        Next

        Return Tarifs

    End Function

    Public Function Rechercher_Par_Libelle(ByVal P_Libelle As String) As List(Of TARIF)

        Actualiser_Liste()

        Dim ListeOfTarif As New List(Of TARIF)

        If Tarifs.Count <> Nothing Then

            For i As Integer = 0 To Tarifs.Count - 1
                If Tarifs(i).Trf_Libelle.Length >= P_Libelle.Length Then

                    If Tarifs(i).Trf_Libelle.Substring(0, P_Libelle.Length).ToLower = P_Libelle.ToLower Then
                        ListeOfTarif.Add(Tarifs(i))
                    End If

                End If
            Next

        End If

        Return ListeOfTarif

    End Function


    Public Function Rechercher_Par_COEFFICIENT(ByVal P_COEFFICIENT As String) As List(Of TARIF)

        Actualiser_Liste()

        Dim ListeOfTarif As New List(Of TARIF)

        If Tarifs.Count <> Nothing Then
            If IsNumeric(P_COEFFICIENT) = True Then
                For i As Integer = 0 To Tarifs.Count - 1


                    If Tarifs(i).Trf_Coefficient = P_COEFFICIENT.ToLower Then
                        ListeOfTarif.Add(Tarifs(i))
                    End If


                Next
            End If
        End If

        Return ListeOfTarif

    End Function

#End Region



End Class
