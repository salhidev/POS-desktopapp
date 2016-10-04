<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTicket))
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.DgvTicket = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMontRecu = New System.Windows.Forms.TextBox()
        Me.txtype = New System.Windows.Forms.TextBox()
        Me.dtptick = New System.Windows.Forms.DateTimePicker()
        Me.lblMontantreçu = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblDatecreation = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.BtnModifier_a = New System.Windows.Forms.Button()
        Me.BtnSupprimer_a = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCommand = New System.Windows.Forms.ComboBox()
        CType(Me.DgvTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(236, 22)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(305, 31)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Mise à jour des tickets"
        '
        'DgvTicket
        '
        Me.DgvTicket.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTicket.Location = New System.Drawing.Point(310, 85)
        Me.DgvTicket.Name = "DgvTicket"
        Me.DgvTicket.Size = New System.Drawing.Size(373, 146)
        Me.DgvTicket.TabIndex = 17
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = Global.Caisse.My.Resources.Resources.Down
        Me.Button3.Location = New System.Drawing.Point(695, 154)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 63)
        Me.Button3.TabIndex = 213
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button9.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Image = Global.Caisse.My.Resources.Resources.Up
        Me.Button9.Location = New System.Drawing.Point(695, 85)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(53, 63)
        Me.Button9.TabIndex = 212
        Me.Button9.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbCommand)
        Me.GroupBox2.Controls.Add(Me.txtMontRecu)
        Me.GroupBox2.Controls.Add(Me.txtype)
        Me.GroupBox2.Controls.Add(Me.dtptick)
        Me.GroupBox2.Controls.Add(Me.lblMontantreçu)
        Me.GroupBox2.Controls.Add(Me.lblType)
        Me.GroupBox2.Controls.Add(Me.lblDatecreation)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(279, 220)
        Me.GroupBox2.TabIndex = 214
        Me.GroupBox2.TabStop = False
        '
        'txtMontRecu
        '
        Me.txtMontRecu.Location = New System.Drawing.Point(118, 113)
        Me.txtMontRecu.Name = "txtMontRecu"
        Me.txtMontRecu.Size = New System.Drawing.Size(146, 20)
        Me.txtMontRecu.TabIndex = 12
        '
        'txtype
        '
        Me.txtype.Location = New System.Drawing.Point(118, 72)
        Me.txtype.Name = "txtype"
        Me.txtype.Size = New System.Drawing.Size(146, 20)
        Me.txtype.TabIndex = 11
        '
        'dtptick
        '
        Me.dtptick.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtptick.Location = New System.Drawing.Point(118, 24)
        Me.dtptick.Name = "dtptick"
        Me.dtptick.Size = New System.Drawing.Size(146, 20)
        Me.dtptick.TabIndex = 10
        '
        'lblMontantreçu
        '
        Me.lblMontantreçu.AutoSize = True
        Me.lblMontantreçu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontantreçu.Location = New System.Drawing.Point(4, 116)
        Me.lblMontantreçu.Name = "lblMontantreçu"
        Me.lblMontantreçu.Size = New System.Drawing.Size(94, 13)
        Me.lblMontantreçu.TabIndex = 9
        Me.lblMontantreçu.Text = "Montant reçu : "
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(4, 72)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(47, 13)
        Me.lblType.TabIndex = 8
        Me.lblType.Text = "Type : "
        '
        'lblDatecreation
        '
        Me.lblDatecreation.AutoSize = True
        Me.lblDatecreation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatecreation.Location = New System.Drawing.Point(4, 24)
        Me.lblDatecreation.Name = "lblDatecreation"
        Me.lblDatecreation.Size = New System.Drawing.Size(96, 13)
        Me.lblDatecreation.TabIndex = 7
        Me.lblDatecreation.Text = "Date creation : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.btnEnregistrer)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.BtnModifier_a)
        Me.GroupBox1.Controls.Add(Me.BtnSupprimer_a)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox1.Location = New System.Drawing.Point(316, 238)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 71)
        Me.GroupBox1.TabIndex = 215
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestion :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Button10)
        Me.GroupBox4.Controls.Add(Me.Button11)
        Me.GroupBox4.Controls.Add(Me.Button12)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(373, 71)
        Me.GroupBox4.TabIndex = 215
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Gestion :"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.Black
        Me.Button10.Image = Global.Caisse.My.Resources.Resources.btAjouter32
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(11, 19)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(107, 37)
        Me.Button10.TabIndex = 30
        Me.Button10.Text = "    &Enregistrer"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Black
        Me.Button11.Image = Global.Caisse.My.Resources.Resources.btModifier222
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.Location = New System.Drawing.Point(139, 19)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(102, 37)
        Me.Button11.TabIndex = 31
        Me.Button11.Text = "Modifier"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.Black
        Me.Button12.Image = Global.Caisse.My.Resources.Resources.Supprimer
        Me.Button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.Location = New System.Drawing.Point(265, 19)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(93, 37)
        Me.Button12.TabIndex = 32
        Me.Button12.Text = "Supprimer"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button12.UseVisualStyleBackColor = False
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnregistrer.ForeColor = System.Drawing.Color.Black
        Me.btnEnregistrer.Image = Global.Caisse.My.Resources.Resources.btAjouter32
        Me.btnEnregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnregistrer.Location = New System.Drawing.Point(11, 19)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(107, 37)
        Me.btnEnregistrer.TabIndex = 30
        Me.btnEnregistrer.Text = "    &Enregistrer"
        Me.btnEnregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnregistrer.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Image = Global.Caisse.My.Resources.Resources.Down
        Me.Button8.Location = New System.Drawing.Point(379, -84)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(53, 63)
        Me.Button8.TabIndex = 213
        Me.Button8.UseVisualStyleBackColor = False
        '
        'BtnModifier_a
        '
        Me.BtnModifier_a.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnModifier_a.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnModifier_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModifier_a.ForeColor = System.Drawing.Color.Black
        Me.BtnModifier_a.Image = Global.Caisse.My.Resources.Resources.btModifier222
        Me.BtnModifier_a.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModifier_a.Location = New System.Drawing.Point(139, 19)
        Me.BtnModifier_a.Name = "BtnModifier_a"
        Me.BtnModifier_a.Size = New System.Drawing.Size(102, 37)
        Me.BtnModifier_a.TabIndex = 31
        Me.BtnModifier_a.Text = "Modifier"
        Me.BtnModifier_a.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModifier_a.UseVisualStyleBackColor = False
        '
        'BtnSupprimer_a
        '
        Me.BtnSupprimer_a.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSupprimer_a.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSupprimer_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSupprimer_a.ForeColor = System.Drawing.Color.Black
        Me.BtnSupprimer_a.Image = Global.Caisse.My.Resources.Resources.Supprimer
        Me.BtnSupprimer_a.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSupprimer_a.Location = New System.Drawing.Point(265, 19)
        Me.BtnSupprimer_a.Name = "BtnSupprimer_a"
        Me.BtnSupprimer_a.Size = New System.Drawing.Size(93, 37)
        Me.BtnSupprimer_a.TabIndex = 32
        Me.BtnSupprimer_a.Text = "Supprimer"
        Me.BtnSupprimer_a.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSupprimer_a.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Image = Global.Caisse.My.Resources.Resources.Up
        Me.Button7.Location = New System.Drawing.Point(379, -153)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(53, 63)
        Me.Button7.TabIndex = 212
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.Caisse.My.Resources.Resources.Up
        Me.Button1.Location = New System.Drawing.Point(695, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 63)
        Me.Button1.TabIndex = 212
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.Caisse.My.Resources.Resources.Down
        Me.Button2.Location = New System.Drawing.Point(695, 154)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 63)
        Me.Button2.TabIndex = 213
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox3.Location = New System.Drawing.Point(316, 238)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(373, 71)
        Me.GroupBox3.TabIndex = 215
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gestion :"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Silver
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = Global.Caisse.My.Resources.Resources.btEnregistrer323
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(11, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 37)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "    &Valider"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button5.BackColor = System.Drawing.Color.Silver
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Image = Global.Caisse.My.Resources.Resources.btRetour323
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(139, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 37)
        Me.Button5.TabIndex = 31
        Me.Button5.Text = "Vider"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button6.BackColor = System.Drawing.Color.Silver
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Image = Global.Caisse.My.Resources.Resources.Log_Out2
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(265, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(93, 37)
        Me.Button6.TabIndex = 32
        Me.Button6.Text = "Fermer"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Commande : "
        '
        'cmbCommand
        '
        Me.cmbCommand.FormattingEnabled = True
        Me.cmbCommand.Location = New System.Drawing.Point(118, 161)
        Me.cmbCommand.Name = "cmbCommand"
        Me.cmbCommand.Size = New System.Drawing.Size(150, 21)
        Me.cmbCommand.TabIndex = 18
        '
        'FrmTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(753, 321)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.DgvTicket)
        Me.Controls.Add(Me.lblTitre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FBA"
        CType(Me.DgvTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents DgvTicket As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMontRecu As System.Windows.Forms.TextBox
    Friend WithEvents txtype As System.Windows.Forms.TextBox
    Friend WithEvents dtptick As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMontantreçu As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblDatecreation As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents BtnModifier_a As System.Windows.Forms.Button
    Friend WithEvents BtnSupprimer_a As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCommand As System.Windows.Forms.ComboBox
End Class
