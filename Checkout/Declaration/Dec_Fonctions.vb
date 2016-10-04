Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Image

Module Dec_Fonctions

    '-----pour  Charger  Comobo Apartir d'un Fichir text
    Public Function charger_liste(ByVal P_STRING As String) As List(Of String)

        Dim List As New List(Of String)
        If File.Exists(P_STRING) Then

            Dim sr As New StreamReader(P_STRING)
            While Not sr.Peek
                List.Add(sr.ReadLine)
            End While
            sr.Close()
            List.Sort()

        End If
        If List.Count <> 0 Then

            List.Insert(0, "---Faites votre choix---")

        End If

        Return List

    End Function


#Region "Remplissage des ComboBox"

    'Remplissage d'un combobox a partir d'un datatable
    Public Sub RemplirCombo(ByVal cmb As ComboBox, ByVal table As DataTable)

        cmb.Items.Clear()
        For i As Integer = 0 To table.Rows.Count - 1
            cmb.DisplayMember = table.Rows(i)(1)
            cmb.ValueMember = table.Rows(i)(0)
            cmb.Items.Add(table.Rows(i)(1))
        Next

    End Sub

#End Region

   

#Region "Création des button"

    'Creer Button 
    Public Function CreerButtonOfSousFamilleArticle() As Button

        Dim o_sf As New SOUS_FAMILLE
        Dim listSF As New List(Of SOUS_FAMILLE)
        listSF = o_sf.Actualiser_Liste

        Dim btn As Button

        For i As Integer = 0 To listSF.Count - 1

            btn = New Button
            btn.Name = "btn" & listSF.Item(i).Sf_Lib
            btn.Text = listSF.Item(i).Sf_Lib
            btn.Size = New Size(91, 57)
            btn.BackgroundImageLayout = ImageLayout.Stretch
            btn.BackColor = Color.RoyalBlue
            FrmCaisse.FlpSF.Controls.Add(btn)

        Next

        Return Nothing
    End Function

    Public Function creerButtonOfArticle() As Button

        Dim o_art As New ARTICLE
        Dim listArt As New List(Of ARTICLE)
        listArt = o_art.Actualiser_Liste
        Dim btn As Button

        For i As Integer = 0 To listArt.Count - 1

            btn = New Button
            btn.Name = "btn" & listArt.Item(i).ART_DESCRIPTION
            btn.Text = listArt.Item(i).ART_DESCRIPTION
            btn.Image = ByteArrayToImage(listArt.Item(i).ART_PHOTO)
            btn.BackgroundImageLayout = 3
            btn.Size = New Size(91, 57)
            btn.BackColor = Color.RoyalBlue
            FrmCaisse.FlpMarque.Controls.Add(btn)

        Next

        Return Nothing
    End Function

#End Region

  

