<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListeArticle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListeArticle))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TCGestion = New System.Windows.Forms.TabControl()
        Me.TabPageRayon = New System.Windows.Forms.TabPage()
        Me.Btn_Supprimer = New System.Windows.Forms.Button()
        Me.Btn_Modifier = New System.Windows.Forms.Button()
        Me.DGVRayon = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BDSRayon = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdFermer = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRayonLibelle = New System.Windows.Forms.TextBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.TabPageFamille = New System.Windows.Forms.TabPage()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.DGVFamille = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BDSFamille = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.txtFamilleLibelle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPageSousFamille = New System.Windows.Forms.TabPage()
        Me.Button32 = New System.Windows.Forms.Button()
        Me.Button33 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.DGVSousFamille = New System.Windows.Forms.DataGridView()
        Me.SFIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FamilleofSousFamilleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SfLibDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BDSSousFamille = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.txtSousFamilleLibelle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabPageMarque = New System.Windows.Forms.TabPage()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.Button35 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.DGVMarque = New System.Windows.Forms.DataGridView()
        Me.MrqIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SousFamilleofMarquesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MrqLibDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BDSMarque = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GbxFiltreMarque = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.txtMarqueLibelle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TabPageArticle = New System.Windows.Forms.TabPage()
        Me.Button40 = New System.Windows.Forms.Button()
        Me.Button36 = New System.Windows.Forms.Button()
        Me.Button37 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Cmb_Type = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.DGVArticle = New System.Windows.Forms.DataGridView()
        Me.ARTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifOfArticleOfArticleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTREFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TvaOfArticleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeBarOfArticleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarqueOfArticleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTDATEENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTPRIXUHTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTTAUXTVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTDESCRIPTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTSTOCKMINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTDATEPEREMTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTSTOCKMAXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTPHOTODataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ARTTYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTSTOCKABLEDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ARTSTOCKREELDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTSTOCKALERTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTSTOCKRESERVEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTCONSOMABLEDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ARTNATUREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTDATEMODIFICATIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTMOTIFMODIFICATIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTICLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabPageTarif = New System.Windows.Forms.TabPage()
        Me.Button38 = New System.Windows.Forms.Button()
        Me.Button39 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.DGVTarif = New System.Windows.Forms.DataGridView()
        Me.TrfIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrfLibelleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrfCoefficientDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifOfArticleOfTarifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BDSTarif = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.txtCoefficient = New System.Windows.Forms.TextBox()
        Me.lbltrf_Coefficient = New System.Windows.Forms.Label()
        Me.txtTarif = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TCGestion.SuspendLayout()
        Me.TabPageRayon.SuspendLayout()
        CType(Me.DGVRayon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSRayon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabPageFamille.SuspendLayout()
        CType(Me.DGVFamille, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSFamille, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPageSousFamille.SuspendLayout()
        CType(Me.DGVSousFamille, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSSousFamille, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPageMarque.SuspendLayout()
        CType(Me.DGVMarque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSMarque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbxFiltreMarque.SuspendLayout()
        Me.TabPageArticle.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DGVArticle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageTarif.SuspendLayout()
        CType(Me.DGVTarif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSTarif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TCGestion
        '
        Me.TCGestion.Controls.Add(Me.TabPageRayon)
        Me.TCGestion.Controls.Add(Me.TabPageFamille)
        Me.TCGestion.Controls.Add(Me.TabPageSousFamille)
        Me.TCGestion.Controls.Add(Me.TabPageMarque)
        Me.TCGestion.Controls.Add(Me.TabPageArticle)
        Me.TCGestion.Controls.Add(Me.TabPageTarif)
        Me.TCGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCGestion.ItemSize = New System.Drawing.Size(48, 40)
        Me.TCGestion.Location = New System.Drawing.Point(12, 63)
        Me.TCGestion.Name = "TCGestion"
        Me.TCGestion.Padding = New System.Drawing.Point(6, 6)
        Me.TCGestion.SelectedIndex = 0
        Me.TCGestion.Size = New System.Drawing.Size(1134, 517)
        Me.TCGestion.TabIndex = 3
        '
        'TabPageRayon
        '
        Me.TabPageRayon.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPageRayon.Controls.Add(Me.Btn_Supprimer)
        Me.TabPageRayon.Controls.Add(Me.Btn_Modifier)
        Me.TabPageRayon.Controls.Add(Me.DGVRayon)
        Me.TabPageRayon.Controls.Add(Me.cmdFermer)
        Me.TabPageRayon.Controls.Add(Me.GroupBox3)
        Me.TabPageRayon.Controls.Add(Me.Button13)
        Me.TabPageRayon.Controls.Add(Me.Button14)
        Me.TabPageRayon.Controls.Add(Me.btnEnregistrer)
        Me.TabPageRayon.ForeColor = System.Drawing.Color.Black
        Me.TabPageRayon.Location = New System.Drawing.Point(4, 44)
        Me.TabPageRayon.Name = "TabPageRayon"
        Me.TabPageRayon.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageRayon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabPageRayon.Size = New System.Drawing.Size(1126, 469)
        Me.TabPageRayon.TabIndex = 0
        Me.TabPageRayon.Text = "    Rayon"
        '
        'Btn_Supprimer
        '
        Me.Btn_Supprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btn_Supprimer.Image = CType(resources.GetObject("Btn_Supprimer.Image"), System.Drawing.Image)
        Me.Btn_Supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Supprimer.Location = New System.Drawing.Point(466, 298)
        Me.Btn_Supprimer.Name = "Btn_Supprimer"
        Me.Btn_Supprimer.Size = New System.Drawing.Size(168, 42)
        Me.Btn_Supprimer.TabIndex = 217
        Me.Btn_Supprimer.Text = "   &Supprimer"
        Me.Btn_Supprimer.UseVisualStyleBackColor = False
        '
        'Btn_Modifier
        '
        Me.Btn_Modifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btn_Modifier.Image = CType(resources.GetObject("Btn_Modifier.Image"), System.Drawing.Image)
        Me.Btn_Modifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Modifier.Location = New System.Drawing.Point(280, 298)
        Me.Btn_Modifier.Name = "Btn_Modifier"
        Me.Btn_Modifier.Size = New System.Drawing.Size(168, 42)
        Me.Btn_Modifier.TabIndex = 216
        Me.Btn_Modifier.Text = "     &Modifier"
        Me.Btn_Modifier.UseVisualStyleBackColor = False
        '
        'DGVRayon
        '
        Me.DGVRayon.AutoGenerateColumns = False
        Me.DGVRayon.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGVRayon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRayon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DGVRayon.DataSource = Me.BDSRayon
        Me.DGVRayon.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGVRayon.Location = New System.Drawing.Point(106, 127)
        Me.DGVRayon.Name = "DGVRayon"
        Me.DGVRayon.Size = New System.Drawing.Size(713, 150)
        Me.DGVRayon.TabIndex = 215
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Ray_ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Ray_ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Ray_Lib"
        Me.DataGridViewTextBoxColumn8.HeaderText = "      Rayon "
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'BDSRayon
        '
        Me.BDSRayon.AllowNew = True
        Me.BDSRayon.DataSource = GetType(Caisse.RAYON)
        '
        'cmdFermer
        '
        Me.cmdFermer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFermer.ForeColor = System.Drawing.Color.Black
        Me.cmdFermer.Image = CType(resources.GetObject("cmdFermer.Image"), System.Drawing.Image)
        Me.cmdFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFermer.Location = New System.Drawing.Point(651, 298)
        Me.cmdFermer.Name = "cmdFermer"
        Me.cmdFermer.Size = New System.Drawing.Size(168, 42)
        Me.cmdFermer.TabIndex = 214
        Me.cmdFermer.Text = "&Fermer"
        Me.cmdFermer.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button25)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtRayonLibelle)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox3.Location = New System.Drawing.Point(106, 33)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(713, 63)
        Me.GroupBox3.TabIndex = 59
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtre"
        '
        'Button25
        '
        Me.Button25.Enabled = False
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button25.ForeColor = System.Drawing.Color.Transparent
        Me.Button25.Image = CType(resources.GetObject("Button25.Image"), System.Drawing.Image)
        Me.Button25.Location = New System.Drawing.Point(627, 21)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(78, 35)
        Me.Button25.TabIndex = 26
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(133, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Libellé  :"
        '
        'txtRayonLibelle
        '
        Me.txtRayonLibelle.BackColor = System.Drawing.SystemColors.Window
        Me.txtRayonLibelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRayonLibelle.Location = New System.Drawing.Point(219, 30)
        Me.txtRayonLibelle.Name = "txtRayonLibelle"
        Me.txtRayonLibelle.Size = New System.Drawing.Size(139, 22)
        Me.txtRayonLibelle.TabIndex = 23
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button13.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.Black
        Me.Button13.Image = CType(resources.GetObject("Button13.Image"), System.Drawing.Image)
        Me.Button13.Location = New System.Drawing.Point(825, 204)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(53, 77)
        Me.Button13.TabIndex = 58
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button14.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.Black
        Me.Button14.Image = CType(resources.GetObject("Button14.Image"), System.Drawing.Image)
        Me.Button14.Location = New System.Drawing.Point(825, 123)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(53, 77)
        Me.Button14.TabIndex = 57
        Me.Button14.UseVisualStyleBackColor = False
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEnregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnregistrer.Image = CType(resources.GetObject("btnEnregistrer.Image"), System.Drawing.Image)
        Me.btnEnregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnregistrer.Location = New System.Drawing.Point(106, 298)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(168, 42)
        Me.btnEnregistrer.TabIndex = 19
        Me.btnEnregistrer.Text = "    &Nouveau Rayon"
        Me.btnEnregistrer.UseVisualStyleBackColor = False
        '
        'TabPageFamille
        '
        Me.TabPageFamille.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPageFamille.Controls.Add(Me.Button30)
        Me.TabPageFamille.Controls.Add(Me.Button31)
        Me.TabPageFamille.Controls.Add(Me.Button7)
        Me.TabPageFamille.Controls.Add(Me.Button15)
        Me.TabPageFamille.Controls.Add(Me.Button16)
        Me.TabPageFamille.Controls.Add(Me.DGVFamille)
        Me.TabPageFamille.Controls.Add(Me.GroupBox2)
        Me.TabPageFamille.Controls.Add(Me.Button1)
        Me.TabPageFamille.Location = New System.Drawing.Point(4, 44)
        Me.TabPageFamille.Name = "TabPageFamille"
        Me.TabPageFamille.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageFamille.Size = New System.Drawing.Size(1126, 469)
        Me.TabPageFamille.TabIndex = 1
        Me.TabPageFamille.Text = "Famille"
        '
        'Button30
        '
        Me.Button30.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button30.Image = CType(resources.GetObject("Button30.Image"), System.Drawing.Image)
        Me.Button30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button30.Location = New System.Drawing.Point(359, 395)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(162, 42)
        Me.Button30.TabIndex = 219
        Me.Button30.Text = "   &Supprimer"
        Me.Button30.UseVisualStyleBackColor = False
        '
        'Button31
        '
        Me.Button31.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button31.Image = CType(resources.GetObject("Button31.Image"), System.Drawing.Image)
        Me.Button31.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button31.Location = New System.Drawing.Point(198, 395)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(162, 42)
        Me.Button31.TabIndex = 218
        Me.Button31.Text = "    &Modifier"
        Me.Button31.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button7.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(731, 393)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(162, 42)
        Me.Button7.TabIndex = 215
        Me.Button7.Text = "&Fermer"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button15.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.Black
        Me.Button15.Image = CType(resources.GetObject("Button15.Image"), System.Drawing.Image)
        Me.Button15.Location = New System.Drawing.Point(899, 310)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(53, 77)
        Me.Button15.TabIndex = 60
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button16.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.Color.Black
        Me.Button16.Image = CType(resources.GetObject("Button16.Image"), System.Drawing.Image)
        Me.Button16.Location = New System.Drawing.Point(899, 106)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(53, 77)
        Me.Button16.TabIndex = 59
        Me.Button16.UseVisualStyleBackColor = False
        '
        'DGVFamille
        '
        Me.DGVFamille.AutoGenerateColumns = False
        Me.DGVFamille.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGVFamille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVFamille.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.DGVFamille.DataSource = Me.BDSFamille
        Me.DGVFamille.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGVFamille.Location = New System.Drawing.Point(36, 106)
        Me.DGVFamille.Name = "DGVFamille"
        Me.DGVFamille.ReadOnly = True
        Me.DGVFamille.Size = New System.Drawing.Size(857, 281)
        Me.DGVFamille.TabIndex = 22
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Fml_Id"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fml_Id"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FamilleofRayon"
        Me.DataGridViewTextBoxColumn10.HeaderText = "FamilleofRayon"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Fml_Lib"
        Me.DataGridViewTextBoxColumn11.HeaderText = "      Famille "
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'BDSFamille
        '
        Me.BDSFamille.AllowNew = True
        Me.BDSFamille.DataSource = GetType(Caisse.FAMILLE)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.txtFamilleLibelle)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox2.Location = New System.Drawing.Point(36, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(857, 62)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtre"
        '
        'Button8
        '
        Me.Button8.Enabled = False
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(783, 19)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(50, 35)
        Me.Button8.TabIndex = 24
        Me.Button8.UseVisualStyleBackColor = True
        '
        'txtFamilleLibelle
        '
        Me.txtFamilleLibelle.BackColor = System.Drawing.SystemColors.Window
        Me.txtFamilleLibelle.Location = New System.Drawing.Point(241, 27)
        Me.txtFamilleLibelle.Name = "txtFamilleLibelle"
        Me.txtFamilleLibelle.Size = New System.Drawing.Size(166, 20)
        Me.txtFamilleLibelle.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(180, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Libellé  :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(36, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 42)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "   &Nouvelle Famille"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TabPageSousFamille
        '
        Me.TabPageSousFamille.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPageSousFamille.Controls.Add(Me.Button32)
        Me.TabPageSousFamille.Controls.Add(Me.Button33)
        Me.TabPageSousFamille.Controls.Add(Me.Button26)
        Me.TabPageSousFamille.Controls.Add(Me.Button17)
        Me.TabPageSousFamille.Controls.Add(Me.Button18)
        Me.TabPageSousFamille.Controls.Add(Me.DGVSousFamille)
        Me.TabPageSousFamille.Controls.Add(Me.GroupBox1)
        Me.TabPageSousFamille.Controls.Add(Me.Button2)
        Me.TabPageSousFamille.Location = New System.Drawing.Point(4, 44)
        Me.TabPageSousFamille.Name = "TabPageSousFamille"
        Me.TabPageSousFamille.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSousFamille.Size = New System.Drawing.Size(1126, 469)
        Me.TabPageSousFamille.TabIndex = 2
        Me.TabPageSousFamille.Text = "Sous Famille"
        '
        'Button32
        '
        Me.Button32.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button32.Image = CType(resources.GetObject("Button32.Image"), System.Drawing.Image)
        Me.Button32.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button32.Location = New System.Drawing.Point(384, 392)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(162, 42)
        Me.Button32.TabIndex = 219
        Me.Button32.Text = "   &Supprimer"
        Me.Button32.UseVisualStyleBackColor = False
        '
        'Button33
        '
        Me.Button33.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button33.Image = CType(resources.GetObject("Button33.Image"), System.Drawing.Image)
        Me.Button33.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button33.Location = New System.Drawing.Point(215, 392)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(162, 42)
        Me.Button33.TabIndex = 218
        Me.Button33.Text = "     &Modifier"
        Me.Button33.UseVisualStyleBackColor = False
        '
        'Button26
        '
        Me.Button26.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button26.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button26.ForeColor = System.Drawing.Color.Black
        Me.Button26.Image = CType(resources.GetObject("Button26.Image"), System.Drawing.Image)
        Me.Button26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button26.Location = New System.Drawing.Point(765, 392)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(162, 42)
        Me.Button26.TabIndex = 215
        Me.Button26.Text = "&Fermer"
        Me.Button26.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button17.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.ForeColor = System.Drawing.Color.Black
        Me.Button17.Image = CType(resources.GetObject("Button17.Image"), System.Drawing.Image)
        Me.Button17.Location = New System.Drawing.Point(933, 309)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(53, 77)
        Me.Button17.TabIndex = 60
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button18.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.ForeColor = System.Drawing.Color.Black
        Me.Button18.Image = CType(resources.GetObject("Button18.Image"), System.Drawing.Image)
        Me.Button18.Location = New System.Drawing.Point(933, 105)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(53, 77)
        Me.Button18.TabIndex = 59
        Me.Button18.UseVisualStyleBackColor = False
        '
        'DGVSousFamille
        '
        Me.DGVSousFamille.AutoGenerateColumns = False
        Me.DGVSousFamille.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGVSousFamille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSousFamille.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SFIDDataGridViewTextBoxColumn, Me.FamilleofSousFamilleDataGridViewTextBoxColumn, Me.SfLibDataGridViewTextBoxColumn})
        Me.DGVSousFamille.DataSource = Me.BDSSousFamille
        Me.DGVSousFamille.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGVSousFamille.Location = New System.Drawing.Point(19, 105)
        Me.DGVSousFamille.Name = "DGVSousFamille"
        Me.DGVSousFamille.Size = New System.Drawing.Size(908, 281)
        Me.DGVSousFamille.TabIndex = 21
        '
        'SFIDDataGridViewTextBoxColumn
        '
        Me.SFIDDataGridViewTextBoxColumn.DataPropertyName = "SF_ID"
        Me.SFIDDataGridViewTextBoxColumn.HeaderText = "SF_ID"
        Me.SFIDDataGridViewTextBoxColumn.Name = "SFIDDataGridViewTextBoxColumn"
        Me.SFIDDataGridViewTextBoxColumn.Visible = False
        '
        'FamilleofSousFamilleDataGridViewTextBoxColumn
        '
        Me.FamilleofSousFamilleDataGridViewTextBoxColumn.DataPropertyName = "FamilleofSousFamille"
        Me.FamilleofSousFamilleDataGridViewTextBoxColumn.HeaderText = "FamilleofSousFamille"
        Me.FamilleofSousFamilleDataGridViewTextBoxColumn.Name = "FamilleofSousFamilleDataGridViewTextBoxColumn"
        Me.FamilleofSousFamilleDataGridViewTextBoxColumn.Visible = False
        '
        'SfLibDataGridViewTextBoxColumn
        '
        Me.SfLibDataGridViewTextBoxColumn.DataPropertyName = "Sf_Lib"
        Me.SfLibDataGridViewTextBoxColumn.HeaderText = "        Sous          Famille"
        Me.SfLibDataGridViewTextBoxColumn.Name = "SfLibDataGridViewTextBoxColumn"
        '
        'BDSSousFamille
        '
        Me.BDSSousFamille.DataSource = GetType(Caisse.SOUS_FAMILLE)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.txtSousFamilleLibelle)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox1.Location = New System.Drawing.Point(19, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(908, 63)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtre"
        '
        'Button9
        '
        Me.Button9.Enabled = False
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(834, 20)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(65, 35)
        Me.Button9.TabIndex = 23
        Me.Button9.UseVisualStyleBackColor = True
        '
        'txtSousFamilleLibelle
        '
        Me.txtSousFamilleLibelle.BackColor = System.Drawing.SystemColors.Window
        Me.txtSousFamilleLibelle.Location = New System.Drawing.Point(208, 28)
        Me.txtSousFamilleLibelle.Name = "txtSousFamilleLibelle"
        Me.txtSousFamilleLibelle.Size = New System.Drawing.Size(166, 20)
        Me.txtSousFamilleLibelle.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(140, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Libellé  :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(19, 392)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(190, 42)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "      &Nouvelle Sous Famille"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TabPageMarque
        '
        Me.TabPageMarque.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPageMarque.Controls.Add(Me.Button34)
        Me.TabPageMarque.Controls.Add(Me.Button35)
        Me.TabPageMarque.Controls.Add(Me.Button27)
        Me.TabPageMarque.Controls.Add(Me.Button19)
        Me.TabPageMarque.Controls.Add(Me.Button20)
        Me.TabPageMarque.Controls.Add(Me.DGVMarque)
        Me.TabPageMarque.Controls.Add(Me.Button3)
        Me.TabPageMarque.Controls.Add(Me.GbxFiltreMarque)
        Me.TabPageMarque.Controls.Add(Me.Button6)
        Me.TabPageMarque.Location = New System.Drawing.Point(4, 44)
        Me.TabPageMarque.Name = "TabPageMarque"
        Me.TabPageMarque.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMarque.Size = New System.Drawing.Size(1126, 469)
        Me.TabPageMarque.TabIndex = 3
        Me.TabPageMarque.Text = "Marque"
        '
        'Button34
        '
        Me.Button34.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button34.Image = CType(resources.GetObject("Button34.Image"), System.Drawing.Image)
        Me.Button34.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button34.Location = New System.Drawing.Point(354, 386)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(162, 42)
        Me.Button34.TabIndex = 219
        Me.Button34.Text = "   &Supprimer"
        Me.Button34.UseVisualStyleBackColor = False
        '
        'Button35
        '
        Me.Button35.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button35.Image = CType(resources.GetObject("Button35.Image"), System.Drawing.Image)
        Me.Button35.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button35.Location = New System.Drawing.Point(185, 386)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(162, 42)
        Me.Button35.TabIndex = 218
        Me.Button35.Text = "    &Modifier"
        Me.Button35.UseVisualStyleBackColor = False
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button27.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.ForeColor = System.Drawing.Color.Black
        Me.Button27.Image = CType(resources.GetObject("Button27.Image"), System.Drawing.Image)
        Me.Button27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button27.Location = New System.Drawing.Point(789, 386)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(162, 42)
        Me.Button27.TabIndex = 215
        Me.Button27.Text = "&Fermer"
        Me.Button27.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button19.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.ForeColor = System.Drawing.Color.Black
        Me.Button19.Image = CType(resources.GetObject("Button19.Image"), System.Drawing.Image)
        Me.Button19.Location = New System.Drawing.Point(957, 303)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(53, 77)
        Me.Button19.TabIndex = 60
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button20.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.ForeColor = System.Drawing.Color.Black
        Me.Button20.Image = CType(resources.GetObject("Button20.Image"), System.Drawing.Image)
        Me.Button20.Location = New System.Drawing.Point(957, 99)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(53, 77)
        Me.Button20.TabIndex = 59
        Me.Button20.UseVisualStyleBackColor = False
        '
        'DGVMarque
        '
        Me.DGVMarque.AutoGenerateColumns = False
        Me.DGVMarque.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGVMarque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMarque.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MrqIdDataGridViewTextBoxColumn, Me.SousFamilleofMarquesDataGridViewTextBoxColumn, Me.MrqLibDataGridViewTextBoxColumn})
        Me.DGVMarque.DataSource = Me.BDSMarque
        Me.DGVMarque.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGVMarque.Location = New System.Drawing.Point(17, 99)
        Me.DGVMarque.Name = "DGVMarque"
        Me.DGVMarque.Size = New System.Drawing.Size(934, 281)
        Me.DGVMarque.TabIndex = 41
        '
        'MrqIdDataGridViewTextBoxColumn
        '
        Me.MrqIdDataGridViewTextBoxColumn.DataPropertyName = "Mrq_Id"
        Me.MrqIdDataGridViewTextBoxColumn.HeaderText = "Mrq_Id"
        Me.MrqIdDataGridViewTextBoxColumn.Name = "MrqIdDataGridViewTextBoxColumn"
        Me.MrqIdDataGridViewTextBoxColumn.Visible = False
        '
        'SousFamilleofMarquesDataGridViewTextBoxColumn
        '
        Me.SousFamilleofMarquesDataGridViewTextBoxColumn.DataPropertyName = "SousFamilleofMarques"
        Me.SousFamilleofMarquesDataGridViewTextBoxColumn.HeaderText = "SousFamilleofMarques"
        Me.SousFamilleofMarquesDataGridViewTextBoxColumn.Name = "SousFamilleofMarquesDataGridViewTextBoxColumn"
        Me.SousFamilleofMarquesDataGridViewTextBoxColumn.Visible = False
        '
        'MrqLibDataGridViewTextBoxColumn
        '
        Me.MrqLibDataGridViewTextBoxColumn.DataPropertyName = "Mrq_Lib"
        Me.MrqLibDataGridViewTextBoxColumn.HeaderText = "         Marque"
        Me.MrqLibDataGridViewTextBoxColumn.Name = "MrqLibDataGridViewTextBoxColumn"
        '
        'BDSMarque
        '
        Me.BDSMarque.DataSource = GetType(Caisse.MARQUE)
        '
        'Button3
        '
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(1255, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(211, 36)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "    &Mise A Jour"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GbxFiltreMarque
        '
        Me.GbxFiltreMarque.Controls.Add(Me.Button10)
        Me.GbxFiltreMarque.Controls.Add(Me.txtMarqueLibelle)
        Me.GbxFiltreMarque.Controls.Add(Me.Label4)
        Me.GbxFiltreMarque.ForeColor = System.Drawing.Color.Purple
        Me.GbxFiltreMarque.Location = New System.Drawing.Point(17, 22)
        Me.GbxFiltreMarque.Name = "GbxFiltreMarque"
        Me.GbxFiltreMarque.Size = New System.Drawing.Size(934, 61)
        Me.GbxFiltreMarque.TabIndex = 14
        Me.GbxFiltreMarque.TabStop = False
        Me.GbxFiltreMarque.Text = "Filtre"
        '
        'Button10
        '
        Me.Button10.Enabled = False
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.Location = New System.Drawing.Point(864, 19)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(64, 35)
        Me.Button10.TabIndex = 43
        Me.Button10.UseVisualStyleBackColor = True
        '
        'txtMarqueLibelle
        '
        Me.txtMarqueLibelle.BackColor = System.Drawing.SystemColors.Window
        Me.txtMarqueLibelle.Location = New System.Drawing.Point(218, 30)
        Me.txtMarqueLibelle.Name = "txtMarqueLibelle"
        Me.txtMarqueLibelle.Size = New System.Drawing.Size(166, 20)
        Me.txtMarqueLibelle.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(146, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Libellé  :"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(17, 386)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(162, 42)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "   &Nouvelle Marque"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'TabPageArticle
        '
        Me.TabPageArticle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPageArticle.Controls.Add(Me.Button40)
        Me.TabPageArticle.Controls.Add(Me.Button36)
        Me.TabPageArticle.Controls.Add(Me.Button37)
        Me.TabPageArticle.Controls.Add(Me.Button28)
        Me.TabPageArticle.Controls.Add(Me.Button21)
        Me.TabPageArticle.Controls.Add(Me.Button22)
        Me.TabPageArticle.Controls.Add(Me.GroupBox5)
        Me.TabPageArticle.Controls.Add(Me.DGVArticle)
        Me.TabPageArticle.Controls.Add(Me.Button4)
        Me.TabPageArticle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageArticle.Location = New System.Drawing.Point(4, 44)
        Me.TabPageArticle.Name = "TabPageArticle"
        Me.TabPageArticle.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageArticle.Size = New System.Drawing.Size(1126, 469)
        Me.TabPageArticle.TabIndex = 4
        Me.TabPageArticle.Text = "Article"
        '
        'Button40
        '
        Me.Button40.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button40.Image = CType(resources.GetObject("Button40.Image"), System.Drawing.Image)
        Me.Button40.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button40.Location = New System.Drawing.Point(733, 425)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(162, 42)
        Me.Button40.TabIndex = 220
        Me.Button40.Text = "   &Imprimer"
        Me.Button40.UseVisualStyleBackColor = False
        '
        'Button36
        '
        Me.Button36.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button36.Image = CType(resources.GetObject("Button36.Image"), System.Drawing.Image)
        Me.Button36.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button36.Location = New System.Drawing.Point(343, 425)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(162, 42)
        Me.Button36.TabIndex = 219
        Me.Button36.Text = "   &Supprimer"
        Me.Button36.UseVisualStyleBackColor = False
        '
        'Button37
        '
        Me.Button37.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button37.Image = CType(resources.GetObject("Button37.Image"), System.Drawing.Image)
        Me.Button37.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button37.Location = New System.Drawing.Point(174, 425)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(162, 42)
        Me.Button37.TabIndex = 218
        Me.Button37.Text = "    &Modifier"
        Me.Button37.UseVisualStyleBackColor = False
        '
        'Button28
        '
        Me.Button28.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button28.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button28.ForeColor = System.Drawing.Color.Black
        Me.Button28.Image = CType(resources.GetObject("Button28.Image"), System.Drawing.Image)
        Me.Button28.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button28.Location = New System.Drawing.Point(901, 425)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(162, 42)
        Me.Button28.TabIndex = 215
        Me.Button28.Text = "&Fermer"
        Me.Button28.UseVisualStyleBackColor = False
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button21.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.ForeColor = System.Drawing.Color.Black
        Me.Button21.Image = CType(resources.GetObject("Button21.Image"), System.Drawing.Image)
        Me.Button21.Location = New System.Drawing.Point(1067, 343)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(53, 77)
        Me.Button21.TabIndex = 60
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button22.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.ForeColor = System.Drawing.Color.Black
        Me.Button22.Image = CType(resources.GetObject("Button22.Image"), System.Drawing.Image)
        Me.Button22.Location = New System.Drawing.Point(1067, 164)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(53, 77)
        Me.Button22.TabIndex = 59
        Me.Button22.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Cmb_Type)
        Me.GroupBox5.Controls.Add(Me.ComboBox1)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.txtDescription)
        Me.GroupBox5.Controls.Add(Me.Button11)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox5.Location = New System.Drawing.Point(15, 46)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(987, 63)
        Me.GroupBox5.TabIndex = 41
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Filtre"
        '
        'Cmb_Type
        '
        Me.Cmb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Type.FormattingEnabled = True
        Me.Cmb_Type.Location = New System.Drawing.Point(561, 26)
        Me.Cmb_Type.Name = "Cmb_Type"
        Me.Cmb_Type.Size = New System.Drawing.Size(241, 21)
        Me.Cmb_Type.TabIndex = 93
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(32745, 32064)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(516, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Type :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(33, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "&Description        :"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(159, 19)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(208, 38)
        Me.txtDescription.TabIndex = 54
        '
        'Button11
        '
        Me.Button11.Enabled = False
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.ForeColor = System.Drawing.SystemColors.Control
        Me.Button11.Image = CType(resources.GetObject("Button11.Image"), System.Drawing.Image)
        Me.Button11.Location = New System.Drawing.Point(849, 19)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(113, 38)
        Me.Button11.TabIndex = 52
        Me.Button11.UseVisualStyleBackColor = True
        '
        'DGVArticle
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVArticle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVArticle.AutoGenerateColumns = False
        Me.DGVArticle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGVArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVArticle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ARTIDDataGridViewTextBoxColumn, Me.TarifOfArticleOfArticleDataGridViewTextBoxColumn, Me.ARTREFDataGridViewTextBoxColumn, Me.TvaOfArticleDataGridViewTextBoxColumn, Me.CodeBarOfArticleDataGridViewTextBoxColumn, Me.MarqueOfArticleDataGridViewTextBoxColumn, Me.ARTDATEENTDataGridViewTextBoxColumn, Me.ARTPRIXUHTDataGridViewTextBoxColumn, Me.ARTTAUXTVADataGridViewTextBoxColumn, Me.ARTDESCRIPTIONDataGridViewTextBoxColumn, Me.ARTSTOCKMINDataGridViewTextBoxColumn, Me.ARTDATEPEREMTIONDataGridViewTextBoxColumn, Me.ARTSTOCKMAXDataGridViewTextBoxColumn, Me.ARTPHOTODataGridViewImageColumn, Me.ARTTYPEDataGridViewTextBoxColumn, Me.ARTSTOCKABLEDataGridViewCheckBoxColumn, Me.ARTSTOCKREELDataGridViewTextBoxColumn, Me.ARTSTOCKALERTDataGridViewTextBoxColumn, Me.ARTSTOCKRESERVEDataGridViewTextBoxColumn, Me.ARTCONSOMABLEDataGridViewCheckBoxColumn, Me.ARTNATUREDataGridViewTextBoxColumn, Me.ARTDATEMODIFICATIONDataGridViewTextBoxColumn, Me.ARTMOTIFMODIFICATIONDataGridViewTextBoxColumn})
        Me.DGVArticle.DataSource = Me.ARTICLEBindingSource
        Me.DGVArticle.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGVArticle.Location = New System.Drawing.Point(6, 126)
        Me.DGVArticle.Name = "DGVArticle"
        Me.DGVArticle.ReadOnly = True
        Me.DGVArticle.RowHeadersVisible = False
        Me.DGVArticle.Size = New System.Drawing.Size(996, 273)
        Me.DGVArticle.TabIndex = 40
        '
        'ARTIDDataGridViewTextBoxColumn
        '
        Me.ARTIDDataGridViewTextBoxColumn.DataPropertyName = "ART_ID"
        Me.ARTIDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.ARTIDDataGridViewTextBoxColumn.Name = "ARTIDDataGridViewTextBoxColumn"
        Me.ARTIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TarifOfArticleOfArticleDataGridViewTextBoxColumn
        '
        Me.TarifOfArticleOfArticleDataGridViewTextBoxColumn.DataPropertyName = "TarifOfArticleOfArticle"
        Me.TarifOfArticleOfArticleDataGridViewTextBoxColumn.HeaderText = "TarifOfArticleOfArticle"
        Me.TarifOfArticleOfArticleDataGridViewTextBoxColumn.Name = "TarifOfArticleOfArticleDataGridViewTextBoxColumn"
        Me.TarifOfArticleOfArticleDataGridViewTextBoxColumn.ReadOnly = True
        Me.TarifOfArticleOfArticleDataGridViewTextBoxColumn.Visible = False
        '
        'ARTREFDataGridViewTextBoxColumn
        '
        Me.ARTREFDataGridViewTextBoxColumn.DataPropertyName = "ART_REF"
        Me.ARTREFDataGridViewTextBoxColumn.HeaderText = "REFERENCE"
        Me.ARTREFDataGridViewTextBoxColumn.Name = "ARTREFDataGridViewTextBoxColumn"
        Me.ARTREFDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TvaOfArticleDataGridViewTextBoxColumn
        '
        Me.TvaOfArticleDataGridViewTextBoxColumn.DataPropertyName = "TvaOfArticle"
        Me.TvaOfArticleDataGridViewTextBoxColumn.HeaderText = "TvaOfArticle"
        Me.TvaOfArticleDataGridViewTextBoxColumn.Name = "TvaOfArticleDataGridViewTextBoxColumn"
        Me.TvaOfArticleDataGridViewTextBoxColumn.ReadOnly = True
        Me.TvaOfArticleDataGridViewTextBoxColumn.Visible = False
        '
        'CodeBarOfArticleDataGridViewTextBoxColumn
        '
        Me.CodeBarOfArticleDataGridViewTextBoxColumn.DataPropertyName = "CodeBarOfArticle"
        Me.CodeBarOfArticleDataGridViewTextBoxColumn.HeaderText = "CodeBarOfArticle"
        Me.CodeBarOfArticleDataGridViewTextBoxColumn.Name = "CodeBarOfArticleDataGridViewTextBoxColumn"
        Me.CodeBarOfArticleDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodeBarOfArticleDataGridViewTextBoxColumn.Visible = False
        '
        'MarqueOfArticleDataGridViewTextBoxColumn
        '
        Me.MarqueOfArticleDataGridViewTextBoxColumn.DataPropertyName = "MarqueOfArticle"
        Me.MarqueOfArticleDataGridViewTextBoxColumn.HeaderText = "MarqueOfArticle"
        Me.MarqueOfArticleDataGridViewTextBoxColumn.Name = "MarqueOfArticleDataGridViewTextBoxColumn"
        Me.MarqueOfArticleDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarqueOfArticleDataGridViewTextBoxColumn.Visible = False
        '
        'ARTDATEENTDataGridViewTextBoxColumn
        '
        Me.ARTDATEENTDataGridViewTextBoxColumn.DataPropertyName = "ART_DATEENT"
        Me.ARTDATEENTDataGridViewTextBoxColumn.HeaderText = "Date entre"
        Me.ARTDATEENTDataGridViewTextBoxColumn.Name = "ARTDATEENTDataGridViewTextBoxColumn"
        Me.ARTDATEENTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ARTPRIXUHTDataGridViewTextBoxColumn
        '
        Me.ARTPRIXUHTDataGridViewTextBoxColumn.DataPropertyName = "ART_PRIXUHT"
        Me.ARTPRIXUHTDataGridViewTextBoxColumn.HeaderText = "Prix Unitaire HT"
        Me.ARTPRIXUHTDataGridViewTextBoxColumn.Name = "ARTPRIXUHTDataGridViewTextBoxColumn"
        Me.ARTPRIXUHTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ARTTAUXTVADataGridViewTextBoxColumn
        '
        Me.ARTTAUXTVADataGridViewTextBoxColumn.DataPropertyName = "ART_TAUXTVA"
        Me.ARTTAUXTVADataGridViewTextBoxColumn.HeaderText = "Taux TVA"
        Me.ARTTAUXTVADataGridViewTextBoxColumn.Name = "ARTTAUXTVADataGridViewTextBoxColumn"
        Me.ARTTAUXTVADataGridViewTextBoxColumn.ReadOnly = True
        '
        'ARTDESCRIPTIONDataGridViewTextBoxColumn
        '
        Me.ARTDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "ART_DESCRIPTION"
        Me.ARTDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.ARTDESCRIPTIONDataGridViewTextBoxColumn.Name = "ARTDESCRIPTIONDataGridViewTextBoxColumn"
        Me.ARTDESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ARTSTOCKMINDataGridViewTextBoxColumn
        '
        Me.ARTSTOCKMINDataGridViewTextBoxColumn.DataPropertyName = "ART_STOCKMIN"
        Me.ARTSTOCKMINDataGridViewTextBoxColumn.HeaderText = "Stock MIN"
        Me.ARTSTOCKMINDataGridViewTextBoxColumn.Name = "ARTSTOCKMINDataGridViewTextBoxColumn"
        Me.ARTSTOCKMINDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ARTDATEPEREMTIONDataGridViewTextBoxColumn
        '
        Me.ARTDATEPEREMTIONDataGridViewTextBoxColumn.DataPropertyName = "ART_DATEPEREMTION"
        Me.ARTDATEPEREMTIONDataGridViewTextBoxColumn.HeaderText = "Date Peremtion"
        Me.ARTDATEPEREMTIONDataGridViewTextBoxColumn.Name = "ARTDATEPEREMTIONDataGridViewTextBoxColumn"
        Me.ARTDATEPEREMTIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ARTSTOCKMAXDataGridViewTextBoxColumn
        '
        Me.ARTSTOCKMAXDataGridViewTextBoxColumn.DataPropertyName = "ART_STOCKMAX"
        Me.ARTSTOCKMAXDataGridViewTextBoxColumn.HeaderText = "Stock MAX"
        Me.ARTSTOCKMAXDataGridViewTextBoxColumn.Name = "ARTSTOCKMAXDataGridViewTextBoxColumn"
        Me.ARTSTOCKMAXDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ARTPHOTODataGridViewImageColumn
        '
        Me.ARTPHOTODataGridViewImageColumn.DataPropertyName = "ART_PHOTO"
        Me.ARTPHOTODataGridViewImageColumn.HeaderText = "PHOTO"
        Me.ARTPHOTODataGridViewImageColumn.Name = "ARTPHOTODataGridViewImageColumn"
        Me.ARTPHOTODataGridViewImageColumn.ReadOnly = True
        '
        'ARTTYPEDataGridViewTextBoxColumn
        '
        Me.ARTTYPEDataGridViewTextBoxColumn.DataPropertyName = "ART_TYPE"
        Me.ARTTYPEDataGridViewTextBoxColumn.HeaderText = "TYPE"
        Me.ARTTYPEDataGridViewTextBoxColumn.Name = "ARTTYPEDataGridViewTextBoxColumn"
        Me.ARTTYPEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ARTSTOCKABLEDataGridViewCheckBoxColumn
        '
        Me.ARTSTOCKABLEDataGridViewCheckBoxColumn.DataPropertyName = "ART_STOCKABLE"
        Me.ARTSTOCKABLEDataGridViewCheckBoxColumn.HeaderText = "STOCKABLE"
        Me.ARTSTOCKABLEDataGridViewCheckBoxColumn.Name = "ARTSTOCKABLEDataGridViewCheckBoxColumn"
        Me.ARTSTOCKABLEDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ARTSTOCKREELDataGridViewTextBoxColumn
        '
        Me.ARTSTOCKREELDataGridViewTextBoxColumn.DataPropertyName = "ART_STOCKREEL"
        Me.ARTSTOCKREELDataGridViewTextBoxColumn.HeaderText = "STOCK REEL"
        Me.ARTSTOCKREELDataGridViewTextBoxColumn.Name = "ARTSTOCKREELDataGridViewTextBoxColumn"
        Me.ARTSTOCKREELDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ARTSTOCKALERTDataGridViewTextBoxColumn
        '
        Me.ARTSTOCKALERTDataGridViewTextBoxColumn.DataPropertyName = "ART_STOCKALERT"
        Me.ARTSTOCKALERTDataGridViewTextBoxColumn.HeaderText = "STOCK ALERT"
        Me.ARTSTOCKALERTDataGridViewTextBoxColumn.Name = "ARTSTOCKALERTDataGridViewTextBoxColumn"
        Me.ARTSTOCKALERTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ARTSTOCKRESERVEDataGridViewTextBoxColumn
        '
        Me.ARTSTOCKRESERVEDataGridViewTextBoxColumn.DataPropertyName = "ART_STOCKRESERVE"
        Me.ARTSTOCKRESERVEDataGridViewTextBoxColumn.HeaderText = "STOCK RESERVE"
        Me.ARTSTOCKRESERVEDataGridViewTextBoxColumn.Name = "ARTSTOCKRESERVEDataGridViewTextBoxColumn"
        Me.ARTSTOCKRESERVEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ARTCONSOMABLEDataGridViewCheckBoxColumn
        '
        Me.ARTCONSOMABLEDataGridViewCheckBoxColumn.DataPropertyName = "ART_CONSOMABLE"
        Me.ARTCONSOMABLEDataGridViewCheckBoxColumn.HeaderText = "CONSOMABLE"
        Me.ARTCONSOMABLEDataGridViewCheckBoxColumn.Name = "ARTCONSOMABLEDataGridViewCheckBoxColumn"
        Me.ARTCONSOMABLEDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ARTNATUREDataGridViewTextBoxColumn
        '
        Me.ARTNATUREDataGridViewTextBoxColumn.DataPropertyName = "ART_NATURE"
        Me.ARTNATUREDataGridViewTextBoxColumn.HeaderText = "NATURE"
        Me.ARTNATUREDataGridViewTextBoxColumn.Name = "ARTNATUREDataGridViewTextBoxColumn"
        Me.ARTNATUREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ARTDATEMODIFICATIONDataGridViewTextBoxColumn
        '
        Me.ARTDATEMODIFICATIONDataGridViewTextBoxColumn.DataPropertyName = "ART_DATEMODIFICATION"
        Me.ARTDATEMODIFICATIONDataGridViewTextBoxColumn.HeaderText = "DATE MODIFICATION"
        Me.ARTDATEMODIFICATIONDataGridViewTextBoxColumn.Name = "ARTDATEMODIFICATIONDataGridViewTextBoxColumn"
        Me.ARTDATEMODIFICATIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ARTMOTIFMODIFICATIONDataGridViewTextBoxColumn
        '
        Me.ARTMOTIFMODIFICATIONDataGridViewTextBoxColumn.DataPropertyName = "ART_MOTIFMODIFICATION"
        Me.ARTMOTIFMODIFICATIONDataGridViewTextBoxColumn.HeaderText = "MOTIF MODIFICATION"
        Me.ARTMOTIFMODIFICATIONDataGridViewTextBoxColumn.Name = "ARTMOTIFMODIFICATIONDataGridViewTextBoxColumn"
        Me.ARTMOTIFMODIFICATIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ARTICLEBindingSource
        '
        Me.ARTICLEBindingSource.DataSource = GetType(Caisse.ARTICLE)
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(6, 425)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(162, 42)
        Me.Button4.TabIndex = 39
        Me.Button4.Text = "   &Nouveau Article"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TabPageTarif
        '
        Me.TabPageTarif.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPageTarif.Controls.Add(Me.Button38)
        Me.TabPageTarif.Controls.Add(Me.Button39)
        Me.TabPageTarif.Controls.Add(Me.Button29)
        Me.TabPageTarif.Controls.Add(Me.Button23)
        Me.TabPageTarif.Controls.Add(Me.Button24)
        Me.TabPageTarif.Controls.Add(Me.DGVTarif)
        Me.TabPageTarif.Controls.Add(Me.GroupBox4)
        Me.TabPageTarif.Controls.Add(Me.Button5)
        Me.TabPageTarif.Location = New System.Drawing.Point(4, 44)
        Me.TabPageTarif.Name = "TabPageTarif"
        Me.TabPageTarif.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTarif.Size = New System.Drawing.Size(1126, 469)
        Me.TabPageTarif.TabIndex = 5
        Me.TabPageTarif.Text = "Tarif"
        '
        'Button38
        '
        Me.Button38.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button38.Image = CType(resources.GetObject("Button38.Image"), System.Drawing.Image)
        Me.Button38.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button38.Location = New System.Drawing.Point(371, 377)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(162, 42)
        Me.Button38.TabIndex = 219
        Me.Button38.Text = "  &Supprimer"
        Me.Button38.UseVisualStyleBackColor = False
        '
        'Button39
        '
        Me.Button39.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button39.Image = CType(resources.GetObject("Button39.Image"), System.Drawing.Image)
        Me.Button39.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button39.Location = New System.Drawing.Point(202, 377)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(162, 42)
        Me.Button39.TabIndex = 218
        Me.Button39.Text = "     &Modifier"
        Me.Button39.UseVisualStyleBackColor = False
        '
        'Button29
        '
        Me.Button29.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button29.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button29.ForeColor = System.Drawing.Color.Black
        Me.Button29.Image = CType(resources.GetObject("Button29.Image"), System.Drawing.Image)
        Me.Button29.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button29.Location = New System.Drawing.Point(776, 377)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(162, 42)
        Me.Button29.TabIndex = 215
        Me.Button29.Text = "&Fermer"
        Me.Button29.UseVisualStyleBackColor = False
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button23.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.ForeColor = System.Drawing.Color.Black
        Me.Button23.Image = CType(resources.GetObject("Button23.Image"), System.Drawing.Image)
        Me.Button23.Location = New System.Drawing.Point(944, 294)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(53, 77)
        Me.Button23.TabIndex = 60
        Me.Button23.UseVisualStyleBackColor = False
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button24.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.ForeColor = System.Drawing.Color.Black
        Me.Button24.Image = CType(resources.GetObject("Button24.Image"), System.Drawing.Image)
        Me.Button24.Location = New System.Drawing.Point(944, 90)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(53, 77)
        Me.Button24.TabIndex = 59
        Me.Button24.UseVisualStyleBackColor = False
        '
        'DGVTarif
        '
        Me.DGVTarif.AutoGenerateColumns = False
        Me.DGVTarif.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGVTarif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTarif.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TrfIDDataGridViewTextBoxColumn, Me.TrfLibelleDataGridViewTextBoxColumn, Me.TrfCoefficientDataGridViewTextBoxColumn, Me.TarifOfArticleOfTarifDataGridViewTextBoxColumn})
        Me.DGVTarif.DataSource = Me.BDSTarif
        Me.DGVTarif.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGVTarif.Location = New System.Drawing.Point(30, 90)
        Me.DGVTarif.Name = "DGVTarif"
        Me.DGVTarif.Size = New System.Drawing.Size(908, 281)
        Me.DGVTarif.TabIndex = 41
        '
        'TrfIDDataGridViewTextBoxColumn
        '
        Me.TrfIDDataGridViewTextBoxColumn.DataPropertyName = "Trf_ID"
        Me.TrfIDDataGridViewTextBoxColumn.HeaderText = "Trf_ID"
        Me.TrfIDDataGridViewTextBoxColumn.Name = "TrfIDDataGridViewTextBoxColumn"
        Me.TrfIDDataGridViewTextBoxColumn.Visible = False
        '
        'TrfLibelleDataGridViewTextBoxColumn
        '
        Me.TrfLibelleDataGridViewTextBoxColumn.DataPropertyName = "Trf_Libelle"
        Me.TrfLibelleDataGridViewTextBoxColumn.HeaderText = "Tarif"
        Me.TrfLibelleDataGridViewTextBoxColumn.Name = "TrfLibelleDataGridViewTextBoxColumn"
        '
        'TrfCoefficientDataGridViewTextBoxColumn
        '
        Me.TrfCoefficientDataGridViewTextBoxColumn.DataPropertyName = "Trf_Coefficient"
        Me.TrfCoefficientDataGridViewTextBoxColumn.HeaderText = "Coefficient"
        Me.TrfCoefficientDataGridViewTextBoxColumn.Name = "TrfCoefficientDataGridViewTextBoxColumn"
        '
        'TarifOfArticleOfTarifDataGridViewTextBoxColumn
        '
        Me.TarifOfArticleOfTarifDataGridViewTextBoxColumn.DataPropertyName = "TarifOfArticleOfTarif"
        Me.TarifOfArticleOfTarifDataGridViewTextBoxColumn.HeaderText = "TarifOfArticleOfTarif"
        Me.TarifOfArticleOfTarifDataGridViewTextBoxColumn.Name = "TarifOfArticleOfTarifDataGridViewTextBoxColumn"
        Me.TarifOfArticleOfTarifDataGridViewTextBoxColumn.Visible = False
        '
        'BDSTarif
        '
        Me.BDSTarif.DataSource = GetType(Caisse.TARIF)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button12)
        Me.GroupBox4.Controls.Add(Me.txtCoefficient)
        Me.GroupBox4.Controls.Add(Me.lbltrf_Coefficient)
        Me.GroupBox4.Controls.Add(Me.txtTarif)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox4.Location = New System.Drawing.Point(30, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(908, 63)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Filtre"
        '
        'Button12
        '
        Me.Button12.Enabled = False
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button12.Image = CType(resources.GetObject("Button12.Image"), System.Drawing.Image)
        Me.Button12.Location = New System.Drawing.Point(823, 23)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(79, 35)
        Me.Button12.TabIndex = 43
        Me.Button12.UseVisualStyleBackColor = True
        '
        'txtCoefficient
        '
        Me.txtCoefficient.BackColor = System.Drawing.SystemColors.Window
        Me.txtCoefficient.Location = New System.Drawing.Point(567, 34)
        Me.txtCoefficient.Name = "txtCoefficient"
        Me.txtCoefficient.Size = New System.Drawing.Size(166, 20)
        Me.txtCoefficient.TabIndex = 21
        '
        'lbltrf_Coefficient
        '
        Me.lbltrf_Coefficient.AutoSize = True
        Me.lbltrf_Coefficient.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltrf_Coefficient.ForeColor = System.Drawing.Color.Black
        Me.lbltrf_Coefficient.Location = New System.Drawing.Point(486, 36)
        Me.lbltrf_Coefficient.Name = "lbltrf_Coefficient"
        Me.lbltrf_Coefficient.Size = New System.Drawing.Size(80, 13)
        Me.lbltrf_Coefficient.TabIndex = 20
        Me.lbltrf_Coefficient.Text = "Coefficient  :"
        '
        'txtTarif
        '
        Me.txtTarif.BackColor = System.Drawing.SystemColors.Window
        Me.txtTarif.Location = New System.Drawing.Point(203, 29)
        Me.txtTarif.Name = "txtTarif"
        Me.txtTarif.Size = New System.Drawing.Size(166, 20)
        Me.txtTarif.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(139, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Libellé   :"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(30, 377)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(166, 42)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "&Nouveau Tarif"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(408, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(261, 29)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Gestion Des Articles"
        '
        'FrmListeArticle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1028, 616)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TCGestion)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListeArticle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FBA"
        Me.TCGestion.ResumeLayout(False)
        Me.TabPageRayon.ResumeLayout(False)
        CType(Me.DGVRayon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSRayon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPageFamille.ResumeLayout(False)
        CType(Me.DGVFamille, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSFamille, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPageSousFamille.ResumeLayout(False)
        CType(Me.DGVSousFamille, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSSousFamille, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPageMarque.ResumeLayout(False)
        CType(Me.DGVMarque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSMarque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbxFiltreMarque.ResumeLayout(False)
        Me.GbxFiltreMarque.PerformLayout()
        Me.TabPageArticle.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DGVArticle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageTarif.ResumeLayout(False)
        CType(Me.DGVTarif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSTarif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TCGestion As System.Windows.Forms.TabControl
    Friend WithEvents TabPageRayon As System.Windows.Forms.TabPage
    Friend WithEvents btnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents TabPageFamille As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFamilleLibelle As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPageSousFamille As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSousFamilleLibelle As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPageArticle As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TabPageTarif As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCoefficient As System.Windows.Forms.TextBox
    Friend WithEvents lbltrf_Coefficient As System.Windows.Forms.Label
    Friend WithEvents txtTarif As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DGVFamille As System.Windows.Forms.DataGridView
    Friend WithEvents DGVSousFamille As System.Windows.Forms.DataGridView
    Friend WithEvents TabPageMarque As System.Windows.Forms.TabPage
    Friend WithEvents DGVMarque As System.Windows.Forms.DataGridView
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GbxFiltreMarque As System.Windows.Forms.GroupBox
    Friend WithEvents txtMarqueLibelle As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DGVArticle As System.Windows.Forms.DataGridView
    Friend WithEvents DGVTarif As System.Windows.Forms.DataGridView
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents cmdFermer As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRayonLibelle As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents RayIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RayLibDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RAYONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DGVRayon As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Btn_Supprimer As System.Windows.Forms.Button
    Friend WithEvents Btn_Modifier As System.Windows.Forms.Button
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents FAMILLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FmlIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FamilleofRayonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FmlLibDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents Button33 As System.Windows.Forms.Button
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents Button35 As System.Windows.Forms.Button
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents Button37 As System.Windows.Forms.Button
    Friend WithEvents Button38 As System.Windows.Forms.Button
    Friend WithEvents Button39 As System.Windows.Forms.Button
    Friend WithEvents BDSSousFamille As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SFIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FamilleofSousFamilleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SfLibDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MrqIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SousFamilleofMarquesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MrqLibDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDSMarque As System.Windows.Forms.BindingSource
    Friend WithEvents TrfIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrfLibelleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrfCoefficientDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TarifOfArticleOfTarifDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDSTarif As System.Windows.Forms.BindingSource
    Friend WithEvents BDSRayon As System.Windows.Forms.BindingSource
    Friend WithEvents BDSFamille As System.Windows.Forms.BindingSource
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cmb_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Button40 As System.Windows.Forms.Button
    Friend WithEvents ARTICLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ARTIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TarifOfArticleOfArticleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARTREFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TvaOfArticleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeBarOfArticleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarqueOfArticleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARTDATEENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARTPRIXUHTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARTTAUXTVADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARTDESCRIPTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARTSTOCKMINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARTDATEPEREMTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARTSTOCKMAXDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARTPHOTODataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ARTTYPEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARTSTOCKABLEDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ARTSTOCKREELDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARTSTOCKALERTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARTSTOCKRESERVEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARTCONSOMABLEDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ARTNATUREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARTDATEMODIFICATIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARTMOTIFMODIFICATIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
