<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCloturerLaCaisse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCloturerLaCaisse))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtEtat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtRemarque = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtFondCaisseCloture = New System.Windows.Forms.TextBox()
        Me.TxtRemiseCloture = New System.Windows.Forms.TextBox()
        Me.TxtTickResCloture = New System.Windows.Forms.TextBox()
        Me.TxtCBcloture = New System.Windows.Forms.TextBox()
        Me.txtChequeCloture = New System.Windows.Forms.TextBox()
        Me.TxtEspeceCloture = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnValiderCloture = New System.Windows.Forms.Button()
        Me.BtnAnnulerCloture = New System.Windows.Forms.Button()
        Me.LblCaisseID = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtEtat)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtRemarque)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtFondCaisseCloture)
        Me.GroupBox1.Controls.Add(Me.TxtRemiseCloture)
        Me.GroupBox1.Controls.Add(Me.TxtTickResCloture)
        Me.GroupBox1.Controls.Add(Me.TxtCBcloture)
        Me.GroupBox1.Controls.Add(Me.txtChequeCloture)
        Me.GroupBox1.Controls.Add(Me.TxtEspeceCloture)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 255)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TxtEtat
        '
        Me.TxtEtat.Location = New System.Drawing.Point(162, 223)
        Me.TxtEtat.Name = "TxtEtat"
        Me.TxtEtat.Size = New System.Drawing.Size(124, 20)
        Me.TxtEtat.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Etat :"
        '
        'TxtRemarque
        '
        Me.TxtRemarque.Location = New System.Drawing.Point(312, 40)
        Me.TxtRemarque.Name = "TxtRemarque"
        Me.TxtRemarque.Size = New System.Drawing.Size(112, 203)
        Me.TxtRemarque.TabIndex = 12
        Me.TxtRemarque.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(321, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Remarque :"
        '
        'TxtFondCaisseCloture
        '
        Me.TxtFondCaisseCloture.Location = New System.Drawing.Point(162, 189)
        Me.TxtFondCaisseCloture.Name = "TxtFondCaisseCloture"
        Me.TxtFondCaisseCloture.Size = New System.Drawing.Size(124, 20)
        Me.TxtFondCaisseCloture.TabIndex = 10
        '
        'TxtRemiseCloture
        '
        Me.TxtRemiseCloture.Location = New System.Drawing.Point(162, 154)
        Me.TxtRemiseCloture.Name = "TxtRemiseCloture"
        Me.TxtRemiseCloture.Size = New System.Drawing.Size(124, 20)
        Me.TxtRemiseCloture.TabIndex = 10
        '
        'TxtTickResCloture
        '
        Me.TxtTickResCloture.Location = New System.Drawing.Point(162, 117)
        Me.TxtTickResCloture.Name = "TxtTickResCloture"
        Me.TxtTickResCloture.Size = New System.Drawing.Size(124, 20)
        Me.TxtTickResCloture.TabIndex = 9
        '
        'TxtCBcloture
        '
        Me.TxtCBcloture.Location = New System.Drawing.Point(162, 83)
        Me.TxtCBcloture.Name = "TxtCBcloture"
        Me.TxtCBcloture.Size = New System.Drawing.Size(124, 20)
        Me.TxtCBcloture.TabIndex = 8
        '
        'txtChequeCloture
        '
        Me.txtChequeCloture.Location = New System.Drawing.Point(162, 49)
        Me.txtChequeCloture.Name = "txtChequeCloture"
        Me.txtChequeCloture.Size = New System.Drawing.Size(124, 20)
        Me.txtChequeCloture.TabIndex = 7
        '
        'TxtEspeceCloture
        '
        Me.TxtEspeceCloture.Location = New System.Drawing.Point(162, 17)
        Me.TxtEspeceCloture.Name = "TxtEspeceCloture"
        Me.TxtEspeceCloture.Size = New System.Drawing.Size(124, 20)
        Me.TxtEspeceCloture.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Fond De Caisse : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Remise : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ticket Restaurant : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Espece : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cheque : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Carte Bancaire : "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 53)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vérifier Avant de Cloture"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnValiderCloture)
        Me.GroupBox3.Controls.Add(Me.BtnAnnulerCloture)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 364)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(440, 64)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'BtnValiderCloture
        '
        Me.BtnValiderCloture.BackColor = System.Drawing.Color.Silver
        Me.BtnValiderCloture.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValiderCloture.Image = Global.Caisse.My.Resources.Resources.Valide2
        Me.BtnValiderCloture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnValiderCloture.Location = New System.Drawing.Point(13, 19)
        Me.BtnValiderCloture.Name = "BtnValiderCloture"
        Me.BtnValiderCloture.Size = New System.Drawing.Size(122, 39)
        Me.BtnValiderCloture.TabIndex = 2
        Me.BtnValiderCloture.Text = "Valider"
        Me.BtnValiderCloture.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnValiderCloture.UseVisualStyleBackColor = False
        '
        'BtnAnnulerCloture
        '
        Me.BtnAnnulerCloture.BackColor = System.Drawing.Color.Silver
        Me.BtnAnnulerCloture.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnnulerCloture.Image = Global.Caisse.My.Resources.Resources.Delete
        Me.BtnAnnulerCloture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnnulerCloture.Location = New System.Drawing.Point(300, 19)
        Me.BtnAnnulerCloture.Name = "BtnAnnulerCloture"
        Me.BtnAnnulerCloture.Size = New System.Drawing.Size(109, 37)
        Me.BtnAnnulerCloture.TabIndex = 1
        Me.BtnAnnulerCloture.Text = "Annuler"
        Me.BtnAnnulerCloture.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAnnulerCloture.UseVisualStyleBackColor = False
        '
        'LblCaisseID
        '
        Me.LblCaisseID.AutoSize = True
        Me.LblCaisseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCaisseID.Location = New System.Drawing.Point(201, 79)
        Me.LblCaisseID.Name = "LblCaisseID"
        Me.LblCaisseID.Size = New System.Drawing.Size(63, 20)
        Me.LblCaisseID.TabIndex = 3
        Me.LblCaisseID.Text = "Caisse"
        '
        'FrmCloturerLaCaisse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(476, 448)
        Me.Controls.Add(Me.LblCaisseID)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCloturerLaCaisse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FBA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtRemiseCloture As System.Windows.Forms.TextBox
    Friend WithEvents TxtTickResCloture As System.Windows.Forms.TextBox
    Friend WithEvents TxtCBcloture As System.Windows.Forms.TextBox
    Friend WithEvents txtChequeCloture As System.Windows.Forms.TextBox
    Friend WithEvents TxtEspeceCloture As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAnnulerCloture As System.Windows.Forms.Button
    Friend WithEvents BtnValiderCloture As System.Windows.Forms.Button
    Friend WithEvents TxtFondCaisseCloture As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblCaisseID As System.Windows.Forms.Label
    Friend WithEvents TxtEtat As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtRemarque As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
