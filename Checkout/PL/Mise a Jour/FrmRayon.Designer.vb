<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRayon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRayon))
        Me.GBXRayon = New System.Windows.Forms.GroupBox()
        Me.txtRay_Lib = New System.Windows.Forms.TextBox()
        Me.lbllibellé = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn_Quitter = New System.Windows.Forms.Button()
        Me.LblRayon = New System.Windows.Forms.Label()
        Me.GBXRayon.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBXRayon
        '
        Me.GBXRayon.Controls.Add(Me.txtRay_Lib)
        Me.GBXRayon.Controls.Add(Me.lbllibellé)
        Me.GBXRayon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBXRayon.ForeColor = System.Drawing.Color.Purple
        Me.GBXRayon.Location = New System.Drawing.Point(9, 53)
        Me.GBXRayon.Name = "GBXRayon"
        Me.GBXRayon.Size = New System.Drawing.Size(511, 81)
        Me.GBXRayon.TabIndex = 3
        Me.GBXRayon.TabStop = False
        Me.GBXRayon.Text = "Rayon"
        '
        'txtRay_Lib
        '
        Me.txtRay_Lib.BackColor = System.Drawing.SystemColors.Window
        Me.txtRay_Lib.Location = New System.Drawing.Point(186, 33)
        Me.txtRay_Lib.Name = "txtRay_Lib"
        Me.txtRay_Lib.Size = New System.Drawing.Size(143, 20)
        Me.txtRay_Lib.TabIndex = 0
        '
        'lbllibellé
        '
        Me.lbllibellé.AutoSize = True
        Me.lbllibellé.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllibellé.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbllibellé.Location = New System.Drawing.Point(106, 40)
        Me.lbllibellé.Name = "lbllibellé"
        Me.lbllibellé.Size = New System.Drawing.Size(44, 13)
        Me.lbllibellé.TabIndex = 0
        Me.lbllibellé.Text = "Libellé"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Btn_Quitter)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox1.Location = New System.Drawing.Point(12, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 90)
        Me.GroupBox1.TabIndex = 199
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestion :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.Caisse.My.Resources.Resources.btRetour324
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(197, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 48)
        Me.Button2.TabIndex = 208
        Me.Button2.Text = "     &Vider"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Image = Global.Caisse.My.Resources.Resources.btEnregistrer321
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(58, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 48)
        Me.Button1.TabIndex = 201
        Me.Button1.Text = "       &Valider"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Btn_Quitter
        '
        Me.Btn_Quitter.BackColor = System.Drawing.Color.Silver
        Me.Btn_Quitter.ForeColor = System.Drawing.Color.Black
        Me.Btn_Quitter.Image = Global.Caisse.My.Resources.Resources.btFermer323
        Me.Btn_Quitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Quitter.Location = New System.Drawing.Point(336, 25)
        Me.Btn_Quitter.Name = "Btn_Quitter"
        Me.Btn_Quitter.Size = New System.Drawing.Size(133, 48)
        Me.Btn_Quitter.TabIndex = 207
        Me.Btn_Quitter.Text = "     Fermer"
        Me.Btn_Quitter.UseVisualStyleBackColor = False
        '
        'LblRayon
        '
        Me.LblRayon.AutoSize = True
        Me.LblRayon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRayon.ForeColor = System.Drawing.Color.Purple
        Me.LblRayon.Location = New System.Drawing.Point(232, 21)
        Me.LblRayon.Name = "LblRayon"
        Me.LblRayon.Size = New System.Drawing.Size(60, 20)
        Me.LblRayon.TabIndex = 200
        Me.LblRayon.Text = "Rayon"
        '
        'FrmRayon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(535, 254)
        Me.Controls.Add(Me.LblRayon)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBXRayon)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRayon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FBA"
        Me.GBXRayon.ResumeLayout(False)
        Me.GBXRayon.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBXRayon As System.Windows.Forms.GroupBox
    Friend WithEvents txtRay_Lib As System.Windows.Forms.TextBox
    Friend WithEvents lbllibellé As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblRayon As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Btn_Quitter As System.Windows.Forms.Button
End Class