#Region "Création des datatable"

    'Creer  databale
    Public Function creerdatatableCommande()


        col = New DataColumn
        col.DataType = Type.GetType("System.String")
        col.ColumnName = "Reference"
        Dt.Columns.Add(col)

        col = New DataColumn
        col.DataType = Type.GetType("System.String")
        col.ColumnName = "Article"
        Dt.Columns.Add(col)

        col = New DataColumn
        col.DataType = Type.GetType("System.Double")
        col.ColumnName = "Prix Unitaire"
        Dt.Columns.Add(col)

        col = New DataColumn
        col.DataType = Type.GetType("System.Double")
        col.ColumnName = "%"
        Dt.Columns.Add(col)

        col = New DataColumn
        col.DataType = Type.GetType("System.Double")
        col.ColumnName = "Qte"
        Dt.Columns.Add(col)

        col = New DataColumn
        col.DataType = Type.GetType("System.Double")
        col.ColumnName = "Total"
        dt.Columns.Add(col)

        col = New DataColumn
        col.DataType = Type.GetType("System.String")
        col.ColumnName = "ART"
        dt.Columns.Add(col)


        Return Dt

    End Function


    'Creer  Datatable
    Public Function creerdatatableTousLesArticles()


        col = New DataColumn
        col.DataType = Type.GetType("System.String")
        col.ColumnName = "Reference"
        dt.Columns.Add(col)

        col = New DataColumn
        col.DataType = Type.GetType("System.String")
        col.ColumnName = "Article"
        dt.Columns.Add(col)

        col = New DataColumn
        col.DataType = Type.GetType("System.Double")
        col.ColumnName = "Prix Unitaire"
        dt.Columns.Add(col)

        col = New DataColumn
        col.DataType = Type.GetType("System.Double")
        col.ColumnName = "%"
        dt.Columns.Add(col)

        col = New DataColumn
        col.DataType = Type.GetType("System.Double")
        col.ColumnName = "Qte"
        dt.Columns.Add(col)

        col = New DataColumn
        col.DataType = Type.GetType("System.Double")
        col.ColumnName = "Total"
        dt.Columns.Add(col)

        Return dt

    End Function

    'Creerdatabletarif_of_article  table intermediare
    Public Function Creerdatabletarif_of_article()


        col = New DataColumn
        col.DataType = Type.GetType("System.String")
        col.ColumnName = "NumTarif"
        col.ReadOnly = True
        Dt.Columns.Add(col)

        col = New DataColumn
        col.DataType = Type.GetType("System.String")
        col.ColumnName = "Tarif"
        Dt.Columns.Add(col)

        col = New DataColumn
        col.DataType = Type.GetType("System.String")
        col.ColumnName = "Prix d'achat "
        Dt.Columns.Add(col)

        col = New DataColumn
        col.DataType = Type.GetType("System.Double")
        col.ColumnName = "Prix de Vente"
        Dt.Columns.Add(col)


        Dim t As New TARIF
        Dim List As New List(Of TARIF)

        List = t.Actualiser_Liste

        For i As Integer = 0 To List.Count - 1

            Dim dr As DataRow = Dt.NewRow
            dr(0) = List.Item(i).Trf_ID
            dr(1) = List.Item(i).Trf_Libelle
            dr(2) = 0
            dr(3) = 0
            Dt.Rows.Add(dr)

        Next

        Return Dt

    End Function

    Public Function datatable_tarif_of_article_Modifier()


        '-------------------------------------------------------------------


        Dim O_tar As New TARIF_OF_ARTICLE
        Da_Tarif_Of_Article.Fill(ds.TARIF_OF_ARTICLE)

        Dim DT2 As New DataTable
        Dim Col2 As New DataColumn
        Col2 = New DataColumn
        Col2.DataType = Type.GetType("System.String")
        Col2.ColumnName = "Article"
        Col2.ReadOnly = True
        DT2.Columns.Add(Col2)

        Col2 = New DataColumn
        Col2.DataType = Type.GetType("System.String")
        Col2.ColumnName = "Tarif"
        DT2.Columns.Add(Col2)
        Col2.ReadOnly = True

        Col2 = New DataColumn
        Col2.DataType = Type.GetType("System.String")
        Col2.ColumnName = "  Prix d'achat "
        DT2.Columns.Add(Col2)

        Col2 = New DataColumn
        Col2.DataType = Type.GetType("System.Double")
        Col2.ColumnName = "  Prix de Vente  "
        DT2.Columns.Add(Col2)


        For i As Integer = 0 To ds.TARIF_OF_ARTICLE.Count - 1

            If ds.TARIF_OF_ARTICLE.Item(i).ART_ID = FrmArticle.Tag Then


                Dim dr2 As DataRow = DT2.NewRow

                dr2(0) = ds.TARIF_OF_ARTICLE.Item(i).ART_ID
                dr2(1) = ds.TARIF_OF_ARTICLE.Item(i).TRF_ID
                dr2(2) = ds.TARIF_OF_ARTICLE.Item(i).PRIXACHAT
                dr2(3) = ds.TARIF_OF_ARTICLE.Item(i).PRIXVENTE

                DT2.Rows.Add(dr2)

            End If
        Next
        Return DT2

    End Function

    Public Function CreerDatatableRappelerTicket()

        col4 = New DataColumn
        col4.DataType = Type.GetType("System.String")
        col4.ColumnName = "Numero du Ticket"
        dt4.Columns.Add(col4)

        col4 = New DataColumn
        col4.DataType = Type.GetType("System.String")
        col4.ColumnName = "Montant Ticket"
        dt4.Columns.Add(col4)

        col4 = New DataColumn
        col4.DataType = Type.GetType("System.String")
        col4.ColumnName = "Date Ticket"
        col4.MaxLength = 100
        dt4.Columns.Add(col4)

        'col4 = New DataColumn
        'col4.DataType = Type.GetType("System.String")
        'col4.ColumnName = "ART"
        'col4.MaxLength = 100
        'dt4.Columns.Add(col4)

        Return dt4

    End Function

    Public Function CreerDatatableTicketEnAttente()

        col3 = New DataColumn
        col3.DataType = Type.GetType("System.String")
        col3.ColumnName = "Numero Du Ticket"
        dt3.Columns.Add(col3)

        col3 = New DataColumn
        col3.DataType = Type.GetType("System.String")
        col3.ColumnName = "Date Du Ticket"
        col3.MaxLength = 100

        dt3.Columns.Add(col3)

        col3 = New DataColumn
        col3.DataType = Type.GetType("System.String")
        col3.ColumnName = "Montant Du Ticket"
        dt3.Columns.Add(col3)


        Return dt3

    End Function

    Public Function Creerdatabletarif_of_Reglement()

        col2 = New DataColumn
        col2.DataType = Type.GetType("System.String")
        col2.ColumnName = "Reglement"
        col2.ReadOnly = True
        dt2.Columns.Add(col2)

        col2 = New DataColumn
        col2.DataType = Type.GetType("System.String")
        col2.ColumnName = "Montant"
        dt2.Columns.Add(col2)

        col2 = New DataColumn
        col2.DataType = Type.GetType("System.String")
        col2.ColumnName = "Commentaire "
        dt2.Columns.Add(col2)

        col2 = New DataColumn
        col2.DataType = Type.GetType("System.String")
        col2.ColumnName = "Mode "
        dt2.Columns.Add(col2)


        Return dt2

    End Function

    Public Sub creer_data(ByVal sql As String, ByVal dgv As DataGridView)

        Dim dt7 As New DataTable
        Dim da7 As New SqlDataAdapter

        dt7.Clear()

        Connecter()

        cmd.Connection = Con()
        cmd.CommandText = sql
        da7.SelectCommand = cmd
        da7.Fill(dt7)
        dgv.DataSource = dt7
        Deconnecter()

    End Sub

