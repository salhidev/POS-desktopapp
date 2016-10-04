Public Class CAISSIER

#Region "Attributs"

    Private Caissiers As New List(Of CAISSIER)

    Private _CAISSIER_ID As Integer
    Private _CAISSIER_DATENAISS As Date
    Private _CAISSIER_TYPE As String
    Private _CAISSIER_MOTDEPASSE As String
    Private _CAISSIER_CIN As String
    Private _CAISSIER_VILLE As String
    Private _CAISSIER_PAYS As String
    Private _CAISSIER_ADRESSE As String
    Private _CAISSIER_CODEPOSTAL As String
    Private _CAISSIER_TEL As String
    Private _CAISSIER_SEX As String
    Private _CAISSIER_PRENOM As String
    Private _CAISSIER_NOM As String


    Private _OccupationOfCaissier As List(Of OCCUPATION)
    Private _CommandesOfCaissier As List(Of Commande)

#End Region

#Region "Propriété"

    Public Property CAISSIER_ID() As Integer
        Get
            Return _CAISSIER_ID
        End Get
        Set(ByVal value As Integer)
            _CAISSIER_ID = value
        End Set
    End Property

    Public Property CAISSIER_DATENAISS() As Date
        Get
            Return _CAISSIER_DATENAISS
        End Get
        Set(ByVal value As Date)
            _CAISSIER_DATENAISS = value
        End Set
    End Property

    Public Property CAISSIER_TYPE() As String
        Get
            Return _CAISSIER_TYPE
        End Get
        Set(ByVal value As String)
            _CAISSIER_TYPE = value
        End Set
    End Property

    Public Property CAISSIER_MOTDEPASSE() As String
        Get
            Return _CAISSIER_MOTDEPASSE
        End Get
        Set(ByVal value As String)
            _CAISSIER_MOTDEPASSE = value
        End Set
    End Property

    Public Property CAISSIER_CIN() As String
        Get
            Return _CAISSIER_CIN
        End Get
        Set(ByVal value As String)
            _CAISSIER_CIN = value
        End Set
    End Property

    Public Property CAISSIER_VILLE() As String
        Get
            Return _CAISSIER_VILLE
        End Get
        Set(ByVal value As String)
            _CAISSIER_VILLE = value
        End Set
    End Property

    Public Property CAISSIER_PAYS() As String
        Get
            Return _CAISSIER_PAYS
        End Get
        Set(ByVal value As String)
            _CAISSIER_PAYS = value
        End Set
    End Property

    Public Property CAISSIER_ADRESSE() As String
        Get
            Return _CAISSIER_ADRESSE
        End Get
        Set(ByVal value As String)
            _CAISSIER_ADRESSE = value
        End Set
    End Property

    Public Property CAISSIER_CODEPOSTAL() As String
        Get
            Return _CAISSIER_CODEPOSTAL
        End Get
        Set(ByVal value As String)
            _CAISSIER_CODEPOSTAL = value
        End Set
    End Property

    Public Property CAISSIER_TEL() As String
        Get
            Return _CAISSIER_TEL
        End Get
        Set(ByVal value As String)
            _CAISSIER_TEL = value
        End Set
    End Property

    Public Property CAISSIER_SEX() As String
        Get
            Return _CAISSIER_SEX
        End Get
        Set(ByVal value As String)
            _CAISSIER_SEX = value
        End Set
    End Property

    Public Property CAISSIER_PRENOM() As String
        Get
            Return _CAISSIER_PRENOM
        End Get
        Set(ByVal value As String)
            _CAISSIER_PRENOM = value
        End Set
    End Property

    Public Property CAISSIER_NOM() As String
        Get
            Return _CAISSIER_NOM
        End Get
        Set(ByVal value As String)
            _CAISSIER_NOM = value
        End Set
    End Property

    Public Property OccupationOfCaissier() As List(Of OCCUPATION)
        Get
            Return _OccupationOfCaissier
        End Get
        Set(ByVal value As List(Of OCCUPATION))
            _OccupationOfCaissier = value
        End Set
    End Property

    Public Property CommandesOfCaissier() As List(Of Commande)
        Get
            Return _CommandesOfCaissier
        End Get
        Set(ByVal value As List(Of Commande))
            _CommandesOfCaissier = value
        End Set
    End Property

