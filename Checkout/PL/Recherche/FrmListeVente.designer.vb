<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListeVente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListeVente))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgtickets = New System.Windows.Forms.TabPage()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Grbrecherche = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbldatecreationtick = New System.Windows.Forms.Label()
        Me.lblTypeticket = New System.Windows.Forms.Label()
        Me.lblMontantReçu = New System.Windows.Forms.Label()
        Me.txtMontantreçu = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txttypetick = New System.Windows.Forms.TextBox()
        Me.dgvtickets = New System.Windows.Forms.DataGridView()
        Me.tpgfacture = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbRechFact = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblEtatfact = New System.Windows.Forms.Label()
        Me.RdbNonValide = New System.Windows.Forms.RadioButton()
        Me.RdbValide = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.dgvFacture = New System.Windows.Forms.DataGridView()
        Me.tpgcmdclient = New System.Windows.Forms.TabPage()
        Me.DgvCommande = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblnomclient = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRefCom = New System.Windows.Forms.Label()
        Me.txtrefcom = New System.Windows.Forms.TextBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.txtNomclient = New System.Windows.Forms.TextBox()
        Me.tpgRéglement = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dgvModeReglement = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtLibRegl = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLibRegl = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.TXTCIN = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblVente = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tpgtickets.SuspendLayout()
        Me.Grbrecherche.SuspendLayout()
        CType(Me.dgvtickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgfacture.SuspendLayout()
        Me.grbRechFact.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvFacture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgcmdclient.SuspendLayout()
        CType(Me.DgvCommande, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.tpgRéglement.SuspendLayout()
        CType(Me.dgvModeReglement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgtickets)
        Me.TabControl1.Controls.Add(Me.tpgfacture)
        Me.TabControl1.Controls.Add(Me.tpgcmdclient)
        Me.TabControl1.Controls.Add(Me.tpgRéglement)
        Me.TabControl1.ItemSize = New System.Drawing.Size(54, 40)
        Me.TabControl1.Location = New System.Drawing.Point(12, 168)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1049, 496)
        Me.TabControl1.TabIndex = 0
        '
        'tpgtickets
        '
        Me.tpgtickets.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tpgtickets.Controls.Add(Me.Button8)
        Me.tpgtickets.Controls.Add(Me.Button28)
        Me.tpgtickets.Controls.Add(Me.Label6)
        Me.tpgtickets.Controls.Add(Me.Grbrecherche)
        Me.tpgtickets.Controls.Add(Me.dgvtickets)
        Me.tpgtickets.Location = New System.Drawing.Point(4, 44)
        Me.tpgtickets.Name = "tpgtickets"
        Me.tpgtickets.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgtickets.Size = New System.Drawing.Size(1041, 448)
        Me.tpgtickets.TabIndex = 0
        Me.tpgtickets.Text = "Tickets"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button8.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Image = Global.Caisse.My.Resources.Resources.Valider
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(10, 343)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(162, 42)
        Me.Button8.TabIndex = 230
        Me.Button8.Text = "Consulter"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button28
        '
        Me.Button28.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button28.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button28.ForeColor = System.Drawing.Color.Black
        Me.Button28.Image = Global.Caisse.My.Resources.Resources.Log_Out2
        Me.Button28.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button28.Location = New System.Drawing.Point(723, 343)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(162, 42)
        Me.Button28.TabIndex = 222
        Me.Button28.Text = "&Fermer"
        Me.Button28.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Critéres de recherche :"
        '
        'Grbrecherche
        '
        Me.Grbrecherche.Controls.Add(Me.Button1)
        Me.Grbrecherche.Controls.Add(Me.lbldatecreationtick)
        Me.Grbrecherche.Controls.Add(Me.lblTypeticket)
        Me.Grbrecherche.Controls.Add(Me.lblMontantReçu)
        Me.Grbrecherche.Controls.Add(Me.txtMontantreçu)
        Me.Grbrecherche.Controls.Add(Me.DateTimePicker1)
        Me.Grbrecherche.Controls.Add(Me.txttypetick)
        Me.Grbrecherche.Location = New System.Drawing.Point(12, 24)
        Me.Grbrecherche.Name = "Grbrecherche"
        Me.Grbrecherche.Size = New System.Drawing.Size(873, 56)
        Me.Grbrecherche.TabIndex = 10
        Me.Grbrecherche.TabStop = False
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Caisse.My.Resources.Resources.btFiltre325
        Me.Button1.Location = New System.Drawing.Point(765, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 33)
        Me.Button1.TabIndex = 44
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbldatecreationtick
        '
        Me.lbldatecreationtick.AutoSize = True
        Me.lbldatecreationtick.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldatecreationtick.ForeColor = System.Drawing.Color.Black
        Me.lbldatecreationtick.Location = New System.Drawing.Point(50, 22)
        Me.lbldatecreationtick.Name = "lbldatecreationtick"
        Me.lbldatecreationtick.Size = New System.Drawing.Size(110, 13)
        Me.lbldatecreationtick.TabIndex = 0
        Me.lbldatecreationtick.Text = "Date de création :"
        '
        'lblTypeticket
        '
        Me.lblTypeticket.AutoSize = True
        Me.lblTypeticket.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeticket.ForeColor = System.Drawing.Color.Black
        Me.lblTypeticket.Location = New System.Drawing.Point(321, 25)
        Me.lblTypeticket.Name = "lblTypeticket"
        Me.lblTypeticket.Size = New System.Drawing.Size(101, 13)
        Me.lblTypeticket.TabIndex = 1
        Me.lblTypeticket.Text = "Type de ticket : "
        '
        'lblMontantReçu
        '
        Me.lblMontantReçu.AutoSize = True
        Me.lblMontantReçu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontantReçu.ForeColor = System.Drawing.Color.Black
        Me.lblMontantReçu.Location = New System.Drawing.Point(539, 24)
        Me.lblMontantReçu.Name = "lblMontantReçu"
        Me.lblMontantReçu.Size = New System.Drawing.Size(94, 13)
        Me.lblMontantReçu.TabIndex = 2
        Me.lblMontantReçu.Text = "Montant reçu : "
        '
        'txtMontantreçu
        '
        Me.txtMontantreçu.Location = New System.Drawing.Point(639, 20)
        Me.txtMontantreçu.Name = "txtMontantreçu"
        Me.txtMontantreçu.Size = New System.Drawing.Size(120, 20)
        Me.txtMontantreçu.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(166, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(137, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'txttypetick
        '
        Me.txttypetick.Location = New System.Drawing.Point(428, 22)
        Me.txttypetick.Name = "txttypetick"
        Me.txttypetick.Size = New System.Drawing.Size(105, 20)
        Me.txttypetick.TabIndex = 5
        '
        'dgvtickets
        '
        Me.dgvtickets.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvtickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtickets.Location = New System.Drawing.Point(12, 86)
        Me.dgvtickets.Name = "dgvtickets"
        Me.dgvtickets.RowHeadersVisible = False
        Me.dgvtickets.Size = New System.Drawing.Size(873, 251)
        Me.dgvtickets.TabIndex = 7
        '
        'tpgfacture
        '
        Me.tpgfacture.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tpgfacture.Controls.Add(Me.Button7)
        Me.tpgfacture.Controls.Add(Me.Button2)
        Me.tpgfacture.Controls.Add(Me.Label1)
        Me.tpgfacture.Controls.Add(Me.grbRechFact)
        Me.tpgfacture.Controls.Add(Me.dgvFacture)
        Me.tpgfacture.Location = New System.Drawing.Point(4, 44)
        Me.tpgfacture.Name = "tpgfacture"
        Me.tpgfacture.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgfacture.Size = New System.Drawing.Size(1041, 448)
        Me.tpgfacture.TabIndex = 1
        Me.tpgfacture.Text = "Factures"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button7.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Image = Global.Caisse.My.Resources.Resources.Valider
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(12, 363)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(162, 37)
        Me.Button7.TabIndex = 230
        Me.Button7.Text = "Consulter"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.Caisse.My.Resources.Resources.Log_Out2
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(730, 362)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 37)
        Me.Button2.TabIndex = 227
        Me.Button2.Text = "&Fermer"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Critéres de recherche :"
        '
        'grbRechFact
        '
        Me.grbRechFact.Controls.Add(Me.GroupBox1)
        Me.grbRechFact.Controls.Add(Me.Label4)
        Me.grbRechFact.Controls.Add(Me.DateTimePicker2)
        Me.grbRechFact.Location = New System.Drawing.Point(12, 32)
        Me.grbRechFact.Name = "grbRechFact"
        Me.grbRechFact.Size = New System.Drawing.Size(761, 63)
        Me.grbRechFact.TabIndex = 22
        Me.grbRechFact.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEtatfact)
        Me.GroupBox1.Controls.Add(Me.RdbNonValide)
        Me.GroupBox1.Controls.Add(Me.RdbValide)
        Me.GroupBox1.Location = New System.Drawing.Point(327, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 41)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'lblEtatfact
        '
        Me.lblEtatfact.AutoSize = True
        Me.lblEtatfact.Location = New System.Drawing.Point(6, 17)
        Me.lblEtatfact.Name = "lblEtatfact"
        Me.lblEtatfact.Size = New System.Drawing.Size(104, 13)
        Me.lblEtatfact.TabIndex = 19
        Me.lblEtatfact.Text = "Etat du facture : "
        '
        'RdbNonValide
        '
        Me.RdbNonValide.AutoSize = True
        Me.RdbNonValide.Location = New System.Drawing.Point(290, 14)
        Me.RdbNonValide.Name = "RdbNonValide"
        Me.RdbNonValide.Size = New System.Drawing.Size(76, 17)
        Me.RdbNonValide.TabIndex = 21
        Me.RdbNonValide.TabStop = True
        Me.RdbNonValide.Text = "Non valide"
        Me.RdbNonValide.UseVisualStyleBackColor = True
        '
        'RdbValide
        '
        Me.RdbValide.AutoSize = True
        Me.RdbValide.Location = New System.Drawing.Point(146, 14)
        Me.RdbValide.Name = "RdbValide"
        Me.RdbValide.Size = New System.Drawing.Size(54, 17)
        Me.RdbValide.TabIndex = 20
        Me.RdbValide.TabStop = True
        Me.RdbValide.Text = "Valide"
        Me.RdbValide.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Date de création :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(134, 19)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(179, 20)
        Me.DateTimePicker2.TabIndex = 14
        '
        'dgvFacture
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvFacture.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFacture.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacture.Location = New System.Drawing.Point(12, 101)
        Me.dgvFacture.Name = "dgvFacture"
        Me.dgvFacture.RowHeadersVisible = False
        Me.dgvFacture.Size = New System.Drawing.Size(880, 251)
        Me.dgvFacture.TabIndex = 17
        '
        'tpgcmdclient
        '
        Me.tpgcmdclient.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tpgcmdclient.Controls.Add(Me.DgvCommande)
        Me.tpgcmdclient.Controls.Add(Me.Button6)
        Me.tpgcmdclient.Controls.Add(Me.Button3)
        Me.tpgcmdclient.Controls.Add(Me.GroupBox2)
        Me.tpgcmdclient.Location = New System.Drawing.Point(4, 44)
        Me.tpgcmdclient.Name = "tpgcmdclient"
        Me.tpgcmdclient.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgcmdclient.Size = New System.Drawing.Size(1041, 448)
        Me.tpgcmdclient.TabIndex = 2
        Me.tpgcmdclient.Text = "Commandes du client"
        '
        'DgvCommande
        '
        Me.DgvCommande.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCommande.Location = New System.Drawing.Point(12, 79)
        Me.DgvCommande.Name = "DgvCommande"
        Me.DgvCommande.Size = New System.Drawing.Size(1020, 289)
        Me.DgvCommande.TabIndex = 230
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button6.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Image = Global.Caisse.My.Resources.Resources.Valider
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(12, 387)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(162, 42)
        Me.Button6.TabIndex = 229
        Me.Button6.Text = "Consulter"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = Global.Caisse.My.Resources.Resources.Log_Out2
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(837, 387)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 42)
        Me.Button3.TabIndex = 224
        Me.Button3.Text = "&Fermer"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblnomclient)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblRefCom)
        Me.GroupBox2.Controls.Add(Me.txtrefcom)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox2.Controls.Add(Me.txtNomclient)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(897, 49)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Critére de la recherche : "
        '
        'lblnomclient
        '
        Me.lblnomclient.AutoSize = True
        Me.lblnomclient.Location = New System.Drawing.Point(627, 22)
        Me.lblnomclient.Name = "lblnomclient"
        Me.lblnomclient.Size = New System.Drawing.Size(75, 13)
        Me.lblnomclient.TabIndex = 7
        Me.lblnomclient.Text = "Nom client :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date de création :"
        '
        'lblRefCom
        '
        Me.lblRefCom.AutoSize = True
        Me.lblRefCom.Location = New System.Drawing.Point(402, 22)
        Me.lblRefCom.Name = "lblRefCom"
        Me.lblRefCom.Size = New System.Drawing.Size(78, 13)
        Me.lblRefCom.TabIndex = 2
        Me.lblRefCom.Text = "Reference : "
        '
        'txtrefcom
        '
        Me.txtrefcom.Location = New System.Drawing.Point(486, 19)
        Me.txtrefcom.Name = "txtrefcom"
        Me.txtrefcom.Size = New System.Drawing.Size(135, 20)
        Me.txtrefcom.TabIndex = 6
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(217, 18)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(179, 20)
        Me.DateTimePicker3.TabIndex = 4
        '
        'txtNomclient
        '
        Me.txtNomclient.Location = New System.Drawing.Point(708, 20)
        Me.txtNomclient.Name = "txtNomclient"
        Me.txtNomclient.Size = New System.Drawing.Size(135, 20)
        Me.txtNomclient.TabIndex = 5
        '
        'tpgRéglement
        '
        Me.tpgRéglement.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tpgRéglement.Controls.Add(Me.Button5)
        Me.tpgRéglement.Controls.Add(Me.Button4)
        Me.tpgRéglement.Controls.Add(Me.dgvModeReglement)
        Me.tpgRéglement.Controls.Add(Me.GroupBox3)
        Me.tpgRéglement.Controls.Add(Me.Label8)
        Me.tpgRéglement.Location = New System.Drawing.Point(4, 44)
        Me.tpgRéglement.Name = "tpgRéglement"
        Me.tpgRéglement.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgRéglement.Size = New System.Drawing.Size(1041, 448)
        Me.tpgRéglement.TabIndex = 4
        Me.tpgRéglement.Text = "Réglement"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Image = Global.Caisse.My.Resources.Resources.Valider
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(10, 353)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(162, 42)
        Me.Button5.TabIndex = 228
        Me.Button5.Text = "Consulter"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = Global.Caisse.My.Resources.Resources.Log_Out2
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(706, 349)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(162, 42)
        Me.Button4.TabIndex = 227
        Me.Button4.Text = "&Fermer"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'dgvModeReglement
        '
        Me.dgvModeReglement.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvModeReglement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModeReglement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgvModeReglement.Location = New System.Drawing.Point(10, 92)
        Me.dgvModeReglement.Name = "dgvModeReglement"
        Me.dgvModeReglement.Size = New System.Drawing.Size(858, 251)
        Me.dgvModeReglement.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.HeaderText = "Reference"
        Me.Column1.Name = "Column1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtLibRegl)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.lblLibRegl)
        Me.GroupBox3.Controls.Add(Me.lblPrenom)
        Me.GroupBox3.Controls.Add(Me.TXTCIN)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(856, 49)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        '
        'txtLibRegl
        '
        Me.txtLibRegl.Location = New System.Drawing.Point(194, 18)
        Me.txtLibRegl.Name = "txtLibRegl"
        Me.txtLibRegl.Size = New System.Drawing.Size(135, 20)
        Me.txtLibRegl.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(569, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nom client :"
        '
        'lblLibRegl
        '
        Me.lblLibRegl.AutoSize = True
        Me.lblLibRegl.Location = New System.Drawing.Point(77, 22)
        Me.lblLibRegl.Name = "lblLibRegl"
        Me.lblLibRegl.Size = New System.Drawing.Size(111, 13)
        Me.lblLibRegl.TabIndex = 0
        Me.lblLibRegl.Text = "Libellé reglement :"
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Location = New System.Drawing.Point(351, 22)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(61, 13)
        Me.lblPrenom.TabIndex = 2
        Me.lblPrenom.Text = "Prenom : "
        '
        'TXTCIN
        '
        Me.TXTCIN.Location = New System.Drawing.Point(418, 19)
        Me.TXTCIN.Name = "TXTCIN"
        Me.TXTCIN.Size = New System.Drawing.Size(135, 20)
        Me.TXTCIN.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(664, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(135, 20)
        Me.TextBox2.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(6, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Critéres de recherche :"
        '
        'lblVente
        '
        Me.lblVente.AutoSize = True
        Me.lblVente.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVente.ForeColor = System.Drawing.Color.Black
        Me.lblVente.Location = New System.Drawing.Point(344, 84)
        Me.lblVente.Name = "lblVente"
        Me.lblVente.Size = New System.Drawing.Size(369, 36)
        Me.lblVente.TabIndex = 1
        Me.lblVente.Text = "Configuration des ventes"
        '
        'FrmListeVente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1097, 676)
        Me.Controls.Add(Me.lblVente)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListeVente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FBA"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgtickets.ResumeLayout(False)
        Me.tpgtickets.PerformLayout()
        Me.Grbrecherche.ResumeLayout(False)
        Me.Grbrecherche.PerformLayout()
        CType(Me.dgvtickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgfacture.ResumeLayout(False)
        Me.tpgfacture.PerformLayout()
        Me.grbRechFact.ResumeLayout(False)
        Me.grbRechFact.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvFacture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgcmdclient.ResumeLayout(False)
        CType(Me.DgvCommande, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tpgRéglement.ResumeLayout(False)
        Me.tpgRéglement.PerformLayout()
        CType(Me.dgvModeReglement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpgtickets As System.Windows.Forms.TabPage
    Friend WithEvents tpgfacture As System.Windows.Forms.TabPage
    Friend WithEvents lblVente As System.Windows.Forms.Label
    Friend WithEvents txtMontantreçu As System.Windows.Forms.TextBox
    Friend WithEvents txttypetick As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMontantReçu As System.Windows.Forms.Label
    Friend WithEvents lblTypeticket As System.Windows.Forms.Label
    Friend WithEvents lbldatecreationtick As System.Windows.Forms.Label
    Friend WithEvents tpgcmdclient As System.Windows.Forms.TabPage
    Friend WithEvents tpgRéglement As System.Windows.Forms.TabPage
    Friend WithEvents dgvtickets As System.Windows.Forms.DataGridView
    Friend WithEvents lblEtatfact As System.Windows.Forms.Label
    Friend WithEvents dgvFacture As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Grbrecherche As System.Windows.Forms.GroupBox
    Friend WithEvents RdbNonValide As System.Windows.Forms.RadioButton
    Friend WithEvents RdbValide As System.Windows.Forms.RadioButton
    Friend WithEvents grbRechFact As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblnomclient As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblRefCom As System.Windows.Forms.Label
    Friend WithEvents txtrefcom As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNomclient As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLibRegl As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblLibRegl As System.Windows.Forms.Label
    Friend WithEvents lblPrenom As System.Windows.Forms.Label
    Friend WithEvents TXTCIN As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents dgvModeReglement As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MDRGIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MDRGLIBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MDRGCOMMANTAUREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DgvCommande As System.Windows.Forms.DataGridView
End Class
