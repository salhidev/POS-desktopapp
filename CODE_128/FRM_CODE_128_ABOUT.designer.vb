<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CODE_128_ABOUT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_CODE_128_ABOUT))
        Me.PBX_ICON = New System.Windows.Forms.PictureBox
        Me.LBL_TIT = New System.Windows.Forms.Label
        Me.LBL_VER = New System.Windows.Forms.Label
        Me.LBL_CPY = New System.Windows.Forms.Label
        Me.LBL_DSC = New System.Windows.Forms.Label
        Me.LBL_DIR = New System.Windows.Forms.Label
        CType(Me.PBX_ICON, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBX_ICON
        '
        Me.PBX_ICON.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PBX_ICON.Location = New System.Drawing.Point(12, 12)
        Me.PBX_ICON.Name = "PBX_ICON"
        Me.PBX_ICON.Size = New System.Drawing.Size(64, 64)
        Me.PBX_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBX_ICON.TabIndex = 1
        Me.PBX_ICON.TabStop = False
        Me.PBX_ICON.Tag = "PBX_ICON"
        '
        'LBL_TIT
        '
        Me.LBL_TIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBL_TIT.Font = New System.Drawing.Font("Bitstream Vera Sans", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TIT.Location = New System.Drawing.Point(82, 92)
        Me.LBL_TIT.Name = "LBL_TIT"
        Me.LBL_TIT.Size = New System.Drawing.Size(510, 50)
        Me.LBL_TIT.TabIndex = 2
        Me.LBL_TIT.Tag = "LBL_TIT"
        Me.LBL_TIT.Text = "LBL_TIT"
        Me.LBL_TIT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBL_VER
        '
        Me.LBL_VER.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBL_VER.Font = New System.Drawing.Font("Bitstream Vera Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_VER.Location = New System.Drawing.Point(82, 142)
        Me.LBL_VER.Name = "LBL_VER"
        Me.LBL_VER.Size = New System.Drawing.Size(510, 30)
        Me.LBL_VER.TabIndex = 3
        Me.LBL_VER.Tag = "LBL_VER"
        Me.LBL_VER.Text = "LBL_VER"
        Me.LBL_VER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBL_CPY
        '
        Me.LBL_CPY.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBL_CPY.Font = New System.Drawing.Font("Bitstream Vera Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CPY.Location = New System.Drawing.Point(82, 202)
        Me.LBL_CPY.Name = "LBL_CPY"
        Me.LBL_CPY.Size = New System.Drawing.Size(510, 30)
        Me.LBL_CPY.TabIndex = 4
        Me.LBL_CPY.Tag = "LBL_CPY"
        Me.LBL_CPY.Text = "LBL_CPY"
        Me.LBL_CPY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBL_DSC
        '
        Me.LBL_DSC.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBL_DSC.Font = New System.Drawing.Font("Bitstream Vera Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DSC.Location = New System.Drawing.Point(82, 172)
        Me.LBL_DSC.Name = "LBL_DSC"
        Me.LBL_DSC.Size = New System.Drawing.Size(510, 30)
        Me.LBL_DSC.TabIndex = 6
        Me.LBL_DSC.Tag = "LBL_DSC"
        Me.LBL_DSC.Text = "LBL_DSC"
        Me.LBL_DSC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBL_DIR
        '
        Me.LBL_DIR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_DIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LBL_DIR.Font = New System.Drawing.Font("Bitstream Vera Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DIR.Location = New System.Drawing.Point(-2, 290)
        Me.LBL_DIR.Name = "LBL_DIR"
        Me.LBL_DIR.Size = New System.Drawing.Size(631, 23)
        Me.LBL_DIR.TabIndex = 7
        Me.LBL_DIR.Tag = "LBL_DIR"
        Me.LBL_DIR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FRM_CODE_128_ABOUT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(629, 312)
        Me.Controls.Add(Me.LBL_DIR)
        Me.Controls.Add(Me.LBL_DSC)
        Me.Controls.Add(Me.LBL_CPY)
        Me.Controls.Add(Me.LBL_VER)
        Me.Controls.Add(Me.LBL_TIT)
        Me.Controls.Add(Me.PBX_ICON)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_CODE_128_ABOUT"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "FRM_CHG5_ABOUT"
        Me.Text = "Au sujet de..."
        CType(Me.PBX_ICON, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PBX_ICON As System.Windows.Forms.PictureBox
    Friend WithEvents LBL_TIT As System.Windows.Forms.Label
    Friend WithEvents LBL_VER As System.Windows.Forms.Label
    Friend WithEvents LBL_CPY As System.Windows.Forms.Label
    Friend WithEvents LBL_DSC As System.Windows.Forms.Label
    Friend WithEvents LBL_DIR As System.Windows.Forms.Label
End Class
