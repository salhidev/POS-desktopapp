Imports System.Data.SqlClient
Imports System.Data
Public Class Client

#Region " Attributs..."

    Private Shared Clients As New List(Of Client)

    Private _CLT_MAT As Integer
    Private _CLT_NOM As String
    Private _CLT_PRENOM As String
    Private _CLT_REF As String
    Private _CLT_VILLE As String
    Private _CLT_CP As Integer
    Private _CLT_ADRESSE As String
    Private _CLT_EMAIL As String
    Private _CLT_FAX As Integer
    Private _CLT_TELPRO As Integer
    Private _CLT_PAYS As String
    Private _CLT_TEL2 As Integer
    Private _CLT_SEX As String
    Private _CLT_CIN As String
    Private _CLT_SITEWEB As String
    Private _CLT_ETAT As String
    Private _CLT_TYPE As String
    Private _CLT_DTIM As Date
    Private _CLT_DATENAISSE As Date

    Private _ClientOfCommande As List(Of Commande)


#End Region

#Region " Property..."

    Public Property CLT_MAT As Integer
        Get
            Return _CLT_MAT
        End Get
        Set(ByVal value As Integer)
            _CLT_MAT = value
        End Set
    End Property

    Public Property CLT_NOM As String
        Get
            Return _CLT_NOM
        End Get
        Set(ByVal value As String)
            _CLT_NOM = value
        End Set
    End Property

    Public Property CLT_PRENOM As String
        Get
            Return _CLT_PRENOM
        End Get
        Set(ByVal value As String)
            _CLT_PRENOM = value
        End Set
    End Property

    Public Property CLT_REF As String
        Get
            Return _CLT_REF
        End Get
        Set(ByVal value As String)
            _CLT_REF = value
        End Set
    End Property

    Public Property CLT_VILLE As String
        Get
            Return _CLT_VILLE
        End Get
        Set(ByVal value As String)
            _CLT_VILLE = value
        End Set
    End Property

    Public Property CLT_CP As Integer
        Get
            Return _CLT_CP
        End Get
        Set(ByVal value As Integer)
            _CLT_CP = value
        End Set
    End Property


    Public Property CLT_ADRESSE As String
        Get
            Return _CLT_ADRESSE
        End Get
        Set(ByVal value As String)
            _CLT_ADRESSE = value
        End Set
    End Property

    Public Property CLT_EMAIL As String
        Get
            Return _CLT_EMAIL
        End Get
        Set(ByVal value As String)
            _CLT_EMAIL = value
        End Set
    End Property

    Public Property CLT_FAX As Integer
        Get
            Return _CLT_FAX
        End Get
        Set(ByVal value As Integer)
            _CLT_FAX = value
        End Set

    End Property

    Public Property CLT_TELPRO As Integer
        Get
            Return _CLT_TELPRO
        End Get
        Set(ByVal value As Integer)
            _CLT_TELPRO = value
        End Set
    End Property

    Public Property CLT_PAYS As String
        Get
            Return _CLT_PAYS
        End Get
        Set(ByVal value As String)
            _CLT_PAYS = value
        End Set
    End Property

    Public Property CLT_TEL2 As Integer
        Get
            Return _CLT_TEL2
        End Get
        Set(ByVal value As Integer)
            _CLT_TEL2 = value
        End Set
    End Property

    Public Property CLT_SEX As String
        Get
            Return _CLT_SEX
        End Get
        Set(ByVal value As String)
            _CLT_SEX = value
        End Set
    End Property

    Public Property CLT_CIN As String
        Get
            Return _CLT_CIN
        End Get
        Set(ByVal value As String)
            _CLT_CIN = value
        End Set
    End Property

    Public Property CLT_SITEWEB As String
        Get
            Return _CLT_SITEWEB
        End Get
        Set(ByVal value As String)
            _CLT_SITEWEB = value
        End Set
    End Property

    Public Property CLT_ETAT As String
        Get
            Return _CLT_ETAT
        End Get
        Set(ByVal value As String)
            _CLT_ETAT = value
        End Set
    End Property

    Public Property CLT_TYPE As String
        Get
            Return _CLT_TYPE
        End Get
        Set(ByVal value As String)
            _CLT_TYPE = value
        End Set
    End Property

    Public Property CLT_DTIM As Date
        Get
            Return _CLT_DTIM
        End Get
        Set(ByVal value As Date)
            _CLT_DTIM = value
        End Set
    End Property


    Public Property CLT_DATENAISSE As Date
        Get
            Return _CLT_DATENAISSE
        End Get
        Set(ByVal value As Date)
            _CLT_DATENAISSE = value
        End Set
    End Property


    Public Property ClientOfCommande As List(Of Commande)
        Get
            Return _ClientOfCommande
        End Get
        Set(ByVal value As List(Of Commande))
            _ClientOfCommande = value
        End Set
    End Property

