<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFamille
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFamille))
        Me.GBXFamille = New System.Windows.Forms.GroupBox()
        Me.CmbRay_ID = New System.Windows.Forms.ComboBox()
        Me.lblRay_id = New System.Windows.Forms.Label()
        Me.txtFml_Lib = New System.Windows.Forms.TextBox()
        Me.lbllibellé = New System.Windows.Forms.Label()
        Me.btnVider = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.lblFamille = New System.Windows.Forms.Label()
        Me.GBXFamille.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBXFamille
        '
        Me.GBXFamille.Controls.Add(Me.CmbRay_ID)
        Me.GBXFamille.Controls.Add(Me.lblRay_id)
        Me.GBXFamille.Controls.Add(Me.txtFml_Lib)
        Me.GBXFamille.Controls.Add(Me.lbllibellé)
        Me.GBXFamille.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBXFamille.ForeColor = System.Drawing.Color.Purple
        Me.GBXFamille.Location = New System.Drawing.Point(12, 37)
        Me.GBXFamille.Name = "GBXFamille"
        Me.GBXFamille.Size = New System.Drawing.Size(511, 109)
        Me.GBXFamille.TabIndex = 12
        Me.GBXFamille.TabStop = False
        Me.GBXFamille.Text = "Famille"
        '
        'CmbRay_ID
        '
        Me.CmbRay_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRay_ID.FormattingEnabled = True
        Me.CmbRay_ID.Location = New System.Drawing.Point(200, 29)
        Me.CmbRay_ID.Name = "CmbRay_ID"
        Me.CmbRay_ID.Size = New System.Drawing.Size(166, 21)
        Me.CmbRay_ID.TabIndex = 197
        '
        'lblRay_id
        '
        Me.lblRay_id.AutoSize = True
        Me.lblRay_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRay_id.ForeColor = System.Drawing.Color.Black
        Me.lblRay_id.Location = New System.Drawing.Point(106, 32)
        Me.lblRay_id.Name = "lblRay_id"
        Me.lblRay_id.Size = New System.Drawing.Size(43, 13)
        Me.lblRay_id.TabIndex = 1
        Me.lblRay_id.Text = "Rayon"
        '
        'txtFml_Lib
        '
        Me.txtFml_Lib.BackColor = System.Drawing.SystemColors.Window
        Me.txtFml_Lib.Location = New System.Drawing.Point(200, 67)
        Me.txtFml_Lib.Name = "txtFml_Lib"
        Me.txtFml_Lib.Size = New System.Drawing.Size(166, 20)
        Me.txtFml_Lib.TabIndex = 0
        '
        'lbllibellé
        '
        Me.lbllibellé.AutoSize = True
        Me.lbllibellé.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllibellé.ForeColor = System.Drawing.Color.Black
        Me.lbllibellé.Location = New System.Drawing.Point(106, 67)
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
        Me.btnVider.Location = New System.Drawing.Point(207, 19)
        Me.btnVider.Name = "btnVider"
        Me.btnVider.Size = New System.Drawing.Size(133, 48)
        Me.btnVider.TabIndex = 196
        Me.btnVider.Text = "    &Vider"
        Me.btnVider.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnAnnuler)
        Me.GroupBox1.Controls.Add(Me.btnVider)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox1.Location = New System.Drawing.Point(12, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 90)
        Me.GroupBox1.TabIndex = 202
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestion :"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Image = Global.Caisse.My.Resources.Resources.btEnregistrer323
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(68, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 48)
        Me.Button1.TabIndex = 204
        Me.Button1.Text = "       &Valider"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAnnuler.BackColor = System.Drawing.Color.Silver
        Me.BtnAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnnuler.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BtnAnnuler.Image = Global.Caisse.My.Resources.Resources.btFermer321
        Me.BtnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnnuler.Location = New System.Drawing.Point(346, 19)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(133, 48)
        Me.BtnAnnuler.TabIndex = 14
        Me.BtnAnnuler.Text = "&Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = False
        '
        'lblFamille
        '
        Me.lblFamille.AutoSize = True
        Me.lblFamille.ForeColor = System.Drawing.Color.Black
        Me.lblFamille.Location = New System.Drawing.Point(233, 17)
        Me.lblFamille.Name = "lblFamille"
        Me.lblFamille.Size = New System.Drawing.Size(46, 13)
        Me.lblFamille.TabIndex = 203
        Me.lblFamille.Text = "Famille"
        '
        'FrmFamille
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(535, 254)
        Me.Controls.Add(Me.lblFamille)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBXFamille)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFamille"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FBA"
        Me.GBXFamille.ResumeLayout(False)
        Me.GBXFamille.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBXFamille As System.Windows.Forms.GroupBox
    Friend WithEvents lblRay_id As System.Windows.Forms.Label
    Friend WithEvents txtFml_Lib As System.Windows.Forms.TextBox
    Friend WithEvents lbllibellé As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnVider As System.Windows.Forms.Button
    Friend WithEvents BtnAnnuler As System.Windows.Forms.Button
    Friend WithEvents CmbRay_ID As System.Windows.Forms.ComboBox
    Friend WithEvents lblFamille As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
