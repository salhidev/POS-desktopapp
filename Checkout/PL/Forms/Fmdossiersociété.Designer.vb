<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmdossiersociété
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmdossiersociété))
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPaysfact = New System.Windows.Forms.TextBox()
        Me.txtLocalitéfact = New System.Windows.Forms.TextBox()
        Me.txtCPfact = New System.Windows.Forms.TextBox()
        Me.txtAdresseFact = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBanque2 = New System.Windows.Forms.TextBox()
        Me.txtbanque1 = New System.Windows.Forms.TextBox()
        Me.txttele = New System.Windows.Forms.TextBox()
        Me.txtGSM = New System.Windows.Forms.TextBox()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtRPM = New System.Windows.Forms.TextBox()
        Me.txtnumentreprise = New System.Windows.Forms.TextBox()
        Me.txtprenom = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtstatut = New System.Windows.Forms.TextBox()
        Me.txtsociété = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPaysLiv = New System.Windows.Forms.TextBox()
        Me.txtLocalitéLiv = New System.Windows.Forms.TextBox()
        Me.txtCPliv = New System.Windows.Forms.TextBox()
        Me.txtAdresseLiv = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 443)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(229, 15)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Introduisez les cordonnées de la société."
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(4, 24)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(214, 20)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Créer un nouveau dossier"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.btnValider)
        Me.GroupBox2.Controls.Add(Me.btnAnnuler)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(966, 373)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.txtPaysfact)
        Me.GroupBox5.Controls.Add(Me.txtLocalitéfact)
        Me.GroupBox5.Controls.Add(Me.txtCPfact)
        Me.GroupBox5.Controls.Add(Me.txtAdresseFact)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(16, 194)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(476, 114)
        Me.GroupBox5.TabIndex = 100
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Adresse Facturation"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(310, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Pays :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(169, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Localité :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "CP :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "Adresse :"
        '
        'txtPaysfact
        '
        Me.txtPaysfact.Location = New System.Drawing.Point(356, 69)
        Me.txtPaysfact.Name = "txtPaysfact"
        Me.txtPaysfact.Size = New System.Drawing.Size(69, 20)
        Me.txtPaysfact.TabIndex = 98
        '
        'txtLocalitéfact
        '
        Me.txtLocalitéfact.Location = New System.Drawing.Point(235, 69)
        Me.txtLocalitéfact.Name = "txtLocalitéfact"
        Me.txtLocalitéfact.Size = New System.Drawing.Size(69, 20)
        Me.txtLocalitéfact.TabIndex = 97
        '
        'txtCPfact
        '
        Me.txtCPfact.Location = New System.Drawing.Point(86, 69)
        Me.txtCPfact.Name = "txtCPfact"
        Me.txtCPfact.Size = New System.Drawing.Size(69, 20)
        Me.txtCPfact.TabIndex = 96
        '
        'txtAdresseFact
        '
        Me.txtAdresseFact.Location = New System.Drawing.Point(86, 31)
        Me.txtAdresseFact.Name = "txtAdresseFact"
        Me.txtAdresseFact.Size = New System.Drawing.Size(339, 20)
        Me.txtAdresseFact.TabIndex = 95
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.ComboBox1)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtBanque2)
        Me.GroupBox4.Controls.Add(Me.txtbanque1)
        Me.GroupBox4.Controls.Add(Me.txttele)
        Me.GroupBox4.Controls.Add(Me.txtGSM)
        Me.GroupBox4.Controls.Add(Me.txtFax)
        Me.GroupBox4.Controls.Add(Me.txtRPM)
        Me.GroupBox4.Controls.Add(Me.txtnumentreprise)
        Me.GroupBox4.Controls.Add(Me.txtprenom)
        Me.GroupBox4.Controls.Add(Me.txtNom)
        Me.GroupBox4.Controls.Add(Me.txtstatut)
        Me.GroupBox4.Controls.Add(Me.txtsociété)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(16, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(927, 138)
        Me.GroupBox4.TabIndex = 99
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Info Société"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 13)
        Me.Label17.TabIndex = 119
        Me.Label17.Text = "Titre :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(752, 103)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 118
        Me.Label15.Text = "Banque2 :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(751, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 117
        Me.Label14.Text = "Banque1 :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(562, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 116
        Me.Label13.Text = "Téléphone :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(751, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 115
        Me.Label12.Text = " GSM :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(574, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 114
        Me.Label11.Text = "Fax :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(391, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "RPM :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "N° Entreprise : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(384, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "Prenom : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(219, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Nom : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(384, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Statut : "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(97, 55)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(111, 21)
        Me.ComboBox1.TabIndex = 108
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Société : "
        '
        'txtBanque2
        '
        Me.txtBanque2.Location = New System.Drawing.Point(827, 100)
        Me.txtBanque2.Name = "txtBanque2"
        Me.txtBanque2.Size = New System.Drawing.Size(87, 20)
        Me.txtBanque2.TabIndex = 106
        '
        'txtbanque1
        '
        Me.txtbanque1.Location = New System.Drawing.Point(827, 60)
        Me.txtbanque1.Name = "txtbanque1"
        Me.txtbanque1.Size = New System.Drawing.Size(87, 20)
        Me.txtbanque1.TabIndex = 105
        '
        'txttele
        '
        Me.txttele.Location = New System.Drawing.Point(643, 58)
        Me.txttele.Name = "txttele"
        Me.txttele.Size = New System.Drawing.Size(100, 20)
        Me.txttele.TabIndex = 104
        '
        'txtGSM
        '
        Me.txtGSM.Location = New System.Drawing.Point(814, 16)
        Me.txtGSM.Name = "txtGSM"
        Me.txtGSM.Size = New System.Drawing.Size(100, 20)
        Me.txtGSM.TabIndex = 103
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(643, 15)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(100, 20)
        Me.txtFax.TabIndex = 102
        '
        'txtRPM
        '
        Me.txtRPM.Location = New System.Drawing.Point(442, 100)
        Me.txtRPM.Name = "txtRPM"
        Me.txtRPM.Size = New System.Drawing.Size(100, 20)
        Me.txtRPM.TabIndex = 101
        '
        'txtnumentreprise
        '
        Me.txtnumentreprise.Location = New System.Drawing.Point(112, 100)
        Me.txtnumentreprise.Name = "txtnumentreprise"
        Me.txtnumentreprise.Size = New System.Drawing.Size(255, 20)
        Me.txtnumentreprise.TabIndex = 100
        '
        'txtprenom
        '
        Me.txtprenom.Location = New System.Drawing.Point(453, 58)
        Me.txtprenom.Name = "txtprenom"
        Me.txtprenom.Size = New System.Drawing.Size(89, 20)
        Me.txtprenom.TabIndex = 99
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(273, 55)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(94, 20)
        Me.txtNom.TabIndex = 98
        '
        'txtstatut
        '
        Me.txtstatut.Location = New System.Drawing.Point(442, 19)
        Me.txtstatut.Name = "txtstatut"
        Me.txtstatut.Size = New System.Drawing.Size(100, 20)
        Me.txtstatut.TabIndex = 97
        '
        'txtsociété
        '
        Me.txtsociété.Location = New System.Drawing.Point(97, 19)
        Me.txtsociété.Name = "txtsociété"
        Me.txtsociété.Size = New System.Drawing.Size(270, 20)
        Me.txtsociété.TabIndex = 96
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtPaysLiv)
        Me.GroupBox3.Controls.Add(Me.txtLocalitéLiv)
        Me.GroupBox3.Controls.Add(Me.txtCPliv)
        Me.GroupBox3.Controls.Add(Me.txtAdresseLiv)
        Me.GroupBox3.Controls.Add(Me.txtEmail)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(547, 201)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(396, 154)
        Me.GroupBox3.TabIndex = 98
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Adresse de Livraison"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(184, 126)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 13)
        Me.Label21.TabIndex = 103
        Me.Label21.Text = "Pays :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(16, 123)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 13)
        Me.Label20.TabIndex = 102
        Me.Label20.Text = "Localité :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(16, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 13)
        Me.Label19.TabIndex = 101
        Me.Label19.Text = "CP :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(16, 42)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 100
        Me.Label18.Text = "Adresse :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(179, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 99
        Me.Label16.Text = "E-mail :"
        '
        'txtPaysLiv
        '
        Me.txtPaysLiv.Location = New System.Drawing.Point(239, 123)
        Me.txtPaysLiv.Name = "txtPaysLiv"
        Me.txtPaysLiv.Size = New System.Drawing.Size(82, 20)
        Me.txtPaysLiv.TabIndex = 98
        '
        'txtLocalitéLiv
        '
        Me.txtLocalitéLiv.Location = New System.Drawing.Point(82, 123)
        Me.txtLocalitéLiv.Name = "txtLocalitéLiv"
        Me.txtLocalitéLiv.Size = New System.Drawing.Size(82, 20)
        Me.txtLocalitéLiv.TabIndex = 97
        '
        'txtCPliv
        '
        Me.txtCPliv.Location = New System.Drawing.Point(82, 80)
        Me.txtCPliv.Name = "txtCPliv"
        Me.txtCPliv.Size = New System.Drawing.Size(82, 20)
        Me.txtCPliv.TabIndex = 96
        '
        'txtAdresseLiv
        '
        Me.txtAdresseLiv.Location = New System.Drawing.Point(92, 39)
        Me.txtAdresseLiv.Name = "txtAdresseLiv"
        Me.txtAdresseLiv.Size = New System.Drawing.Size(288, 20)
        Me.txtAdresseLiv.TabIndex = 95
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(237, 77)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(143, 20)
        Me.txtEmail.TabIndex = 94
        '
        'btnValider
        '
        Me.btnValider.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValider.Image = Global.Caisse.My.Resources.Resources.btEnregistrer322
        Me.btnValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnValider.Location = New System.Drawing.Point(251, 314)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(110, 41)
        Me.btnValider.TabIndex = 97
        Me.btnValider.Text = "Valider"
        Me.btnValider.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnValider.UseVisualStyleBackColor = False
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnuler.Image = Global.Caisse.My.Resources.Resources.btRetour321
        Me.btnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnnuler.Location = New System.Drawing.Point(389, 314)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(107, 41)
        Me.btnAnnuler.TabIndex = 96
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'Frmdossiersociété
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(982, 467)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmdossiersociété"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FBA"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPaysfact As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalitéfact As System.Windows.Forms.TextBox
    Friend WithEvents txtCPfact As System.Windows.Forms.TextBox
    Friend WithEvents txtAdresseFact As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBanque2 As System.Windows.Forms.TextBox
    Friend WithEvents txtbanque1 As System.Windows.Forms.TextBox
    Friend WithEvents txttele As System.Windows.Forms.TextBox
    Friend WithEvents txtGSM As System.Windows.Forms.TextBox
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents txtRPM As System.Windows.Forms.TextBox
    Friend WithEvents txtnumentreprise As System.Windows.Forms.TextBox
    Friend WithEvents txtprenom As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtstatut As System.Windows.Forms.TextBox
    Friend WithEvents txtsociété As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtPaysLiv As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalitéLiv As System.Windows.Forms.TextBox
    Friend WithEvents txtCPliv As System.Windows.Forms.TextBox
    Friend WithEvents txtAdresseLiv As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
End Class
