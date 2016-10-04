<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCommande
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCommande))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMontGlob = New System.Windows.Forms.TextBox()
        Me.txtNomCaissier = New System.Windows.Forms.TextBox()
        Me.txtNomClient = New System.Windows.Forms.TextBox()
        Me.GrbRemis = New System.Windows.Forms.GroupBox()
        Me.rdbRemis = New System.Windows.Forms.RadioButton()
        Me.rdbNonRemis = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblNomCaissier = New System.Windows.Forms.Label()
        Me.lblMontantGlob = New System.Windows.Forms.Label()
        Me.lblComRemis = New System.Windows.Forms.Label()
        Me.lblDateCreaCom = New System.Windows.Forms.Label()
        Me.lblomclient = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GrbRemis.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(356, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(511, 223)
        Me.DataGridView1.TabIndex = 12
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(374, 9)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(313, 36)
        Me.lblTitre.TabIndex = 13
        Me.lblTitre.Text = "Mise à jour commande"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.Button7)
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Controls.Add(Me.Button6)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox5.Location = New System.Drawing.Point(380, 310)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(440, 64)
        Me.GroupBox5.TabIndex = 212
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Gestion :"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Silver
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Image = Global.Caisse.My.Resources.Resources.btAjouter32
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(15, 19)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(132, 39)
        Me.Button7.TabIndex = 27
        Me.Button7.Text = "    &Enregistrer"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button5.BackColor = System.Drawing.Color.Silver
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Image = Global.Caisse.My.Resources.Resources.Supprimer
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(294, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(132, 39)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Supprimer"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button6.BackColor = System.Drawing.Color.Silver
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Image = Global.Caisse.My.Resources.Resources.btModifier222
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(151, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(132, 39)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "Modifier"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMontGlob)
        Me.GroupBox1.Controls.Add(Me.txtNomCaissier)
        Me.GroupBox1.Controls.Add(Me.txtNomClient)
        Me.GroupBox1.Controls.Add(Me.GrbRemis)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.lblNomCaissier)
        Me.GroupBox1.Controls.Add(Me.lblMontantGlob)
        Me.GroupBox1.Controls.Add(Me.lblComRemis)
        Me.GroupBox1.Controls.Add(Me.lblDateCreaCom)
        Me.GroupBox1.Controls.Add(Me.lblomclient)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 327)
        Me.GroupBox1.TabIndex = 214
        Me.GroupBox1.TabStop = False
        '
        'txtMontGlob
        '
        Me.txtMontGlob.Location = New System.Drawing.Point(151, 252)
        Me.txtMontGlob.Name = "txtMontGlob"
        Me.txtMontGlob.Size = New System.Drawing.Size(143, 20)
        Me.txtMontGlob.TabIndex = 21
        '
        'txtNomCaissier
        '
        Me.txtNomCaissier.Location = New System.Drawing.Point(151, 101)
        Me.txtNomCaissier.Name = "txtNomCaissier"
        Me.txtNomCaissier.Size = New System.Drawing.Size(143, 20)
        Me.txtNomCaissier.TabIndex = 20
        '
        'txtNomClient
        '
        Me.txtNomClient.Location = New System.Drawing.Point(151, 52)
        Me.txtNomClient.Name = "txtNomClient"
        Me.txtNomClient.Size = New System.Drawing.Size(143, 20)
        Me.txtNomClient.TabIndex = 19
        '
        'GrbRemis
        '
        Me.GrbRemis.Controls.Add(Me.rdbRemis)
        Me.GrbRemis.Controls.Add(Me.rdbNonRemis)
        Me.GrbRemis.Location = New System.Drawing.Point(147, 194)
        Me.GrbRemis.Name = "GrbRemis"
        Me.GrbRemis.Size = New System.Drawing.Size(160, 37)
        Me.GrbRemis.TabIndex = 18
        Me.GrbRemis.TabStop = False
        '
        'rdbRemis
        '
        Me.rdbRemis.AutoSize = True
        Me.rdbRemis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbRemis.Location = New System.Drawing.Point(5, 13)
        Me.rdbRemis.Name = "rdbRemis"
        Me.rdbRemis.Size = New System.Drawing.Size(59, 17)
        Me.rdbRemis.TabIndex = 6
        Me.rdbRemis.TabStop = True
        Me.rdbRemis.Text = "Remis"
        Me.rdbRemis.UseVisualStyleBackColor = True
        '
        'rdbNonRemis
        '
        Me.rdbNonRemis.AutoSize = True
        Me.rdbNonRemis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbNonRemis.Location = New System.Drawing.Point(76, 13)
        Me.rdbNonRemis.Name = "rdbNonRemis"
        Me.rdbNonRemis.Size = New System.Drawing.Size(81, 17)
        Me.rdbNonRemis.TabIndex = 7
        Me.rdbNonRemis.TabStop = True
        Me.rdbNonRemis.Text = "Non remis"
        Me.rdbNonRemis.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(151, 151)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(143, 20)
        Me.DateTimePicker1.TabIndex = 17
        '
        'lblNomCaissier
        '
        Me.lblNomCaissier.AutoSize = True
        Me.lblNomCaissier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomCaissier.Location = New System.Drawing.Point(18, 104)
        Me.lblNomCaissier.Name = "lblNomCaissier"
        Me.lblNomCaissier.Size = New System.Drawing.Size(113, 16)
        Me.lblNomCaissier.TabIndex = 16
        Me.lblNomCaissier.Text = "Nom Caissier : "
        '
        'lblMontantGlob
        '
        Me.lblMontantGlob.AutoSize = True
        Me.lblMontantGlob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontantGlob.Location = New System.Drawing.Point(18, 255)
        Me.lblMontantGlob.Name = "lblMontantGlob"
        Me.lblMontantGlob.Size = New System.Drawing.Size(131, 16)
        Me.lblMontantGlob.TabIndex = 15
        Me.lblMontantGlob.Text = "Montant globale : "
        '
        'lblComRemis
        '
        Me.lblComRemis.AutoSize = True
        Me.lblComRemis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComRemis.Location = New System.Drawing.Point(6, 207)
        Me.lblComRemis.Name = "lblComRemis"
        Me.lblComRemis.Size = New System.Drawing.Size(146, 16)
        Me.lblComRemis.TabIndex = 14
        Me.lblComRemis.Text = "Commande Remis : "
        '
        'lblDateCreaCom
        '
        Me.lblDateCreaCom.AutoSize = True
        Me.lblDateCreaCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateCreaCom.Location = New System.Drawing.Point(18, 151)
        Me.lblDateCreaCom.Name = "lblDateCreaCom"
        Me.lblDateCreaCom.Size = New System.Drawing.Size(115, 16)
        Me.lblDateCreaCom.TabIndex = 13
        Me.lblDateCreaCom.Text = "Date Creation : "
        '
        'lblomclient
        '
        Me.lblomclient.AutoSize = True
        Me.lblomclient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblomclient.Location = New System.Drawing.Point(18, 52)
        Me.lblomclient.Name = "lblomclient"
        Me.lblomclient.Size = New System.Drawing.Size(91, 16)
        Me.lblomclient.TabIndex = 12
        Me.lblomclient.Text = "Nom Client :"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Silver
        Me.Button4.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = Global.Caisse.My.Resources.Resources.Down
        Me.Button4.Location = New System.Drawing.Point(886, 226)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(53, 63)
        Me.Button4.TabIndex = 216
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Silver
        Me.Button9.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Image = Global.Caisse.My.Resources.Resources.Up
        Me.Button9.Location = New System.Drawing.Point(886, 66)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(53, 63)
        Me.Button9.TabIndex = 215
        Me.Button9.UseVisualStyleBackColor = False
        '
        'FrmCommande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(951, 408)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCommande"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FBA"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrbRemis.ResumeLayout(False)
        Me.GrbRemis.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMontGlob As System.Windows.Forms.TextBox
    Friend WithEvents txtNomCaissier As System.Windows.Forms.TextBox
    Friend WithEvents txtNomClient As System.Windows.Forms.TextBox
    Friend WithEvents GrbRemis As System.Windows.Forms.GroupBox
    Friend WithEvents rdbRemis As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNonRemis As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNomCaissier As System.Windows.Forms.Label
    Friend WithEvents lblMontantGlob As System.Windows.Forms.Label
    Friend WithEvents lblComRemis As System.Windows.Forms.Label
    Friend WithEvents lblDateCreaCom As System.Windows.Forms.Label
    Friend WithEvents lblomclient As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
