<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAjoutCaisse
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAjoutCaisse))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Btn_Quitter = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtCAISSe_ID = New System.Windows.Forms.TextBox()
        Me.TxtCAISSE_ETAT = New System.Windows.Forms.TextBox()
        Me.lblCAISSE_ETAT = New System.Windows.Forms.Label()
        Me.TxtCAISSE_LIB = New System.Windows.Forms.TextBox()
        Me.lblCAISSE_LIB = New System.Windows.Forms.Label()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 268)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Btn_Quitter)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 181)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(502, 61)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gestion : "
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Silver
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = Global.Caisse.My.Resources.Resources.btRetour324
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(188, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(133, 32)
        Me.Button4.TabIndex = 214
        Me.Button4.Text = "     &Vider"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button5.BackColor = System.Drawing.Color.Silver
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button5.Image = Global.Caisse.My.Resources.Resources.Valider
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(31, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(133, 32)
        Me.Button5.TabIndex = 212
        Me.Button5.Text = "       &Valider"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Btn_Quitter
        '
        Me.Btn_Quitter.BackColor = System.Drawing.Color.Silver
        Me.Btn_Quitter.ForeColor = System.Drawing.Color.Black
        Me.Btn_Quitter.Image = Global.Caisse.My.Resources.Resources.Log_Out211
        Me.Btn_Quitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Quitter.Location = New System.Drawing.Point(342, 19)
        Me.Btn_Quitter.Name = "Btn_Quitter"
        Me.Btn_Quitter.Size = New System.Drawing.Size(133, 32)
        Me.Btn_Quitter.TabIndex = 213
        Me.Btn_Quitter.Text = "     Fermer"
        Me.Btn_Quitter.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtCAISSe_ID)
        Me.GroupBox2.Controls.Add(Me.TxtCAISSE_ETAT)
        Me.GroupBox2.Controls.Add(Me.lblCAISSE_ETAT)
        Me.GroupBox2.Controls.Add(Me.TxtCAISSE_LIB)
        Me.GroupBox2.Controls.Add(Me.lblCAISSE_LIB)
        Me.GroupBox2.Location = New System.Drawing.Point(64, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(401, 118)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'TxtCAISSe_ID
        '
        Me.TxtCAISSe_ID.Location = New System.Drawing.Point(363, 30)
        Me.TxtCAISSe_ID.Name = "TxtCAISSe_ID"
        Me.TxtCAISSe_ID.Size = New System.Drawing.Size(32, 20)
        Me.TxtCAISSe_ID.TabIndex = 12
        Me.TxtCAISSe_ID.Visible = False
        '
        'TxtCAISSE_ETAT
        '
        Me.TxtCAISSE_ETAT.Location = New System.Drawing.Point(180, 65)
        Me.TxtCAISSE_ETAT.Name = "TxtCAISSE_ETAT"
        Me.TxtCAISSE_ETAT.Size = New System.Drawing.Size(165, 20)
        Me.TxtCAISSE_ETAT.TabIndex = 2
        '
        'lblCAISSE_ETAT
        '
        Me.lblCAISSE_ETAT.AutoSize = True
        Me.lblCAISSE_ETAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCAISSE_ETAT.Location = New System.Drawing.Point(6, 68)
        Me.lblCAISSE_ETAT.Name = "lblCAISSE_ETAT"
        Me.lblCAISSE_ETAT.Size = New System.Drawing.Size(121, 13)
        Me.lblCAISSE_ETAT.TabIndex = 11
        Me.lblCAISSE_ETAT.Text = "Etat De La Caisse : "
        '
        'TxtCAISSE_LIB
        '
        Me.TxtCAISSE_LIB.Location = New System.Drawing.Point(180, 30)
        Me.TxtCAISSE_LIB.Name = "TxtCAISSE_LIB"
        Me.TxtCAISSE_LIB.Size = New System.Drawing.Size(165, 20)
        Me.TxtCAISSE_LIB.TabIndex = 1
        '
        'lblCAISSE_LIB
        '
        Me.lblCAISSE_LIB.AutoSize = True
        Me.lblCAISSE_LIB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCAISSE_LIB.Location = New System.Drawing.Point(6, 30)
        Me.lblCAISSE_LIB.Name = "lblCAISSE_LIB"
        Me.lblCAISSE_LIB.Size = New System.Drawing.Size(119, 13)
        Me.lblCAISSE_LIB.TabIndex = 9
        Me.lblCAISSE_LIB.Text = "Nom De La Caisse :"
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Monotype Corsiva", 29.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(205, 55)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(108, 47)
        Me.lblTitre.TabIndex = 8
        Me.lblTitre.Text = "Caisse"
        '
        'FrmAjoutCaisse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(550, 423)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAjoutCaisse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FBA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCAISSE_ETAT As System.Windows.Forms.TextBox
    Friend WithEvents lblCAISSE_ETAT As System.Windows.Forms.Label
    Friend WithEvents TxtCAISSE_LIB As System.Windows.Forms.TextBox
    Friend WithEvents lblCAISSE_LIB As System.Windows.Forms.Label
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Btn_Quitter As System.Windows.Forms.Button
    Friend WithEvents TxtCAISSe_ID As System.Windows.Forms.TextBox
End Class
