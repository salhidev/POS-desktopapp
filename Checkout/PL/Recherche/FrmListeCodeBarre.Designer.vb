<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListeCodeBarre
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
        Me.components = New System.ComponentModel.Container()
        Me.GBXCodeBarre = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.txtTypeCB = New System.Windows.Forms.TextBox()
        Me.lblTypeCB = New System.Windows.Forms.Label()
        Me.DgvCodeBarre = New System.Windows.Forms.DataGridView()
        Me.CBIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBTYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBACTIVEDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ImgCBDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.LibCBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODEBAREBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.btnafficher = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GBXCodeBarre.SuspendLayout()
        CType(Me.DgvCodeBarre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODEBAREBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBXCodeBarre
        '
        Me.GBXCodeBarre.Controls.Add(Me.CheckBox1)
        Me.GBXCodeBarre.Controls.Add(Me.Button11)
        Me.GBXCodeBarre.Controls.Add(Me.txtTypeCB)
        Me.GBXCodeBarre.Controls.Add(Me.lblTypeCB)
        Me.GBXCodeBarre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBXCodeBarre.ForeColor = System.Drawing.Color.Purple
        Me.GBXCodeBarre.Location = New System.Drawing.Point(56, 146)
        Me.GBXCodeBarre.Name = "GBXCodeBarre"
        Me.GBXCodeBarre.Size = New System.Drawing.Size(718, 67)
        Me.GBXCodeBarre.TabIndex = 212
        Me.GBXCodeBarre.TabStop = False
        Me.GBXCodeBarre.Text = "Code Barre"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(499, 33)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox1.TabIndex = 44
        Me.CheckBox1.Text = "Active"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Enabled = False
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.ForeColor = System.Drawing.Color.White
        Me.Button11.Image = Global.Caisse.My.Resources.Resources.btFiltre325
        Me.Button11.Location = New System.Drawing.Point(619, 21)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(80, 33)
        Me.Button11.TabIndex = 43
        Me.Button11.UseVisualStyleBackColor = True
        '
        'txtTypeCB
        '
        Me.txtTypeCB.BackColor = System.Drawing.SystemColors.Window
        Me.txtTypeCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTypeCB.Location = New System.Drawing.Point(258, 28)
        Me.txtTypeCB.Name = "txtTypeCB"
        Me.txtTypeCB.Size = New System.Drawing.Size(166, 22)
        Me.txtTypeCB.TabIndex = 3
        '
        'lblTypeCB
        '
        Me.lblTypeCB.AutoSize = True
        Me.lblTypeCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeCB.ForeColor = System.Drawing.Color.Black
        Me.lblTypeCB.Location = New System.Drawing.Point(150, 31)
        Me.lblTypeCB.Name = "lblTypeCB"
        Me.lblTypeCB.Size = New System.Drawing.Size(106, 13)
        Me.lblTypeCB.TabIndex = 4
        Me.lblTypeCB.Text = "Type CodeBarre ;"
        '
        'DgvCodeBarre
        '
        Me.DgvCodeBarre.AutoGenerateColumns = False
        Me.DgvCodeBarre.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvCodeBarre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCodeBarre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CBIDDataGridViewTextBoxColumn, Me.CBTYPEDataGridViewTextBoxColumn, Me.CBACTIVEDataGridViewCheckBoxColumn, Me.ImgCBDataGridViewImageColumn, Me.LibCBDataGridViewTextBoxColumn})
        Me.DgvCodeBarre.DataSource = Me.CODEBAREBindingSource
        Me.DgvCodeBarre.Location = New System.Drawing.Point(56, 219)
        Me.DgvCodeBarre.Name = "DgvCodeBarre"
        Me.DgvCodeBarre.Size = New System.Drawing.Size(718, 222)
        Me.DgvCodeBarre.TabIndex = 215
        '
        'CBIDDataGridViewTextBoxColumn
        '
        Me.CBIDDataGridViewTextBoxColumn.DataPropertyName = "CB_ID"
        Me.CBIDDataGridViewTextBoxColumn.HeaderText = "CB_ID"
        Me.CBIDDataGridViewTextBoxColumn.Name = "CBIDDataGridViewTextBoxColumn"
        Me.CBIDDataGridViewTextBoxColumn.Visible = False
        '
        'CBTYPEDataGridViewTextBoxColumn
        '
        Me.CBTYPEDataGridViewTextBoxColumn.DataPropertyName = "CB_TYPE"
        Me.CBTYPEDataGridViewTextBoxColumn.HeaderText = "Type de Code Barre"
        Me.CBTYPEDataGridViewTextBoxColumn.Name = "CBTYPEDataGridViewTextBoxColumn"
        '
        'CBACTIVEDataGridViewCheckBoxColumn
        '
        Me.CBACTIVEDataGridViewCheckBoxColumn.DataPropertyName = "CB_ACTIVE"
        Me.CBACTIVEDataGridViewCheckBoxColumn.HeaderText = "Etat du Code Barre"
        Me.CBACTIVEDataGridViewCheckBoxColumn.Name = "CBACTIVEDataGridViewCheckBoxColumn"
        '
        'ImgCBDataGridViewImageColumn
        '
        Me.ImgCBDataGridViewImageColumn.DataPropertyName = "Img_CB"
        Me.ImgCBDataGridViewImageColumn.HeaderText = "Image Code Barre"
        Me.ImgCBDataGridViewImageColumn.Name = "ImgCBDataGridViewImageColumn"
        '
        'LibCBDataGridViewTextBoxColumn
        '
        Me.LibCBDataGridViewTextBoxColumn.DataPropertyName = "Lib_CB"
        Me.LibCBDataGridViewTextBoxColumn.HeaderText = "Libelle "
        Me.LibCBDataGridViewTextBoxColumn.Name = "LibCBDataGridViewTextBoxColumn"
        '
        'CODEBAREBindingSource
        '
        Me.CODEBAREBindingSource.DataSource = GetType(Caisse.CODE_BARE)
        '
        'Button28
        '
        Me.Button28.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button28.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button28.ForeColor = System.Drawing.Color.Black
        Me.Button28.Image = Global.Caisse.My.Resources.Resources.Log_Out2
        Me.Button28.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button28.Location = New System.Drawing.Point(602, 447)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(171, 48)
        Me.Button28.TabIndex = 221
        Me.Button28.Text = "&Fermer"
        Me.Button28.UseVisualStyleBackColor = False
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button21.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.ForeColor = System.Drawing.Color.Black
        Me.Button21.Image = Global.Caisse.My.Resources.Resources.Down
        Me.Button21.Location = New System.Drawing.Point(780, 378)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(53, 63)
        Me.Button21.TabIndex = 217
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button22.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.ForeColor = System.Drawing.Color.Black
        Me.Button22.Image = Global.Caisse.My.Resources.Resources.Up
        Me.Button22.Location = New System.Drawing.Point(780, 219)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(53, 63)
        Me.Button22.TabIndex = 216
        Me.Button22.UseVisualStyleBackColor = False
        '
        'btnafficher
        '
        Me.btnafficher.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnafficher.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnafficher.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnafficher.ForeColor = System.Drawing.Color.Black
        Me.btnafficher.Image = Global.Caisse.My.Resources.Resources.btEnregistrer22
        Me.btnafficher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnafficher.Location = New System.Drawing.Point(56, 447)
        Me.btnafficher.Name = "btnafficher"
        Me.btnafficher.Size = New System.Drawing.Size(135, 39)
        Me.btnafficher.TabIndex = 222
        Me.btnafficher.Text = "Afiicher"
        Me.btnafficher.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(282, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(316, 29)
        Me.Label7.TabIndex = 223
        Me.Label7.Text = "Gestion Des Code Barres"
        '
        'FrmListeCodeBarre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1027, 588)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnafficher)
        Me.Controls.Add(Me.Button28)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.DgvCodeBarre)
        Me.Controls.Add(Me.GBXCodeBarre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmListeCodeBarre"
        Me.Text = "FrmCodeBarre"
        Me.GBXCodeBarre.ResumeLayout(False)
        Me.GBXCodeBarre.PerformLayout()
        CType(Me.DgvCodeBarre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODEBAREBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBXCodeBarre As System.Windows.Forms.GroupBox
    Friend WithEvents txtTypeCB As System.Windows.Forms.TextBox
    Friend WithEvents lblTypeCB As System.Windows.Forms.Label
    Friend WithEvents DgvCodeBarre As System.Windows.Forms.DataGridView
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CODEBAREBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnafficher As System.Windows.Forms.Button
    Friend WithEvents CBIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBTYPEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBACTIVEDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ImgCBDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents LibCBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
