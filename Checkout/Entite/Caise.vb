Public Class Caise

#Region "Atributs"

    Private Caisses As New List(Of Caise)

    Private _CAISSE_ID As Integer
    Private _CAISSE_LIB As String
    Private _CAISSE_ETAT As String

    Private _OccupationOfCaisse As List(Of OCCUPATION)
    Private _CloturesOfCaisse As List(Of Cloture)

#End Region

#Region "Propriété"

    Public Property CAISSE_ID() As Integer
        Get
            Return _CAISSE_ID
        End Get
        Set(ByVal value As Integer)
            _CAISSE_ID = value
        End Set
    End Property

    Public Property CAISSE_LIB() As String
        Get
            Return _CAISSE_LIB
        End Get
        Set(ByVal value As String)
            _CAISSE_LIB = value
        End Set
    End Property

    Public Property CAISSE_ETAT() As String
        Get
            Return _CAISSE_ETAT
        End Get
        Set(ByVal value As String)
            _CAISSE_ETAT = value
        End Set
    End Property

    Public Property OccupationOfCaisse() As List(Of OCCUPATION)
        Get
            Return _OccupationOfCaisse
        End Get
        Set(ByVal value As List(Of OCCUPATION))
            _OccupationOfCaisse = value
        End Set
    End Property

    Public Property CloturesOfCaisse() As List(Of Cloture)
        Get
            Return _CloturesOfCaisse
        End Get
        Set(ByVal value As List(Of Cloture))
            _CloturesOfCaisse = value
        End Set
    End Property

#End Region

#Region "Constructeurs"

    Public Sub New()

        Me.CAISSE_ID = 0
        Me.CAISSE_LIB = ""
        Me.CAISSE_ETAT = ""
        Me.OccupationOfCaisse = New List(Of OCCUPATION)
        Me.CloturesOfCaisse = New List(Of Cloture)

    End Sub

    Public Sub New(ByVal P_CAISSE_ID As Integer, ByVal P_CAISSE_LIB As String, ByVal P_CAISSE_ETAT As String)

        Me.CAISSE_ID = P_CAISSE_ID
        Me.CAISSE_LIB = P_CAISSE_LIB
        Me.CAISSE_ETAT = P_CAISSE_ETAT
        Me.OccupationOfCaisse = New List(Of OCCUPATION)
        Me.CloturesOfCaisse = New List(Of CLOTURE)

    End Sub

#End Region

#Region "DAL"

    Public Sub Ajouter_DAL()

        Dim dr As DataRow = ds.CAISSE.NewRow

        dr(0) = Me.CAISSE_ID
        dr(1) = Me.CAISSE_LIB
        dr(2) = Me.CAISSE_ETAT

        ds.CAISSE.Rows.Add(dr)

    End Sub

    Public Sub Modifier_DAL()

        Dim dr As DataRow = ds.CAISSE.Select("CAISSE_ID=" & Me.CAISSE_ID)(0)

        dr(1) = Me.CAISSE_LIB
        dr(2) = Me.CAISSE_ETAT

    End Sub

    Public Sub supprimer_DAL()

        Dim dr As DataRow = Ds.CAISSE.Select("CAISSE_ID=" & Me.CAISSE_ID)(0)
        dr.Delete()

    End Sub

#End Region

#Region "BAL"

    Public Sub Ajouter()

        Actualiser()
        CAISSE_ID = Generer_ID(ds.CAISSE, "CAISSE_ID")
        Caisses.Add(Me)
        Me.Ajouter_DAL()
        Enregistrer(Da_Caisse, Ds.CAISSE)

    End Sub

    Public Sub Modifier()

        Actualiser()
        Caisses(RechercheposCaisse(Me.CAISSE_ID)) = Me
        Me.Modifier_DAL()
        Enregistrer(Da_Caisse, Ds.CAISSE)

    End Sub

    Public Sub Supprimer()

        Actualiser()
        Caisses.RemoveAt(RechercheposCaisse(CAISSE_ID))
        Me.supprimer_DAL()
        Enregistrer(Da_Caisse, Ds.CAISSE)

    End Sub

#End Region

