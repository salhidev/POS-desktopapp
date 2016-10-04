<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacture
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacture))
        Me.txtEtat = New System.Windows.Forms.TextBox()
        Me.dtpFact = New System.Windows.Forms.DateTimePicker()
        Me.lblEtat = New System.Windows.Forms.Label()
        Me.lblDatecreation = New System.Windows.Forms.Label()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnAjouterCaisse = New System.Windows.Forms.Button()
        Me.BtnSupprimerCaisse = New System.Windows.Forms.Button()
        Me.BtnModifierCaisse = New System.Windows.Forms.Button()
        Me.cmbCommand = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEtat
        '
        Me.txtEtat.Location = New System.Drawing.Point(168, 123)
        Me.txtEtat.Name = "txtEtat"
        Me.txtEtat.Size = New System.Drawing.Size(150, 20)
        Me.txtEtat.TabIndex = 12
        '
        'dtpFact
        '
        Me.dtpFact.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFact.Location = New System.Drawing.Point(168, 82)
        Me.dtpFact.Name = "dtpFact"
        Me.dtpFact.Size = New System.Drawing.Size(150, 20)
        Me.dtpFact.TabIndex = 11
        '
        'lblEtat
        '
        Me.lblEtat.AutoSize = True
        Me.lblEtat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtat.Location = New System.Drawing.Point(81, 126)
        Me.lblEtat.Name = "lblEtat"
        Me.lblEtat.Size = New System.Drawing.Size(42, 13)
        Me.lblEtat.TabIndex = 9
        Me.lblEtat.Text = "Etat : "
        '
        'lblDatecreation
        '
        Me.lblDatecreation.AutoSize = True
        Me.lblDatecreation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatecreation.Location = New System.Drawing.Point(27, 85)
        Me.lblDatecreation.Name = "lblDatecreation"
        Me.lblDatecreation.Size = New System.Drawing.Size(96, 13)
        Me.lblDatecreation.TabIndex = 8
        Me.lblDatecreation.Text = "Date creation : "
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(67, 9)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(266, 25)
        Me.lblTitre.TabIndex = 7
        Me.lblTitre.Text = "Mise à jour des factures"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnAjouterCaisse)
        Me.GroupBox3.Controls.Add(Me.BtnSupprimerCaisse)
        Me.GroupBox3.Controls.Add(Me.BtnModifierCaisse)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 223)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(428, 68)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gestion :"
        '
        'BtnAjouterCaisse
        '
        Me.BtnAjouterCaisse.BackColor = System.Drawing.Color.Silver
        Me.BtnAjouterCaisse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAjouterCaisse.Image = CType(resources.GetObject("BtnAjouterCaisse.Image"), System.Drawing.Image)
        Me.BtnAjouterCaisse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAjouterCaisse.Location = New System.Drawing.Point(20, 19)
        Me.BtnAjouterCaisse.Name = "BtnAjouterCaisse"
        Me.BtnAjouterCaisse.Size = New System.Drawing.Size(115, 32)
        Me.BtnAjouterCaisse.TabIndex = 4
        Me.BtnAjouterCaisse.Text = "Valider"
        Me.BtnAjouterCaisse.UseVisualStyleBackColor = False
        '
        'BtnSupprimerCaisse
        '
        Me.BtnSupprimerCaisse.BackColor = System.Drawing.Color.Silver
        Me.BtnSupprimerCaisse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSupprimerCaisse.Image = Global.Caisse.My.Resources.Resources.Log_Out2
        Me.BtnSupprimerCaisse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSupprimerCaisse.Location = New System.Drawing.Point(287, 19)
        Me.BtnSupprimerCaisse.Name = "BtnSupprimerCaisse"
        Me.BtnSupprimerCaisse.Size = New System.Drawing.Size(135, 32)
        Me.BtnSupprimerCaisse.TabIndex = 3
        Me.BtnSupprimerCaisse.Text = "Fermer"
        Me.BtnSupprimerCaisse.UseVisualStyleBackColor = False
        '
        'BtnModifierCaisse
        '
        Me.BtnModifierCaisse.BackColor = System.Drawing.Color.Silver
        Me.BtnModifierCaisse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModifierCaisse.Image = Global.Caisse.My.Resources.Resources.btModifier221
        Me.BtnModifierCaisse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModifierCaisse.Location = New System.Drawing.Point(153, 19)
        Me.BtnModifierCaisse.Name = "BtnModifierCaisse"
        Me.BtnModifierCaisse.Size = New System.Drawing.Size(115, 32)
        Me.BtnModifierCaisse.TabIndex = 2
        Me.BtnModifierCaisse.Text = "Vider"
        Me.BtnModifierCaisse.UseVisualStyleBackColor = False
        '
        'cmbCommand
        '
        Me.cmbCommand.FormattingEnabled = True
        Me.cmbCommand.Location = New System.Drawing.Point(168, 173)
        Me.cmbCommand.Name = "cmbCommand"
        Me.cmbCommand.Size = New System.Drawing.Size(150, 21)
        Me.cmbCommand.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Commande : "
        '
        'FrmFacture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(481, 311)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCommand)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtEtat)
        Me.Controls.Add(Me.dtpFact)
        Me.Controls.Add(Me.lblEtat)
        Me.Controls.Add(Me.lblDatecreation)
        Me.Controls.Add(Me.lblTitre)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFacture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FBA"
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEtat As System.Windows.Forms.TextBox
    Friend WithEvents dtpFact As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEtat As System.Windows.Forms.Label
    Friend WithEvents lblDatecreation As System.Windows.Forms.Label
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAjouterCaisse As System.Windows.Forms.Button
    Friend WithEvents BtnSupprimerCaisse As System.Windows.Forms.Button
    Friend WithEvents BtnModifierCaisse As System.Windows.Forms.Button
    Friend WithEvents cmbCommand As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