#End Region

#Region "Constructeurs"

    Public Sub New()

        Me.CAISSIER_ID = 0
        Me.CAISSIER_DATENAISS = Date.Now
        Me.CAISSIER_TYPE = ""
        Me.CAISSIER_MOTDEPASSE = ""
        Me.CAISSIER_CIN = ""
        Me.CAISSIER_VILLE = ""
        Me.CAISSIER_PAYS = ""
        Me.CAISSIER_ADRESSE = ""
        Me.CAISSIER_CODEPOSTAL = ""
        Me.CAISSIER_TEL = ""
        Me.CAISSIER_SEX = ""
        Me.CAISSIER_NOM = ""
        Me.CAISSIER_PRENOM = ""
        Me.OccupationOfCaissier = New List(Of OCCUPATION)
        Me.CommandesOfCaissier = New List(Of Commande)

    End Sub

    Public Sub New(ByVal P_CAISSIER_ID As Integer, ByVal P_CAISSIER_DATENAISS As Date, ByVal P_CAISSIER_TYPE As String, ByVal P_CAISSIER_MOTDEPASSE As String, ByVal P_CAISSIER_CIN As String, ByVal P_CAISSIER_VILLE As String, ByVal P_CAISSIER_PAYS As String, ByVal P_CAISSIER_ADRESSE As String, ByVal P_CAISSIER_CODEPOSTAL As String, ByVal P_CAISSIER_TEL As String, ByVal P_CAISSIER_SEX As String, ByVal P_CAISSIER_PRENOM As String, ByVal P_CAISSIER_NOM As String)

        Me.CAISSIER_ID = P_CAISSIER_ID
        Me.CAISSIER_DATENAISS = P_CAISSIER_DATENAISS
        Me.CAISSIER_TYPE = P_CAISSIER_TYPE
        Me.CAISSIER_MOTDEPASSE = P_CAISSIER_MOTDEPASSE
        Me.CAISSIER_CIN = P_CAISSIER_CIN
        Me.CAISSIER_VILLE = P_CAISSIER_VILLE
        Me.CAISSIER_PAYS = P_CAISSIER_PAYS
        Me.CAISSIER_ADRESSE = P_CAISSIER_ADRESSE
        Me.CAISSIER_CODEPOSTAL = P_CAISSIER_CODEPOSTAL
        Me.CAISSIER_TEL = P_CAISSIER_TEL
        Me.CAISSIER_SEX = P_CAISSIER_SEX
        Me.CAISSIER_PRENOM = P_CAISSIER_PRENOM
        Me.CAISSIER_NOM = P_CAISSIER_NOM

        Me.OccupationOfCaissier = New List(Of OCCUPATION)
        Me.CommandesOfCaissier = New List(Of Commande)

    End Sub

#End Region

#Region "DAL"

    Public Sub Ajouter_DAL()

        Dim dr As DataRow = ds.CAISSIER.NewRow

        dr(0) = Me.CAISSIER_ID
        dr(1) = Me.CAISSIER_DATENAISS
        dr(2) = Me.CAISSIER_TYPE
        dr(3) = Me.CAISSIER_MOTDEPASSE
        dr(4) = Me.CAISSIER_CIN
        dr(5) = Me.CAISSIER_VILLE
        dr(6) = Me.CAISSIER_PAYS
        dr(7) = Me.CAISSIER_ADRESSE
        dr(8) = Me.CAISSIER_CODEPOSTAL
        dr(9) = Me.CAISSIER_TEL
        dr(10) = Me.CAISSIER_SEX
        dr(11) = Me.CAISSIER_PRENOM
        dr(12) = Me.CAISSIER_NOM

        ds.CAISSIER.Rows.Add(dr)

    End Sub

    Public Sub Modifier_DAL()

        Dim dr As DataRow = Ds.CAISSIER.Select("CAISSIER_ID=" & Me.CAISSIER_ID)(0)

        dr(1) = Me.CAISSIER_DATENAISS
        dr(2) = Me.CAISSIER_TYPE
        dr(3) = Me.CAISSIER_MOTDEPASSE
        dr(4) = Me.CAISSIER_CIN
        dr(5) = Me.CAISSIER_VILLE
        dr(6) = Me.CAISSIER_PAYS
        dr(7) = Me.CAISSIER_ADRESSE
        dr(8) = Me.CAISSIER_CODEPOSTAL
        dr(9) = Me.CAISSIER_TEL
        dr(10) = Me.CAISSIER_SEX
        dr(11) = Me.CAISSIER_PRENOM
        dr(12) = Me.CAISSIER_NOM


    End Sub

    Public Sub supprimer_DAL()

        Dim dr As DataRow = Ds.CAISSIER.Select("CAISSIER_ID=" & Me.CAISSIER_ID)(0)
        dr.Delete()

    End Sub


