<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCodeBarre
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Lbl_etatcodebare As System.Windows.Forms.Label
        Dim Lbl_Type As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCodeBarre))
        Me.GBXCodeBarre = New System.Windows.Forms.GroupBox()
        Me.lblCodeBarre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.BtnValider = New System.Windows.Forms.Button()
        Me.BtnVider = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Ckb_NnAct = New System.Windows.Forms.CheckBox()
        Me.Ckb_active = New System.Windows.Forms.CheckBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        Lbl_etatcodebare = New System.Windows.Forms.Label()
        Lbl_Type = New System.Windows.Forms.Label()
        Me.GBXCodeBarre.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBXCodeBarre
        '
        Me.GBXCodeBarre.Controls.Add(Me.GroupBox2)
        Me.GBXCodeBarre.Controls.Add(Me.PictureBox1)
        Me.GBXCodeBarre.Controls.Add(Label1)
        Me.GBXCodeBarre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBXCodeBarre.ForeColor = System.Drawing.Color.Purple
        Me.GBXCodeBarre.Location = New System.Drawing.Point(29, 54)
        Me.GBXCodeBarre.Name = "GBXCodeBarre"
        Me.GBXCodeBarre.Size = New System.Drawing.Size(480, 285)
        Me.GBXCodeBarre.TabIndex = 215
        Me.GBXCodeBarre.TabStop = False
        Me.GBXCodeBarre.Text = "CodeBarre"
        '
        'lblCodeBarre
        '
        Me.lblCodeBarre.AutoSize = True
        Me.lblCodeBarre.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodeBarre.Location = New System.Drawing.Point(194, 20)
        Me.lblCodeBarre.Name = "lblCodeBarre"
        Me.lblCodeBarre.Size = New System.Drawing.Size(151, 29)
        Me.lblCodeBarre.TabIndex = 216
        Me.lblCodeBarre.Text = "Code Barre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnAnnuler)
        Me.GroupBox1.Controls.Add(Me.BtnValider)
        Me.GroupBox1.Controls.Add(Me.BtnVider)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox1.Location = New System.Drawing.Point(25, 352)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 81)
        Me.GroupBox1.TabIndex = 217
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestion :"
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnnuler.ForeColor = System.Drawing.Color.Black
        Me.BtnAnnuler.Image = Global.Caisse.My.Resources.Resources.btFermer324
        Me.BtnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnnuler.Location = New System.Drawing.Point(313, 19)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(133, 48)
        Me.BtnAnnuler.TabIndex = 30
        Me.BtnAnnuler.Text = "   Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = False
        '
        'BtnValider
        '
        Me.BtnValider.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValider.ForeColor = System.Drawing.Color.Black
        Me.BtnValider.Image = Global.Caisse.My.Resources.Resources.btEnregistrer323
        Me.BtnValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnValider.Location = New System.Drawing.Point(35, 19)
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.Size = New System.Drawing.Size(133, 48)
        Me.BtnValider.TabIndex = 27
        Me.BtnValider.Text = "    &Valider"
        Me.BtnValider.UseVisualStyleBackColor = False
        '
        'BtnVider
        '
        Me.BtnVider.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnVider.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnVider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVider.ForeColor = System.Drawing.Color.Black
        Me.BtnVider.Image = Global.Caisse.My.Resources.Resources.btRetour324
        Me.BtnVider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVider.Location = New System.Drawing.Point(174, 19)
        Me.BtnVider.Name = "BtnVider"
        Me.BtnVider.Size = New System.Drawing.Size(133, 48)
        Me.BtnVider.TabIndex = 29
        Me.BtnVider.Text = "    &Vider"
        Me.BtnVider.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Black
        Label1.Location = New System.Drawing.Point(16, 99)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(53, 13)
        Label1.TabIndex = 220
        Label1.Text = "Image : "
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(19, 124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(443, 150)
        Me.PictureBox1.TabIndex = 221
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtType)
        Me.GroupBox2.Controls.Add(Lbl_Type)
        Me.GroupBox2.Controls.Add(Me.Ckb_NnAct)
        Me.GroupBox2.Controls.Add(Me.Ckb_active)
        Me.GroupBox2.Controls.Add(Lbl_etatcodebare)
        Me.GroupBox2.Location = New System.Drawing.Point(85, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(357, 85)
        Me.GroupBox2.TabIndex = 223
        Me.GroupBox2.TabStop = False
        '
        'Ckb_NnAct
        '
        Me.Ckb_NnAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ckb_NnAct.ForeColor = System.Drawing.Color.Black
        Me.Ckb_NnAct.Location = New System.Drawing.Point(242, 38)
        Me.Ckb_NnAct.Name = "Ckb_NnAct"
        Me.Ckb_NnAct.Size = New System.Drawing.Size(104, 24)
        Me.Ckb_NnAct.TabIndex = 225
        Me.Ckb_NnAct.Text = "Non Active"
        Me.Ckb_NnAct.UseVisualStyleBackColor = True
        '
        'Ckb_active
        '
        Me.Ckb_active.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ckb_active.ForeColor = System.Drawing.Color.Black
        Me.Ckb_active.Location = New System.Drawing.Point(242, 59)
        Me.Ckb_active.Name = "Ckb_active"
        Me.Ckb_active.Size = New System.Drawing.Size(104, 24)
        Me.Ckb_active.TabIndex = 224
        Me.Ckb_active.Text = "Active"
        Me.Ckb_active.UseVisualStyleBackColor = True
        '
        'Lbl_etatcodebare
        '
        Lbl_etatcodebare.AutoSize = True
        Lbl_etatcodebare.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Lbl_etatcodebare.ForeColor = System.Drawing.Color.Black
        Lbl_etatcodebare.Location = New System.Drawing.Point(221, 16)
        Lbl_etatcodebare.Name = "Lbl_etatcodebare"
        Lbl_etatcodebare.Size = New System.Drawing.Size(125, 13)
        Lbl_etatcodebare.TabIndex = 223
        Lbl_etatcodebare.Text = "Etat Du Code Barre :"
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(64, 13)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(131, 20)
        Me.txtType.TabIndex = 229
        '
        'Lbl_Type
        '
        Lbl_Type.AutoSize = True
        Lbl_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Lbl_Type.ForeColor = System.Drawing.Color.Black
        Lbl_Type.Location = New System.Drawing.Point(6, 16)
        Lbl_Type.Name = "Lbl_Type"
        Lbl_Type.Size = New System.Drawing.Size(43, 13)
        Lbl_Type.TabIndex = 228
        Lbl_Type.Text = "Type :"
        '
        'FrmCodeBarre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(542, 445)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCodeBarre)
        Me.Controls.Add(Me.GBXCodeBarre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCodeBarre"
        Me.Text = "FBA"
        Me.GBXCodeBarre.ResumeLayout(False)
        Me.GBXCodeBarre.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBXCodeBarre As System.Windows.Forms.GroupBox
    Friend WithEvents lblCodeBarre As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAnnuler As System.Windows.Forms.Button
    Friend WithEvents BtnValider As System.Windows.Forms.Button
    Friend WithEvents BtnVider As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents Ckb_NnAct As System.Windows.Forms.CheckBox
    Friend WithEvents Ckb_active As System.Windows.Forms.CheckBox
End Class
