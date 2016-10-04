<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Encaissement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Encaissement))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtchoisirClient = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LblNomVendeur = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnEffacerReglement = New System.Windows.Forms.Button()
        Me.DgvReglement = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.BtnTickResto = New System.Windows.Forms.Button()
        Me.BtnCheque = New System.Windows.Forms.Button()
        Me.BtnCB = New System.Windows.Forms.Button()
        Me.BtnEspece = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TxtPavé = New System.Windows.Forms.TextBox()
        Me.BtnSixPave = New System.Windows.Forms.Button()
        Me.BtnTroisPave = New System.Windows.Forms.Button()
        Me.BtnpointPave = New System.Windows.Forms.Button()
        Me.BtnNeufPave = New System.Windows.Forms.Button()
        Me.BtnCinqPave = New System.Windows.Forms.Button()
        Me.BtnDeuxPave = New System.Windows.Forms.Button()
        Me.BtnZeroPave = New System.Windows.Forms.Button()
        Me.BtnhuitPave = New System.Windows.Forms.Button()
        Me.BtnQuatrePave = New System.Windows.Forms.Button()
        Me.BtnUnPave = New System.Windows.Forms.Button()
        Me.btnPlusmoinPave = New System.Windows.Forms.Button()
        Me.BtnSeptPave = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BtnSansImprimer = New System.Windows.Forms.Button()
        Me.BtnImprimerTicket = New System.Windows.Forms.Button()
        Me.BtnImprimerFacture = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtRemiseParArticle = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblRemiseGlobal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_A_Payer = New System.Windows.Forms.Label()
        Me.Lbl_A_Rendre = New System.Windows.Forms.Label()
        Me.Lbl_Montant_Reçu = New System.Windows.Forms.Label()
        Me.Lbl_Reste_A_Payer = New System.Windows.Forms.Label()
        Me.A_Rendre = New System.Windows.Forms.Label()
        Me.Montant_Reçu = New System.Windows.Forms.Label()
        Me.ResteaPayer = New System.Windows.Forms.Label()
        Me.A_Payer = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvReglement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtchoisirClient)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.LblNomVendeur)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 91)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(344, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "NB: Double Cliquez"
        '
        'txtchoisirClient
        '
        Me.txtchoisirClient.Enabled = False
        Me.txtchoisirClient.Location = New System.Drawing.Point(134, 25)
        Me.txtchoisirClient.Name = "txtchoisirClient"
        Me.txtchoisirClient.Size = New System.Drawing.Size(156, 20)
        Me.txtchoisirClient.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Image = Global.Caisse.My.Resources.Resources.btApercu32
        Me.Button2.Location = New System.Drawing.Point(304, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 27)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = False
        '
        'LblNomVendeur
        '
        Me.LblNomVendeur.AutoSize = True
        Me.LblNomVendeur.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomVendeur.Location = New System.Drawing.Point(99, 59)
        Me.LblNomVendeur.Name = "LblNomVendeur"
        Me.LblNomVendeur.Size = New System.Drawing.Size(71, 16)
        Me.LblNomVendeur.TabIndex = 3
        Me.LblNomVendeur.Text = "_________"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vendeur :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choisir Un Client :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnEffacerReglement)
        Me.GroupBox3.Controls.Add(Me.DgvReglement)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 369)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(501, 240)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'BtnEffacerReglement
        '
        Me.BtnEffacerReglement.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEffacerReglement.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEffacerReglement.Image = Global.Caisse.My.Resources.Resources.deleteCO
        Me.BtnEffacerReglement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEffacerReglement.Location = New System.Drawing.Point(134, 171)
        Me.BtnEffacerReglement.Name = "BtnEffacerReglement"
        Me.BtnEffacerReglement.Size = New System.Drawing.Size(239, 47)
        Me.BtnEffacerReglement.TabIndex = 8
        Me.BtnEffacerReglement.Text = "Effacer Reglement"
        Me.BtnEffacerReglement.UseVisualStyleBackColor = False
        '
        'DgvReglement
        '
        Me.DgvReglement.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvReglement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReglement.Location = New System.Drawing.Point(21, 39)
        Me.DgvReglement.Name = "DgvReglement"
        Me.DgvReglement.Size = New System.Drawing.Size(464, 126)
        Me.DgvReglement.TabIndex = 9
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox8)
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Location = New System.Drawing.Point(553, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(621, 334)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.BtnTickResto)
        Me.GroupBox8.Controls.Add(Me.BtnCheque)
        Me.GroupBox8.Controls.Add(Me.BtnCB)
        Me.GroupBox8.Controls.Add(Me.BtnEspece)
        Me.GroupBox8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(319, 47)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(292, 246)
        Me.GroupBox8.TabIndex = 2
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Mode De Payement"
        '
        'BtnTickResto
        '
        Me.BtnTickResto.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnTickResto.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTickResto.Image = Global.Caisse.My.Resources.Resources.ticketsRES
        Me.BtnTickResto.Location = New System.Drawing.Point(153, 148)
        Me.BtnTickResto.Name = "BtnTickResto"
        Me.BtnTickResto.Size = New System.Drawing.Size(123, 89)
        Me.BtnTickResto.TabIndex = 8
        Me.BtnTickResto.Tag = "4"
        Me.BtnTickResto.Text = "Tickét"
        Me.BtnTickResto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTickResto.UseVisualStyleBackColor = False
        '
        'BtnCheque
        '
        Me.BtnCheque.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCheque.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCheque.Image = Global.Caisse.My.Resources.Resources.check
        Me.BtnCheque.Location = New System.Drawing.Point(14, 149)
        Me.BtnCheque.Name = "BtnCheque"
        Me.BtnCheque.Size = New System.Drawing.Size(133, 89)
        Me.BtnCheque.TabIndex = 7
        Me.BtnCheque.Tag = "3"
        Me.BtnCheque.Text = "Chéque"
        Me.BtnCheque.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCheque.UseVisualStyleBackColor = False
        '
        'BtnCB
        '
        Me.BtnCB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCB.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCB.Image = Global.Caisse.My.Resources.Resources._credit_card
        Me.BtnCB.Location = New System.Drawing.Point(153, 29)
        Me.BtnCB.Name = "BtnCB"
        Me.BtnCB.Size = New System.Drawing.Size(123, 94)
        Me.BtnCB.TabIndex = 6
        Me.BtnCB.Tag = "2"
        Me.BtnCB.Text = "Carte Bancaire"
        Me.BtnCB.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCB.UseVisualStyleBackColor = False
        '
        'BtnEspece
        '
        Me.BtnEspece.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEspece.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEspece.Image = Global.Caisse.My.Resources.Resources.dolar
        Me.BtnEspece.Location = New System.Drawing.Point(14, 29)
        Me.BtnEspece.Name = "BtnEspece"
        Me.BtnEspece.Size = New System.Drawing.Size(133, 94)
        Me.BtnEspece.TabIndex = 5
        Me.BtnEspece.Tag = "1"
        Me.BtnEspece.Text = "Espece"
        Me.BtnEspece.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEspece.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TxtPavé)
        Me.GroupBox7.Controls.Add(Me.BtnSixPave)
        Me.GroupBox7.Controls.Add(Me.BtnTroisPave)
        Me.GroupBox7.Controls.Add(Me.BtnpointPave)
        Me.GroupBox7.Controls.Add(Me.BtnNeufPave)
        Me.GroupBox7.Controls.Add(Me.BtnCinqPave)
        Me.GroupBox7.Controls.Add(Me.BtnDeuxPave)
        Me.GroupBox7.Controls.Add(Me.BtnZeroPave)
        Me.GroupBox7.Controls.Add(Me.BtnhuitPave)
        Me.GroupBox7.Controls.Add(Me.BtnQuatrePave)
        Me.GroupBox7.Controls.Add(Me.BtnUnPave)
        Me.GroupBox7.Controls.Add(Me.btnPlusmoinPave)
        Me.GroupBox7.Controls.Add(Me.BtnSeptPave)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(16, 47)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(291, 249)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        '
        'TxtPavé
        '
        Me.TxtPavé.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPavé.Location = New System.Drawing.Point(16, 24)
        Me.TxtPavé.Multiline = True
        Me.TxtPavé.Name = "TxtPavé"
        Me.TxtPavé.Size = New System.Drawing.Size(251, 31)
        Me.TxtPavé.TabIndex = 68
        '
        'BtnSixPave
        '
        Me.BtnSixPave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSixPave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSixPave.ForeColor = System.Drawing.Color.Black
        Me.BtnSixPave.Location = New System.Drawing.Point(197, 108)
        Me.BtnSixPave.Name = "BtnSixPave"
        Me.BtnSixPave.Size = New System.Drawing.Size(70, 34)
        Me.BtnSixPave.TabIndex = 63
        Me.BtnSixPave.Text = "6"
        Me.BtnSixPave.UseVisualStyleBackColor = False
        '
        'BtnTroisPave
        '
        Me.BtnTroisPave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnTroisPave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTroisPave.ForeColor = System.Drawing.Color.Black
        Me.BtnTroisPave.Location = New System.Drawing.Point(197, 149)
        Me.BtnTroisPave.Name = "BtnTroisPave"
        Me.BtnTroisPave.Size = New System.Drawing.Size(71, 34)
        Me.BtnTroisPave.TabIndex = 62
        Me.BtnTroisPave.Text = "3"
        Me.BtnTroisPave.UseVisualStyleBackColor = False
        '
        'BtnpointPave
        '
        Me.BtnpointPave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnpointPave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnpointPave.ForeColor = System.Drawing.Color.Black
        Me.BtnpointPave.Location = New System.Drawing.Point(197, 189)
        Me.BtnpointPave.Name = "BtnpointPave"
        Me.BtnpointPave.Size = New System.Drawing.Size(71, 34)
        Me.BtnpointPave.TabIndex = 61
        Me.BtnpointPave.Text = "."
        Me.BtnpointPave.UseVisualStyleBackColor = False
        '
        'BtnNeufPave
        '
        Me.BtnNeufPave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnNeufPave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNeufPave.ForeColor = System.Drawing.Color.Black
        Me.BtnNeufPave.Location = New System.Drawing.Point(197, 67)
        Me.BtnNeufPave.Name = "BtnNeufPave"
        Me.BtnNeufPave.Size = New System.Drawing.Size(70, 34)
        Me.BtnNeufPave.TabIndex = 60
        Me.BtnNeufPave.Text = "9"
        Me.BtnNeufPave.UseVisualStyleBackColor = False
        '
        'BtnCinqPave
        '
        Me.BtnCinqPave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCinqPave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCinqPave.ForeColor = System.Drawing.Color.Black
        Me.BtnCinqPave.Location = New System.Drawing.Point(110, 108)
        Me.BtnCinqPave.Name = "BtnCinqPave"
        Me.BtnCinqPave.Size = New System.Drawing.Size(69, 34)
        Me.BtnCinqPave.TabIndex = 59
        Me.BtnCinqPave.Text = "5"
        Me.BtnCinqPave.UseVisualStyleBackColor = False
        '
        'BtnDeuxPave
        '
        Me.BtnDeuxPave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnDeuxPave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeuxPave.ForeColor = System.Drawing.Color.Black
        Me.BtnDeuxPave.Location = New System.Drawing.Point(110, 148)
        Me.BtnDeuxPave.Name = "BtnDeuxPave"
        Me.BtnDeuxPave.Size = New System.Drawing.Size(70, 34)
        Me.BtnDeuxPave.TabIndex = 58
        Me.BtnDeuxPave.Text = "2"
        Me.BtnDeuxPave.UseVisualStyleBackColor = False
        '
        'BtnZeroPave
        '
        Me.BtnZeroPave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnZeroPave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnZeroPave.ForeColor = System.Drawing.Color.Black
        Me.BtnZeroPave.Location = New System.Drawing.Point(110, 189)
        Me.BtnZeroPave.Name = "BtnZeroPave"
        Me.BtnZeroPave.Size = New System.Drawing.Size(70, 34)
        Me.BtnZeroPave.TabIndex = 57
        Me.BtnZeroPave.Text = "0"
        Me.BtnZeroPave.UseVisualStyleBackColor = False
        '
        'BtnhuitPave
        '
        Me.BtnhuitPave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnhuitPave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnhuitPave.ForeColor = System.Drawing.Color.Black
        Me.BtnhuitPave.Location = New System.Drawing.Point(110, 67)
        Me.BtnhuitPave.Name = "BtnhuitPave"
        Me.BtnhuitPave.Size = New System.Drawing.Size(69, 34)
        Me.BtnhuitPave.TabIndex = 56
        Me.BtnhuitPave.Text = "8"
        Me.BtnhuitPave.UseVisualStyleBackColor = False
        '
        'BtnQuatrePave
        '
        Me.BtnQuatrePave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnQuatrePave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuatrePave.ForeColor = System.Drawing.Color.Black
        Me.BtnQuatrePave.Location = New System.Drawing.Point(16, 108)
        Me.BtnQuatrePave.Name = "BtnQuatrePave"
        Me.BtnQuatrePave.Size = New System.Drawing.Size(73, 34)
        Me.BtnQuatrePave.TabIndex = 55
        Me.BtnQuatrePave.Text = "4"
        Me.BtnQuatrePave.UseVisualStyleBackColor = False
        '
        'BtnUnPave
        '
        Me.BtnUnPave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUnPave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUnPave.ForeColor = System.Drawing.Color.Black
        Me.BtnUnPave.Location = New System.Drawing.Point(16, 149)
        Me.BtnUnPave.Name = "BtnUnPave"
        Me.BtnUnPave.Size = New System.Drawing.Size(74, 34)
        Me.BtnUnPave.TabIndex = 54
        Me.BtnUnPave.Text = "1"
        Me.BtnUnPave.UseVisualStyleBackColor = False
        '
        'btnPlusmoinPave
        '
        Me.btnPlusmoinPave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPlusmoinPave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlusmoinPave.ForeColor = System.Drawing.Color.Black
        Me.btnPlusmoinPave.Location = New System.Drawing.Point(16, 189)
        Me.btnPlusmoinPave.Name = "btnPlusmoinPave"
        Me.btnPlusmoinPave.Size = New System.Drawing.Size(74, 34)
        Me.btnPlusmoinPave.TabIndex = 53
        Me.btnPlusmoinPave.Text = "+/-"
        Me.btnPlusmoinPave.UseVisualStyleBackColor = False
        '
        'BtnSeptPave
        '
        Me.BtnSeptPave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSeptPave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeptPave.ForeColor = System.Drawing.Color.Black
        Me.BtnSeptPave.Location = New System.Drawing.Point(16, 67)
        Me.BtnSeptPave.Name = "BtnSeptPave"
        Me.BtnSeptPave.Size = New System.Drawing.Size(73, 34)
        Me.BtnSeptPave.TabIndex = 52
        Me.BtnSeptPave.Text = "7"
        Me.BtnSeptPave.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BtnSansImprimer)
        Me.GroupBox6.Controls.Add(Me.BtnImprimerTicket)
        Me.GroupBox6.Controls.Add(Me.BtnImprimerFacture)
        Me.GroupBox6.Location = New System.Drawing.Point(554, 369)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(621, 174)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        '
        'BtnSansImprimer
        '
        Me.BtnSansImprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSansImprimer.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSansImprimer.Image = Global.Caisse.My.Resources.Resources.button_cancel3
        Me.BtnSansImprimer.Location = New System.Drawing.Point(422, 23)
        Me.BtnSansImprimer.Name = "BtnSansImprimer"
        Me.BtnSansImprimer.Size = New System.Drawing.Size(149, 125)
        Me.BtnSansImprimer.TabIndex = 9
        Me.BtnSansImprimer.Text = "Sans Imprimer "
        Me.BtnSansImprimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSansImprimer.UseVisualStyleBackColor = False
        '
        'BtnImprimerTicket
        '
        Me.BtnImprimerTicket.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnImprimerTicket.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimerTicket.Image = Global.Caisse.My.Resources.Resources.ticket3
        Me.BtnImprimerTicket.Location = New System.Drawing.Point(232, 23)
        Me.BtnImprimerTicket.Name = "BtnImprimerTicket"
        Me.BtnImprimerTicket.Size = New System.Drawing.Size(149, 125)
        Me.BtnImprimerTicket.TabIndex = 8
        Me.BtnImprimerTicket.Text = "Ticket"
        Me.BtnImprimerTicket.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnImprimerTicket.UseVisualStyleBackColor = False
        '
        'BtnImprimerFacture
        '
        Me.BtnImprimerFacture.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnImprimerFacture.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimerFacture.Image = Global.Caisse.My.Resources.Resources.Facture34
        Me.BtnImprimerFacture.Location = New System.Drawing.Point(30, 25)
        Me.BtnImprimerFacture.Name = "BtnImprimerFacture"
        Me.BtnImprimerFacture.Size = New System.Drawing.Size(149, 125)
        Me.BtnImprimerFacture.TabIndex = 7
        Me.BtnImprimerFacture.Text = "Facture"
        Me.BtnImprimerFacture.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnImprimerFacture.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TxtRemiseParArticle)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.LblRemiseGlobal)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Lbl_A_Payer)
        Me.GroupBox2.Controls.Add(Me.Lbl_A_Rendre)
        Me.GroupBox2.Controls.Add(Me.Lbl_Montant_Reçu)
        Me.GroupBox2.Controls.Add(Me.Lbl_Reste_A_Payer)
        Me.GroupBox2.Controls.Add(Me.A_Rendre)
        Me.GroupBox2.Controls.Add(Me.Montant_Reçu)
        Me.GroupBox2.Controls.Add(Me.ResteaPayer)
        Me.GroupBox2.Controls.Add(Me.A_Payer)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(501, 255)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(354, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "%"
        '
        'TxtRemiseParArticle
        '
        Me.TxtRemiseParArticle.AutoSize = True
        Me.TxtRemiseParArticle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRemiseParArticle.Location = New System.Drawing.Point(311, 75)
        Me.TxtRemiseParArticle.Name = "TxtRemiseParArticle"
        Me.TxtRemiseParArticle.Size = New System.Drawing.Size(17, 18)
        Me.TxtRemiseParArticle.TabIndex = 20
        Me.TxtRemiseParArticle.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(257, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Remise Par Atricle  =============>"
        '
        'LblRemiseGlobal
        '
        Me.LblRemiseGlobal.AutoSize = True
        Me.LblRemiseGlobal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemiseGlobal.Location = New System.Drawing.Point(311, 43)
        Me.LblRemiseGlobal.Name = "LblRemiseGlobal"
        Me.LblRemiseGlobal.Size = New System.Drawing.Size(17, 18)
        Me.LblRemiseGlobal.TabIndex = 18
        Me.LblRemiseGlobal.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(259, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Remise Global   ================>"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(245, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 30)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Dh"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(396, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 18)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Dh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(396, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Dh"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(396, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Dh"
        '
        'Lbl_A_Payer
        '
        Me.Lbl_A_Payer.AutoSize = True
        Me.Lbl_A_Payer.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_A_Payer.Location = New System.Drawing.Point(114, 202)
        Me.Lbl_A_Payer.Name = "Lbl_A_Payer"
        Me.Lbl_A_Payer.Size = New System.Drawing.Size(26, 30)
        Me.Lbl_A_Payer.TabIndex = 12
        Me.Lbl_A_Payer.Text = "0"
        '
        'Lbl_A_Rendre
        '
        Me.Lbl_A_Rendre.AutoSize = True
        Me.Lbl_A_Rendre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_A_Rendre.Location = New System.Drawing.Point(311, 170)
        Me.Lbl_A_Rendre.Name = "Lbl_A_Rendre"
        Me.Lbl_A_Rendre.Size = New System.Drawing.Size(17, 18)
        Me.Lbl_A_Rendre.TabIndex = 11
        Me.Lbl_A_Rendre.Text = "0"
        '
        'Lbl_Montant_Reçu
        '
        Me.Lbl_Montant_Reçu.AutoSize = True
        Me.Lbl_Montant_Reçu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Montant_Reçu.Location = New System.Drawing.Point(311, 138)
        Me.Lbl_Montant_Reçu.Name = "Lbl_Montant_Reçu"
        Me.Lbl_Montant_Reçu.Size = New System.Drawing.Size(17, 18)
        Me.Lbl_Montant_Reçu.TabIndex = 10
        Me.Lbl_Montant_Reçu.Text = "0"
        '
        'Lbl_Reste_A_Payer
        '
        Me.Lbl_Reste_A_Payer.AutoSize = True
        Me.Lbl_Reste_A_Payer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Reste_A_Payer.Location = New System.Drawing.Point(311, 107)
        Me.Lbl_Reste_A_Payer.Name = "Lbl_Reste_A_Payer"
        Me.Lbl_Reste_A_Payer.Size = New System.Drawing.Size(17, 18)
        Me.Lbl_Reste_A_Payer.TabIndex = 9
        Me.Lbl_Reste_A_Payer.Text = "0"
        '
        'A_Rendre
        '
        Me.A_Rendre.AutoSize = True
        Me.A_Rendre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_Rendre.Location = New System.Drawing.Point(20, 172)
        Me.A_Rendre.Name = "A_Rendre"
        Me.A_Rendre.Size = New System.Drawing.Size(257, 16)
        Me.A_Rendre.TabIndex = 6
        Me.A_Rendre.Text = "A Rendre  =====================>"
        '
        'Montant_Reçu
        '
        Me.Montant_Reçu.AutoSize = True
        Me.Montant_Reçu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Montant_Reçu.Location = New System.Drawing.Point(19, 140)
        Me.Montant_Reçu.Name = "Montant_Reçu"
        Me.Montant_Reçu.Size = New System.Drawing.Size(258, 16)
        Me.Montant_Reçu.TabIndex = 5
        Me.Montant_Reçu.Text = "Montant Reçu   =================>"
        '
        'ResteaPayer
        '
        Me.ResteaPayer.AutoSize = True
        Me.ResteaPayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResteaPayer.Location = New System.Drawing.Point(18, 109)
        Me.ResteaPayer.Name = "ResteaPayer"
        Me.ResteaPayer.Size = New System.Drawing.Size(259, 16)
        Me.ResteaPayer.TabIndex = 3
        Me.ResteaPayer.Text = "Reste a Payer  =================>"
        '
        'A_Payer
        '
        Me.A_Payer.AutoSize = True
        Me.A_Payer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_Payer.Location = New System.Drawing.Point(20, 212)
        Me.A_Payer.Name = "A_Payer"
        Me.A_Payer.Size = New System.Drawing.Size(75, 16)
        Me.A_Payer.TabIndex = 1
        Me.A_Payer.Text = "A Payer : "
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Caisse.My.Resources.Resources.Log_Out2
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(1044, 562)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 47)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Femer"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Encaissement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1186, 629)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Encaissement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FBA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvReglement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents LblNomVendeur As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgvReglement As System.Windows.Forms.DataGridView
    Friend WithEvents BtnEffacerReglement As System.Windows.Forms.Button
    Friend WithEvents BtnTickResto As System.Windows.Forms.Button
    Friend WithEvents BtnCheque As System.Windows.Forms.Button
    Friend WithEvents BtnCB As System.Windows.Forms.Button
    Friend WithEvents BtnEspece As System.Windows.Forms.Button
    Friend WithEvents BtnSansImprimer As System.Windows.Forms.Button
    Friend WithEvents BtnImprimerTicket As System.Windows.Forms.Button
    Friend WithEvents BtnImprimerFacture As System.Windows.Forms.Button
    Friend WithEvents TxtPavé As System.Windows.Forms.TextBox
    Friend WithEvents BtnSixPave As System.Windows.Forms.Button
    Friend WithEvents BtnTroisPave As System.Windows.Forms.Button
    Friend WithEvents BtnpointPave As System.Windows.Forms.Button
    Friend WithEvents BtnNeufPave As System.Windows.Forms.Button
    Friend WithEvents BtnCinqPave As System.Windows.Forms.Button
    Friend WithEvents BtnDeuxPave As System.Windows.Forms.Button
    Friend WithEvents BtnZeroPave As System.Windows.Forms.Button
    Friend WithEvents BtnhuitPave As System.Windows.Forms.Button
    Friend WithEvents BtnQuatrePave As System.Windows.Forms.Button
    Friend WithEvents BtnUnPave As System.Windows.Forms.Button
    Friend WithEvents btnPlusmoinPave As System.Windows.Forms.Button
    Friend WithEvents BtnSeptPave As System.Windows.Forms.Button
    Friend WithEvents txtchoisirClient As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_A_Payer As System.Windows.Forms.Label
    Friend WithEvents Lbl_A_Rendre As System.Windows.Forms.Label
    Friend WithEvents Lbl_Montant_Reçu As System.Windows.Forms.Label
    Friend WithEvents Lbl_Reste_A_Payer As System.Windows.Forms.Label
    Friend WithEvents A_Rendre As System.Windows.Forms.Label
    Friend WithEvents Montant_Reçu As System.Windows.Forms.Label
    Friend WithEvents ResteaPayer As System.Windows.Forms.Label
    Friend WithEvents A_Payer As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtRemiseParArticle As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblRemiseGlobal As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