#End Region

#Region "BAL"


    Public Sub Ajouter()

        Actualiser()
        CAISSIER_ID = Generer_ID(ds.CAISSIER, "CAISSIER_ID")
        Caissiers.Add(Me)
        Me.Ajouter_DAL()
        Enregistrer(Da_Caissier, ds.CAISSIER)

    End Sub

    Public Sub Modifier()

        Actualiser()
        Caissiers(position(CAISSIER_ID)) = Me
        Me.Modifier_DAL()
        Enregistrer(Da_Caissier, Ds.CAISSIER)

    End Sub

    Public Sub Supprimer()

        Actualiser()
        Caissiers.RemoveAt(position(CAISSIER_ID))
        Me.supprimer_DAL()
        Enregistrer(Da_Caissier, Ds.CAISSIER)

    End Sub

#End Region

#Region "Function"

    Private Function position(ByVal P_CAISSIER_ID As Integer) As Integer

        If Caissiers.Count <> 0 Then
            For i As Integer = 0 To Caissiers.Count - 1
                If Caissiers(i).CAISSIER_ID = P_CAISSIER_ID Then
                    Return i
                End If
            Next
        End If
        Return -1

    End Function

    Public Sub ActualiserListeCaissier()

        Actualiser_Datatable(Da_Caissier, "SELECT * FROM CAISSIER", ds.CAISSIER)

        If Ds.CAISSIER.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim O_Caissier As CAISSIER

        For i As Integer = 0 To Ds.CAISSIER.Rows.Count - 1

            O_Caissier = New CAISSIER

            O_Caissier.CAISSIER_ID = ds.CAISSIER.Rows(i)(0)
            O_Caissier.CAISSIER_DATENAISS = ds.CAISSIER.Rows(i)(1)
            O_Caissier.CAISSIER_TYPE = ds.CAISSIER.Rows(i)(2)
            O_Caissier.CAISSIER_MOTDEPASSE = ds.CAISSIER.Rows(i)(3)
            O_Caissier.CAISSIER_CIN = ds.CAISSIER.Rows(i)(4)
            O_Caissier.CAISSIER_VILLE = ds.CAISSIER.Rows(i)(5)
            O_Caissier.CAISSIER_PAYS = ds.CAISSIER.Rows(i)(6)
            O_Caissier.CAISSIER_ADRESSE = ds.CAISSIER.Rows(i)(7)
            O_Caissier.CAISSIER_CODEPOSTAL = ds.CAISSIER.Rows(i)(8)
            O_Caissier.CAISSIER_TEL = ds.CAISSIER.Rows(i)(9)
            O_Caissier.CAISSIER_SEX = ds.CAISSIER.Rows(i)(10)
            O_Caissier.CAISSIER_PRENOM = ds.CAISSIER.Rows(i)(11)
            O_Caissier.CAISSIER_NOM = ds.CAISSIER.Rows(i)(12)

                        Caissiers.Add(O_Caissier)
        Next

    End Sub

    Public Function RetournerListeCaissier() As List(Of CAISSIER)

        Actualiser_DataTable(Da_Caissier, "SELECT * FROM CAISSIER", ds.CAISSIER)


        If ds.CAISSIER.Rows.Count = 0 Then
            Return Nothing
        End If

        Caissiers.Clear()
        Dim O_Caissier As CAISSIER

        For i As Integer = 0 To ds.CAISSIER.Rows.Count - 1

            O_Caissier = New CAISSIER

            O_Caissier.CAISSIER_ID = ds.CAISSIER.Rows(i)(0)
            O_Caissier.CAISSIER_DATENAISS = ds.CAISSIER.Rows(i)(1)
            O_Caissier.CAISSIER_TYPE = ds.CAISSIER.Rows(i)(2)
            O_Caissier.CAISSIER_MOTDEPASSE = ds.CAISSIER.Rows(i)(3)
            O_Caissier.CAISSIER_CIN = ds.CAISSIER.Rows(i)(4)
            O_Caissier.CAISSIER_VILLE = ds.CAISSIER.Rows(i)(5)
            O_Caissier.CAISSIER_PAYS = ds.CAISSIER.Rows(i)(6)
            O_Caissier.CAISSIER_ADRESSE = ds.CAISSIER.Rows(i)(7)
            O_Caissier.CAISSIER_CODEPOSTAL = ds.CAISSIER.Rows(i)(8)
            O_Caissier.CAISSIER_TEL = ds.CAISSIER.Rows(i)(9)
            O_Caissier.CAISSIER_SEX = ds.CAISSIER.Rows(i)(10)
            O_Caissier.CAISSIER_PRENOM = ds.CAISSIER.Rows(i)(11)
            O_Caissier.CAISSIER_NOM = ds.CAISSIER.Rows(i)(12)

            Caissiers.Add(O_Caissier)

        Next

        Return Caissiers

    End Function

    Public Sub Actualiser()

        Actualiser_DataTable(Da_Caissier, "SELECT * FROM CAISSIER", ds.CAISSIER)
        ActualiserListeCaissier()

    End Sub

    Public Function Rechercher_Par_Nom(ByVal P_Nom As String) As List(Of CAISSIER)

        ActualiserListeCaissier()

        Dim o_caissier As New List(Of CAISSIER)

        If Caissiers.Count <> 0 Then

            For i As Integer = 0 To Caissiers.Count - 1
                If Caissiers(i).CAISSIER_NOM.Length >= P_Nom.Length Then

                    If Caissiers(i).CAISSIER_NOM.Substring(0, P_Nom.Length).ToLower = P_Nom.ToLower Then

                        o_caissier.Add(Caissiers(i))

                    End If

                End If
            Next

        End If

        Return o_caissier

    End Function

    Public Function Rechercher_Par_Prenom(ByVal P_Prenom As String) As List(Of CAISSIER)

        ActualiserListeCaissier()

        Dim o_caissier As New List(Of CAISSIER)

        If Caissiers.Count <> 0 Then

            For i As Integer = 0 To Caissiers.Count - 1
                If Caissiers(i).CAISSIER_PRENOM.Length >= P_Prenom.Length Then

                    If Caissiers(i).CAISSIER_PRENOM.Substring(0, P_Prenom.Length).ToLower = P_Prenom.ToLower Then

                        o_caissier.Add(Caissiers(i))

                    End If

                End If
            Next

        End If

        Return o_caissier

    End Function

    Public Function Rechercher_Par_CIN(ByVal P_CIN As String) As List(Of CAISSIER)

        ActualiserListeCaissier()

        Dim o_caissier As New List(Of CAISSIER)

        If Caissiers.Count <> 0 Then

            For i As Integer = 0 To Caissiers.Count - 1
                If Caissiers(i).CAISSIER_CIN.Length >= P_CIN.Length Then

                    If Caissiers(i).CAISSIER_CIN.Substring(0, P_CIN.Length).ToLower = P_CIN.ToLower Then

                        o_caissier.Add(Caissiers(i))

                    End If

                End If
            Next

        End If

        Return o_caissier

    End Function

    Public Function Rechercher_Par_Date(ByVal P_Date As Date) As List(Of CAISSIER)

        ActualiserListeCaissier()

        Dim o_caissier As New List(Of CAISSIER)

        If Caissiers.Count <> 0 Then

            For i As Integer = 0 To Caissiers.Count - 1
                If Caissiers(i).CAISSIER_DATENAISS = P_Date Then

                    o_caissier.Add(Caissiers(i))

                End If
            Next

        End If

        Return o_caissier

    End Function

    'Public Function Rechercher_Par_tout(ByVal P_Nom As String, ByVal P_Prenom As String, ByVal P_CIN As String) As List(Of CAISSIER)

    '    ActualiserListeCaissier()

    '    Dim o_Caissiers As New List(Of CAISSIER)

    '    If Caissiers.Count <> 0 Then

    '        For i As Integer = 0 To Caissiers.Count - 1

    '            If Caissiers(i).CAISSIER_NOM.Length >= P_Nom.Length Then
    '                If Caissiers(i).CAISSIER_NOM.Substring(0, P_Nom.Length).ToLower = P_Nom.ToLower Then

    '                    If Caissiers(i).CAISSIER_PRENOM.Length >= P_Prenom.Length Then
    '                        If Caissiers(i).CAISSIER_PRENOM.Substring(0, P_Prenom.Length).ToLower = P_Prenom.ToLower Then

    '                            If Caissiers(i).CAISSIER_CIN.Length >= P_CIN.Length Then
    '                                If Caissiers(i).CAISSIER_CIN.Substring(0, P_CIN.Length).ToLower = P_CIN.ToLower Then

    '                                    'If Caissiers(i).CAISSIER_DATENAISS = P_Date Then
    '                                    'If Caissiers(i).CAISSIER_DATENAISS.Substring(0, P_Prenom.Length).ToLower = P_Prenom.ToLower Then

    '                                    o_Caissiers.Add(Caissiers(i))

    '                                    'End If
    '                                    'End If

    '                                End If
    '                            End If

    '                        End If
    '                    End If

    '                End If
    '            End If

    '        Next

    '    End If

    '    Return o_Caissiers

    'End Function

    Public Function Rechercher_Par_tout(ByVal P_Nom As String, ByVal P_Prenom As String, ByVal P_CIN As String) As List(Of CAISSIER)

        Dim rech As Boolean = False

        ActualiserListeCaissier()

        Dim o_Caissiers As New List(Of CAISSIER)

        'If P_CIN = "" And P_Nom = "" And P_Prenom = "" Then
        '    dgv.DataSource = RetournerListeCaissier()
        'End If

        If Caissiers.Count <> 0 Then

            '-------------------Rechercher Par tout les critéres-------------------------

            For i As Integer = 0 To Caissiers.Count - 1

                'If P_Nom <> "" And P_Prenom <> "" And P_CIN <> "" Or P_CIN <> "" And P_Nom <> "" Or P_Prenom <> "" And P_CIN <> "" Or P_Nom <> "" And P_CIN <> "" Or P_Nom <> "" And P_Prenom <> "" Or P_Prenom <> "" And P_Nom <> "" Or P_Prenom <> "" And P_CIN <> "" Then

                If Caissiers(i).CAISSIER_NOM.Length >= P_Nom.Length Then
                    If Caissiers(i).CAISSIER_NOM.Substring(0, P_Nom.Length).ToLower = P_Nom.ToLower Then

                        If Caissiers(i).CAISSIER_PRENOM.Length >= P_Prenom.Length Then
                            If Caissiers(i).CAISSIER_PRENOM.Substring(0, P_Prenom.Length).ToLower = P_Prenom.ToLower Then

                                If Caissiers(i).CAISSIER_CIN.Length >= P_CIN.Length Then
                                    If Caissiers(i).CAISSIER_CIN.Substring(0, P_CIN.Length).ToLower = P_CIN.ToLower Then

                                        o_Caissiers.Add(Caissiers(i))

                                        'rech = True
                                        'Exit Function

                                    End If
                                End If

                            End If
                        End If

                    End If
                End If


                '-------------------Text changed du Nom-------------------------------------

                '        If P_Nom = "" And P_CIN <> "" Then

                '            If Caissiers(i).CAISSIER_CIN.Length >= P_CIN.Length Then
                '                If Caissiers(i).CAISSIER_CIN.Substring(0, P_CIN.Length).ToLower = P_CIN.ToLower Then

                '                    o_Caissiers.Add(Caissiers(i))
                '                    'rech = True
                '                    'Exit Function

                '                End If
                '            End If

                '        ElseIf P_Nom = "" And P_Prenom <> "" Then

                '            If Caissiers(i).CAISSIER_PRENOM.Length >= P_Prenom.Length Then
                '                If Caissiers(i).CAISSIER_PRENOM.Substring(0, P_Prenom.Length).ToLower = P_Prenom.ToLower Then

                '                    o_Caissiers.Add(Caissiers(i))
                '                    'rech = True
                '                    'Exit Function

                '                End If

                '            End If


                '        ElseIf P_Nom <> "" And P_CIN = "" And P_Prenom = "" Then

                '        If Caissiers(i).CAISSIER_NOM.Length >= P_Nom.Length Then
                '            If Caissiers(i).CAISSIER_NOM.Substring(0, P_Nom.Length).ToLower = P_Nom.ToLower Then

                '                o_Caissiers.Add(Caissiers(i))
                '                    'rech = True
                '                    'Exit Function

                '            End If

                '        End If

                '        End If

                ''--------------Text changed de prenom-----------------------------------

                'If P_Prenom = "" And P_CIN <> "" Then

                '    If Caissiers(i).CAISSIER_CIN.Length >= P_CIN.Length Then
                '        If Caissiers(i).CAISSIER_CIN.Substring(0, P_CIN.Length).ToLower = P_CIN.ToLower Then

                '            o_Caissiers.Add(Caissiers(i))
                '                    'rech = True
                '                    'Exit Function

                '        End If
                '    End If


                'ElseIf P_Prenom = "" And P_Nom <> "" Then

                '    If Caissiers(i).CAISSIER_NOM.Length >= P_Nom.Length Then
                '        If Caissiers(i).CAISSIER_NOM.Substring(0, P_Nom.Length).ToLower = P_Nom.ToLower Then

                '            o_Caissiers.Add(Caissiers(i))
                '                    'rech = True
                '                    'Exit Function

                '        End If

                '    End If


                'ElseIf P_Prenom <> "" And P_CIN = "" And P_Nom = "" Then

                '    If Caissiers(i).CAISSIER_PRENOM.Length >= P_Prenom.Length Then
                '        If Caissiers(i).CAISSIER_PRENOM.Substring(0, P_Prenom.Length).ToLower = P_Prenom.ToLower Then

                '            o_Caissiers.Add(Caissiers(i))
                '                    'rech = True
                '                    'Exit Function

                '        End If

                '    End If

                'End If

                ''--------------------Text changed du CIN--------------------------------

                'If P_CIN = "" And P_Nom <> "" Then

                '    If Caissiers(i).CAISSIER_NOM.Length >= P_Nom.Length Then
                '        If Caissiers(i).CAISSIER_NOM.Substring(0, P_Nom.Length).ToLower = P_Nom.ToLower Then

                '            o_Caissiers.Add(Caissiers(i))
                '                    'rech = True
                '                    'Exit Function

                '        End If
                '    End If


                'ElseIf P_CIN = "" And P_Prenom <> "" Then

                '    If Caissiers(i).CAISSIER_PRENOM.Length >= P_Prenom.Length Then
                '        If Caissiers(i).CAISSIER_PRENOM.Substring(0, P_Prenom.Length).ToLower = P_Prenom.ToLower Then

                '            o_Caissiers.Add(Caissiers(i))
                '                    'rech = True
                '                    'Exit Function

                '        End If

                '    End If


                'ElseIf P_CIN <> "" And P_Nom = "" And P_Prenom = "" Then

                '    If Caissiers(i).CAISSIER_CIN.Length >= P_CIN.Length Then
                '        If Caissiers(i).CAISSIER_CIN.Substring(0, P_CIN.Length).ToLower = P_CIN.ToLower Then

                '            o_Caissiers.Add(Caissiers(i))
                '                    'rech = True
                '                    'Exit Function

                '        End If

                '    End If

                'End If

            Next

        End If


        Return o_Caissiers




    End Function


#End Region

End Class
