<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTarif
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTarif))
        Me.GBXMarque = New System.Windows.Forms.GroupBox()
        Me.txtTrf_Coefficient = New System.Windows.Forms.TextBox()
        Me.lbltrf_Coefficient = New System.Windows.Forms.Label()
        Me.txtTRF_Libelle = New System.Windows.Forms.TextBox()
        Me.lbllibellé = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnVider = New System.Windows.Forms.Button()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.LblTarif = New System.Windows.Forms.Label()
        Me.GBXMarque.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBXMarque
        '
        Me.GBXMarque.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GBXMarque.Controls.Add(Me.txtTrf_Coefficient)
        Me.GBXMarque.Controls.Add(Me.lbltrf_Coefficient)
        Me.GBXMarque.Controls.Add(Me.txtTRF_Libelle)
        Me.GBXMarque.Controls.Add(Me.lbllibellé)
        Me.GBXMarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBXMarque.ForeColor = System.Drawing.Color.Purple
        Me.GBXMarque.Location = New System.Drawing.Point(6, 22)
        Me.GBXMarque.Name = "GBXMarque"
        Me.GBXMarque.Size = New System.Drawing.Size(517, 99)
        Me.GBXMarque.TabIndex = 197
        Me.GBXMarque.TabStop = False
        Me.GBXMarque.Text = "Tarif"
        '
        'txtTrf_Coefficient
        '
        Me.txtTrf_Coefficient.BackColor = System.Drawing.SystemColors.Window
        Me.txtTrf_Coefficient.Location = New System.Drawing.Point(213, 58)
        Me.txtTrf_Coefficient.Name = "txtTrf_Coefficient"
        Me.txtTrf_Coefficient.Size = New System.Drawing.Size(166, 20)
        Me.txtTrf_Coefficient.TabIndex = 4
        '
        'lbltrf_Coefficient
        '
        Me.lbltrf_Coefficient.AutoSize = True
        Me.lbltrf_Coefficient.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltrf_Coefficient.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbltrf_Coefficient.Location = New System.Drawing.Point(119, 61)
        Me.lbltrf_Coefficient.Name = "lbltrf_Coefficient"
        Me.lbltrf_Coefficient.Size = New System.Drawing.Size(84, 13)
        Me.lbltrf_Coefficient.TabIndex = 3
        Me.lbltrf_Coefficient.Text = "&Coefficient   :"
        '
        'txtTRF_Libelle
        '
        Me.txtTRF_Libelle.BackColor = System.Drawing.SystemColors.Window
        Me.txtTRF_Libelle.Location = New System.Drawing.Point(213, 29)
        Me.txtTRF_Libelle.Name = "txtTRF_Libelle"
        Me.txtTRF_Libelle.Size = New System.Drawing.Size(166, 20)
        Me.txtTRF_Libelle.TabIndex = 0
        '
        'lbllibellé
        '
        Me.lbllibellé.AutoSize = True
        Me.lbllibellé.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllibellé.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbllibellé.Location = New System.Drawing.Point(119, 29)
        Me.lbllibellé.Name = "lbllibellé"
        Me.lbllibellé.Size = New System.Drawing.Size(84, 13)
        Me.lbllibellé.TabIndex = 0
        Me.lbllibellé.Text = "&Libellé         :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.BtnVider)
        Me.GroupBox1.Controls.Add(Me.BtnAnnuler)
        Me.GroupBox1.Controls.Add(Me.btnEnregistrer)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox1.Location = New System.Drawing.Point(6, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 79)
        Me.GroupBox1.TabIndex = 202
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestion :"
        '
        'BtnVider
        '
        Me.BtnVider.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnVider.BackColor = System.Drawing.Color.Silver
        Me.BtnVider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVider.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BtnVider.Image = Global.Caisse.My.Resources.Resources.btRetour32
        Me.BtnVider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVider.Location = New System.Drawing.Point(197, 19)
        Me.BtnVider.Name = "BtnVider"
        Me.BtnVider.Size = New System.Drawing.Size(133, 48)
        Me.BtnVider.TabIndex = 16
        Me.BtnVider.Text = "&Vider"
        Me.BtnVider.UseVisualStyleBackColor = False
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAnnuler.BackColor = System.Drawing.Color.Silver
        Me.BtnAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnnuler.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BtnAnnuler.Image = Global.Caisse.My.Resources.Resources.btFermer321
        Me.BtnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnnuler.Location = New System.Drawing.Point(344, 19)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(133, 48)
        Me.BtnAnnuler.TabIndex = 15
        Me.BtnAnnuler.Text = "&Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = False
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.BackColor = System.Drawing.Color.Silver
        Me.btnEnregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnregistrer.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnEnregistrer.Image = Global.Caisse.My.Resources.Resources.btEnregistrer324
        Me.btnEnregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnregistrer.Location = New System.Drawing.Point(42, 19)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(133, 48)
        Me.btnEnregistrer.TabIndex = 13
        Me.btnEnregistrer.Text = "    &Valider"
        Me.btnEnregistrer.UseVisualStyleBackColor = False
        '
        'LblTarif
        '
        Me.LblTarif.AutoSize = True
        Me.LblTarif.ForeColor = System.Drawing.Color.Black
        Me.LblTarif.Location = New System.Drawing.Point(230, 9)
        Me.LblTarif.Name = "LblTarif"
        Me.LblTarif.Size = New System.Drawing.Size(33, 13)
        Me.LblTarif.TabIndex = 203
        Me.LblTarif.Text = "Tarif"
        '
        'FrmTarif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(535, 254)
        Me.Controls.Add(Me.LblTarif)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBXMarque)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTarif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FBA"
        Me.GBXMarque.ResumeLayout(False)
        Me.GBXMarque.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBXMarque As System.Windows.Forms.GroupBox
    Friend WithEvents txtTRF_Libelle As System.Windows.Forms.TextBox
    Friend WithEvents lbllibellé As System.Windows.Forms.Label
    Friend WithEvents txtTrf_Coefficient As System.Windows.Forms.TextBox
    Friend WithEvents lbltrf_Coefficient As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents BtnAnnuler As System.Windows.Forms.Button
    Friend WithEvents LblTarif As System.Windows.Forms.Label
    Friend WithEvents BtnVider As System.Windows.Forms.Button
End Class
