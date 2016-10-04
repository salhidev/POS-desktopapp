<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRappelerTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRappelerTicket))
        Me.TicketAttente = New System.Windows.Forms.GroupBox()
        Me.LblCompteur = New System.Windows.Forms.Label()
        Me.DgvRappelDuTicket = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtlibellé = New System.Windows.Forms.TextBox()
        Me.lbllibellé = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmdFermer = New System.Windows.Forms.Button()
        Me.BtnValiderTicket = New System.Windows.Forms.Button()
        Me.TicketAttente.SuspendLayout()
        CType(Me.DgvRappelDuTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TicketAttente
        '
        Me.TicketAttente.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TicketAttente.Controls.Add(Me.LblCompteur)
        Me.TicketAttente.Controls.Add(Me.DgvRappelDuTicket)
        Me.TicketAttente.Controls.Add(Me.GroupBox3)
        Me.TicketAttente.Controls.Add(Me.Button1)
        Me.TicketAttente.Controls.Add(Me.Button3)
        Me.TicketAttente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TicketAttente.Location = New System.Drawing.Point(23, 19)
        Me.TicketAttente.Name = "TicketAttente"
        Me.TicketAttente.Size = New System.Drawing.Size(671, 200)
        Me.TicketAttente.TabIndex = 0
        Me.TicketAttente.TabStop = False
        Me.TicketAttente.Text = "Rappel Du Ticket"
        '
        'LblCompteur
        '
        Me.LblCompteur.AutoSize = True
        Me.LblCompteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCompteur.Location = New System.Drawing.Point(604, 19)
        Me.LblCompteur.Name = "LblCompteur"
        Me.LblCompteur.Size = New System.Drawing.Size(42, 13)
        Me.LblCompteur.TabIndex = 23
        Me.LblCompteur.Text = "Compt"
        '
        'DgvRappelDuTicket
        '
        Me.DgvRappelDuTicket.AllowUserToDeleteRows = False
        Me.DgvRappelDuTicket.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvRappelDuTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRappelDuTicket.Location = New System.Drawing.Point(15, 92)
        Me.DgvRappelDuTicket.Name = "DgvRappelDuTicket"
        Me.DgvRappelDuTicket.ReadOnly = True
        Me.DgvRappelDuTicket.Size = New System.Drawing.Size(583, 88)
        Me.DgvRappelDuTicket.TabIndex = 56
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
        Me.Button1.Location = New System.Drawing.Point(604, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 28)
        Me.Button1.TabIndex = 54
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = Global.Caisse.My.Resources.Resources.Down
        Me.Button3.Location = New System.Drawing.Point(604, 135)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 26)
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
        Me.cmdFermer.Location = New System.Drawing.Point(569, 227)
        Me.cmdFermer.Name = "cmdFermer"
        Me.cmdFermer.Size = New System.Drawing.Size(125, 46)
        Me.cmdFermer.TabIndex = 216
        Me.cmdFermer.Text = "&Fermer"
        Me.cmdFermer.UseVisualStyleBackColor = False
        '
        'BtnValiderTicket
        '
        Me.BtnValiderTicket.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnValiderTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValiderTicket.Image = Global.Caisse.My.Resources.Resources.btEnregistrer32
        Me.BtnValiderTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnValiderTicket.Location = New System.Drawing.Point(23, 225)
        Me.BtnValiderTicket.Name = "BtnValiderTicket"
        Me.BtnValiderTicket.Size = New System.Drawing.Size(120, 46)
        Me.BtnValiderTicket.TabIndex = 1
        Me.BtnValiderTicket.Text = "Valider"
        Me.BtnValiderTicket.UseVisualStyleBackColor = False
        '
        'FrmRappelerTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(712, 281)
        Me.Controls.Add(Me.cmdFermer)
        Me.Controls.Add(Me.BtnValiderTicket)
        Me.Controls.Add(Me.TicketAttente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRappelerTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FBA"
        Me.TicketAttente.ResumeLayout(False)
        Me.TicketAttente.PerformLayout()
        CType(Me.DgvRappelDuTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TicketAttente As System.Windows.Forms.GroupBox
    Friend WithEvents BtnValiderTicket As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtlibellé As System.Windows.Forms.TextBox
    Friend WithEvents lbllibellé As System.Windows.Forms.Label
    Friend WithEvents cmdFermer As System.Windows.Forms.Button
    Friend WithEvents DgvRappelDuTicket As System.Windows.Forms.DataGridView
    Friend WithEvents LblCompteur As System.Windows.Forms.Label
End Class