#End Region

#Region " Constructeur....."

    Public Sub New()

        ClientOfCommande = New List(Of Commande)

    End Sub

    Public Sub New(ByVal p_Mat As Integer, ByVal p_nom As String, ByVal p_prenom As String, ByVal p_ref As String, ByVal p_ville As String, ByVal p_cp As Integer, ByVal p_adresse As String, ByVal p_email As String, ByVal p_fax As Integer, ByVal p_telpro As Integer, ByVal p_pays As String, ByVal p_tel2 As Integer, ByVal p_sex As String, ByVal p_cin As String, ByVal p_site As String, ByVal p_etat As String, ByVal p_type As String, ByVal p_dtim As Date, ByVal p_dtnaiss As Date)

        Me.CLT_MAT = p_Mat
        Me.CLT_NOM = p_nom
        Me.CLT_PRENOM = p_prenom
        Me.CLT_REF = p_ref
        Me.CLT_VILLE = p_ville
        Me.CLT_CP = p_cp
        Me.CLT_ADRESSE = p_adresse
        Me.CLT_EMAIL = p_email
        Me.CLT_FAX = p_fax
        Me.CLT_TELPRO = p_telpro
        Me.CLT_PAYS = p_pays
        Me.CLT_TEL2 = p_tel2
        Me.CLT_SEX = p_sex
        Me.CLT_CIN = p_cin
        Me.CLT_SITEWEB = p_site
        Me.CLT_ETAT = p_etat
        Me.CLT_TYPE = p_type
        Me.CLT_DTIM = p_dtim
        Me.CLT_DATENAISSE = p_dtnaiss
        ClientOfCommande = New List(Of Commande)

    End Sub


#End Region

#Region " BAL..."

    Public Sub Ajouter()

        actualiser()
        Me.CLT_MAT = Generer_ID(ds.CLIENT, "CLT_MAT")
        Clients.Add(Me)
        Me.Ajouter_DAL()
        Enregistrer(da_Client, ds.CLIENT)


    End Sub

    Public Sub Modifier()

        actualiser()
        Clients(RechercherPosClient(CLT_MAT)) = Me
        Me.Modifier_DAL()
        Enregistrer(da_Client, ds.COMMANDE)

    End Sub

    Public Sub Supprimer()

        actualiser()
        Clients.RemoveAt(RechercherPosClient(CLT_MAT))
        Me.Supprimer_Dal()
        Enregistrer(da_Client, ds.CLIENT)

    End Sub

#End Region

#Region " DAL... "

    Public Sub Ajouter_DAL()

        Dim dr As DataRow = ds.CLIENT.NewRow

        dr(0) = Me.CLT_MAT
        dr(1) = Me.CLT_NOM
        dr(2) = Me.CLT_PRENOM
        dr(3) = Me.CLT_REF
        dr(4) = Me.CLT_VILLE
        dr(5) = Me.CLT_CP
        dr(6) = Me.CLT_ADRESSE
        dr(7) = Me.CLT_EMAIL
        dr(8) = Me.CLT_FAX
        dr(9) = Me.CLT_TELPRO
        dr(10) = Me.CLT_PAYS
        dr(11) = Me.CLT_TEL2
        dr(12) = Me.CLT_SEX
        dr(13) = Me.CLT_CIN
        dr(14) = Me.CLT_SITEWEB
        dr(15) = Me.CLT_ETAT
        dr(16) = Me.CLT_TYPE
        dr(17) = Me.CLT_DTIM
        dr(18) = Me.CLT_DATENAISSE

        ds.CLIENT.Rows.Add(dr)

    End Sub

    Public Sub Modifier_DAL()

        Dim dr As DataRow = ds.CLIENT.Select("CLT_MAT=" & Me.CLT_MAT)(0)
        dr(1) = Me.CLT_NOM
        dr(2) = Me.CLT_PRENOM
        dr(3) = Me.CLT_REF
        dr(4) = Me.CLT_VILLE
        dr(5) = Me.CLT_CP
        dr(6) = Me.CLT_ADRESSE
        dr(7) = Me.CLT_EMAIL
        dr(8) = Me.CLT_FAX
        dr(9) = Me.CLT_TELPRO
        dr(10) = Me.CLT_PAYS
        dr(11) = Me.CLT_TEL2
        dr(12) = Me.CLT_SEX
        dr(13) = Me.CLT_CIN
        dr(14) = Me.CLT_SITEWEB
        dr(15) = Me.CLT_ETAT
        dr(16) = Me.CLT_TYPE
        dr(17) = Me.CLT_DTIM
        dr(18) = Me.CLT_DATENAISSE

    End Sub

    Public Sub Supprimer_Dal()

        Dim dr As DataRow = ds.CLIENT.Select("CLT_MAT=" & Me.CLT_MAT)(0)
        dr.Delete()

    End Sub


