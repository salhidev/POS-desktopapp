<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTicketEnAttente
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
        Me.TicketAttente = New System.Windows.Forms.GroupBox()
        Me.DgvTicketEnAttente = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtlibellé = New System.Windows.Forms.TextBox()
        Me.lbllibellé = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmdFermer = New System.Windows.Forms.Button()
        Me.TicketAttente.SuspendLayout()
        CType(Me.DgvTicketEnAttente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TicketAttente
        '
        Me.TicketAttente.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TicketAttente.Controls.Add(Me.DgvTicketEnAttente)
        Me.TicketAttente.Controls.Add(Me.GroupBox3)
        Me.TicketAttente.Controls.Add(Me.Button1)
        Me.TicketAttente.Controls.Add(Me.Button3)
        Me.TicketAttente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TicketAttente.Location = New System.Drawing.Point(27, 12)
        Me.TicketAttente.Name = "TicketAttente"
        Me.TicketAttente.Size = New System.Drawing.Size(671, 319)
        Me.TicketAttente.TabIndex = 217
        Me.TicketAttente.TabStop = False
        Me.TicketAttente.Text = "Ticket En Attente"
        '
        'DgvTicketEnAttente
        '
        Me.DgvTicketEnAttente.AllowUserToDeleteRows = False
        Me.DgvTicketEnAttente.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvTicketEnAttente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTicketEnAttente.Location = New System.Drawing.Point(15, 94)
        Me.DgvTicketEnAttente.Name = "DgvTicketEnAttente"
        Me.DgvTicketEnAttente.ReadOnly = True
        Me.DgvTicketEnAttente.Size = New System.Drawing.Size(568, 209)
        Me.DgvTicketEnAttente.TabIndex = 56
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtlibellé)
        Me.GroupBox3.Controls.Add(Me.lbllibellé)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(15, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(583, 57)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtre"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(127, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(143, 20)
        Me.DateTimePicker1.TabIndex = 22
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = Global.Caisse.My.Resources.Resources.btFiltre325
        Me.Button7.Location = New System.Drawing.Point(529, 16)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(39, 35)
        Me.Button7.TabIndex = 21
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Date Ticket"
        '
        'txtlibellé
        '
        Me.txtlibellé.BackColor = System.Drawing.SystemColors.Window
        Me.txtlibellé.Location = New System.Drawing.Point(386, 24)
        Me.txtlibellé.Name = "txtlibellé"
        Me.txtlibellé.Size = New System.Drawing.Size(123, 20)
        Me.txtlibellé.TabIndex = 2
        '
        'lbllibellé
        '
        Me.lbllibellé.AutoSize = True
        Me.lbllibellé.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllibellé.Location = New System.Drawing.Point(285, 28)
        Me.lbllibellé.Name = "lbllibellé"
        Me.lbllibellé.Size = New System.Drawing.Size(80, 13)
        Me.lbllibellé.TabIndex = 1
        Me.lbllibellé.Text = "Nom Caissier"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.Caisse.My.Resources.Resources.Up
        Me.Button1.Location = New System.Drawing.Point(604, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 63)
        Me.Button1.TabIndex = 54
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = Global.Caisse.My.Resources.Resources.Down
        Me.Button3.Location = New System.Drawing.Point(604, 204)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 63)
        Me.Button3.TabIndex = 53
        Me.Button3.UseVisualStyleBackColor = False
        '
        'cmdFermer
        '
        Me.cmdFermer.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFermer.ForeColor = System.Drawing.Color.Black
        Me.cmdFermer.Image = Global.Caisse.My.Resources.Resources.Log_Out2
        Me.cmdFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFermer.Location = New System.Drawing.Point(297, 337)
        Me.cmdFermer.Name = "cmdFermer"
        Me.cmdFermer.Size = New System.Drawing.Size(125, 46)
        Me.cmdFermer.TabIndex = 220
        Me.cmdFermer.Text = "&Fermer"
        Me.cmdFermer.UseVisualStyleBackColor = False
        '
        'FrmTicketEnAttente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(753, 395)
        Me.Controls.Add(Me.cmdFermer)
        Me.Controls.Add(Me.TicketAttente)
        Me.Name = "FrmTicketEnAttente"
        Me.Text = "FrmTicketEnAttente"
        Me.TicketAttente.ResumeLayout(False)
        CType(Me.DgvTicketEnAttente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdFermer As System.Windows.Forms.Button
    Friend WithEvents TicketAttente As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtlibellé As System.Windows.Forms.TextBox
    Friend WithEvents lbllibellé As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DgvTicketEnAttente As System.Windows.Forms.DataGridView
End Class
