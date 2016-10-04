<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSousFamille
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSousFamille))
        Me.GBXSousFamille = New System.Windows.Forms.GroupBox()
        Me.CmbFML_ID = New System.Windows.Forms.ComboBox()
        Me.lblFML_id = New System.Windows.Forms.Label()
        Me.txtSF_LIB = New System.Windows.Forms.TextBox()
        Me.lbllibellé = New System.Windows.Forms.Label()
        Me.btnVider = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblSousFamille = New System.Windows.Forms.Label()
        Me.GBXSousFamille.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBXSousFamille
        '
        Me.GBXSousFamille.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GBXSousFamille.Controls.Add(Me.CmbFML_ID)
        Me.GBXSousFamille.Controls.Add(Me.lblFML_id)
        Me.GBXSousFamille.Controls.Add(Me.txtSF_LIB)
        Me.GBXSousFamille.Controls.Add(Me.lbllibellé)
        Me.GBXSousFamille.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBXSousFamille.ForeColor = System.Drawing.Color.Purple
        Me.GBXSousFamille.Location = New System.Drawing.Point(12, 48)
        Me.GBXSousFamille.Name = "GBXSousFamille"
        Me.GBXSousFamille.Size = New System.Drawing.Size(511, 109)
        Me.GBXSousFamille.TabIndex = 9
        Me.GBXSousFamille.TabStop = False
        Me.GBXSousFamille.Text = "SousFamille"
        '
        'CmbFML_ID
        '
        Me.CmbFML_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFML_ID.FormattingEnabled = True
        Me.CmbFML_ID.Location = New System.Drawing.Point(169, 30)
        Me.CmbFML_ID.Name = "CmbFML_ID"
        Me.CmbFML_ID.Size = New System.Drawing.Size(166, 21)
        Me.CmbFML_ID.TabIndex = 198
        '
        'lblFML_id
        '
        Me.lblFML_id.AutoSize = True
        Me.lblFML_id.BackColor = System.Drawing.Color.Transparent
        Me.lblFML_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFML_id.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFML_id.Location = New System.Drawing.Point(51, 34)
        Me.lblFML_id.Name = "lblFML_id"
        Me.lblFML_id.Size = New System.Drawing.Size(46, 13)
        Me.lblFML_id.TabIndex = 1
        Me.lblFML_id.Text = "Famille"
        '
        'txtSF_LIB
        '
        Me.txtSF_LIB.BackColor = System.Drawing.SystemColors.Window
        Me.txtSF_LIB.Location = New System.Drawing.Point(169, 57)
        Me.txtSF_LIB.Name = "txtSF_LIB"
        Me.txtSF_LIB.Size = New System.Drawing.Size(166, 20)
        Me.txtSF_LIB.TabIndex = 0
        '
        'lbllibellé
        '
        Me.lbllibellé.AutoSize = True
        Me.lbllibellé.BackColor = System.Drawing.Color.Transparent
        Me.lbllibellé.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllibellé.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbllibellé.Location = New System.Drawing.Point(51, 57)
        Me.lbllibellé.Name = "lbllibellé"
        Me.lbllibellé.Size = New System.Drawing.Size(44, 13)
        Me.lbllibellé.TabIndex = 0
        Me.lbllibellé.Text = "Libellé"
        '
        'btnVider
        '
        Me.btnVider.BackColor = System.Drawing.Color.Silver
        Me.btnVider.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnVider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVider.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVider.Image = Global.Caisse.My.Resources.Resources.btRetour324
        Me.btnVider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVider.Location = New System.Drawing.Point(195, 19)
        Me.btnVider.Name = "btnVider"
        Me.btnVider.Size = New System.Drawing.Size(133, 48)
        Me.btnVider.TabIndex = 199
        Me.btnVider.Text = "    &Vider"
        Me.btnVider.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnVider)
        Me.GroupBox1.Controls.Add(Me.BtnAnnuler)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox1.Location = New System.Drawing.Point(9, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(514, 79)
        Me.GroupBox1.TabIndex = 200
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestion :"
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAnnuler.BackColor = System.Drawing.Color.Silver
        Me.BtnAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnnuler.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BtnAnnuler.Image = Global.Caisse.My.Resources.Resources.btFermer321
        Me.BtnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnnuler.Location = New System.Drawing.Point(348, 19)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(133, 48)
        Me.BtnAnnuler.TabIndex = 15
        Me.BtnAnnuler.Text = "&Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Image = Global.Caisse.My.Resources.Resources.btEnregistrer322
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(39, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 48)
        Me.Button1.TabIndex = 205
        Me.Button1.Text = "       &Valider"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LblSousFamille
        '
        Me.LblSousFamille.AutoSize = True
        Me.LblSousFamille.Location = New System.Drawing.Point(228, 12)
        Me.LblSousFamille.Name = "LblSousFamille"
        Me.LblSousFamille.Size = New System.Drawing.Size(82, 13)
        Me.LblSousFamille.TabIndex = 206
        Me.LblSousFamille.Text = "Sous  Famille"
        '
        'FrmSousFamille
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(535, 254)
        Me.Controls.Add(Me.LblSousFamille)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBXSousFamille)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSousFamille"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FBA"
        Me.GBXSousFamille.ResumeLayout(False)
        Me.GBXSousFamille.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBXSousFamille As System.Windows.Forms.GroupBox
    Friend WithEvents txtSF_LIB As System.Windows.Forms.TextBox
    Friend WithEvents lbllibellé As System.Windows.Forms.Label
    Friend WithEvents lblFML_id As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAnnuler As System.Windows.Forms.Button
    Friend WithEvents CmbFML_ID As System.Windows.Forms.ComboBox
    Friend WithEvents btnVider As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LblSousFamille As System.Windows.Forms.Label
End Class