#End Region


#Region "Function D'image"

    'Converter  l'image to byte
    Public Function ImageToByteArray(ByVal img As Image) As Byte()
        Dim stream As New MemoryStream
        img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return stream.ToArray
    End Function


    'Converter  Byte to   image
    Public Function ByteArrayToImage(ByVal ByteArray As Byte()) As Image
        Dim stream As New MemoryStream(ByteArray, 0, ByteArray.Length)
        Return Image.FromStream(stream, True)
    End Function

#End Region


#Region "Méthode de connection"

    Public Function Con() As SqlConnection
        Dim ConChaine As New SqlConnection(LireFichier("Connection.txt"))
        Return ConChaine
    End Function

    'Lire Une chaine  apartire D'un  fichier
    Public Function LireFichier(ByVal fichier As String) As String

        Dim str As New StreamReader(fichier)
        Dim chaine As String = str.ReadLine
        While Not str.Peek
            chaine = str.ReadToEnd
        End While
        Return chaine

    End Function

    'Connecter
    Public Sub Connecter()
        If Con.State = ConnectionState.Closed Or ConnectionState.Broken Then
            Con.Open()
        End If
    End Sub

    'Deconnecter
    Public Sub Deconnecter()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
    End Sub

#End Region


#Region "Autres"

    Public Function RecalculerPrix() As Double

        Dim v As Double = 0

        For j As Integer = 0 To FrmCaisse.DgvCommande.Rows.Count - 2

            v = v + FrmCaisse.DgvCommande.Rows(j).Cells(5).Value

        Next

        Return v

    End Function

    Public Sub viderGridCommande()

        dt.Rows.Clear()
        FrmCaisse.LblMontantApayerInfo.Text = RecalculerPrix()

    End Sub
    'Mise A Jour
    Public Sub Enregistrer(ByVal p_da As SqlDataAdapter, ByVal p_dt As DataTable)

        Dim cb As New SqlCommandBuilder(p_da)
        p_da.Update(p_dt)

    End Sub


    'Generer_ID  d'un Table
    Public Function Generer_ID(ByVal P_TABLE As DataTable, ByVal P_CHAMP As String) As Integer

        If P_TABLE.Rows.Count <> 0 Then

            Dim EXPRESSION As String = "MAX (" & P_CHAMP & ")"
            Dim FILTRE As String = P_CHAMP & ">= 0"
            Return P_TABLE.Compute(EXPRESSION, FILTRE) + 1

        End If
        Return 1

    End Function


    'Actualiser  Datatable
    Public Sub Actualiser_DataTable(ByVal P_da As SqlDataAdapter, ByVal P_Chaine As String, ByVal P_Dt As DataTable)

        P_Dt.Clear()
        P_da.SelectCommand.CommandText = P_Chaine
        P_da.SelectCommand.Connection = Con()
        P_da.Fill(P_Dt)

    End Sub


    'RechercherLe client textchanged
    Public Sub Rechercher(ByVal table As String, ByVal champAchercher As TextBox, ByVal dgv As DataGridView, ByVal pos As Integer)

        Dim dt As DataTable = ds.Tables(table).Clone
        For i As Integer = 0 To ds.Tables(table).Rows.Count - 1
            If ds.Tables(table).Rows(i)(pos).ToString.Length >= champAchercher.Text.Length Then
                If ds.Tables(table).Rows(i)(pos).ToString.Substring(0, champAchercher.Text.Length).ToLower = champAchercher.Text.ToString.Substring(0, champAchercher.Text.Length).ToLower Then
                    Dim dr As DataRow = ds.Tables(table).Rows(i)
                    dt.ImportRow(dr)
                End If
            End If

        Next

        dgv.DataSource = dt

    End Sub

