Public Class TVA

#Region "Attributs"

    Private Lst_Tva As New List(Of TVA)

    Private _TVA_ID As Integer
    Private _TVA_TAUX As Double

    Private _ArticlesOfTVA As List(Of Article)

#End Region

#Region "Propriété"

    Public Property TVA_ID() As Integer
        Get
            Return _TVA_ID
        End Get
        Set(ByVal value As Integer)
            _TVA_ID = value
        End Set
    End Property

    Public Property TVA_TAUX() As Double
        Get
            Return _TVA_TAUX
        End Get
        Set(ByVal value As Double)
            _TVA_TAUX = value
        End Set
    End Property

    Public Property ArticlesOfTVA() As List(Of Article)
        Get
            Return _ArticlesOfTVA
        End Get
        Set(ByVal value As List(Of Article))
            _ArticlesOfTVA = value
        End Set
    End Property

#End Region

#Region "Constructeurs"

    Public Sub New()
        Me.TVA_ID = 0
        Me.TVA_TAUX = 0
        Me.ArticlesOfTVA = New List(Of Article)
    End Sub

    Public Sub New(ByVal ID As Integer, ByVal Taux As Double)

        Me.TVA_ID = ID
        Me.TVA_TAUX = Taux
        Me.ArticlesOfTVA = New List(Of Article)

    End Sub

#End Region

#Region "BAL"

    Public Sub Ajouter()

        Actualiser()
        TVA_ID = Generer_ID(ds.TVA, "TVA_ID")
        Lst_Tva.Add(Me)
        Me.Ajouter_DAL()
        Enregistrer(Da_TVA, Ds.TVA)

    End Sub

    Public Sub Modifier()

        Actualiser()
        Lst_Tva(position(TVA_ID)) = Me
        Me.Modifier_DAL()
        Enregistrer(Da_TVA, Ds.TVA)

    End Sub

    Public Sub Supprimer()

        Actualiser()
        Lst_Tva.RemoveAt(position(TVA_ID))
        Me.supprimer_DAL()
        Enregistrer(Da_TVA, Ds.TVA)

    End Sub

#End Region

#Region "DAL"

    Public Sub Ajouter_DAL()

        Dim dr As DataRow = Ds.TVA.NewRow

            dr(0) = Me.TVA_ID
        dr(1) = Me.TVA_TAUX

            Ds.TVA.Rows.Add(dr)

    End Sub

    Public Sub Modifier_DAL()

        Dim dr As DataRow = Ds.TVA.Select("TVA_ID=" & Me.TVA_ID)(0)

        dr(1) = Me.TVA_TAUX

    End Sub

    Public Sub supprimer_DAL()

        Dim dr As DataRow = Ds.CLIENT.Select("TVA_ID=" & Me.TVA_ID)(0)
        dr.Delete()

    End Sub

#End Region

#Region "Function"

    Private Function position(ByVal P_TVA_ID As Integer) As Integer

        If Lst_Tva.Count <> 0 Then
            For i As Integer = 0 To Lst_Tva.Count - 1
                If Lst_Tva(i).TVA_ID = P_TVA_ID Then
                    Return i
                End If
            Next
        End If
        Return -1

    End Function

    Public Sub ActualiserListe_TVA()

        Actualiser_DataTable(Da_TVA, "SELECT * FROM TVA", ds.TVA)

        If ds.TVA.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim O_TVA As TVA

        For i As Integer = 0 To ds.TVA.Rows.Count - 1

            O_TVA = New TVA
            O_TVA._TVA_ID = ds.TVA.Rows(i)(0)
            O_TVA._TVA_TAUX = ds.TVA.Rows(i)(1)

            Lst_Tva.Add(O_TVA)

        Next

    End Sub

    Public Function RetournerListe_TVA() As List(Of TVA)

        Actualiser_DataTable(Da_TVA, "SELECT * FROM TVA", ds.TVA)

        If ds.TVA.Rows.Count = 0 Then
            Return Nothing
        End If

        Dim O_TVA As TVA

        For i As Integer = 0 To ds.TVA.Rows.Count - 1

            O_TVA = New TVA
            O_TVA._TVA_ID = ds.TVA.Rows(i)(0)
            O_TVA._TVA_TAUX = ds.TVA.Rows(i)(1)

            Lst_Tva.Add(O_TVA)

        Next

        Return Lst_Tva

    End Function

    Public Sub Actualiser()

        Actualiser_Datatable(Da_TVA, "SELECT * FROM TVA", ds.TVA)
        ActualiserListe_TVA()

    End Sub
#End Region

End Class
