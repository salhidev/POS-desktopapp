<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListeClients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListeClients))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCINClient = New System.Windows.Forms.TextBox()
        Me.txtPrenomClient = New System.Windows.Forms.TextBox()
        Me.txtNomClient = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvClients = New System.Windows.Forms.DataGridView()
        Me.CLTMATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLTNOMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLTPRENOMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLTREFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLTPAYSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLTVILLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLTADRESSEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLTCINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLTCPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLTSEXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLTDATENAISSEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLTDTIMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLTEMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLTFAXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLTTELPRODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLTTEL2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLTSITEWEBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLTETATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLTTYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnChoisiClient = New System.Windows.Forms.Button()
        Me.Btn_Supprimer = New System.Windows.Forms.Button()
        Me.Btn_Modifier = New System.Windows.Forms.Button()
        Me.btnNvClient = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvClients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(494, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 38)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Les Clients"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCINClient)
        Me.GroupBox1.Controls.Add(Me.txtPrenomClient)
        Me.GroupBox1.Controls.Add(Me.txtNomClient)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(111, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(826, 72)
        Me.GroupBox1.TabIndex = 216
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rechercher Par : "
        '
        'txtCINClient
        '
        Me.txtCINClient.Location = New System.Drawing.Point(584, 27)
        Me.txtCINClient.Name = "txtCINClient"
        Me.txtCINClient.Size = New System.Drawing.Size(122, 20)
        Me.txtCINClient.TabIndex = 66
        '
        'txtPrenomClient
        '
        Me.txtPrenomClient.Location = New System.Drawing.Point(390, 27)
        Me.txtPrenomClient.Name = "txtPrenomClient"
        Me.txtPrenomClient.Size = New System.Drawing.Size(122, 20)
        Me.txtPrenomClient.TabIndex = 65
        '
        'txtNomClient
        '
        Me.txtNomClient.Location = New System.Drawing.Point(179, 27)
        Me.txtNomClient.Name = "txtNomClient"
        Me.txtNomClient.Size = New System.Drawing.Size(122, 20)
        Me.txtNomClient.TabIndex = 64
        '
        'Button10
        '
        Me.Button10.Enabled = False
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Image = Global.Caisse.My.Resources.Resources.btFiltre32
        Me.Button10.Location = New System.Drawing.Point(717, 19)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(42, 35)
        Me.Button10.TabIndex = 53
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(529, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "CIN :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(327, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Prenom :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Nom :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvClients)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 215)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1031, 287)
        Me.GroupBox2.TabIndex = 217
        Me.GroupBox2.TabStop = False
        '
        'DgvClients
        '
        Me.DgvClients.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgvClients.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvClients.AutoGenerateColumns = False
        Me.DgvClients.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvClients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLTMATDataGridViewTextBoxColumn, Me.CLTNOMDataGridViewTextBoxColumn, Me.CLTPRENOMDataGridViewTextBoxColumn, Me.CLTREFDataGridViewTextBoxColumn, Me.CLTPAYSDataGridViewTextBoxColumn, Me.CLTVILLEDataGridViewTextBoxColumn, Me.CLTADRESSEDataGridViewTextBoxColumn, Me.CLTCINDataGridViewTextBoxColumn, Me.CLTCPDataGridViewTextBoxColumn, Me.CLTSEXDataGridViewTextBoxColumn, Me.CLTDATENAISSEDataGridViewTextBoxColumn, Me.CLTDTIMDataGridViewTextBoxColumn, Me.CLTEMAILDataGridViewTextBoxColumn, Me.CLTFAXDataGridViewTextBoxColumn, Me.CLTTELPRODataGridViewTextBoxColumn, Me.CLTTEL2DataGridViewTextBoxColumn, Me.CLTSITEWEBDataGridViewTextBoxColumn, Me.CLTETATDataGridViewTextBoxColumn, Me.CLTTYPEDataGridViewTextBoxColumn})
        Me.DgvClients.DataSource = Me.ClientBindingSource
        Me.DgvClients.Location = New System.Drawing.Point(6, 19)
        Me.DgvClients.Name = "DgvClients"
        Me.DgvClients.RowHeadersVisible = False
        Me.DgvClients.Size = New System.Drawing.Size(1004, 250)
        Me.DgvClients.TabIndex = 36
        '
        'CLTMATDataGridViewTextBoxColumn
        '
        Me.CLTMATDataGridViewTextBoxColumn.DataPropertyName = "CLT_MAT"
        Me.CLTMATDataGridViewTextBoxColumn.HeaderText = "CLT_MAT"
        Me.CLTMATDataGridViewTextBoxColumn.Name = "CLTMATDataGridViewTextBoxColumn"
        Me.CLTMATDataGridViewTextBoxColumn.Visible = False
        '
        'CLTNOMDataGridViewTextBoxColumn
        '
        Me.CLTNOMDataGridViewTextBoxColumn.DataPropertyName = "CLT_NOM"
        Me.CLTNOMDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.CLTNOMDataGridViewTextBoxColumn.Name = "CLTNOMDataGridViewTextBoxColumn"
        '
        'CLTPRENOMDataGridViewTextBoxColumn
        '
        Me.CLTPRENOMDataGridViewTextBoxColumn.DataPropertyName = "CLT_PRENOM"
        Me.CLTPRENOMDataGridViewTextBoxColumn.HeaderText = "Prenom"
        Me.CLTPRENOMDataGridViewTextBoxColumn.Name = "CLTPRENOMDataGridViewTextBoxColumn"
        '
        'CLTREFDataGridViewTextBoxColumn
        '
        Me.CLTREFDataGridViewTextBoxColumn.DataPropertyName = "CLT_REF"
        Me.CLTREFDataGridViewTextBoxColumn.HeaderText = "Reference"
        Me.CLTREFDataGridViewTextBoxColumn.Name = "CLTREFDataGridViewTextBoxColumn"
        '
        'CLTPAYSDataGridViewTextBoxColumn
        '
        Me.CLTPAYSDataGridViewTextBoxColumn.DataPropertyName = "CLT_PAYS"
        Me.CLTPAYSDataGridViewTextBoxColumn.HeaderText = "Pays"
        Me.CLTPAYSDataGridViewTextBoxColumn.Name = "CLTPAYSDataGridViewTextBoxColumn"
        '
        'CLTVILLEDataGridViewTextBoxColumn
        '
        Me.CLTVILLEDataGridViewTextBoxColumn.DataPropertyName = "CLT_VILLE"
        Me.CLTVILLEDataGridViewTextBoxColumn.HeaderText = "Ville"
        Me.CLTVILLEDataGridViewTextBoxColumn.Name = "CLTVILLEDataGridViewTextBoxColumn"
        '
        'CLTADRESSEDataGridViewTextBoxColumn
        '
        Me.CLTADRESSEDataGridViewTextBoxColumn.DataPropertyName = "CLT_ADRESSE"
        Me.CLTADRESSEDataGridViewTextBoxColumn.HeaderText = "Adresse"
        Me.CLTADRESSEDataGridViewTextBoxColumn.Name = "CLTADRESSEDataGridViewTextBoxColumn"
        '
        'CLTCINDataGridViewTextBoxColumn
        '
        Me.CLTCINDataGridViewTextBoxColumn.DataPropertyName = "CLT_CIN"
        Me.CLTCINDataGridViewTextBoxColumn.HeaderText = "CIN"
        Me.CLTCINDataGridViewTextBoxColumn.Name = "CLTCINDataGridViewTextBoxColumn"
        '
        'CLTCPDataGridViewTextBoxColumn
        '
        Me.CLTCPDataGridViewTextBoxColumn.DataPropertyName = "CLT_CP"
        Me.CLTCPDataGridViewTextBoxColumn.HeaderText = "Code postal"
        Me.CLTCPDataGridViewTextBoxColumn.Name = "CLTCPDataGridViewTextBoxColumn"
        '
        'CLTSEXDataGridViewTextBoxColumn
        '
        Me.CLTSEXDataGridViewTextBoxColumn.DataPropertyName = "CLT_SEX"
        Me.CLTSEXDataGridViewTextBoxColumn.HeaderText = "Sexe"
        Me.CLTSEXDataGridViewTextBoxColumn.Name = "CLTSEXDataGridViewTextBoxColumn"
        '
        'CLTDATENAISSEDataGridViewTextBoxColumn
        '
        Me.CLTDATENAISSEDataGridViewTextBoxColumn.DataPropertyName = "CLT_DATENAISSE"
        Me.CLTDATENAISSEDataGridViewTextBoxColumn.HeaderText = "Date naissance"
        Me.CLTDATENAISSEDataGridViewTextBoxColumn.Name = "CLTDATENAISSEDataGridViewTextBoxColumn"
        '
        'CLTDTIMDataGridViewTextBoxColumn
        '
        Me.CLTDTIMDataGridViewTextBoxColumn.DataPropertyName = "CLT_DTIM"
        Me.CLTDTIMDataGridViewTextBoxColumn.HeaderText = "Date immatriculation"
        Me.CLTDTIMDataGridViewTextBoxColumn.Name = "CLTDTIMDataGridViewTextBoxColumn"
        '
        'CLTEMAILDataGridViewTextBoxColumn
        '
        Me.CLTEMAILDataGridViewTextBoxColumn.DataPropertyName = "CLT_EMAIL"
        Me.CLTEMAILDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.CLTEMAILDataGridViewTextBoxColumn.Name = "CLTEMAILDataGridViewTextBoxColumn"
        '
        'CLTFAXDataGridViewTextBoxColumn
        '
        Me.CLTFAXDataGridViewTextBoxColumn.DataPropertyName = "CLT_FAX"
        Me.CLTFAXDataGridViewTextBoxColumn.HeaderText = "Fax"
        Me.CLTFAXDataGridViewTextBoxColumn.Name = "CLTFAXDataGridViewTextBoxColumn"
        '
        'CLTTELPRODataGridViewTextBoxColumn
        '
        Me.CLTTELPRODataGridViewTextBoxColumn.DataPropertyName = "CLT_TELPRO"
        Me.CLTTELPRODataGridViewTextBoxColumn.HeaderText = "Tel pro"
        Me.CLTTELPRODataGridViewTextBoxColumn.Name = "CLTTELPRODataGridViewTextBoxColumn"
        '
        'CLTTEL2DataGridViewTextBoxColumn
        '
        Me.CLTTEL2DataGridViewTextBoxColumn.DataPropertyName = "CLT_TEL2"
        Me.CLTTEL2DataGridViewTextBoxColumn.HeaderText = "Tele 2"
        Me.CLTTEL2DataGridViewTextBoxColumn.Name = "CLTTEL2DataGridViewTextBoxColumn"
        '
        'CLTSITEWEBDataGridViewTextBoxColumn
        '
        Me.CLTSITEWEBDataGridViewTextBoxColumn.DataPropertyName = "CLT_SITEWEB"
        Me.CLTSITEWEBDataGridViewTextBoxColumn.HeaderText = "Site web"
        Me.CLTSITEWEBDataGridViewTextBoxColumn.Name = "CLTSITEWEBDataGridViewTextBoxColumn"
        '
        'CLTETATDataGridViewTextBoxColumn
        '
        Me.CLTETATDataGridViewTextBoxColumn.DataPropertyName = "CLT_ETAT"
        Me.CLTETATDataGridViewTextBoxColumn.HeaderText = "Etat"
        Me.CLTETATDataGridViewTextBoxColumn.Name = "CLTETATDataGridViewTextBoxColumn"
        '
        'CLTTYPEDataGridViewTextBoxColumn
        '
        Me.CLTTYPEDataGridViewTextBoxColumn.DataPropertyName = "CLT_TYPE"
        Me.CLTTYPEDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.CLTTYPEDataGridViewTextBoxColumn.Name = "CLTTYPEDataGridViewTextBoxColumn"
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataSource = GetType(Caisse.Client)
        '
        'BtnChoisiClient
        '
        Me.BtnChoisiClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnChoisiClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChoisiClient.Image = Global.Caisse.My.Resources.Resources.Valider
        Me.BtnChoisiClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnChoisiClient.Location = New System.Drawing.Point(21, 508)
        Me.BtnChoisiClient.Name = "BtnChoisiClient"
        Me.BtnChoisiClient.Size = New System.Drawing.Size(184, 43)
        Me.BtnChoisiClient.TabIndex = 218
        Me.BtnChoisiClient.Text = "Confirmer Votre Client"
        Me.BtnChoisiClient.UseVisualStyleBackColor = False
        '
        'Btn_Supprimer
        '
        Me.Btn_Supprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btn_Supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Supprimer.Image = Global.Caisse.My.Resources.Resources.btSupprimer325
        Me.Btn_Supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Supprimer.Location = New System.Drawing.Point(613, 508)
        Me.Btn_Supprimer.Name = "Btn_Supprimer"
        Me.Btn_Supprimer.Size = New System.Drawing.Size(184, 43)
        Me.Btn_Supprimer.TabIndex = 221
        Me.Btn_Supprimer.Text = "   Supprimer"
        Me.Btn_Supprimer.UseVisualStyleBackColor = False
        '
        'Btn_Modifier
        '
        Me.Btn_Modifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btn_Modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modifier.Image = Global.Caisse.My.Resources.Resources.btModifier325
        Me.Btn_Modifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Modifier.Location = New System.Drawing.Point(423, 508)
        Me.Btn_Modifier.Name = "Btn_Modifier"
        Me.Btn_Modifier.Size = New System.Drawing.Size(184, 43)
        Me.Btn_Modifier.TabIndex = 220
        Me.Btn_Modifier.Text = "     Modifier"
        Me.Btn_Modifier.UseVisualStyleBackColor = False
        '
        'btnNvClient
        '
        Me.btnNvClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnNvClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNvClient.Image = Global.Caisse.My.Resources.Resources.MiseAjour4
        Me.btnNvClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNvClient.Location = New System.Drawing.Point(221, 508)
        Me.btnNvClient.Name = "btnNvClient"
        Me.btnNvClient.Size = New System.Drawing.Size(184, 43)
        Me.btnNvClient.TabIndex = 219
        Me.btnNvClient.Text = "    &Nouveau Client"
        Me.btnNvClient.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Caisse.My.Resources.Resources.Log_Out2
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(902, 508)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 43)
        Me.Button1.TabIndex = 222
        Me.Button1.Text = "   Fermer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmListeClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1036, 746)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn_Supprimer)
        Me.Controls.Add(Me.Btn_Modifier)
        Me.Controls.Add(Me.btnNvClient)
        Me.Controls.Add(Me.BtnChoisiClient)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListeClients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FBA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvClients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvClients As System.Windows.Forms.DataGridView
    Friend WithEvents BtnChoisiClient As System.Windows.Forms.Button
    Friend WithEvents Btn_Supprimer As System.Windows.Forms.Button
    Friend WithEvents Btn_Modifier As System.Windows.Forms.Button
    Friend WithEvents btnNvClient As System.Windows.Forms.Button
    Friend WithEvents CLT_MAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLT_NOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLT_PRENOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLT_REF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLT_VILLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLT_CP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLT_ADRESSE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLT_EMAIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLT_FAX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLT_TELPRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLT_PAYS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLT_TEL2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLT_SEX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLT_CIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLT_SITEWEB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLT_ETAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLT_TYPE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLT_DTIM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLT_DATENAISSE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCINClient As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenomClient As System.Windows.Forms.TextBox
    Friend WithEvents txtNomClient As System.Windows.Forms.TextBox
    Friend WithEvents CLTMATDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLTNOMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLTPRENOMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLTREFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLTPAYSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLTVILLEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLTADRESSEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLTCINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLTCPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLTSEXDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLTDATENAISSEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLTDTIMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLTEMAILDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLTFAXDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLTTELPRODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLTTEL2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLTSITEWEBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLTETATDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLTTYPEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