#End Region

#Region " Function "

    Private Function RechercherPosClient(ByVal p_ID As Integer) As Integer

        For i As Integer = 0 To Clients.Count - 1
            If Clients(i).CLT_MAT = p_ID Then
                Return i
            End If
        Next
        Return -1

    End Function

    Public Function RetournerListeClient() As List(Of Client)


        Actualiser_DataTable(da_Client, "SELECT * FROM CLIENT", ds.CLIENT)

        Clients.Clear()

        If ds.CLIENT.Rows.Count = 0 Then

            Return Nothing

        End If

        For i As Integer = 0 To ds.CLIENT.Rows.Count - 1

            Dim o_client As New Client

            o_client.CLT_MAT = ds.CLIENT.Item(i).CLT_MAT
            o_client.CLT_NOM = ds.CLIENT.Item(i).CLT_NOM
            o_client.CLT_PRENOM = ds.CLIENT.Item(i).CLT_PRENOM
            o_client.CLT_REF = ds.CLIENT.Item(i).CLT_REF
            o_client.CLT_VILLE = ds.CLIENT.Item(i).CLT_VILLE
            o_client.CLT_CP = ds.CLIENT.Item(i).CLT_CP
            o_client.CLT_ADRESSE = ds.CLIENT.Item(i).CLT_ADRESSE
            o_client.CLT_EMAIL = ds.CLIENT.Item(i).CLT_EMAIL
            o_client.CLT_FAX = ds.CLIENT.Item(i).CLT_FAX
            o_client.CLT_TELPRO = ds.CLIENT.Item(i).CLT_TELPRO
            o_client.CLT_PAYS = ds.CLIENT.Item(i).CLT_PAYS
            o_client.CLT_TEL2 = ds.CLIENT.Item(i).CLT_TEL2
            o_client.CLT_SEX = ds.CLIENT.Item(i).CLT_SEX
            o_client.CLT_CIN = ds.CLIENT.Item(i).CLT_CIN
            o_client.CLT_SITEWEB = ds.CLIENT.Item(i).CLT_SITEWEB
            o_client.CLT_ETAT = ds.CLIENT.Item(i).CLT_ETAT
            o_client.CLT_TYPE = ds.CLIENT.Item(i).CLT_TYPE
            o_client.CLT_DTIM = ds.CLIENT.Item(i).CLT_DTIM
            o_client.CLT_DATENAISSE = ds.CLIENT.Item(i).CLT_DATENAISSE

            Clients.Add(o_client)

        Next

        Return Clients

    End Function

    Public Sub actualiser_client()

        Actualiser_DataTable(da_Client, "SELECT * FROM CLIENT", ds.CLIENT)

        Clients.Clear()

        If ds.CLIENT.Rows.Count = 0 Then

            Exit Sub

        End If

        For i As Integer = 0 To ds.CLIENT.Rows.Count - 1

            Dim o_client As New Client

            o_client.CLT_MAT = ds.CLIENT.Item(i).CLT_MAT
            o_client.CLT_NOM = ds.CLIENT.Item(i).CLT_NOM
            o_client.CLT_PRENOM = ds.CLIENT.Item(i).CLT_PRENOM
            o_client.CLT_REF = ds.CLIENT.Item(i).CLT_REF
            o_client.CLT_VILLE = ds.CLIENT.Item(i).CLT_VILLE
            o_client.CLT_CP = ds.CLIENT.Item(i).CLT_CP
            o_client.CLT_ADRESSE = ds.CLIENT.Item(i).CLT_ADRESSE
            o_client.CLT_EMAIL = ds.CLIENT.Item(i).CLT_EMAIL
            o_client.CLT_FAX = ds.CLIENT.Item(i).CLT_FAX
            o_client.CLT_TELPRO = ds.CLIENT.Item(i).CLT_TELPRO
            o_client.CLT_PAYS = ds.CLIENT.Item(i).CLT_PAYS
            o_client.CLT_TEL2 = ds.CLIENT.Item(i).CLT_TEL2
            o_client.CLT_SEX = ds.CLIENT.Item(i).CLT_SEX
            o_client.CLT_CIN = ds.CLIENT.Item(i).CLT_CIN
            o_client.CLT_SITEWEB = ds.CLIENT.Item(i).CLT_SITEWEB
            o_client.CLT_ETAT = ds.CLIENT.Item(i).CLT_ETAT
            o_client.CLT_TYPE = ds.CLIENT.Item(i).CLT_TYPE
            o_client.CLT_DTIM = ds.CLIENT.Item(i).CLT_DTIM
            o_client.CLT_DATENAISSE = ds.CLIENT.Item(i).CLT_DATENAISSE

            Clients.Add(o_client)

        Next


    End Sub

    Private Sub actualiser()

        Actualiser_DataTable(da_Client, "SELECT * FROM CLIENT", ds.CLIENT)
        actualiser_client()

    End Sub

    Public Function Rechercher_Par_Prenom(ByVal P_Prenom As String) As List(Of Client)

        actualiser_client()

        Dim o_client As New List(Of Client)

        If Clients.Count <> 0 Then

            For i As Integer = 0 To Clients.Count - 1
                If Clients(i).CLT_PRENOM.Length >= P_Prenom.Length Then

                    If Clients(i).CLT_PRENOM.Substring(0, P_Prenom.Length).ToLower = P_Prenom.ToLower Then

                        o_client.Add(Clients(i))

                    End If

                End If
            Next

        End If

        Return o_client

    End Function

    Public Function Rechercher_Par_Nom(ByVal P_Nom As String) As List(Of Client)

        actualiser_client()

        Dim o_client As New List(Of Client)

        If Clients.Count <> 0 Then

            For i As Integer = 0 To Clients.Count - 1
                If Clients(i).CLT_NOM.Length >= P_Nom.Length Then

                    If Clients(i).CLT_NOM.Substring(0, P_Nom.Length).ToLower = P_Nom.ToLower Then

                        o_client.Add(Clients(i))

                    End If

                End If
            Next

        End If

        Return o_client

    End Function

    Public Function Rechercher_Par_CIN(ByVal P_CIN As String) As List(Of Client)

        actualiser_client()

        Dim o_client As New List(Of Client)

        If Clients.Count <> 0 Then

            For i As Integer = 0 To Clients.Count - 1
                If Clients(i).CLT_CIN.Length >= P_CIN.Length Then

                    If Clients(i).CLT_CIN.Substring(0, P_CIN.Length).ToLower = P_CIN.ToLower Then

                        o_client.Add(Clients(i))

                    End If

                End If
            Next

        End If

        Return o_client

    End Function

    Public Function Rechercher_Par_tout(ByVal P_Nom As String, ByVal P_Prenom As String, ByVal P_CIN As String) As List(Of Client)

        actualiser_client()

        Dim o_Clients As New List(Of Client)

        If Clients.Count <> 0 Then

            For i As Integer = 0 To Clients.Count - 1

                If Clients(i).CLT_NOM.Length >= P_Nom.Length Then
                    If Clients(i).CLT_NOM.Substring(0, P_Nom.Length).ToLower = P_Nom.ToLower Then

                        If Clients(i).CLT_PRENOM.Length >= P_Prenom.Length Then
                            If Clients(i).CLT_PRENOM.Substring(0, P_Prenom.Length).ToLower = P_Prenom.ToLower Then

                                If Clients(i).CLT_CIN.Length >= P_CIN.Length Then
                                    If Clients(i).CLT_CIN.Substring(0, P_CIN.Length).ToLower = P_CIN.ToLower Then

                                        'If Caissiers(i).CAISSIER_DATENAISS = P_Date Then
                                        'If Caissiers(i).CAISSIER_DATENAISS.Substring(0, P_Prenom.Length).ToLower = P_Prenom.ToLower Then

                                        o_Clients.Add(Clients(i))

                                        'End If
                                        'End If

                                    End If
                                End If

                            End If
                        End If

                    End If
                End If

            Next

        End If

        Return o_Clients

    End Function

#End Region

End Class
