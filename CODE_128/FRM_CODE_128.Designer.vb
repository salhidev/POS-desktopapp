<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CODE_128
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_CODE_128))
        Me.PBX_CODE = New System.Windows.Forms.PictureBox
        Me.LBL_INTERPRETE = New System.Windows.Forms.Label
        Me.TXB_INCODE = New System.Windows.Forms.TextBox
        Me.CMD_GO = New System.Windows.Forms.Button
        Me.LBL_MASQUE = New System.Windows.Forms.Label
        Me.CMD_ABOUT = New System.Windows.Forms.Button
        Me.CMD_STOP = New System.Windows.Forms.Button
        CType(Me.PBX_CODE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBX_CODE
        '
        Me.PBX_CODE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBX_CODE.BackColor = System.Drawing.Color.Transparent
        Me.PBX_CODE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PBX_CODE.Location = New System.Drawing.Point(26, 28)
        Me.PBX_CODE.Name = "PBX_CODE"
        Me.PBX_CODE.Size = New System.Drawing.Size(626, 170)
        Me.PBX_CODE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBX_CODE.TabIndex = 2
        Me.PBX_CODE.TabStop = False
        '
        'LBL_INTERPRETE
        '
        Me.LBL_INTERPRETE.BackColor = System.Drawing.Color.White
        Me.LBL_INTERPRETE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBL_INTERPRETE.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_INTERPRETE.Location = New System.Drawing.Point(23, 220)
        Me.LBL_INTERPRETE.Name = "LBL_INTERPRETE"
        Me.LBL_INTERPRETE.Size = New System.Drawing.Size(629, 79)
        Me.LBL_INTERPRETE.TabIndex = 3
        Me.LBL_INTERPRETE.Tag = "LBL_INTERPRETE"
        '
        'TXB_INCODE
        '
        Me.TXB_INCODE.AcceptsReturn = True
        Me.TXB_INCODE.AllowDrop = True
        Me.TXB_INCODE.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXB_INCODE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXB_INCODE.ForeColor = System.Drawing.Color.Black
        Me.TXB_INCODE.Location = New System.Drawing.Point(23, 400)
        Me.TXB_INCODE.Multiline = True
        Me.TXB_INCODE.Name = "TXB_INCODE"
        Me.TXB_INCODE.Size = New System.Drawing.Size(629, 86)
        Me.TXB_INCODE.TabIndex = 4
        Me.TXB_INCODE.Tag = "TXB_INCODE"
        '
        'CMD_GO
        '
        Me.CMD_GO.Location = New System.Drawing.Point(427, 493)
        Me.CMD_GO.Name = "CMD_GO"
        Me.CMD_GO.Size = New System.Drawing.Size(75, 23)
        Me.CMD_GO.TabIndex = 5
        Me.CMD_GO.Tag = "CMD_GO"
        Me.CMD_GO.Text = "GO"
        Me.CMD_GO.UseVisualStyleBackColor = True
        '
        'LBL_MASQUE
        '
        Me.LBL_MASQUE.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBL_MASQUE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBL_MASQUE.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_MASQUE.Location = New System.Drawing.Point(23, 310)
        Me.LBL_MASQUE.Name = "LBL_MASQUE"
        Me.LBL_MASQUE.Size = New System.Drawing.Size(629, 79)
        Me.LBL_MASQUE.TabIndex = 6
        Me.LBL_MASQUE.Tag = "LBL_MASQUE"
        '
        'CMD_ABOUT
        '
        Me.CMD_ABOUT.Location = New System.Drawing.Point(577, 492)
        Me.CMD_ABOUT.Name = "CMD_ABOUT"
        Me.CMD_ABOUT.Size = New System.Drawing.Size(75, 23)
        Me.CMD_ABOUT.TabIndex = 7
        Me.CMD_ABOUT.Tag = "CMD_ABOUT"
        Me.CMD_ABOUT.Text = "ABOUT"
        Me.CMD_ABOUT.UseVisualStyleBackColor = True
        '
        'CMD_STOP
        '
        Me.CMD_STOP.Location = New System.Drawing.Point(502, 493)
        Me.CMD_STOP.Name = "CMD_STOP"
        Me.CMD_STOP.Size = New System.Drawing.Size(75, 23)
        Me.CMD_STOP.TabIndex = 8
        Me.CMD_STOP.Tag = "CMD_STOP"
        Me.CMD_STOP.Text = "STOP"
        Me.CMD_STOP.UseVisualStyleBackColor = True
        '
        'FRM_CODE_128
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(674, 545)
        Me.Controls.Add(Me.CMD_STOP)
        Me.Controls.Add(Me.CMD_ABOUT)
        Me.Controls.Add(Me.LBL_MASQUE)
        Me.Controls.Add(Me.CMD_GO)
        Me.Controls.Add(Me.TXB_INCODE)
        Me.Controls.Add(Me.LBL_INTERPRETE)
        Me.Controls.Add(Me.PBX_CODE)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_CODE_128"
        Me.Tag = "FRM_CODE_128"
        Me.Text = "FRM_CODE_128"
        CType(Me.PBX_CODE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PBX_CODE As System.Windows.Forms.PictureBox
    Friend WithEvents LBL_INTERPRETE As System.Windows.Forms.Label
    Friend WithEvents TXB_INCODE As System.Windows.Forms.TextBox
    Friend WithEvents CMD_GO As System.Windows.Forms.Button
    Friend WithEvents LBL_MASQUE As System.Windows.Forms.Label
    Friend WithEvents CMD_ABOUT As System.Windows.Forms.Button
    Friend WithEvents CMD_STOP As System.Windows.Forms.Button

End Class
