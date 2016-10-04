<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Générer_CB
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CKBNonActive = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTypeCB = New System.Windows.Forms.TextBox()
        Me.CKBActive = New System.Windows.Forms.CheckBox()
        Me.lblTypeCB = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CMD_GO = New System.Windows.Forms.Button()
        Me.LBL_INTERPRETE = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBL_MASQUE = New System.Windows.Forms.Label()
        Me.TXB_INCODE = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PBX_CODE = New System.Windows.Forms.PictureBox()
        Me.Fermer = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PBX_CODE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CKBNonActive)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtTypeCB)
        Me.GroupBox4.Controls.Add(Me.CKBActive)
        Me.GroupBox4.Controls.Add(Me.lblTypeCB)
        Me.GroupBox4.Location = New System.Drawing.Point(395, 254)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(277, 196)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        '
        'CKBNonActive
        '
        Me.CKBNonActive.AutoSize = True
        Me.CKBNonActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CKBNonActive.ForeColor = System.Drawing.Color.Black
        Me.CKBNonActive.Location = New System.Drawing.Point(105, 134)
        Me.CKBNonActive.Name = "CKBNonActive"
        Me.CKBNonActive.Size = New System.Drawing.Size(89, 17)
        Me.CKBNonActive.TabIndex = 53
        Me.CKBNonActive.Text = "Non Active"
        Me.CKBNonActive.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Activation : "
        '
        'txtTypeCB
        '
        Me.txtTypeCB.BackColor = System.Drawing.SystemColors.Window
        Me.txtTypeCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTypeCB.Location = New System.Drawing.Point(18, 54)
        Me.txtTypeCB.Name = "txtTypeCB"
        Me.txtTypeCB.Size = New System.Drawing.Size(166, 22)
        Me.txtTypeCB.TabIndex = 51
        '
        'CKBActive
        '
        Me.CKBActive.AutoSize = True
        Me.CKBActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CKBActive.ForeColor = System.Drawing.Color.Black
        Me.CKBActive.Location = New System.Drawing.Point(18, 134)
        Me.CKBActive.Name = "CKBActive"
        Me.CKBActive.Size = New System.Drawing.Size(62, 17)
        Me.CKBActive.TabIndex = 50
        Me.CKBActive.Text = "Active"
        Me.CKBActive.UseVisualStyleBackColor = True
        '
        'lblTypeCB
        '
        Me.lblTypeCB.AutoSize = True
        Me.lblTypeCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeCB.ForeColor = System.Drawing.Color.Black
        Me.lblTypeCB.Location = New System.Drawing.Point(15, 27)
        Me.lblTypeCB.Name = "lblTypeCB"
        Me.lblTypeCB.Size = New System.Drawing.Size(106, 13)
        Me.lblTypeCB.TabIndex = 49
        Me.lblTypeCB.Text = "Type CodeBarre :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Code Barre "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Fermer)
        Me.GroupBox3.Controls.Add(Me.CMD_GO)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 456)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(650, 75)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'CMD_GO
        '
        Me.CMD_GO.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMD_GO.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_GO.Image = Global.Caisse.My.Resources.Resources.btEnregistrer321
        Me.CMD_GO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CMD_GO.Location = New System.Drawing.Point(11, 19)
        Me.CMD_GO.Name = "CMD_GO"
        Me.CMD_GO.Size = New System.Drawing.Size(295, 41)
        Me.CMD_GO.TabIndex = 5
        Me.CMD_GO.Tag = "CMD_GO"
        Me.CMD_GO.Text = "Générer"
        Me.CMD_GO.UseVisualStyleBackColor = False
        '
        'LBL_INTERPRETE
        '
        Me.LBL_INTERPRETE.BackColor = System.Drawing.Color.White
        Me.LBL_INTERPRETE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBL_INTERPRETE.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_INTERPRETE.Location = New System.Drawing.Point(11, 25)
        Me.LBL_INTERPRETE.Name = "LBL_INTERPRETE"
        Me.LBL_INTERPRETE.Size = New System.Drawing.Size(315, 40)
        Me.LBL_INTERPRETE.TabIndex = 7
        Me.LBL_INTERPRETE.Tag = "LBL_INTERPRETE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LBL_MASQUE)
        Me.GroupBox2.Controls.Add(Me.TXB_INCODE)
        Me.GroupBox2.Controls.Add(Me.LBL_INTERPRETE)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(348, 196)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'LBL_MASQUE
        '
        Me.LBL_MASQUE.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBL_MASQUE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBL_MASQUE.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_MASQUE.Location = New System.Drawing.Point(11, 75)
        Me.LBL_MASQUE.Name = "LBL_MASQUE"
        Me.LBL_MASQUE.Size = New System.Drawing.Size(315, 43)
        Me.LBL_MASQUE.TabIndex = 9
        Me.LBL_MASQUE.Tag = "LBL_MASQUE"
        '
        'TXB_INCODE
        '
        Me.TXB_INCODE.AcceptsReturn = True
        Me.TXB_INCODE.AllowDrop = True
        Me.TXB_INCODE.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXB_INCODE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXB_INCODE.ForeColor = System.Drawing.Color.Black
        Me.TXB_INCODE.Location = New System.Drawing.Point(11, 130)
        Me.TXB_INCODE.Multiline = True
        Me.TXB_INCODE.Name = "TXB_INCODE"
        Me.TXB_INCODE.Size = New System.Drawing.Size(315, 52)
        Me.TXB_INCODE.TabIndex = 8
        Me.TXB_INCODE.Tag = "TXB_INCODE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PBX_CODE)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 206)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'PBX_CODE
        '
        Me.PBX_CODE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBX_CODE.BackColor = System.Drawing.Color.Transparent
        Me.PBX_CODE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PBX_CODE.Location = New System.Drawing.Point(6, 18)
        Me.PBX_CODE.Name = "PBX_CODE"
        Me.PBX_CODE.Size = New System.Drawing.Size(638, 181)
        Me.PBX_CODE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBX_CODE.TabIndex = 2
        Me.PBX_CODE.TabStop = False
        '
        'Fermer
        '
        Me.Fermer.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Fermer.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fermer.Image = Global.Caisse.My.Resources.Resources.Log_Out21
        Me.Fermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Fermer.Location = New System.Drawing.Point(461, 19)
        Me.Fermer.Name = "Fermer"
        Me.Fermer.Size = New System.Drawing.Size(169, 41)
        Me.Fermer.TabIndex = 6
        Me.Fermer.Tag = "CMD_GO"
        Me.Fermer.Text = "Fermer"
        Me.Fermer.UseVisualStyleBackColor = False
        '
        'Frm_Générer_CB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(718, 614)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_Générer_CB"
        Me.Text = "Frm_Générer_CB"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PBX_CODE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PBX_CODE As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CKBNonActive As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTypeCB As System.Windows.Forms.TextBox
    Friend WithEvents CKBActive As System.Windows.Forms.CheckBox
    Friend WithEvents lblTypeCB As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CMD_GO As System.Windows.Forms.Button
    Friend WithEvents LBL_INTERPRETE As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LBL_MASQUE As System.Windows.Forms.Label
    Friend WithEvents TXB_INCODE As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Fermer As System.Windows.Forms.Button
End Class
