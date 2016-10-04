<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMarque))
        Me.GBXMarque = New System.Windows.Forms.GroupBox()
        Me.CmbSF_id = New System.Windows.Forms.ComboBox()
        Me.txtMrq_Lib = New System.Windows.Forms.TextBox()
        Me.lblSF_id = New System.Windows.Forms.Label()
        Me.LblMrq_Lib = New System.Windows.Forms.Label()
        Me.btnVider = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.LblMarque = New System.Windows.Forms.Label()
        Me.GBXMarque.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBXMarque
        '
        Me.GBXMarque.Controls.Add(Me.CmbSF_id)
        Me.GBXMarque.Controls.Add(Me.txtMrq_Lib)
        Me.GBXMarque.Controls.Add(Me.lblSF_id)
        Me.GBXMarque.Controls.Add(Me.LblMrq_Lib)
        Me.GBXMarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBXMarque.ForeColor = System.Drawing.Color.Purple
        Me.GBXMarque.Location = New System.Drawing.Point(12, 38)
        Me.GBXMarque.Name = "GBXMarque"
        Me.GBXMarque.Size = New System.Drawing.Size(517, 106)
        Me.GBXMarque.TabIndex = 6
        Me.GBXMarque.TabStop = False
        Me.GBXMarque.Text = "Marque"
        '
        'CmbSF_id
        '
        Me.CmbSF_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSF_id.FormattingEnabled = True
        Me.CmbSF_id.Location = New System.Drawing.Point(212, 31)
        Me.CmbSF_id.Name = "CmbSF_id"
        Me.CmbSF_id.Size = New System.Drawing.Size(166, 21)
        Me.CmbSF_id.TabIndex = 203
        '
        'txtMrq_Lib
        '
        Me.txtMrq_Lib.BackColor = System.Drawing.SystemColors.Window
        Me.txtMrq_Lib.Location = New System.Drawing.Point(212, 67)
        Me.txtMrq_Lib.Name = "txtMrq_Lib"
        Me.txtMrq_Lib.Size = New System.Drawing.Size(165, 20)
        Me.txtMrq_Lib.TabIndex = 4
        '
        'lblSF_id
        '
        Me.lblSF_id.AutoSize = True
        Me.lblSF_id.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSF_id.Location = New System.Drawing.Point(106, 35)
        Me.lblSF_id.Name = "lblSF_id"
        Me.lblSF_id.Size = New System.Drawing.Size(78, 13)
        Me.lblSF_id.TabIndex = 3
        Me.lblSF_id.Text = "Sous Famille"
        '
        'LblMrq_Lib
        '
        Me.LblMrq_Lib.AutoSize = True
        Me.LblMrq_Lib.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblMrq_Lib.Location = New System.Drawing.Point(106, 74)
        Me.LblMrq_Lib.Name = "LblMrq_Lib"
        Me.LblMrq_Lib.Size = New System.Drawing.Size(44, 13)
        Me.LblMrq_Lib.TabIndex = 0
        Me.LblMrq_Lib.Text = "Libellé"
        '
        'btnVider
        '
        Me.btnVider.BackColor = System.Drawing.Color.Silver
        Me.btnVider.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnVider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVider.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVider.Image = Global.Caisse.My.Resources.Resources.btRetour324
        Me.btnVider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVider.Location = New System.Drawing.Point(190, 18)
        Me.btnVider.Name = "btnVider"
        Me.btnVider.Size = New System.Drawing.Size(133, 48)
        Me.btnVider.TabIndex = 202
        Me.btnVider.Text = "    &Vider"
        Me.btnVider.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnAnnuler)
        Me.GroupBox1.Controls.Add(Me.btnVider)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox1.Location = New System.Drawing.Point(12, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(517, 72)
        Me.GroupBox1.TabIndex = 200
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestion :"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Image = Global.Caisse.My.Resources.Resources.btEnregistrer322
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(31, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 48)
        Me.Button1.TabIndex = 205
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
        Me.BtnAnnuler.Location = New System.Drawing.Point(344, 17)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(133, 48)
        Me.BtnAnnuler.TabIndex = 201
        Me.BtnAnnuler.Text = "&Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = False
        '
        'LblMarque
        '
        Me.LblMarque.AutoSize = True
        Me.LblMarque.Location = New System.Drawing.Point(224, 13)
        Me.LblMarque.Name = "LblMarque"
        Me.LblMarque.Size = New System.Drawing.Size(43, 13)
        Me.LblMarque.TabIndex = 201
        Me.LblMarque.Text = "Marque"
        '
        'FrmMarque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(535, 252)
        Me.Controls.Add(Me.LblMarque)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBXMarque)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmMarque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FBA"
        Me.GBXMarque.ResumeLayout(False)
        Me.GBXMarque.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBXMarque As System.Windows.Forms.GroupBox
    Friend WithEvents LblMrq_Lib As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMrq_Lib As System.Windows.Forms.TextBox
    Friend WithEvents lblSF_id As System.Windows.Forms.Label
    Friend WithEvents btnVider As System.Windows.Forms.Button
    Friend WithEvents BtnAnnuler As System.Windows.Forms.Button
    Friend WithEvents CmbSF_id As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LblMarque As System.Windows.Forms.Label
End Class