#Region "Function"

    Private Function RechercheposCaisse(ByVal P_CAISSE_ID As Integer) As Integer

        If Caisses.Count <> 0 Then
            For i As Integer = 0 To Caisses.Count - 1
                If Caisses(i).CAISSE_ID = P_CAISSE_ID Then
                    Return i
                End If
            Next
        End If
        Return -1

    End Function

    Public Sub ActualiserListeCaisse()

        Actualiser_Datatable(Da_Caisse, "SELECT * FROM CAISSE", ds.CAISSE)

        If Ds.CAISSE.Rows.Count = 0 Then
            Exit Sub
        End If

        Caisses.Clear()

        Dim O_caisse As Caise

        For i As Integer = 0 To Ds.CAISSE.Rows.Count - 1

            O_caisse = New Caise

            O_caisse.CAISSE_ID = ds.CAISSE.Item(i).CAISSE_ID
            O_caisse.CAISSE_LIB = ds.CAISSE.Item(i).CAISSE_LIB
            O_caisse.CAISSE_ETAT = ds.CAISSE.Item(i).CAISSE_ETAT

            Caisses.Add(O_caisse)

        Next

    End Sub

    Public Function RetournerListeCaisse(Optional ByVal Ok As Boolean = False) As List(Of Caise)

        Actualiser_DataTable(Da_Caisse, "SELECT * FROM CAISSE", ds.CAISSE)

        If ds.CAISSE.Rows.Count = 0 Then
            Return Nothing
        End If

        Caisses.Clear()

        Dim O_caisse As Caise

        For i As Integer = 0 To ds.CAISSE.Rows.Count - 1

            O_caisse = New Caise

            O_caisse.CAISSE_ID = ds.CAISSE.Item(i).CAISSE_ID
            O_caisse.CAISSE_LIB = ds.CAISSE.Item(i).CAISSE_LIB
            O_caisse.CAISSE_ETAT = ds.CAISSE.Item(i).CAISSE_ETAT

            Caisses.Add(O_caisse)

        Next

        If Ok = True Then
            Dim o_cais As New Caise
            o_cais.CAISSE_ETAT = "--Faites Votre choix--"
            Caisses.Insert(0, o_cais)

        End If


        Return Caisses

    End Function

    Public Function RetournerListeCaisse(ByVal cmb As ComboBox) As List(Of Caise)

        Actualiser_DataTable(Da_Caisse, "SELECT * FROM CAISSE", ds.CAISSE)

        If ds.CAISSE.Rows.Count = 0 Then
            Return Nothing
        End If

        Caisses.Clear()

        Dim O_caisse As Caise

        For i As Integer = 0 To ds.CAISSE.Rows.Count - 1

            O_caisse = New Caise
            cmb.Items.Insert(0, "--Faite votre choix--")
            cmb.Items.Add(0)
            O_caisse.CAISSE_ID = ds.CAISSE.Item(i).CAISSE_ID
            O_caisse.CAISSE_LIB = ds.CAISSE.Item(i).CAISSE_LIB
            O_caisse.CAISSE_ETAT = ds.CAISSE.Item(i).CAISSE_ETAT

            Caisses.Add(O_caisse)

        Next

        Return Caisses

    End Function

    Public Sub Actualiser()

        Actualiser_Datatable(Da_Caisse, "SELECT * FROM CAISSE", ds.CAISSE)
        ActualiserListeCaisse()

    End Sub

    Public Function Recherche_Par_Lib(ByVal P_lib As String) As List(Of Caise)

        ActualiserListeCaisse()

        Dim o_caisse As New List(Of Caise)

        If Caisses.Count <> 0 Then

            For i As Integer = 0 To Caisses.Count - 1

                If Caisses(i).CAISSE_LIB.Length >= P_lib.Length Then
                    If Caisses(i).CAISSE_LIB.Substring(0, P_lib.Length).ToLower = P_lib.ToLower Then
                        o_caisse.Add(Caisses(i))
                    End If

                End If
            Next

        End If


        Return o_caisse

    End Function

    Public Function Recherche_Par_Etat(ByVal P_Etat As String) As List(Of Caise)

        ActualiserListeCaisse()

        Dim o_caisse As New List(Of Caise)

        If Caisses.Count <> 0 Then

            For i As Integer = 0 To Caisses.Count - 1

                If Caisses(i).CAISSE_ETAT.Length >= P_Etat.Length Then
                    If Caisses(i).CAISSE_ETAT.Substring(0, P_Etat.Length).ToLower = P_Etat.ToLower Then
                        o_caisse.Add(Caisses(i))
                    End If

                End If
            Next

        End If


        Return o_caisse

    End Function

    Public Function Recherche_Par_tout(ByVal P_lib As String, ByVal P_Etat As String) As List(Of Caise)

        ActualiserListeCaisse()

        Dim o_caisse As New List(Of Caise)

        If Caisses.Count <> 0 Then
            For i As Integer = 0 To Caisses.Count - 1

                If Caisses(i).CAISSE_LIB.Length >= P_lib.Length Then
                    If Caisses(i).CAISSE_LIB.Substring(0, P_lib.Length).ToLower = P_lib.ToLower Then

                        If Caisses(i).CAISSE_ETAT.Length >= P_Etat.Length Then
                            If Caisses(i).CAISSE_ETAT.Substring(0, P_Etat.Length).ToLower = P_Etat.ToLower Then

                                o_caisse.Add(Caisses(i))

                            End If

                        End If
                    End If
                End If
            Next
        End If

        Return o_caisse

    End Function


#End Region

End Class
