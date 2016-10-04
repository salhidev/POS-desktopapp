<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOccupation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOccupation))
        Me.lblIdentification = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnNvCaissier = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblCaissier = New System.Windows.Forms.Label()
        Me.lblCaisse = New System.Windows.Forms.Label()
        Me.cmbCaissier = New System.Windows.Forms.ComboBox()
        Me.cmbCaisse = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblAnnuler = New System.Windows.Forms.Button()
        Me.btValider = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIdentification
        '
        Me.lblIdentification.AutoSize = True
        Me.lblIdentification.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentification.Location = New System.Drawing.Point(95, 9)
        Me.lblIdentification.Name = "lblIdentification"
        Me.lblIdentification.Size = New System.Drawing.Size(182, 31)
        Me.lblIdentification.TabIndex = 29
        Me.lblIdentification.Text = "Identification"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.btnNvCaissier)
        Me.GroupBox1.Controls.Add(Me.lblPassword)
        Me.GroupBox1.Controls.Add(Me.lblCaissier)
        Me.GroupBox1.Controls.Add(Me.lblCaisse)
        Me.GroupBox1.Controls.Add(Me.cmbCaissier)
        Me.GroupBox1.Controls.Add(Me.cmbCaisse)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 163)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Image = Global.Caisse.My.Resources.Resources.btAjouter32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(323, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 33)
        Me.Button1.TabIndex = 39
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(103, 120)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9786)
        Me.txtPassword.Size = New System.Drawing.Size(192, 20)
        Me.txtPassword.TabIndex = 38
        '
        'btnNvCaissier
        '
        Me.btnNvCaissier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNvCaissier.Image = Global.Caisse.My.Resources.Resources.btAjouter32
        Me.btnNvCaissier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNvCaissier.Location = New System.Drawing.Point(323, 70)
        Me.btnNvCaissier.Name = "btnNvCaissier"
        Me.btnNvCaissier.Size = New System.Drawing.Size(39, 34)
        Me.btnNvCaissier.TabIndex = 37
        Me.btnNvCaissier.UseVisualStyleBackColor = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.Location = New System.Drawing.Point(17, 120)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(73, 13)
        Me.lblPassword.TabIndex = 36
        Me.lblPassword.Text = "Password : "
        '
        'lblCaissier
        '
        Me.lblCaissier.AutoSize = True
        Me.lblCaissier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCaissier.Location = New System.Drawing.Point(17, 77)
        Me.lblCaissier.Name = "lblCaissier"
        Me.lblCaissier.Size = New System.Drawing.Size(59, 13)
        Me.lblCaissier.TabIndex = 35
        Me.lblCaissier.Text = "Caissier :"
        '
        'lblCaisse
        '
        Me.lblCaisse.AutoSize = True
        Me.lblCaisse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCaisse.Location = New System.Drawing.Point(17, 34)
        Me.lblCaisse.Name = "lblCaisse"
        Me.lblCaisse.Size = New System.Drawing.Size(52, 13)
        Me.lblCaisse.TabIndex = 34
        Me.lblCaisse.Text = "Caisse :"
        '
        'cmbCaissier
        '
        Me.cmbCaissier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaissier.FormattingEnabled = True
        Me.cmbCaissier.Location = New System.Drawing.Point(103, 78)
        Me.cmbCaissier.Name = "cmbCaissier"
        Me.cmbCaissier.Size = New System.Drawing.Size(192, 21)
        Me.cmbCaissier.TabIndex = 33
        '
        'cmbCaisse
        '
        Me.cmbCaisse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaisse.FormattingEnabled = True
        Me.cmbCaisse.Location = New System.Drawing.Point(103, 34)
        Me.cmbCaisse.Name = "cmbCaisse"
        Me.cmbCaisse.Size = New System.Drawing.Size(192, 21)
        Me.cmbCaisse.TabIndex = 32
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblAnnuler)
        Me.GroupBox2.Controls.Add(Me.btValider)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 227)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(378, 61)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        '
        'lblAnnuler
        '
        Me.lblAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblAnnuler.Image = Global.Caisse.My.Resources.Resources.btFermer324
        Me.lblAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAnnuler.Location = New System.Drawing.Point(185, 15)
        Me.lblAnnuler.Name = "lblAnnuler"
        Me.lblAnnuler.Size = New System.Drawing.Size(127, 40)
        Me.lblAnnuler.TabIndex = 19
        Me.lblAnnuler.Text = "Annuler"
        Me.lblAnnuler.UseVisualStyleBackColor = False
        '
        'btValider
        '
        Me.btValider.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btValider.Image = Global.Caisse.My.Resources.Resources.btEnregistrer323
        Me.btValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btValider.Location = New System.Drawing.Point(40, 15)
        Me.btValider.Name = "btValider"
        Me.btValider.Size = New System.Drawing.Size(127, 40)
        Me.btValider.TabIndex = 18
        Me.btValider.Text = "Valider"
        Me.btValider.UseVisualStyleBackColor = False
        '
        'FrmOccupation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(402, 300)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblIdentification)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOccupation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FBA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIdentification As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnNvCaissier As System.Windows.Forms.Button
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblCaissier As System.Windows.Forms.Label
    Friend WithEvents lblCaisse As System.Windows.Forms.Label
    Friend WithEvents cmbCaissier As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCaisse As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAnnuler As System.Windows.Forms.Button
    Friend WithEvents btValider As System.Windows.Forms.Button
End Class
