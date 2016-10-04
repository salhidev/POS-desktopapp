Public Class CLOTURE

#Region "Attributs"

    Private Clotures As List(Of CLOTURE)

    Private _CLTR_ID As Integer
    Private _CLTR_DATE As Date
    Private _CLTR_ETAT As String
    Private _CLTR_FONDCAISSESOIR As Double
    Private _CLTR_CAISSE_REMARQUE As String

    Private _CAISSE As Caise

#End Region

#Region "Propriété"

    Public Property CLTR_ID() As Integer
        Get
            Return _CLTR_ID
        End Get
        Set(ByVal value As Integer)
            _CLTR_ID = value
        End Set
    End Property

    Public Property CLTR_DATE() As Date
        Get
            Return _CLTR_DATE
        End Get
        Set(ByVal value As Date)
            _CLTR_DATE = value
        End Set
    End Property

    Public Property CLTR_ETAT() As String
        Get
            Return _CLTR_ETAT
        End Get
        Set(ByVal value As String)
            _CLTR_ETAT = value
        End Set
    End Property

    Public Property CLTR_FONDCAISSESOIR() As Double
        Get
            Return _CLTR_FONDCAISSESOIR
        End Get
        Set(ByVal value As Double)
            _CLTR_FONDCAISSESOIR = value
        End Set
    End Property

    Public Property CLTR_CAISSE_REMARQUE() As String
        Get
            Return _CLTR_CAISSE_REMARQUE
        End Get
        Set(ByVal value As String)
            _CLTR_CAISSE_REMARQUE = value
        End Set
    End Property

    Public Property CAISSE() As Caise
        Get
            Return _CAISSE
        End Get
        Set(ByVal value As Caise)
            _CAISSE = value
        End Set
    End Property

#End Region

#Region "Constructeurs"

    Public Sub New()
        Me.CLTR_ID = 0
        Me.CLTR_DATE = Now.Date
        Me.CLTR_ETAT = ""
        Me.CLTR_FONDCAISSESOIR = 0
        Me.CLTR_CAISSE_REMARQUE = ""
        Me.CAISSE = New Caise
    End Sub

    Public Sub New(ByVal P_CLTR_ID As Integer, ByVal P_CLTR_DATE As Date, ByVal P_CLTR_ETAT As String, ByVal P_CLTR_FONDCAISSESOIR As Double, ByVal P_CLTR_CAISSE_REMARQUE As String)

        Me.CLTR_ID = P_CLTR_ID
        Me.CLTR_DATE = P_CLTR_DATE
        Me.CLTR_ETAT = P_CLTR_ETAT
        Me.CLTR_FONDCAISSESOIR = P_CLTR_FONDCAISSESOIR
        Me.CLTR_CAISSE_REMARQUE = P_CLTR_CAISSE_REMARQUE
        Me.CAISSE = New Caise

    End Sub

#End Region

#Region "DAL"

    Public Sub Ajouter_DAL()

        Dim dr As DataRow = Ds.CLOTURE.NewRow

        dr(0) = Me.CLTR_ID
        dr(1) = Me.CAISSE.CAISSE_ID
        dr(2) = Me.CLTR_DATE
        dr(3) = Me.CLTR_ETAT
        dr(4) = Me.CLTR_FONDCAISSESOIR
        dr(5) = Me.CLTR_CAISSE_REMARQUE

        Ds.CLOTURE.Rows.Add(dr)

    End Sub

    Public Sub Modifier_DAL()

        Dim dr As DataRow = Ds.CLOTURE.Select("CLTR_ID=" & Me.CLTR_ID)(0)

        dr(1) = Me.CAISSE.CAISSE_ID
        dr(2) = Me.CLTR_DATE
        dr(3) = Me._CLTR_ETAT
        dr(4) = Me._CLTR_FONDCAISSESOIR
        dr(5) = Me._CLTR_CAISSE_REMARQUE

    End Sub

    Public Sub Supprimer_DAL()

        Dim dr As DataRow = Ds.CLOTURE.Select("CLTR_ID=" & Me.CLTR_ID)(0)
        dr.Delete()

    End Sub

