Imports System.Data.SqlClient
Imports System.Data
Module Dec_Variables

#Region " Conexion a la base "

    Public Conex As New SqlConnection("server=.\SQLEXPRESS; initial catalog=IN5_CAISSE; integrated security=true")
    Public cmd As New SqlCommand

    Public dt As New DataTable

    Public col As DataColumn
    Public dr As DataRow

    Public dt2 As New DataTable
    Public col2 As New DataColumn
    Public dr2 As DataRow

    Public dt3 As New DataTable
    Public col3 As New DataColumn
    Public dr3 As DataRow

    Public dt4 As New DataTable
    Public col4 As New DataColumn
    Public dr4 As DataRow

    '------- Instantiation Dataset ---------

    Public ds As New DSG

    '--chaine de conexion

    ' Public Con As New SqlConnection("server=zizo-pc\sqlexpress;initial catalog = IN5_CAISSE; integrated security = true")


    '--DataAdapters des Tables

    Public Da_Facture As New SqlDataAdapter("Select * from Facture", Con)
    Public Da_ModeReglement As New SqlDataAdapter("Select * from Mode_Regelement", Con)
    Public Da_Payement As New SqlDataAdapter("Select * from Payement", Con)
    Public Da_Payement_Of_Facture As New SqlDataAdapter("Select * from Payement_Of_Facture", Con)
    Public Da_Payement_Of_Ticket As New SqlDataAdapter("Select * from Payement_Of_Ticket", Con)
    Public Da_Ticket As New SqlDataAdapter("Select * from Ticket", Con)
    Public Da_Tarif As New SqlDataAdapter("SELECT * FROM TARIF", Con)
    Public Da_Marque As New SqlDataAdapter("SELECT * FROM MARQUE", Con)
    Public Da_SousFamille As New SqlDataAdapter("SELECT * FROM SOUS_FAMILLE", Con)
    Public Da_Famille As New SqlDataAdapter("SELECT * FROM FAMILLE", Con)
    Public Da_Tarif_Of_Article As New SqlDataAdapter("SELECT * FROM  TARIF_OF_ARTICLE", Con)
    Public Da_Rayon As New SqlDataAdapter("SELECT * FROM  RAYON", Con)
    Public Da_Caisse As New SqlDataAdapter("SELECT * FROM CAISSE", Con)
    '-----
    Public Da_Article As New SqlDataAdapter("select * from ARTICLE", Con)
    Public Da_Caissier As New SqlDataAdapter("select * from CAISSIER", Con)
    Public da_Client As New SqlDataAdapter("select * from CLIENT", Con)
    Public Da_Cloture As New SqlDataAdapter("select * from CLOTURE", Con)
    Public Da_Code_Bare As New SqlDataAdapter("select * from CODE_BARE", Con)
    Public Da_Commande As New SqlDataAdapter("select * from COMMANDE", Con)
    Public Da_Commande_Of_Article As New SqlDataAdapter("select * from Commande_Of_Article", Con)
    Public Da_Occupation As New SqlDataAdapter("select * from OCCUPATION", Con)
    Public Da_TVA As New SqlDataAdapter("select * from TVA", Con)
    '-----


#End Region

End Module
