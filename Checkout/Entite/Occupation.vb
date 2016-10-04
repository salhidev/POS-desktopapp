Public Class OCCUPATION

#Region "Attributs"

    Private Occupations As New List(Of OCCUPATION)

    Private _OCP_ID As Integer
    Private _OCP_DATED As Date
    Private _OCP_DATEF As Date

    Private _O_Caissier As CAISSIER
    Private _O_Caisse As Caise

#End Region

#Region "Propriété"

    Public Property OCP_ID() As Integer
        Get
            Return _OCP_ID
        End Get
        Set(ByVal value As Integer)
            _OCP_ID = value
        End Set
    End Property

    Public Property OCP_DATED() As Date
        Get
            Return _OCP_DATED
        End Get
        Set(ByVal value As Date)
            _OCP_DATED = value
        End Set
    End Property

    Public Property OCP_DATEF() As Date
        Get
            Return _OCP_DATEF
        End Get
        Set(ByVal value As Date)
            _OCP_DATEF = value
        End Set
    End Property

    Public Property O_Caissier() As CAISSIER
        Get
            Return _O_Caissier
        End Get
        Set(ByVal value As CAISSIER)
            _O_Caissier = value
        End Set
    End Property

    Public Property O_Caisse() As Caise
        Get
            Return _O_Caisse
        End Get
        Set(ByVal value As Caise)
            _O_Caisse = value
        End Set
    End Property

#End Region

#Region "Constructeurs"

    Public Sub New()

        Me.OCP_ID = 0
        Me.OCP_DATED = Date.Now
        Me.OCP_DATEF = Date.Now
        Me.O_Caissier = New CAISSIER
        Me.O_Caisse = New Caise

    End Sub

    Public Sub New(ByVal P_OCP_ID As Integer, ByVal P_OCP_DATED As Date, ByVal P_OCP_DATEF As Date)

        Me.OCP_ID = P_OCP_ID
        Me.OCP_DATED = P_OCP_DATED
        Me.OCP_DATEF = P_OCP_DATEF
        Me.O_Caissier = New CAISSIER
        Me.O_Caisse = New Caise

    End Sub

#End Region

#Region "DAL"

    Public Sub Ajouter_DAL()

        Dim Dr As DataRow = ds.OCCUPATION.NewRow

        Dr(0) = Me.OCP_ID
        Dr(1) = Me.O_Caissier.CAISSIER_ID
        Dr(2) = Me.O_Caisse.CAISSE_ID
        Dr(3) = Me.OCP_DATED
        Dr(4) = Me.OCP_DATEF

        ds.OCCUPATION.Rows.Add(Dr)

    End Sub

    Public Sub Modifier_DAL()

        Dim Dr As DataRow = ds.OCCUPATION.Select("OCP_ID =" & Me.OCP_ID)(0)

        Dr(1) = Me.O_Caissier.CAISSIER_ID
        Dr(2) = Me.O_Caisse.CAISSE_ID
        Dr(3) = Me.OCP_DATED
        Dr(4) = Me.OCP_DATEF

    End Sub

    Public Sub supprimer_DAL()

        Dim dr As DataRow = Ds.OCCUPATION.Select("OCP_ID=" & Me.OCP_ID)(0)
        dr.Delete()

    End Sub

#End Region

#Region "BAL"

    Public Sub Ajouter()

        actualiser()
        Me.OCP_ID = Generer_ID(ds.OCCUPATION, "OCP_ID")
        Me.Occupations.Add(Me)
        Me.Ajouter_DAL()
        Enregistrer(Da_Occupation, Ds.OCCUPATION)

    End Sub

    Public Sub Modifier()

        actualiser()
        Me.Occupations(position(OCP_ID)) = Me
        Me.Modifier_DAL()
        Enregistrer(Da_Occupation, Ds.OCCUPATION)

    End Sub

    Public Sub Supprimer()

        actualiser()
        Me.Occupations.RemoveAt(position(OCP_ID))
        Me.supprimer_DAL()
        Enregistrer(Da_Occupation, Ds.OCCUPATION)

    End Sub

#End Region

#Region "Functions"


    Private Sub actualiser()

        Actualiser_DataTable(Da_Occupation, "SELECT * FROM OCCUPATION", ds.OCCUPATION)
        ActualiserListeOccupation()

    End Sub

    Private Sub ActualiserListeOccupation()


        Actualiser_DataTable(Da_Occupation, "SELECT * FROM OCCUPATION", ds.OCCUPATION)

        If ds.OCCUPATION.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim O_Occupation As New OCCUPATION

        For i As Integer = 0 To ds.OCCUPATION.Rows.Count - 1

            O_Occupation.OCP_ID = ds.OCCUPATION.Item(i).OCP_ID
            O_Occupation.O_Caissier.CAISSIER_ID = ds.OCCUPATION.Item(i).CAISSIER_ID
            O_Occupation.O_Caisse.CAISSE_ID = ds.OCCUPATION.Item(i).CAISSE_ID
            O_Occupation.OCP_DATED = ds.OCCUPATION.Item(i).OCP_DATED
            O_Occupation.OCP_DATEF = ds.OCCUPATION.Item(i).OCP_DATEF

            Occupations.Add(O_Occupation)

        Next

    End Sub

    Private Function RetournerListeOccupation() As List(Of OCCUPATION)


        Actualiser_DataTable(Da_Occupation, "SELECT * FROM OCCUPATION", ds.OCCUPATION)

        If ds.OCCUPATION.Rows.Count = 0 Then
            Return Nothing
        End If

        Dim O_Occupation As New OCCUPATION

        For i As Integer = 0 To ds.OCCUPATION.Rows.Count - 1

            O_Occupation.OCP_ID = ds.OCCUPATION.Item(i).OCP_ID
            O_Occupation.O_Caissier.CAISSIER_ID = ds.OCCUPATION.Item(i).CAISSIER_ID
            O_Occupation.O_Caisse.CAISSE_ID = ds.OCCUPATION.Item(i).CAISSE_ID
            O_Occupation.OCP_DATED = ds.OCCUPATION.Item(i).OCP_DATED
            O_Occupation.OCP_DATEF = ds.OCCUPATION.Item(i).OCP_DATEF

            Occupations.Add(O_Occupation)

        Next

        Return Occupations

    End Function

    Private Function position(ByVal P_OCP_ID As Integer) As Integer

        If Occupations.Count <> 0 Then
            For i As Integer = 0 To Occupations.Count - 1
                If Occupations(i).OCP_ID = P_OCP_ID Then
                    Return i
                End If
            Next
        End If
        Return -1

    End Function


#End Region


End Class