#End Region

#Region "BAL"


    Public Sub Ajouter()

        Actualiser()
        CLTR_ID = Generer_ID(ds.cloture, "CLTR_ID")
        Clotures.Add(Me)
        Me.Ajouter_DAL()
        Enregistrer(Da_Cloture, Ds.CLOTURE)

    End Sub

    Public Sub Modifier()

        Actualiser()
        Clotures(position(CLTR_ID)) = Me
        Me.Modifier_DAL()
        Enregistrer(Da_Cloture, Ds.CLOTURE)

    End Sub

    Public Sub Supprimer()

        Actualiser()
        Clotures.RemoveAt(position(CLTR_ID))
        Me.Supprimer_DAL()
        Enregistrer(Da_Cloture, Ds.CLOTURE)

    End Sub

#End Region

#Region "Functions"

    Private Function position(ByVal P_CLTR_ID As Integer) As Integer

        If Clotures.Count <> 0 Then
            For i As Integer = 0 To Clotures.Count - 1
                If Clotures(i).CLTR_ID = P_CLTR_ID Then
                    Return i
                End If
            Next
        End If
        Return -1

    End Function

    Public Sub ActualiserListe_Cloture()

        Actualiser_Datatable(Da_Cloture, "SELECT * FROM CLOTURE", ds.CLOTURE)


        If Ds.CLOTURE.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim O_Cloture As CLOTURE

        For i As Integer = 0 To Ds.CLOTURE.Rows.Count - 1

            O_Cloture = New CLOTURE

            O_Cloture.CLTR_ID = ds.CLOTURE.Item(i).CLTR_ID
            O_Cloture.CAISSE.CAISSE_ID = ds.CLOTURE.Item(i).CAISSE_ID
            O_Cloture.CLTR_DATE = ds.CLOTURE.Item(i).CLTR_DATE
            O_Cloture.CLTR_ETAT = ds.CLOTURE.Item(i).CLTR_ETAT
            O_Cloture.CLTR_FONDCAISSESOIR = ds.CLOTURE.Item(i).CLTR_FONDCAISSESOIR
            O_Cloture.CLTR_CAISSE_REMARQUE = ds.CLOTURE.Item(i).CLTR_CAISSE_REMARQUE

            Clotures.Add(O_Cloture)

        Next


    End Sub

    Public Function RetournerListe_Cloture() As List(Of CLOTURE)

        Actualiser_DataTable(Da_Cloture, "SELECT * FROM CLOTURE", ds.CLOTURE)


        If ds.CLOTURE.Rows.Count = 0 Then
            Return Nothing
        End If

        Dim O_Cloture As CLOTURE

        For i As Integer = 0 To ds.CLOTURE.Rows.Count - 1

            O_Cloture = New CLOTURE

            O_Cloture.CLTR_ID = ds.CLOTURE.Item(i).CLTR_ID
            O_Cloture.CAISSE.CAISSE_ID = ds.CLOTURE.Item(i).CAISSE_ID
            O_Cloture.CLTR_DATE = ds.CLOTURE.Item(i).CLTR_DATE
            O_Cloture.CLTR_ETAT = ds.CLOTURE.Item(i).CLTR_ETAT
            O_Cloture.CLTR_FONDCAISSESOIR = ds.CLOTURE.Item(i).CLTR_FONDCAISSESOIR
            O_Cloture.CLTR_CAISSE_REMARQUE = ds.CLOTURE.Item(i).CLTR_CAISSE_REMARQUE

            Clotures.Add(O_Cloture)

        Next

        Return Clotures

    End Function

    Public Sub Actualiser()

        Actualiser_Datatable(Da_Cloture, "SELECT * FROM CLOTURE", ds.CLOTURE)
        ActualiserListe_Cloture()

    End Sub

#End Region

End Class