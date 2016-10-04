<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticle
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArticle))
        Me.grpbxVehicule = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LstMarque = New System.Windows.Forms.ListBox()
        Me.LstSousFamille = New System.Windows.Forms.ListBox()
        Me.grpbxIdentite = New System.Windows.Forms.GroupBox()
        Me.txtRef = New System.Windows.Forms.TextBox()
        Me.lblRef = New System.Windows.Forms.Label()
        Me.dtpDateEntré = New System.Windows.Forms.DateTimePicker()
        Me.lblDateEnt = New System.Windows.Forms.Label()
        Me.dtpDatePeremtion = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateModification = New System.Windows.Forms.DateTimePicker()
        Me.lblDateAcquisition = New System.Windows.Forms.Label()
        Me.lblMiseEnCirculation = New System.Windows.Forms.Label()
        Me.grpbxTechniques = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrixUnitaireHT = New System.Windows.Forms.TextBox()
        Me.txttauxTVA = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrixachat = New System.Windows.Forms.TextBox()
        Me.CbConsomable = New System.Windows.Forms.CheckBox()
        Me.cbStockable = New System.Windows.Forms.CheckBox()
        Me.lblPrixVente = New System.Windows.Forms.Label()
        Me.txtstockmin = New System.Windows.Forms.TextBox()
        Me.txtstockalerte = New System.Windows.Forms.TextBox()
        Me.lblPrixachat = New System.Windows.Forms.Label()
        Me.txtstockReserve = New System.Windows.Forms.TextBox()
        Me.txtstockreel = New System.Windows.Forms.TextBox()
        Me.txtstockmax = New System.Windows.Forms.TextBox()
        Me.lblstockmin = New System.Windows.Forms.Label()
        Me.lblstockalert = New System.Windows.Forms.Label()
        Me.lblStockreel = New System.Windows.Forms.Label()
        Me.Stockmax = New System.Windows.Forms.Label()
        Me.lblPoidsTRkg = New System.Windows.Forms.Label()
        Me.lblPoidsAVkg = New System.Windows.Forms.Label()
        Me.lblPoidsTCkg = New System.Windows.Forms.Label()
        Me.lblstockreserve = New System.Windows.Forms.Label()
        Me.lblPrixUHT = New System.Windows.Forms.Label()
        Me.lblTauxTVA = New System.Windows.Forms.Label()
        Me.grpbxProprietaire = New System.Windows.Forms.GroupBox()
        Me.Cmb_Type = New System.Windows.Forms.ComboBox()
        Me.RTbDescription = New System.Windows.Forms.RichTextBox()
        Me.txtNatureArticle = New System.Windows.Forms.TextBox()
        Me.lblNature = New System.Windows.Forms.Label()
        Me.lbltypearticle = New System.Windows.Forms.Label()
        Me.txtMotifModification = New System.Windows.Forms.TextBox()
        Me.lblMotifModification = New System.Windows.Forms.Label()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.grpbxComplementaire = New System.Windows.Forms.GroupBox()
        Me.BtnNouveauTva = New System.Windows.Forms.Button()
        Me.CmbTva = New System.Windows.Forms.ComboBox()
        Me.lbltva = New System.Windows.Forms.Label()
        Me.BtnAjouterCodeBarre = New System.Windows.Forms.Button()
        Me.txtCodeBarre = New System.Windows.Forms.TextBox()
        Me.lblCodeBarre = New System.Windows.Forms.Label()
        Me.DgvTarifOfArticle = New System.Windows.Forms.DataGridView()
        Me.TXTPIC = New System.Windows.Forms.TextBox()
        Me.grbPhoto = New System.Windows.Forms.GroupBox()
        Me.PBXPhotos = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.btnVider = New System.Windows.Forms.Button()
        Me.BtnChoixTarif = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Pbx_CB = New System.Windows.Forms.PictureBox()
        Me.LblArticle = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.grpbxVehicule.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpbxIdentite.SuspendLayout()
        Me.grpbxTechniques.SuspendLayout()
        Me.grpbxProprietaire.SuspendLayout()
        Me.grpbxComplementaire.SuspendLayout()
        CType(Me.DgvTarifOfArticle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbPhoto.SuspendLayout()
        CType(Me.PBXPhotos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Pbx_CB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpbxVehicule
        '
        Me.grpbxVehicule.Controls.Add(Me.GroupBox2)
        Me.grpbxVehicule.Controls.Add(Me.grpbxIdentite)
        Me.grpbxVehicule.Controls.Add(Me.grpbxTechniques)
        Me.grpbxVehicule.Controls.Add(Me.grpbxProprietaire)
        Me.grpbxVehicule.Controls.Add(Me.grpbxComplementaire)
        Me.grpbxVehicule.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxVehicule.ForeColor = System.Drawing.Color.Purple
        Me.grpbxVehicule.Location = New System.Drawing.Point(3, 21)
        Me.grpbxVehicule.Name = "grpbxVehicule"
        Me.grpbxVehicule.Size = New System.Drawing.Size(836, 634)
        Me.grpbxVehicule.TabIndex = 34
        Me.grpbxVehicule.TabStop = False
        Me.grpbxVehicule.Text = "Fiche Article"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LstMarque)
        Me.GroupBox2.Controls.Add(Me.LstSousFamille)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox2.Location = New System.Drawing.Point(374, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 204)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Emplacement "
        '
        'LstMarque
        '
        Me.LstMarque.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LstMarque.FormattingEnabled = True
        Me.LstMarque.Location = New System.Drawing.Point(226, 23)
        Me.LstMarque.Name = "LstMarque"
        Me.LstMarque.Size = New System.Drawing.Size(216, 160)
        Me.LstMarque.TabIndex = 3
        '
        'LstSousFamille
        '
        Me.LstSousFamille.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LstSousFamille.FormattingEnabled = True
        Me.LstSousFamille.IntegralHeight = False
        Me.LstSousFamille.Location = New System.Drawing.Point(5, 23)
        Me.LstSousFamille.Name = "LstSousFamille"
        Me.LstSousFamille.Size = New System.Drawing.Size(216, 160)
        Me.LstSousFamille.TabIndex = 2
        '
        'grpbxIdentite
        '
        Me.grpbxIdentite.Controls.Add(Me.txtRef)
        Me.grpbxIdentite.Controls.Add(Me.lblRef)
        Me.grpbxIdentite.Controls.Add(Me.dtpDateEntré)
        Me.grpbxIdentite.Controls.Add(Me.lblDateEnt)
        Me.grpbxIdentite.Controls.Add(Me.dtpDatePeremtion)
        Me.grpbxIdentite.Controls.Add(Me.dtpDateModification)
        Me.grpbxIdentite.Controls.Add(Me.lblDateAcquisition)
        Me.grpbxIdentite.Controls.Add(Me.lblMiseEnCirculation)
        Me.grpbxIdentite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxIdentite.ForeColor = System.Drawing.Color.Purple
        Me.grpbxIdentite.Location = New System.Drawing.Point(12, 229)
        Me.grpbxIdentite.Name = "grpbxIdentite"
        Me.grpbxIdentite.Size = New System.Drawing.Size(810, 108)
        Me.grpbxIdentite.TabIndex = 30
        Me.grpbxIdentite.TabStop = False
        Me.grpbxIdentite.Text = "Identité d'article"
        '
        'txtRef
        '
        Me.txtRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRef.Location = New System.Drawing.Point(132, 45)
        Me.txtRef.Name = "txtRef"
        Me.txtRef.Size = New System.Drawing.Size(208, 20)
        Me.txtRef.TabIndex = 5
        '
        'lblRef
        '
        Me.lblRef.AutoSize = True
        Me.lblRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRef.ForeColor = System.Drawing.Color.Black
        Me.lblRef.Location = New System.Drawing.Point(28, 48)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(66, 13)
        Me.lblRef.TabIndex = 13
        Me.lblRef.Text = "Référence"
        '
        'dtpDateEntré
        '
        Me.dtpDateEntré.Location = New System.Drawing.Point(131, 74)
        Me.dtpDateEntré.Name = "dtpDateEntré"
        Me.dtpDateEntré.Size = New System.Drawing.Size(208, 20)
        Me.dtpDateEntré.TabIndex = 6
        Me.dtpDateEntré.Value = New Date(2006, 7, 30, 0, 0, 0, 0)
        '
        'lblDateEnt
        '
        Me.lblDateEnt.AutoSize = True
        Me.lblDateEnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateEnt.ForeColor = System.Drawing.Color.Black
        Me.lblDateEnt.Location = New System.Drawing.Point(28, 77)
        Me.lblDateEnt.Name = "lblDateEnt"
        Me.lblDateEnt.Size = New System.Drawing.Size(84, 13)
        Me.lblDateEnt.TabIndex = 5
        Me.lblDateEnt.Text = "Date d'entrée"
        '
        'dtpDatePeremtion
        '
        Me.dtpDatePeremtion.Location = New System.Drawing.Point(564, 71)
        Me.dtpDatePeremtion.Name = "dtpDatePeremtion"
        Me.dtpDatePeremtion.Size = New System.Drawing.Size(208, 20)
        Me.dtpDatePeremtion.TabIndex = 8
        Me.dtpDatePeremtion.Value = New Date(2006, 7, 30, 0, 0, 0, 0)
        '
        'dtpDateModification
        '
        Me.dtpDateModification.Location = New System.Drawing.Point(564, 42)
        Me.dtpDateModification.Name = "dtpDateModification"
        Me.dtpDateModification.Size = New System.Drawing.Size(208, 20)
        Me.dtpDateModification.TabIndex = 7
        Me.dtpDateModification.Value = New Date(2006, 7, 30, 0, 0, 0, 0)
        '
        'lblDateAcquisition
        '
        Me.lblDateAcquisition.AutoSize = True
        Me.lblDateAcquisition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateAcquisition.ForeColor = System.Drawing.Color.Black
        Me.lblDateAcquisition.Location = New System.Drawing.Point(447, 74)
        Me.lblDateAcquisition.Name = "lblDateAcquisition"
        Me.lblDateAcquisition.Size = New System.Drawing.Size(94, 13)
        Me.lblDateAcquisition.TabIndex = 3
        Me.lblDateAcquisition.Text = "Date Peremtion"
        '
        'lblMiseEnCirculation
        '
        Me.lblMiseEnCirculation.AutoSize = True
        Me.lblMiseEnCirculation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiseEnCirculation.ForeColor = System.Drawing.Color.Black
        Me.lblMiseEnCirculation.Location = New System.Drawing.Point(449, 48)
        Me.lblMiseEnCirculation.Name = "lblMiseEnCirculation"
        Me.lblMiseEnCirculation.Size = New System.Drawing.Size(107, 13)
        Me.lblMiseEnCirculation.TabIndex = 3
        Me.lblMiseEnCirculation.Text = "Date Modification"
        '
        'grpbxTechniques
        '
        Me.grpbxTechniques.Controls.Add(Me.Label7)
        Me.grpbxTechniques.Controls.Add(Me.Label5)
        Me.grpbxTechniques.Controls.Add(Me.Label4)
        Me.grpbxTechniques.Controls.Add(Me.txtPrixUnitaireHT)
        Me.grpbxTechniques.Controls.Add(Me.txttauxTVA)
        Me.grpbxTechniques.Controls.Add(Me.TextBox1)
        Me.grpbxTechniques.Controls.Add(Me.Label2)
        Me.grpbxTechniques.Controls.Add(Me.Label1)
        Me.grpbxTechniques.Controls.Add(Me.txtPrixachat)
        Me.grpbxTechniques.Controls.Add(Me.CbConsomable)
        Me.grpbxTechniques.Controls.Add(Me.cbStockable)
        Me.grpbxTechniques.Controls.Add(Me.lblPrixVente)
        Me.grpbxTechniques.Controls.Add(Me.txtstockmin)
        Me.grpbxTechniques.Controls.Add(Me.txtstockalerte)
        Me.grpbxTechniques.Controls.Add(Me.lblPrixachat)
        Me.grpbxTechniques.Controls.Add(Me.txtstockReserve)
        Me.grpbxTechniques.Controls.Add(Me.txtstockreel)
        Me.grpbxTechniques.Controls.Add(Me.txtstockmax)
        Me.grpbxTechniques.Controls.Add(Me.lblstockmin)
        Me.grpbxTechniques.Controls.Add(Me.lblstockalert)
        Me.grpbxTechniques.Controls.Add(Me.lblStockreel)
        Me.grpbxTechniques.Controls.Add(Me.Stockmax)
        Me.grpbxTechniques.Controls.Add(Me.lblPoidsTRkg)
        Me.grpbxTechniques.Controls.Add(Me.lblPoidsAVkg)
        Me.grpbxTechniques.Controls.Add(Me.lblPoidsTCkg)
        Me.grpbxTechniques.Controls.Add(Me.lblstockreserve)
        Me.grpbxTechniques.Controls.Add(Me.lblPrixUHT)
        Me.grpbxTechniques.Controls.Add(Me.lblTauxTVA)
        Me.grpbxTechniques.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxTechniques.ForeColor = System.Drawing.Color.Purple
        Me.grpbxTechniques.Location = New System.Drawing.Point(13, 442)
        Me.grpbxTechniques.Name = "grpbxTechniques"
        Me.grpbxTechniques.Size = New System.Drawing.Size(809, 167)
        Me.grpbxTechniques.TabIndex = 29
        Me.grpbxTechniques.TabStop = False
        Me.grpbxTechniques.Text = "Données Techniques"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Location = New System.Drawing.Point(196, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "DH"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(706, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "DH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(706, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "DH"
        '
        'txtPrixUnitaireHT
        '
        Me.txtPrixUnitaireHT.Location = New System.Drawing.Point(115, 65)
        Me.txtPrixUnitaireHT.MaxLength = 9
        Me.txtPrixUnitaireHT.Name = "txtPrixUnitaireHT"
        Me.txtPrixUnitaireHT.Size = New System.Drawing.Size(75, 20)
        Me.txtPrixUnitaireHT.TabIndex = 16
        Me.txtPrixUnitaireHT.Text = "0"
        Me.txtPrixUnitaireHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttauxTVA
        '
        Me.txttauxTVA.Location = New System.Drawing.Point(115, 95)
        Me.txttauxTVA.MaxLength = 9
        Me.txttauxTVA.Name = "txttauxTVA"
        Me.txttauxTVA.Size = New System.Drawing.Size(75, 20)
        Me.txttauxTVA.TabIndex = 17
        Me.txttauxTVA.Text = "0"
        Me.txttauxTVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(623, 98)
        Me.TextBox1.MaxLength = 5
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(80, 20)
        Me.TextBox1.TabIndex = 23
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(196, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "tonne"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(448, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "tonne"
        '
        'txtPrixachat
        '
        Me.txtPrixachat.Location = New System.Drawing.Point(622, 70)
        Me.txtPrixachat.MaxLength = 9
        Me.txtPrixachat.Name = "txtPrixachat"
        Me.txtPrixachat.Size = New System.Drawing.Size(80, 20)
        Me.txtPrixachat.TabIndex = 22
        Me.txtPrixachat.Text = "0"
        Me.txtPrixachat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CbConsomable
        '
        Me.CbConsomable.AutoSize = True
        Me.CbConsomable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbConsomable.ForeColor = System.Drawing.Color.Black
        Me.CbConsomable.Location = New System.Drawing.Point(559, 33)
        Me.CbConsomable.Name = "CbConsomable"
        Me.CbConsomable.Size = New System.Drawing.Size(94, 17)
        Me.CbConsomable.TabIndex = 15
        Me.CbConsomable.Text = "Consomable"
        Me.CbConsomable.UseVisualStyleBackColor = True
        '
        'cbStockable
        '
        Me.cbStockable.AutoSize = True
        Me.cbStockable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStockable.ForeColor = System.Drawing.Color.Black
        Me.cbStockable.Location = New System.Drawing.Point(115, 33)
        Me.cbStockable.Name = "cbStockable"
        Me.cbStockable.Size = New System.Drawing.Size(83, 17)
        Me.cbStockable.TabIndex = 14
        Me.cbStockable.Text = "Stockable"
        Me.cbStockable.UseVisualStyleBackColor = True
        '
        'lblPrixVente
        '
        Me.lblPrixVente.AutoSize = True
        Me.lblPrixVente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixVente.ForeColor = System.Drawing.Color.Black
        Me.lblPrixVente.Location = New System.Drawing.Point(517, 100)
        Me.lblPrixVente.Name = "lblPrixVente"
        Me.lblPrixVente.Size = New System.Drawing.Size(61, 13)
        Me.lblPrixVente.TabIndex = 21
        Me.lblPrixVente.Text = "PrixVente"
        '
        'txtstockmin
        '
        Me.txtstockmin.Location = New System.Drawing.Point(356, 94)
        Me.txtstockmin.MaxLength = 5
        Me.txtstockmin.Name = "txtstockmin"
        Me.txtstockmin.Size = New System.Drawing.Size(84, 20)
        Me.txtstockmin.TabIndex = 20
        Me.txtstockmin.Text = "0"
        Me.txtstockmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtstockalerte
        '
        Me.txtstockalerte.Location = New System.Drawing.Point(356, 124)
        Me.txtstockalerte.MaxLength = 5
        Me.txtstockalerte.Name = "txtstockalerte"
        Me.txtstockalerte.Size = New System.Drawing.Size(84, 20)
        Me.txtstockalerte.TabIndex = 21
        Me.txtstockalerte.Text = "0"
        Me.txtstockalerte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPrixachat
        '
        Me.lblPrixachat.AutoSize = True
        Me.lblPrixachat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixachat.ForeColor = System.Drawing.Color.Black
        Me.lblPrixachat.Location = New System.Drawing.Point(517, 74)
        Me.lblPrixachat.Name = "lblPrixachat"
        Me.lblPrixachat.Size = New System.Drawing.Size(76, 13)
        Me.lblPrixachat.TabIndex = 20
        Me.lblPrixachat.Text = "Prix D'achat"
        '
        'txtstockReserve
        '
        Me.txtstockReserve.Location = New System.Drawing.Point(623, 124)
        Me.txtstockReserve.MaxLength = 5
        Me.txtstockReserve.Name = "txtstockReserve"
        Me.txtstockReserve.Size = New System.Drawing.Size(79, 20)
        Me.txtstockReserve.TabIndex = 24
        Me.txtstockReserve.Text = "0"
        Me.txtstockReserve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtstockreel
        '
        Me.txtstockreel.Location = New System.Drawing.Point(115, 124)
        Me.txtstockreel.MaxLength = 3
        Me.txtstockreel.Name = "txtstockreel"
        Me.txtstockreel.Size = New System.Drawing.Size(75, 20)
        Me.txtstockreel.TabIndex = 18
        Me.txtstockreel.Text = "0"
        Me.txtstockreel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtstockmax
        '
        Me.txtstockmax.Location = New System.Drawing.Point(356, 67)
        Me.txtstockmax.MaxLength = 9
        Me.txtstockmax.Name = "txtstockmax"
        Me.txtstockmax.Size = New System.Drawing.Size(84, 20)
        Me.txtstockmax.TabIndex = 19
        Me.txtstockmax.Text = "0"
        Me.txtstockmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblstockmin
        '
        Me.lblstockmin.AutoSize = True
        Me.lblstockmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstockmin.ForeColor = System.Drawing.Color.Black
        Me.lblstockmin.Location = New System.Drawing.Point(259, 100)
        Me.lblstockmin.Name = "lblstockmin"
        Me.lblstockmin.Size = New System.Drawing.Size(64, 13)
        Me.lblstockmin.TabIndex = 9
        Me.lblstockmin.Text = "Stock Min"
        '
        'lblstockalert
        '
        Me.lblstockalert.AutoSize = True
        Me.lblstockalert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstockalert.ForeColor = System.Drawing.Color.Black
        Me.lblstockalert.Location = New System.Drawing.Point(256, 127)
        Me.lblstockalert.Name = "lblstockalert"
        Me.lblstockalert.Size = New System.Drawing.Size(77, 13)
        Me.lblstockalert.TabIndex = 9
        Me.lblstockalert.Text = "Stock Alerte"
        '
        'lblStockreel
        '
        Me.lblStockreel.AutoSize = True
        Me.lblStockreel.ForeColor = System.Drawing.Color.Black
        Me.lblStockreel.Location = New System.Drawing.Point(9, 126)
        Me.lblStockreel.Name = "lblStockreel"
        Me.lblStockreel.Size = New System.Drawing.Size(70, 13)
        Me.lblStockreel.TabIndex = 9
        Me.lblStockreel.Text = "Stock Réel"
        '
        'Stockmax
        '
        Me.Stockmax.AutoSize = True
        Me.Stockmax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stockmax.ForeColor = System.Drawing.Color.Black
        Me.Stockmax.Location = New System.Drawing.Point(259, 70)
        Me.Stockmax.Name = "Stockmax"
        Me.Stockmax.Size = New System.Drawing.Size(67, 13)
        Me.Stockmax.TabIndex = 9
        Me.Stockmax.Text = "Stock Max"
        '
        'lblPoidsTRkg
        '
        Me.lblPoidsTRkg.AutoSize = True
        Me.lblPoidsTRkg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoidsTRkg.ForeColor = System.Drawing.Color.Black
        Me.lblPoidsTRkg.Location = New System.Drawing.Point(448, 128)
        Me.lblPoidsTRkg.Name = "lblPoidsTRkg"
        Me.lblPoidsTRkg.Size = New System.Drawing.Size(39, 13)
        Me.lblPoidsTRkg.TabIndex = 9
        Me.lblPoidsTRkg.Text = "tonne"
        '
        'lblPoidsAVkg
        '
        Me.lblPoidsAVkg.AutoSize = True
        Me.lblPoidsAVkg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoidsAVkg.ForeColor = System.Drawing.Color.Black
        Me.lblPoidsAVkg.Location = New System.Drawing.Point(448, 92)
        Me.lblPoidsAVkg.Name = "lblPoidsAVkg"
        Me.lblPoidsAVkg.Size = New System.Drawing.Size(39, 13)
        Me.lblPoidsAVkg.TabIndex = 0
        Me.lblPoidsAVkg.Text = "tonne"
        '
        'lblPoidsTCkg
        '
        Me.lblPoidsTCkg.AutoSize = True
        Me.lblPoidsTCkg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoidsTCkg.ForeColor = System.Drawing.Color.Black
        Me.lblPoidsTCkg.Location = New System.Drawing.Point(705, 129)
        Me.lblPoidsTCkg.Name = "lblPoidsTCkg"
        Me.lblPoidsTCkg.Size = New System.Drawing.Size(39, 13)
        Me.lblPoidsTCkg.TabIndex = 9
        Me.lblPoidsTCkg.Text = "tonne"
        '
        'lblstockreserve
        '
        Me.lblstockreserve.AutoSize = True
        Me.lblstockreserve.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstockreserve.ForeColor = System.Drawing.Color.Black
        Me.lblstockreserve.Location = New System.Drawing.Point(517, 127)
        Me.lblstockreserve.Name = "lblstockreserve"
        Me.lblstockreserve.Size = New System.Drawing.Size(91, 13)
        Me.lblstockreserve.TabIndex = 8
        Me.lblstockreserve.Text = "Stock Reserve"
        '
        'lblPrixUHT
        '
        Me.lblPrixUHT.AutoSize = True
        Me.lblPrixUHT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixUHT.ForeColor = System.Drawing.Color.Black
        Me.lblPrixUHT.Location = New System.Drawing.Point(9, 69)
        Me.lblPrixUHT.Name = "lblPrixUHT"
        Me.lblPrixUHT.Size = New System.Drawing.Size(97, 13)
        Me.lblPrixUHT.TabIndex = 9
        Me.lblPrixUHT.Text = "Prix Unitaire HT"
        '
        'lblTauxTVA
        '
        Me.lblTauxTVA.AutoSize = True
        Me.lblTauxTVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTauxTVA.ForeColor = System.Drawing.Color.Black
        Me.lblTauxTVA.Location = New System.Drawing.Point(8, 96)
        Me.lblTauxTVA.Name = "lblTauxTVA"
        Me.lblTauxTVA.Size = New System.Drawing.Size(71, 13)
        Me.lblTauxTVA.TabIndex = 8
        Me.lblTauxTVA.Text = "Taux T.V.A"
        '
        'grpbxProprietaire
        '
        Me.grpbxProprietaire.Controls.Add(Me.Cmb_Type)
        Me.grpbxProprietaire.Controls.Add(Me.RTbDescription)
        Me.grpbxProprietaire.Controls.Add(Me.txtNatureArticle)
        Me.grpbxProprietaire.Controls.Add(Me.lblNature)
        Me.grpbxProprietaire.Controls.Add(Me.lbltypearticle)
        Me.grpbxProprietaire.Controls.Add(Me.txtMotifModification)
        Me.grpbxProprietaire.Controls.Add(Me.lblMotifModification)
        Me.grpbxProprietaire.Controls.Add(Me.lbldescription)
        Me.grpbxProprietaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxProprietaire.ForeColor = System.Drawing.Color.Purple
        Me.grpbxProprietaire.Location = New System.Drawing.Point(12, 19)
        Me.grpbxProprietaire.Name = "grpbxProprietaire"
        Me.grpbxProprietaire.Size = New System.Drawing.Size(356, 204)
        Me.grpbxProprietaire.TabIndex = 27
        Me.grpbxProprietaire.TabStop = False
        Me.grpbxProprietaire.Text = "Propriétaire"
        '
        'Cmb_Type
        '
        Me.Cmb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Type.FormattingEnabled = True
        Me.Cmb_Type.Location = New System.Drawing.Point(131, 132)
        Me.Cmb_Type.Name = "Cmb_Type"
        Me.Cmb_Type.Size = New System.Drawing.Size(216, 21)
        Me.Cmb_Type.TabIndex = 94
        '
        'RTbDescription
        '
        Me.RTbDescription.Location = New System.Drawing.Point(134, 27)
        Me.RTbDescription.Name = "RTbDescription"
        Me.RTbDescription.Size = New System.Drawing.Size(214, 67)
        Me.RTbDescription.TabIndex = 18
        Me.RTbDescription.Text = ""
        '
        'txtNatureArticle
        '
        Me.txtNatureArticle.Location = New System.Drawing.Point(133, 103)
        Me.txtNatureArticle.Name = "txtNatureArticle"
        Me.txtNatureArticle.Size = New System.Drawing.Size(215, 20)
        Me.txtNatureArticle.TabIndex = 19
        '
        'lblNature
        '
        Me.lblNature.AutoSize = True
        Me.lblNature.ForeColor = System.Drawing.Color.Black
        Me.lblNature.Location = New System.Drawing.Point(18, 107)
        Me.lblNature.Name = "lblNature"
        Me.lblNature.Size = New System.Drawing.Size(85, 13)
        Me.lblNature.TabIndex = 24
        Me.lblNature.Text = "Nature Article"
        '
        'lbltypearticle
        '
        Me.lbltypearticle.AutoSize = True
        Me.lbltypearticle.ForeColor = System.Drawing.Color.Black
        Me.lbltypearticle.Location = New System.Drawing.Point(18, 135)
        Me.lbltypearticle.Name = "lbltypearticle"
        Me.lbltypearticle.Size = New System.Drawing.Size(84, 13)
        Me.lbltypearticle.TabIndex = 23
        Me.lbltypearticle.Text = "Type d'article"
        '
        'txtMotifModification
        '
        Me.txtMotifModification.Location = New System.Drawing.Point(132, 159)
        Me.txtMotifModification.Name = "txtMotifModification"
        Me.txtMotifModification.Size = New System.Drawing.Size(215, 20)
        Me.txtMotifModification.TabIndex = 20
        '
        'lblMotifModification
        '
        Me.lblMotifModification.AutoSize = True
        Me.lblMotifModification.ForeColor = System.Drawing.Color.Black
        Me.lblMotifModification.Location = New System.Drawing.Point(18, 164)
        Me.lblMotifModification.Name = "lblMotifModification"
        Me.lblMotifModification.Size = New System.Drawing.Size(108, 13)
        Me.lblMotifModification.TabIndex = 22
        Me.lblMotifModification.Text = "Motif Modification"
        '
        'lbldescription
        '
        Me.lbldescription.AutoSize = True
        Me.lbldescription.ForeColor = System.Drawing.Color.Black
        Me.lbldescription.Location = New System.Drawing.Point(20, 29)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(71, 13)
        Me.lbldescription.TabIndex = 21
        Me.lbldescription.Text = "Description"
        '
        'grpbxComplementaire
        '
        Me.grpbxComplementaire.Controls.Add(Me.BtnNouveauTva)
        Me.grpbxComplementaire.Controls.Add(Me.CmbTva)
        Me.grpbxComplementaire.Controls.Add(Me.lbltva)
        Me.grpbxComplementaire.Controls.Add(Me.BtnAjouterCodeBarre)
        Me.grpbxComplementaire.Controls.Add(Me.txtCodeBarre)
        Me.grpbxComplementaire.Controls.Add(Me.lblCodeBarre)
        Me.grpbxComplementaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxComplementaire.ForeColor = System.Drawing.Color.Purple
        Me.grpbxComplementaire.Location = New System.Drawing.Point(9, 347)
        Me.grpbxComplementaire.Name = "grpbxComplementaire"
        Me.grpbxComplementaire.Size = New System.Drawing.Size(809, 76)
        Me.grpbxComplementaire.TabIndex = 28
        Me.grpbxComplementaire.TabStop = False
        Me.grpbxComplementaire.Text = "Donneés Complémentaires"
        '
        'BtnNouveauTva
        '
        Me.BtnNouveauTva.Image = Global.Caisse.My.Resources.Resources.btAjouter224
        Me.BtnNouveauTva.Location = New System.Drawing.Point(741, 25)
        Me.BtnNouveauTva.Name = "BtnNouveauTva"
        Me.BtnNouveauTva.Size = New System.Drawing.Size(37, 25)
        Me.BtnNouveauTva.TabIndex = 13
        Me.BtnNouveauTva.UseVisualStyleBackColor = True
        '
        'CmbTva
        '
        Me.CmbTva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTva.FormattingEnabled = True
        Me.CmbTva.Location = New System.Drawing.Point(563, 25)
        Me.CmbTva.Name = "CmbTva"
        Me.CmbTva.Size = New System.Drawing.Size(172, 21)
        Me.CmbTva.TabIndex = 12
        '
        'lbltva
        '
        Me.lbltva.AutoSize = True
        Me.lbltva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltva.ForeColor = System.Drawing.Color.Black
        Me.lbltva.Location = New System.Drawing.Point(492, 33)
        Me.lbltva.Name = "lbltva"
        Me.lbltva.Size = New System.Drawing.Size(39, 13)
        Me.lbltva.TabIndex = 9
        Me.lbltva.Text = "T.V.A"
        '
        'BtnAjouterCodeBarre
        '
        Me.BtnAjouterCodeBarre.Image = Global.Caisse.My.Resources.Resources.btAjouter223
        Me.BtnAjouterCodeBarre.Location = New System.Drawing.Point(329, 28)
        Me.BtnAjouterCodeBarre.Name = "BtnAjouterCodeBarre"
        Me.BtnAjouterCodeBarre.Size = New System.Drawing.Size(37, 25)
        Me.BtnAjouterCodeBarre.TabIndex = 11
        Me.BtnAjouterCodeBarre.UseVisualStyleBackColor = True
        '
        'txtCodeBarre
        '
        Me.txtCodeBarre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodeBarre.Location = New System.Drawing.Point(127, 30)
        Me.txtCodeBarre.Name = "txtCodeBarre"
        Me.txtCodeBarre.Size = New System.Drawing.Size(196, 20)
        Me.txtCodeBarre.TabIndex = 9
        '
        'lblCodeBarre
        '
        Me.lblCodeBarre.AutoSize = True
        Me.lblCodeBarre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodeBarre.ForeColor = System.Drawing.Color.Black
        Me.lblCodeBarre.Location = New System.Drawing.Point(40, 34)
        Me.lblCodeBarre.Name = "lblCodeBarre"
        Me.lblCodeBarre.Size = New System.Drawing.Size(70, 13)
        Me.lblCodeBarre.TabIndex = 9
        Me.lblCodeBarre.Text = "Code Barre"
        '
        'DgvTarifOfArticle
        '
        Me.DgvTarifOfArticle.AllowUserToAddRows = False
        Me.DgvTarifOfArticle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvTarifOfArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTarifOfArticle.Location = New System.Drawing.Point(851, 451)
        Me.DgvTarifOfArticle.Name = "DgvTarifOfArticle"
        Me.DgvTarifOfArticle.Size = New System.Drawing.Size(426, 117)
        Me.DgvTarifOfArticle.TabIndex = 27
        '
        'TXTPIC
        '
        Me.TXTPIC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPIC.Location = New System.Drawing.Point(924, 380)
        Me.TXTPIC.Name = "TXTPIC"
        Me.TXTPIC.Size = New System.Drawing.Size(270, 20)
        Me.TXTPIC.TabIndex = 25
        '
        'grbPhoto
        '
        Me.grbPhoto.Controls.Add(Me.PBXPhotos)
        Me.grbPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grbPhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbPhoto.ForeColor = System.Drawing.Color.Purple
        Me.grbPhoto.Location = New System.Drawing.Point(845, 194)
        Me.grbPhoto.Name = "grbPhoto"
        Me.grbPhoto.Size = New System.Drawing.Size(432, 168)
        Me.grbPhoto.TabIndex = 205
        Me.grbPhoto.TabStop = False
        Me.grbPhoto.Text = "Photo"
        '
        'PBXPhotos
        '
        Me.PBXPhotos.Location = New System.Drawing.Point(6, 19)
        Me.PBXPhotos.Name = "PBXPhotos"
        Me.PBXPhotos.Size = New System.Drawing.Size(420, 139)
        Me.PBXPhotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBXPhotos.TabIndex = 8
        Me.PBXPhotos.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnAnnuler)
        Me.GroupBox1.Controls.Add(Me.btnVider)
        Me.GroupBox1.Location = New System.Drawing.Point(850, 571)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 76)
        Me.GroupBox1.TabIndex = 212
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestion :"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Image = Global.Caisse.My.Resources.Resources.btEnregistrer32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(31, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 48)
        Me.Button1.TabIndex = 214
        Me.Button1.Text = "       &Valider"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAnnuler.BackColor = System.Drawing.Color.Silver
        Me.BtnAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnnuler.ForeColor = System.Drawing.Color.Black
        Me.BtnAnnuler.Image = Global.Caisse.My.Resources.Resources.btFermer324
        Me.BtnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnnuler.Location = New System.Drawing.Point(294, 19)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(115, 48)
        Me.BtnAnnuler.TabIndex = 212
        Me.BtnAnnuler.Text = "   &Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = False
        '
        'btnVider
        '
        Me.btnVider.BackColor = System.Drawing.Color.Silver
        Me.btnVider.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnVider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVider.ForeColor = System.Drawing.Color.Black
        Me.btnVider.Image = Global.Caisse.My.Resources.Resources.btRetour323
        Me.btnVider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVider.Location = New System.Drawing.Point(171, 21)
        Me.btnVider.Name = "btnVider"
        Me.btnVider.Size = New System.Drawing.Size(117, 48)
        Me.btnVider.TabIndex = 213
        Me.btnVider.Text = "&Vider"
        Me.btnVider.UseVisualStyleBackColor = False
        '
        'BtnChoixTarif
        '
        Me.BtnChoixTarif.BackColor = System.Drawing.Color.Silver
        Me.BtnChoixTarif.Location = New System.Drawing.Point(1152, 416)
        Me.BtnChoixTarif.Name = "BtnChoixTarif"
        Me.BtnChoixTarif.Size = New System.Drawing.Size(125, 32)
        Me.BtnChoixTarif.TabIndex = 213
        Me.BtnChoixTarif.Text = "Choisir un Tarif  "
        Me.BtnChoixTarif.UseVisualStyleBackColor = False
        Me.BtnChoixTarif.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Pbx_CB)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox3.Location = New System.Drawing.Point(845, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(432, 168)
        Me.GroupBox3.TabIndex = 214
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Code Barre D'article"
        '
        'Pbx_CB
        '
        Me.Pbx_CB.Location = New System.Drawing.Point(6, 19)
        Me.Pbx_CB.Name = "Pbx_CB"
        Me.Pbx_CB.Size = New System.Drawing.Size(420, 139)
        Me.Pbx_CB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbx_CB.TabIndex = 8
        Me.Pbx_CB.TabStop = False
        '
        'LblArticle
        '
        Me.LblArticle.AutoSize = True
        Me.LblArticle.Location = New System.Drawing.Point(369, 3)
        Me.LblArticle.Name = "LblArticle"
        Me.LblArticle.Size = New System.Drawing.Size(43, 13)
        Me.LblArticle.TabIndex = 215
        Me.LblArticle.Text = "Article"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = Global.Caisse.My.Resources.Resources.btFiltre322
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(1208, 372)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 30)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FrmArticle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1276, 659)
        Me.Controls.Add(Me.LblArticle)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnChoixTarif)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TXTPIC)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.grbPhoto)
        Me.Controls.Add(Me.DgvTarifOfArticle)
        Me.Controls.Add(Me.grpbxVehicule)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmArticle"
        Me.Text = "FBA"
        Me.grpbxVehicule.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.grpbxIdentite.ResumeLayout(False)
        Me.grpbxIdentite.PerformLayout()
        Me.grpbxTechniques.ResumeLayout(False)
        Me.grpbxTechniques.PerformLayout()
        Me.grpbxProprietaire.ResumeLayout(False)
        Me.grpbxProprietaire.PerformLayout()
        Me.grpbxComplementaire.ResumeLayout(False)
        Me.grpbxComplementaire.PerformLayout()
        CType(Me.DgvTarifOfArticle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbPhoto.ResumeLayout(False)
        CType(Me.PBXPhotos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Pbx_CB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpbxVehicule As System.Windows.Forms.GroupBox
    Friend WithEvents grpbxIdentite As System.Windows.Forms.GroupBox
    Friend WithEvents txtRef As System.Windows.Forms.TextBox
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents dtpDateEntré As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDateEnt As System.Windows.Forms.Label
    Friend WithEvents dtpDatePeremtion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateModification As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDateAcquisition As System.Windows.Forms.Label
    Friend WithEvents lblMiseEnCirculation As System.Windows.Forms.Label
    Friend WithEvents grpbxTechniques As System.Windows.Forms.GroupBox
    Friend WithEvents txtPrixUnitaireHT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CbConsomable As System.Windows.Forms.CheckBox
    Friend WithEvents cbStockable As System.Windows.Forms.CheckBox
    Friend WithEvents txtstockmin As System.Windows.Forms.TextBox
    Friend WithEvents txtstockalerte As System.Windows.Forms.TextBox
    Friend WithEvents txtstockReserve As System.Windows.Forms.TextBox
    Friend WithEvents txtstockreel As System.Windows.Forms.TextBox
    Friend WithEvents txtstockmax As System.Windows.Forms.TextBox
    Friend WithEvents lblstockmin As System.Windows.Forms.Label
    Friend WithEvents lblstockalert As System.Windows.Forms.Label
    Friend WithEvents lblStockreel As System.Windows.Forms.Label
    Friend WithEvents Stockmax As System.Windows.Forms.Label
    Friend WithEvents lblPoidsTRkg As System.Windows.Forms.Label
    Friend WithEvents lblPoidsAVkg As System.Windows.Forms.Label
    Friend WithEvents lblPoidsTCkg As System.Windows.Forms.Label
    Friend WithEvents lblstockreserve As System.Windows.Forms.Label
    Friend WithEvents lblPrixUHT As System.Windows.Forms.Label
    Friend WithEvents grpbxProprietaire As System.Windows.Forms.GroupBox
    Friend WithEvents grpbxComplementaire As System.Windows.Forms.GroupBox
    Friend WithEvents lbltva As System.Windows.Forms.Label
    Friend WithEvents BtnAjouterCodeBarre As System.Windows.Forms.Button
    Friend WithEvents txtCodeBarre As System.Windows.Forms.TextBox
    Friend WithEvents lblCodeBarre As System.Windows.Forms.Label
    Friend WithEvents CmbTva As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrixachat As System.Windows.Forms.TextBox
    Friend WithEvents lblPrixVente As System.Windows.Forms.Label
    Friend WithEvents lblPrixachat As System.Windows.Forms.Label
    Friend WithEvents DgvTarifOfArticle As System.Windows.Forms.DataGridView
    Friend WithEvents TXTPIC As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents grbPhoto As System.Windows.Forms.GroupBox
    Friend WithEvents PBXPhotos As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNouveauTva As System.Windows.Forms.Button
    Friend WithEvents txttauxTVA As System.Windows.Forms.TextBox
    Friend WithEvents lblTauxTVA As System.Windows.Forms.Label
    Friend WithEvents RTbDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents txtNatureArticle As System.Windows.Forms.TextBox
    Friend WithEvents lblNature As System.Windows.Forms.Label
    Friend WithEvents lbltypearticle As System.Windows.Forms.Label
    Friend WithEvents txtMotifModification As System.Windows.Forms.TextBox
    Friend WithEvents lblMotifModification As System.Windows.Forms.Label
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents LstMarque As System.Windows.Forms.ListBox
    Friend WithEvents LstSousFamille As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnAnnuler As System.Windows.Forms.Button
    Friend WithEvents btnVider As System.Windows.Forms.Button
    Friend WithEvents BtnChoixTarif As System.Windows.Forms.Button
    Friend WithEvents Cmb_Type As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Pbx_CB As System.Windows.Forms.PictureBox
    Friend WithEvents LblArticle As System.Windows.Forms.Label
End Class