#End Region


#Region "Méthodes de verification"

    'Vider  Un  Label
    Public Sub EffacerLabel(ByVal grb As GroupBox)
        For Each ctl As Control In grb.Controls
            If TypeOf ctl Is Label Then
                If ctl.Text <> "" Then
                    ctl.Text = ""
                End If
            End If
        Next
    End Sub

    Public Sub GetResolution(ByVal frm As Form)

        Dim screenHeight As Integer = My.Computer.Screen.Bounds.Height
        Dim screenWidth As Integer = My.Computer.Screen.Bounds.Width
        Dim x As Integer = My.Computer.Screen.Bounds.X
        Dim y As Integer = My.Computer.Screen.Bounds.Y
        frm.SetBounds(x, y, screenWidth, screenHeight)

    End Sub

    Public Sub ViderForm(ByVal Ob As Object)

        For Each Ctl As Control In Ob.controls

            If TypeOf Ctl Is TextBox Or TypeOf Ctl Is RichTextBox Then
                Ctl.Text = ""
            End If

            If TypeOf Ctl Is RadioButton Then
                If CType(Ctl, RadioButton).Checked = True Then
                    CType(Ctl, RadioButton).Checked = False
                End If
            End If

            If TypeOf Ctl Is ComboBox Then
                CType(Ctl, ComboBox).SelectedItem = "--Faite votre choix--"
            End If

            If TypeOf Ctl Is CheckBox Then
                If CType(Ctl, CheckBox).Checked = True Then
                    CType(Ctl, CheckBox).Checked = False
                End If
            End If

            If TypeOf Ctl Is DateTimePicker Then
                CType(Ctl, DateTimePicker).Value = Now.Date
            End If

            If TypeOf Ctl Is GroupBox Then
                ViderForm(Ctl)
            End If

        Next
    End Sub


    Public Function EstNumeric(ByVal zone As TextBox, ByVal f As Object) As Boolean
        For Each ctl As Control In f.controls
            If TypeOf ctl Is Label And ctl.Name.Substring(3) = zone.Name.Substring(3) Then
                If Not IsNumeric(zone.Text) Then
                    MsgBox(" le champs" & ctl.Text & "  doit être numérique !")
                    zone.Focus()
                    zone.SelectAll()
                    Return False
                End If
            End If
        Next

        Return True
    End Function


    Public Function VerifierVide(ByVal ob As Object) As Boolean

        For Each ctl As Control In ob.Controls
            If TypeOf ctl Is TextBox Or TypeOf ctl Is RichTextBox Then
                If ctl.Text = "" Then
                    For Each ctl2 As Control In ob.Controls
                        If TypeOf ctl2 Is Label And ctl2.Font.Underline = True Then

                            If CType(ctl2, Label).Name.Substring(3) = ctl.Name.Substring(3) Then
                                MsgBox("Le champ " & CType(ctl2, Label).Text & " est obligatoire", MsgBoxStyle.Information)
                                ctl.Focus()
                                Return True
                                Exit Function
                            End If

                        End If
                    Next
                End If
            End If

            If TypeOf ctl Is ComboBox Then

                If CType(ctl, ComboBox).SelectedItem = "--Faite votre choix--" Then

                    For Each ctl2 As Control In ob.controls
                        If TypeOf ctl2 Is Label And CType(ctl2, Label).Name.Substring(3) = ctl.Name.Substring(3) And ctl2.Font.Underline = True Then

                            MsgBox("Veuillez choisir votre " & ctl2.Text & "SVP!!", MsgBoxStyle.Information)
                            CType(ctl, ComboBox).Focus()
                            Return True
                            Exit Function

                        End If
                    Next

                End If

            End If

            If TypeOf ctl Is DateTimePicker Then
                If CType(ctl, DateTimePicker).Text = Now.Date Then
                    For Each ctl2 As Control In ob.controls
                        If TypeOf ctl2 Is Label And ctl2.Name.Substring(3) = ctl.Name.Substring(3) And ctl2.Font.Underline = True Then

                            MsgBox("Vous de devez entrer une date valide")
                            ctl.Focus()
                            Return True
                            Exit Function

                        End If
                    Next

                End If
            End If

            Dim coché As Integer

            If TypeOf ctl Is GroupBox And ctl.Font.Underline = True Then

                For Each ctl2 As Control In ctl.Controls
                    If TypeOf ctl2 Is RadioButton Then

                        If CType(ctl2, RadioButton).Checked = True Then
                            coché = 1
                        End If

                    End If
                Next

                If coché = 0 Then
                    MsgBox("Vous dever cocher un " & ctl.Text & " SVP!!")
                    Return True
                    Exit Function
                End If

            End If

        Next

        Return False

    End Function


    Public Sub Fermer_Form(ByVal Mdi As Form)

        For Each mdi_children As Form In Mdi.MdiChildren

            mdi_children.Close()

        Next

    End Sub


    Public Sub AfficherDansForm(ByVal Dvg As DataGridView, ByVal ob As Object)

        For i As Integer = 0 To Dvg.ColumnCount - 1

            For Each ctl As Control In ob.Controls

                If (TypeOf ctl Is TextBox Or TypeOf ctl Is RichTextBox) And (ctl.Name.Substring(3) = Dvg.Columns(i).Name) Then
                    ctl.Text = Dvg.CurrentRow.Cells(Dvg.Columns(i).Name).Value
                End If

                'If TypeOf ctl Is RadioButton Then

                '    If CType(ctl, RadioButton).Tag = Dvg.CurrentRow.Cells(CType(ctl, RadioButton).Name.Substring(3)).Value Then

                '        CType(ctl, RadioButton).Checked = True

                '    End If

                'End If

                If TypeOf ctl Is ComboBox Then

                    If ctl.Name.Substring(3) = Dvg.Columns(i).Name Then

                        CType(ctl, ComboBox).SelectedItem = Dvg.CurrentRow.Cells(Dvg.Columns(i).Name).Value

                        CType(ctl, ComboBox).SelectedItem = Dvg.CurrentRow.Cells(Dvg.Columns(i).Name).Value

                    End If
                End If

                'If TypeOf ctl Is DateTimePicker Then

                '    If CType(ctl, DateTimePicker).Value = Dvg.CurrentRow.Cells(CType(ctl, DateTimePicker).Name.Substring(3)).Value Then

                '        CType(ctl, DateTimePicker).Value = Dvg.CurrentRow.Cells(CType(ctl, DateTimePicker).Name.Substring(3)).Value

                '    End If

                'End If

                If TypeOf ctl Is GroupBox Then

                    AfficherDansForm(Dvg, ctl)

                End If

            Next
        Next
      

    End Sub


    Public Sub Bloquer_Formulaire(ByVal P_OBJET As Object)

        For Each o_CONTROL As Control In P_OBJET.Controls
            If TypeOf o_CONTROL Is TextBox _
               Or TypeOf o_CONTROL Is RichTextBox _
               Or TypeOf o_CONTROL Is DateTimePicker _
               Or TypeOf o_CONTROL Is CheckBox _
               Or TypeOf o_CONTROL Is RadioButton _
               Or TypeOf o_CONTROL Is ComboBox Then

                o_CONTROL.Enabled = False

            End If
            If TypeOf o_CONTROL Is GroupBox Then

                Bloquer_Formulaire(o_CONTROL)

            End If
        Next

    End Sub


    Public Function VerifierRadioBotton(ByVal grp As GroupBox) As Boolean
        Dim ctl As Control
        For Each ctl In grp.Controls
            If TypeOf ctl Is RadioButton Then
                If CType(ctl, RadioButton).Checked = True Then
                    Return True
                    Exit Function
                End If
            End If
        Next
        Return False

    End Function

#End Region


End Module
