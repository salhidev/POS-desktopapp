<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListeCaissier
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListeCaissier))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCINCaissier = New System.Windows.Forms.TextBox()
        Me.txtPrenomCaissier = New System.Windows.Forms.TextBox()
        Me.txtNomCaissier = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvCaissier = New System.Windows.Forms.DataGridView()
        Me.Btn_Supprimer = New System.Windows.Forms.Button()
        Me.Btn_Modifier = New System.Windows.Forms.Button()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.Button40 = New System.Windows.Forms.Button()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.CAISSIER_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAISSIER_NOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAISSIER_PRENOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAISSIER_DATENAISS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAISSIER_TYPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAISSIER_MOTDEPASSE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAISSIER_CIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAISSIER_SEX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAISSIER_VILLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAISSIER_PAYS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAISSIER_ADRESSE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAISSIER_CODEPOSTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAISSIER_TEL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAISSIERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvCaissier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAISSIERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.BackColor = System.Drawing.Color.Transparent
        Me.lblTitre.Font = New System.Drawing.Font("Constantia", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblTitre.Location = New System.Drawing.Point(378, 70)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(213, 41)
        Me.lblTitre.TabIndex = 54
        Me.lblTitre.Text = "Les Caissier "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtCINCaissier)
        Me.GroupBox1.Controls.Add(Me.txtPrenomCaissier)
        Me.GroupBox1.Controls.Add(Me.txtNomCaissier)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(95, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 63)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rechercher par : "
        '
        'txtCINCaissier
        '
        Me.txtCINCaissier.Location = New System.Drawing.Point(585, 31)
        Me.txtCINCaissier.Name = "txtCINCaissier"
        Me.txtCINCaissier.Size = New System.Drawing.Size(122, 20)
        Me.txtCINCaissier.TabIndex = 63
        '
        'txtPrenomCaissier
        '
        Me.txtPrenomCaissier.Location = New System.Drawing.Point(364, 31)
        Me.txtPrenomCaissier.Name = "txtPrenomCaissier"
        Me.txtPrenomCaissier.Size = New System.Drawing.Size(122, 20)
        Me.txtPrenomCaissier.TabIndex = 62
        '
        'txtNomCaissier
        '
        Me.txtNomCaissier.Location = New System.Drawing.Point(129, 31)
        Me.txtNomCaissier.Name = "txtNomCaissier"
        Me.txtNomCaissier.Size = New System.Drawing.Size(122, 20)
        Me.txtNomCaissier.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(548, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "CIN :"
        '
        'Button10
        '
        Me.Button10.Enabled = False
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Image = Global.Caisse.My.Resources.Resources.btFiltre324
        Me.Button10.Location = New System.Drawing.Point(740, 16)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(46, 35)
        Me.Button10.TabIndex = 55
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(301, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Prenom :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Nom :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DgvCaissier)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(927, 260)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        '
        'DgvCaissier
        '
        Me.DgvCaissier.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgvCaissier.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCaissier.AutoGenerateColumns = False
        Me.DgvCaissier.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvCaissier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCaissier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CAISSIER_ID, Me.CAISSIER_NOM, Me.CAISSIER_PRENOM, Me.CAISSIER_DATENAISS, Me.CAISSIER_TYPE, Me.CAISSIER_MOTDEPASSE, Me.CAISSIER_CIN, Me.CAISSIER_SEX, Me.CAISSIER_VILLE, Me.CAISSIER_PAYS, Me.CAISSIER_ADRESSE, Me.CAISSIER_CODEPOSTAL, Me.CAISSIER_TEL})
        Me.DgvCaissier.DataSource = Me.CAISSIERBindingSource
        Me.DgvCaissier.Location = New System.Drawing.Point(6, 19)
        Me.DgvCaissier.Name = "DgvCaissier"
        Me.DgvCaissier.RowHeadersVisible = False
        Me.DgvCaissier.Size = New System.Drawing.Size(907, 235)
        Me.DgvCaissier.TabIndex = 46
        '
        'Btn_Supprimer
        '
        Me.Btn_Supprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btn_Supprimer.Image = Global.Caisse.My.Resources.Resources.btSupprimer32
        Me.Btn_Supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Supprimer.Location = New System.Drawing.Point(355, 476)
        Me.Btn_Supprimer.Name = "Btn_Supprimer"
        Me.Btn_Supprimer.Size = New System.Drawing.Size(154, 48)
        Me.Btn_Supprimer.TabIndex = 223
        Me.Btn_Supprimer.Text = "   Supprimer"
        Me.Btn_Supprimer.UseVisualStyleBackColor = False
        '
        'Btn_Modifier
        '
        Me.Btn_Modifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btn_Modifier.Image = Global.Caisse.My.Resources.Resources.btModifier32
        Me.Btn_Modifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Modifier.Location = New System.Drawing.Point(195, 476)
        Me.Btn_Modifier.Name = "Btn_Modifier"
        Me.Btn_Modifier.Size = New System.Drawing.Size(154, 48)
        Me.Btn_Modifier.TabIndex = 222
        Me.Btn_Modifier.Text = "     Modifier"
        Me.Btn_Modifier.UseVisualStyleBackColor = False
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEnregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnregistrer.Image = Global.Caisse.My.Resources.Resources.btEnregistrer32
        Me.btnEnregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnregistrer.Location = New System.Drawing.Point(35, 476)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(154, 48)
        Me.btnEnregistrer.TabIndex = 221
        Me.btnEnregistrer.Text = "    &Nouvelle caissier"
        Me.btnEnregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnregistrer.UseVisualStyleBackColor = False
        '
        'Button40
        '
        Me.Button40.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button40.Image = CType(resources.GetObject("Button40.Image"), System.Drawing.Image)
        Me.Button40.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button40.Location = New System.Drawing.Point(528, 476)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(154, 48)
        Me.Button40.TabIndex = 225
        Me.Button40.Text = "   &Imprimer"
        Me.Button40.UseVisualStyleBackColor = False
        '
        'btnFermer
        '
        Me.btnFermer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnFermer.Image = Global.Caisse.My.Resources.Resources.Log_Out2
        Me.btnFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFermer.Location = New System.Drawing.Point(788, 474)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(154, 48)
        Me.btnFermer.TabIndex = 226
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = False
        '
        'CAISSIER_ID
        '
        Me.CAISSIER_ID.DataPropertyName = "CAISSIER_ID"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CAISSIER_ID.DefaultCellStyle = DataGridViewCellStyle2
        Me.CAISSIER_ID.HeaderText = "CAISSIER_ID"
        Me.CAISSIER_ID.Name = "CAISSIER_ID"
        Me.CAISSIER_ID.Visible = False
        '
        'CAISSIER_NOM
        '
        Me.CAISSIER_NOM.DataPropertyName = "CAISSIER_NOM"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CAISSIER_NOM.DefaultCellStyle = DataGridViewCellStyle3
        Me.CAISSIER_NOM.HeaderText = "Nom"
        Me.CAISSIER_NOM.Name = "CAISSIER_NOM"
        '
        'CAISSIER_PRENOM
        '
        Me.CAISSIER_PRENOM.DataPropertyName = "CAISSIER_PRENOM"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CAISSIER_PRENOM.DefaultCellStyle = DataGridViewCellStyle4
        Me.CAISSIER_PRENOM.HeaderText = "Prenom"
        Me.CAISSIER_PRENOM.Name = "CAISSIER_PRENOM"
        '
        'CAISSIER_DATENAISS
        '
        Me.CAISSIER_DATENAISS.DataPropertyName = "CAISSIER_DATENAISS"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CAISSIER_DATENAISS.DefaultCellStyle = DataGridViewCellStyle5
        Me.CAISSIER_DATENAISS.HeaderText = "Date de naissance"
        Me.CAISSIER_DATENAISS.Name = "CAISSIER_DATENAISS"
        '
        'CAISSIER_TYPE
        '
        Me.CAISSIER_TYPE.DataPropertyName = "CAISSIER_TYPE"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CAISSIER_TYPE.DefaultCellStyle = DataGridViewCellStyle6
        Me.CAISSIER_TYPE.HeaderText = "Type de caissier"
        Me.CAISSIER_TYPE.Name = "CAISSIER_TYPE"
        '
        'CAISSIER_MOTDEPASSE
        '
        Me.CAISSIER_MOTDEPASSE.DataPropertyName = "CAISSIER_MOTDEPASSE"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CAISSIER_MOTDEPASSE.DefaultCellStyle = DataGridViewCellStyle7
        Me.CAISSIER_MOTDEPASSE.HeaderText = "Mot de passe"
        Me.CAISSIER_MOTDEPASSE.Name = "CAISSIER_MOTDEPASSE"
        '
        'CAISSIER_CIN
        '
        Me.CAISSIER_CIN.DataPropertyName = "CAISSIER_CIN"
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CAISSIER_CIN.DefaultCellStyle = DataGridViewCellStyle8
        Me.CAISSIER_CIN.HeaderText = "CIN"
        Me.CAISSIER_CIN.Name = "CAISSIER_CIN"
        '
        'CAISSIER_SEX
        '
        Me.CAISSIER_SEX.DataPropertyName = "CAISSIER_SEX"
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CAISSIER_SEX.DefaultCellStyle = DataGridViewCellStyle9
        Me.CAISSIER_SEX.HeaderText = "Sexe"
        Me.CAISSIER_SEX.Name = "CAISSIER_SEX"
        '
        'CAISSIER_VILLE
        '
        Me.CAISSIER_VILLE.DataPropertyName = "CAISSIER_VILLE"
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CAISSIER_VILLE.DefaultCellStyle = DataGridViewCellStyle10
        Me.CAISSIER_VILLE.HeaderText = "Ville"
        Me.CAISSIER_VILLE.Name = "CAISSIER_VILLE"
        '
        'CAISSIER_PAYS
        '
        Me.CAISSIER_PAYS.DataPropertyName = "CAISSIER_PAYS"
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CAISSIER_PAYS.DefaultCellStyle = DataGridViewCellStyle11
        Me.CAISSIER_PAYS.HeaderText = "Pays"
        Me.CAISSIER_PAYS.Name = "CAISSIER_PAYS"
        '
        'CAISSIER_ADRESSE
        '
        Me.CAISSIER_ADRESSE.DataPropertyName = "CAISSIER_ADRESSE"
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CAISSIER_ADRESSE.DefaultCellStyle = DataGridViewCellStyle12
        Me.CAISSIER_ADRESSE.HeaderText = "Adresse"
        Me.CAISSIER_ADRESSE.Name = "CAISSIER_ADRESSE"
        '
        'CAISSIER_CODEPOSTAL
        '
        Me.CAISSIER_CODEPOSTAL.DataPropertyName = "CAISSIER_CODEPOSTAL"
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CAISSIER_CODEPOSTAL.DefaultCellStyle = DataGridViewCellStyle13
        Me.CAISSIER_CODEPOSTAL.HeaderText = "Code postal"
        Me.CAISSIER_CODEPOSTAL.Name = "CAISSIER_CODEPOSTAL"
        '
        'CAISSIER_TEL
        '
        Me.CAISSIER_TEL.DataPropertyName = "CAISSIER_TEL"
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CAISSIER_TEL.DefaultCellStyle = DataGridViewCellStyle14
        Me.CAISSIER_TEL.HeaderText = "Telephone"
        Me.CAISSIER_TEL.Name = "CAISSIER_TEL"
        '
        'CAISSIERBindingSource
        '
        Me.CAISSIERBindingSource.DataSource = GetType(Caisse.CAISSIER)
        '
        'FrmListeCaissier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(994, 687)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.Button40)
        Me.Controls.Add(Me.Btn_Supprimer)
        Me.Controls.Add(Me.Btn_Modifier)
        Me.Controls.Add(Me.btnEnregistrer)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitre)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListeCaissier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FBA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvCaissier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAISSIERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvCaissier As System.Windows.Forms.DataGridView
    Friend WithEvents CAISSIERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Btn_Supprimer As System.Windows.Forms.Button
    Friend WithEvents Btn_Modifier As System.Windows.Forms.Button
    Friend WithEvents btnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents txtCINCaissier As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenomCaissier As System.Windows.Forms.TextBox
    Friend WithEvents txtNomCaissier As System.Windows.Forms.TextBox
    Friend WithEvents CAISSIER_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAISSIER_NOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAISSIER_PRENOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAISSIER_DATENAISS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAISSIER_TYPE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAISSIER_MOTDEPASSE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAISSIER_CIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAISSIER_SEX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAISSIER_VILLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAISSIER_PAYS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAISSIER_ADRESSE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAISSIER_CODEPOSTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAISSIER_TEL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button40 As System.Windows.Forms.Button
    Friend WithEvents btnFermer As System.Windows.Forms.Button
End Class
