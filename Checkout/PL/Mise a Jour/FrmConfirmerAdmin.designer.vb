<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfirmerAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfirmerAdmin))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtMotDePasse = New System.Windows.Forms.TextBox()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.TimerProgresse = New System.Windows.Forms.Timer(Me.components)
        Me.GrbNumeroMotsPass = New System.Windows.Forms.GroupBox()
        Me.BtnZERO = New System.Windows.Forms.Button()
        Me.BtnDEUX = New System.Windows.Forms.Button()
        Me.BtnUN = New System.Windows.Forms.Button()
        Me.BtnTROIS = New System.Windows.Forms.Button()
        Me.BtnCINQ = New System.Windows.Forms.Button()
        Me.BtnQUATRE = New System.Windows.Forms.Button()
        Me.BtnSIX = New System.Windows.Forms.Button()
        Me.BtnSEPT = New System.Windows.Forms.Button()
        Me.BtnHUIT = New System.Windows.Forms.Button()
        Me.BtnNEUF = New System.Windows.Forms.Button()
        Me.GrbLettreMotsDepass = New System.Windows.Forms.GroupBox()
        Me.BtnA = New System.Windows.Forms.Button()
        Me.BtnJ = New System.Windows.Forms.Button()
        Me.BtnS = New System.Windows.Forms.Button()
        Me.BtnC = New System.Windows.Forms.Button()
        Me.BtnL = New System.Windows.Forms.Button()
        Me.BtnU = New System.Windows.Forms.Button()
        Me.BtnB = New System.Windows.Forms.Button()
        Me.BtnK = New System.Windows.Forms.Button()
        Me.BtnT = New System.Windows.Forms.Button()
        Me.BtnD = New System.Windows.Forms.Button()
        Me.BtnM = New System.Windows.Forms.Button()
        Me.BtnV = New System.Windows.Forms.Button()
        Me.BtnF = New System.Windows.Forms.Button()
        Me.BtnO = New System.Windows.Forms.Button()
        Me.BtnX = New System.Windows.Forms.Button()
        Me.BtnE = New System.Windows.Forms.Button()
        Me.BtnN = New System.Windows.Forms.Button()
        Me.BtnW = New System.Windows.Forms.Button()
        Me.BtnG = New System.Windows.Forms.Button()
        Me.BtnP = New System.Windows.Forms.Button()
        Me.BtnY = New System.Windows.Forms.Button()
        Me.BtnH = New System.Windows.Forms.Button()
        Me.BtnQ = New System.Windows.Forms.Button()
        Me.BtnZ = New System.Windows.Forms.Button()
        Me.BtnI = New System.Windows.Forms.Button()
        Me.BtnR = New System.Windows.Forms.Button()
        Me.BtnUperToLower = New System.Windows.Forms.Button()
        Me.BtnSpace = New System.Windows.Forms.Button()
        Me.BtnVIDER = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GrbNumeroMotsPass.SuspendLayout()
        Me.GrbLettreMotsDepass.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GrbLettreMotsDepass)
        Me.GroupBox1.Controls.Add(Me.GrbNumeroMotsPass)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.txtMotDePasse)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnAnnuler)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnValider)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(734, 476)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(601, 437)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(107, 24)
        Me.ProgressBar1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 455)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Veuillez-vous identifier."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Identification"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Enabled = False
        Me.Button1.Image = Global.Caisse.My.Resources.Resources._1334595482_application_pgp_signature
        Me.Button1.Location = New System.Drawing.Point(17, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 49)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtMotDePasse
        '
        Me.txtMotDePasse.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotDePasse.Location = New System.Drawing.Point(225, 89)
        Me.txtMotDePasse.Multiline = True
        Me.txtMotDePasse.Name = "txtMotDePasse"
        Me.txtMotDePasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMotDePasse.Size = New System.Drawing.Size(221, 23)
        Me.txtMotDePasse.TabIndex = 5
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnuler.Image = Global.Caisse.My.Resources.Resources.btFermer32
        Me.btnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnnuler.Location = New System.Drawing.Point(599, 77)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(109, 41)
        Me.btnAnnuler.TabIndex = 1
        Me.btnAnnuler.Text = "Fermer"
        Me.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mot de passe :"
        '
        'btnValider
        '
        Me.btnValider.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValider.Image = Global.Caisse.My.Resources.Resources.btEnregistrer32
        Me.btnValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnValider.Location = New System.Drawing.Point(467, 78)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(113, 40)
        Me.btnValider.TabIndex = 0
        Me.btnValider.Text = "Valider"
        Me.btnValider.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnValider.UseVisualStyleBackColor = False
        '
        'TimerProgresse
        '
        '
        'GrbNumeroMotsPass
        '
        Me.GrbNumeroMotsPass.Controls.Add(Me.BtnNEUF)
        Me.GrbNumeroMotsPass.Controls.Add(Me.BtnZERO)
        Me.GrbNumeroMotsPass.Controls.Add(Me.BtnHUIT)
        Me.GrbNumeroMotsPass.Controls.Add(Me.BtnSEPT)
        Me.GrbNumeroMotsPass.Controls.Add(Me.BtnSIX)
        Me.GrbNumeroMotsPass.Controls.Add(Me.BtnQUATRE)
        Me.GrbNumeroMotsPass.Controls.Add(Me.BtnCINQ)
        Me.GrbNumeroMotsPass.Controls.Add(Me.BtnTROIS)
        Me.GrbNumeroMotsPass.Controls.Add(Me.BtnUN)
        Me.GrbNumeroMotsPass.Controls.Add(Me.BtnDEUX)
        Me.GrbNumeroMotsPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrbNumeroMotsPass.Location = New System.Drawing.Point(17, 350)
        Me.GrbNumeroMotsPass.Name = "GrbNumeroMotsPass"
        Me.GrbNumeroMotsPass.Size = New System.Drawing.Size(693, 69)
        Me.GrbNumeroMotsPass.TabIndex = 120
        Me.GrbNumeroMotsPass.TabStop = False
        '
        'BtnZERO
        '
        Me.BtnZERO.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnZERO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnZERO.ForeColor = System.Drawing.Color.Black
        Me.BtnZERO.Location = New System.Drawing.Point(7, 12)
        Me.BtnZERO.Name = "BtnZERO"
        Me.BtnZERO.Size = New System.Drawing.Size(61, 54)
        Me.BtnZERO.TabIndex = 119
        Me.BtnZERO.Tag = ""
        Me.BtnZERO.Text = "0"
        Me.BtnZERO.UseVisualStyleBackColor = False
        '
        'BtnDEUX
        '
        Me.BtnDEUX.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnDEUX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDEUX.ForeColor = System.Drawing.Color.Black
        Me.BtnDEUX.Location = New System.Drawing.Point(141, 12)
        Me.BtnDEUX.Name = "BtnDEUX"
        Me.BtnDEUX.Size = New System.Drawing.Size(61, 54)
        Me.BtnDEUX.TabIndex = 120
        Me.BtnDEUX.Tag = ""
        Me.BtnDEUX.Text = "2"
        Me.BtnDEUX.UseVisualStyleBackColor = False
        '
        'BtnUN
        '
        Me.BtnUN.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUN.ForeColor = System.Drawing.Color.Black
        Me.BtnUN.Location = New System.Drawing.Point(74, 12)
        Me.BtnUN.Name = "BtnUN"
        Me.BtnUN.Size = New System.Drawing.Size(61, 54)
        Me.BtnUN.TabIndex = 121
        Me.BtnUN.Tag = ""
        Me.BtnUN.Text = "1"
        Me.BtnUN.UseVisualStyleBackColor = False
        '
        'BtnTROIS
        '
        Me.BtnTROIS.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnTROIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTROIS.ForeColor = System.Drawing.Color.Black
        Me.BtnTROIS.Location = New System.Drawing.Point(208, 12)
        Me.BtnTROIS.Name = "BtnTROIS"
        Me.BtnTROIS.Size = New System.Drawing.Size(61, 54)
        Me.BtnTROIS.TabIndex = 122
        Me.BtnTROIS.Tag = ""
        Me.BtnTROIS.Text = "3"
        Me.BtnTROIS.UseVisualStyleBackColor = False
        '
        'BtnCINQ
        '
        Me.BtnCINQ.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCINQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCINQ.ForeColor = System.Drawing.Color.Black
        Me.BtnCINQ.Location = New System.Drawing.Point(343, 12)
        Me.BtnCINQ.Name = "BtnCINQ"
        Me.BtnCINQ.Size = New System.Drawing.Size(61, 54)
        Me.BtnCINQ.TabIndex = 123
        Me.BtnCINQ.Tag = ""
        Me.BtnCINQ.Text = "5"
        Me.BtnCINQ.UseVisualStyleBackColor = False
        '
        'BtnQUATRE
        '
        Me.BtnQUATRE.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnQUATRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQUATRE.ForeColor = System.Drawing.Color.Black
        Me.BtnQUATRE.Location = New System.Drawing.Point(276, 12)
        Me.BtnQUATRE.Name = "BtnQUATRE"
        Me.BtnQUATRE.Size = New System.Drawing.Size(61, 54)
        Me.BtnQUATRE.TabIndex = 124
        Me.BtnQUATRE.Tag = ""
        Me.BtnQUATRE.Text = "4"
        Me.BtnQUATRE.UseVisualStyleBackColor = False
        '
        'BtnSIX
        '
        Me.BtnSIX.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSIX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSIX.ForeColor = System.Drawing.Color.Black
        Me.BtnSIX.Location = New System.Drawing.Point(410, 12)
        Me.BtnSIX.Name = "BtnSIX"
        Me.BtnSIX.Size = New System.Drawing.Size(61, 54)
        Me.BtnSIX.TabIndex = 125
        Me.BtnSIX.Tag = ""
        Me.BtnSIX.Text = "6"
        Me.BtnSIX.UseVisualStyleBackColor = False
        '
        'BtnSEPT
        '
        Me.BtnSEPT.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSEPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSEPT.ForeColor = System.Drawing.Color.Black
        Me.BtnSEPT.Location = New System.Drawing.Point(477, 12)
        Me.BtnSEPT.Name = "BtnSEPT"
        Me.BtnSEPT.Size = New System.Drawing.Size(61, 54)
        Me.BtnSEPT.TabIndex = 126
        Me.BtnSEPT.Tag = ""
        Me.BtnSEPT.Text = "7"
        Me.BtnSEPT.UseVisualStyleBackColor = False
        '
        'BtnHUIT
        '
        Me.BtnHUIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnHUIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHUIT.ForeColor = System.Drawing.Color.Black
        Me.BtnHUIT.Location = New System.Drawing.Point(549, 12)
        Me.BtnHUIT.Name = "BtnHUIT"
        Me.BtnHUIT.Size = New System.Drawing.Size(61, 54)
        Me.BtnHUIT.TabIndex = 127
        Me.BtnHUIT.Tag = ""
        Me.BtnHUIT.Text = "8"
        Me.BtnHUIT.UseVisualStyleBackColor = False
        '
        'BtnNEUF
        '
        Me.BtnNEUF.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnNEUF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNEUF.ForeColor = System.Drawing.Color.Black
        Me.BtnNEUF.Location = New System.Drawing.Point(623, 12)
        Me.BtnNEUF.Name = "BtnNEUF"
        Me.BtnNEUF.Size = New System.Drawing.Size(61, 54)
        Me.BtnNEUF.TabIndex = 128
        Me.BtnNEUF.Tag = ""
        Me.BtnNEUF.Text = "9"
        Me.BtnNEUF.UseVisualStyleBackColor = False
        '
        'GrbLettreMotsDepass
        '
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnVIDER)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnSpace)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnUperToLower)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnR)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnI)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnZ)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnQ)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnH)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnY)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnP)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnG)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnW)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnN)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnE)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnX)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnO)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnF)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnV)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnM)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnD)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnT)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnK)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnB)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnU)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnL)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnC)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnS)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnJ)
        Me.GrbLettreMotsDepass.Controls.Add(Me.BtnA)
        Me.GrbLettreMotsDepass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrbLettreMotsDepass.Location = New System.Drawing.Point(17, 132)
        Me.GrbLettreMotsDepass.Name = "GrbLettreMotsDepass"
        Me.GrbLettreMotsDepass.Size = New System.Drawing.Size(691, 203)
        Me.GrbLettreMotsDepass.TabIndex = 121
        Me.GrbLettreMotsDepass.TabStop = False
        '
        'BtnA
        '
        Me.BtnA.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnA.ForeColor = System.Drawing.Color.Black
        Me.BtnA.Location = New System.Drawing.Point(6, 13)
        Me.BtnA.Name = "BtnA"
        Me.BtnA.Size = New System.Drawing.Size(61, 57)
        Me.BtnA.TabIndex = 120
        Me.BtnA.Tag = "a"
        Me.BtnA.Text = "A"
        Me.BtnA.UseVisualStyleBackColor = False
        '
        'BtnJ
        '
        Me.BtnJ.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJ.ForeColor = System.Drawing.Color.Black
        Me.BtnJ.Location = New System.Drawing.Point(6, 73)
        Me.BtnJ.Name = "BtnJ"
        Me.BtnJ.Size = New System.Drawing.Size(61, 57)
        Me.BtnJ.TabIndex = 121
        Me.BtnJ.Tag = "j"
        Me.BtnJ.Text = "J"
        Me.BtnJ.UseVisualStyleBackColor = False
        '
        'BtnS
        '
        Me.BtnS.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnS.ForeColor = System.Drawing.Color.Black
        Me.BtnS.Location = New System.Drawing.Point(6, 133)
        Me.BtnS.Name = "BtnS"
        Me.BtnS.Size = New System.Drawing.Size(61, 57)
        Me.BtnS.TabIndex = 122
        Me.BtnS.Tag = "s"
        Me.BtnS.Text = "S"
        Me.BtnS.UseVisualStyleBackColor = False
        '
        'BtnC
        '
        Me.BtnC.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnC.ForeColor = System.Drawing.Color.Black
        Me.BtnC.Location = New System.Drawing.Point(141, 13)
        Me.BtnC.Name = "BtnC"
        Me.BtnC.Size = New System.Drawing.Size(61, 57)
        Me.BtnC.TabIndex = 123
        Me.BtnC.Tag = "c"
        Me.BtnC.Text = "C"
        Me.BtnC.UseVisualStyleBackColor = False
        '
        'BtnL
        '
        Me.BtnL.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnL.ForeColor = System.Drawing.Color.Black
        Me.BtnL.Location = New System.Drawing.Point(141, 73)
        Me.BtnL.Name = "BtnL"
        Me.BtnL.Size = New System.Drawing.Size(61, 57)
        Me.BtnL.TabIndex = 124
        Me.BtnL.Tag = "l"
        Me.BtnL.Text = "L"
        Me.BtnL.UseVisualStyleBackColor = False
        '
        'BtnU
        '
        Me.BtnU.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnU.ForeColor = System.Drawing.Color.Black
        Me.BtnU.Location = New System.Drawing.Point(141, 133)
        Me.BtnU.Name = "BtnU"
        Me.BtnU.Size = New System.Drawing.Size(61, 57)
        Me.BtnU.TabIndex = 125
        Me.BtnU.Tag = "u"
        Me.BtnU.Text = "U"
        Me.BtnU.UseVisualStyleBackColor = False
        '
        'BtnB
        '
        Me.BtnB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnB.ForeColor = System.Drawing.Color.Black
        Me.BtnB.Location = New System.Drawing.Point(74, 13)
        Me.BtnB.Name = "BtnB"
        Me.BtnB.Size = New System.Drawing.Size(61, 57)
        Me.BtnB.TabIndex = 126
        Me.BtnB.Tag = "b"
        Me.BtnB.Text = "B"
        Me.BtnB.UseVisualStyleBackColor = False
        '
        'BtnK
        '
        Me.BtnK.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnK.ForeColor = System.Drawing.Color.Black
        Me.BtnK.Location = New System.Drawing.Point(74, 73)
        Me.BtnK.Name = "BtnK"
        Me.BtnK.Size = New System.Drawing.Size(61, 57)
        Me.BtnK.TabIndex = 127
        Me.BtnK.Tag = "k"
        Me.BtnK.Text = "K"
        Me.BtnK.UseVisualStyleBackColor = False
        '
        'BtnT
        '
        Me.BtnT.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnT.ForeColor = System.Drawing.Color.Black
        Me.BtnT.Location = New System.Drawing.Point(74, 133)
        Me.BtnT.Name = "BtnT"
        Me.BtnT.Size = New System.Drawing.Size(61, 57)
        Me.BtnT.TabIndex = 128
        Me.BtnT.Tag = "t"
        Me.BtnT.Text = "T"
        Me.BtnT.UseVisualStyleBackColor = False
        '
        'BtnD
        '
        Me.BtnD.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnD.ForeColor = System.Drawing.Color.Black
        Me.BtnD.Location = New System.Drawing.Point(208, 13)
        Me.BtnD.Name = "BtnD"
        Me.BtnD.Size = New System.Drawing.Size(61, 57)
        Me.BtnD.TabIndex = 129
        Me.BtnD.Tag = "d"
        Me.BtnD.Text = "D"
        Me.BtnD.UseVisualStyleBackColor = False
        '
        'BtnM
        '
        Me.BtnM.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnM.ForeColor = System.Drawing.Color.Black
        Me.BtnM.Location = New System.Drawing.Point(208, 73)
        Me.BtnM.Name = "BtnM"
        Me.BtnM.Size = New System.Drawing.Size(61, 57)
        Me.BtnM.TabIndex = 130
        Me.BtnM.Tag = "m"
        Me.BtnM.Text = "M"
        Me.BtnM.UseVisualStyleBackColor = False
        '
        'BtnV
        '
        Me.BtnV.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnV.ForeColor = System.Drawing.Color.Black
        Me.BtnV.Location = New System.Drawing.Point(208, 133)
        Me.BtnV.Name = "BtnV"
        Me.BtnV.Size = New System.Drawing.Size(61, 57)
        Me.BtnV.TabIndex = 131
        Me.BtnV.Tag = "v"
        Me.BtnV.Text = "V"
        Me.BtnV.UseVisualStyleBackColor = False
        '
        'BtnF
        '
        Me.BtnF.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnF.ForeColor = System.Drawing.Color.Black
        Me.BtnF.Location = New System.Drawing.Point(343, 13)
        Me.BtnF.Name = "BtnF"
        Me.BtnF.Size = New System.Drawing.Size(61, 57)
        Me.BtnF.TabIndex = 132
        Me.BtnF.Tag = "f"
        Me.BtnF.Text = "F"
        Me.BtnF.UseVisualStyleBackColor = False
        '
        'BtnO
        '
        Me.BtnO.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnO.ForeColor = System.Drawing.Color.Black
        Me.BtnO.Location = New System.Drawing.Point(343, 73)
        Me.BtnO.Name = "BtnO"
        Me.BtnO.Size = New System.Drawing.Size(61, 57)
        Me.BtnO.TabIndex = 133
        Me.BtnO.Tag = "o"
        Me.BtnO.Text = "O"
        Me.BtnO.UseVisualStyleBackColor = False
        '
        'BtnX
        '
        Me.BtnX.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnX.ForeColor = System.Drawing.Color.Black
        Me.BtnX.Location = New System.Drawing.Point(343, 133)
        Me.BtnX.Name = "BtnX"
        Me.BtnX.Size = New System.Drawing.Size(61, 57)
        Me.BtnX.TabIndex = 134
        Me.BtnX.Tag = "x"
        Me.BtnX.Text = "X"
        Me.BtnX.UseVisualStyleBackColor = False
        '
        'BtnE
        '
        Me.BtnE.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnE.ForeColor = System.Drawing.Color.Black
        Me.BtnE.Location = New System.Drawing.Point(276, 13)
        Me.BtnE.Name = "BtnE"
        Me.BtnE.Size = New System.Drawing.Size(61, 57)
        Me.BtnE.TabIndex = 135
        Me.BtnE.Tag = "e"
        Me.BtnE.Text = "E"
        Me.BtnE.UseVisualStyleBackColor = False
        '
        'BtnN
        '
        Me.BtnN.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnN.ForeColor = System.Drawing.Color.Black
        Me.BtnN.Location = New System.Drawing.Point(276, 73)
        Me.BtnN.Name = "BtnN"
        Me.BtnN.Size = New System.Drawing.Size(61, 57)
        Me.BtnN.TabIndex = 136
        Me.BtnN.Tag = "n"
        Me.BtnN.Text = "N"
        Me.BtnN.UseVisualStyleBackColor = False
        '
        'BtnW
        '
        Me.BtnW.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnW.ForeColor = System.Drawing.Color.Black
        Me.BtnW.Location = New System.Drawing.Point(276, 133)
        Me.BtnW.Name = "BtnW"
        Me.BtnW.Size = New System.Drawing.Size(61, 57)
        Me.BtnW.TabIndex = 137
        Me.BtnW.Tag = "w"
        Me.BtnW.Text = "W"
        Me.BtnW.UseVisualStyleBackColor = False
        '
        'BtnG
        '
        Me.BtnG.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnG.ForeColor = System.Drawing.Color.Black
        Me.BtnG.Location = New System.Drawing.Point(410, 13)
        Me.BtnG.Name = "BtnG"
        Me.BtnG.Size = New System.Drawing.Size(61, 57)
        Me.BtnG.TabIndex = 138
        Me.BtnG.Tag = "g"
        Me.BtnG.Text = "G"
        Me.BtnG.UseVisualStyleBackColor = False
        '
        'BtnP
        '
        Me.BtnP.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnP.ForeColor = System.Drawing.Color.Black
        Me.BtnP.Location = New System.Drawing.Point(410, 73)
        Me.BtnP.Name = "BtnP"
        Me.BtnP.Size = New System.Drawing.Size(61, 57)
        Me.BtnP.TabIndex = 139
        Me.BtnP.Tag = "p"
        Me.BtnP.Text = "P"
        Me.BtnP.UseVisualStyleBackColor = False
        '
        'BtnY
        '
        Me.BtnY.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnY.ForeColor = System.Drawing.Color.Black
        Me.BtnY.Location = New System.Drawing.Point(410, 133)
        Me.BtnY.Name = "BtnY"
        Me.BtnY.Size = New System.Drawing.Size(61, 57)
        Me.BtnY.TabIndex = 140
        Me.BtnY.Tag = "y"
        Me.BtnY.Text = "Y"
        Me.BtnY.UseVisualStyleBackColor = False
        '
        'BtnH
        '
        Me.BtnH.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnH.ForeColor = System.Drawing.Color.Black
        Me.BtnH.Location = New System.Drawing.Point(477, 13)
        Me.BtnH.Name = "BtnH"
        Me.BtnH.Size = New System.Drawing.Size(61, 57)
        Me.BtnH.TabIndex = 141
        Me.BtnH.Tag = "h"
        Me.BtnH.Text = "H"
        Me.BtnH.UseVisualStyleBackColor = False
        '
        'BtnQ
        '
        Me.BtnQ.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQ.ForeColor = System.Drawing.Color.Black
        Me.BtnQ.Location = New System.Drawing.Point(477, 73)
        Me.BtnQ.Name = "BtnQ"
        Me.BtnQ.Size = New System.Drawing.Size(61, 57)
        Me.BtnQ.TabIndex = 142
        Me.BtnQ.Tag = "q"
        Me.BtnQ.Text = "Q"
        Me.BtnQ.UseVisualStyleBackColor = False
        '
        'BtnZ
        '
        Me.BtnZ.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnZ.ForeColor = System.Drawing.Color.Black
        Me.BtnZ.Location = New System.Drawing.Point(477, 133)
        Me.BtnZ.Name = "BtnZ"
        Me.BtnZ.Size = New System.Drawing.Size(61, 57)
        Me.BtnZ.TabIndex = 143
        Me.BtnZ.Tag = "z"
        Me.BtnZ.Text = "Z"
        Me.BtnZ.UseVisualStyleBackColor = False
        '
        'BtnI
        '
        Me.BtnI.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnI.ForeColor = System.Drawing.Color.Black
        Me.BtnI.Location = New System.Drawing.Point(549, 13)
        Me.BtnI.Name = "BtnI"
        Me.BtnI.Size = New System.Drawing.Size(61, 57)
        Me.BtnI.TabIndex = 144
        Me.BtnI.Tag = "i"
        Me.BtnI.Text = "I"
        Me.BtnI.UseVisualStyleBackColor = False
        '
        'BtnR
        '
        Me.BtnR.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnR.ForeColor = System.Drawing.Color.Black
        Me.BtnR.Location = New System.Drawing.Point(549, 73)
        Me.BtnR.Name = "BtnR"
        Me.BtnR.Size = New System.Drawing.Size(61, 57)
        Me.BtnR.TabIndex = 145
        Me.BtnR.Tag = "r"
        Me.BtnR.Text = "R"
        Me.BtnR.UseVisualStyleBackColor = False
        '
        'BtnUperToLower
        '
        Me.BtnUperToLower.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUperToLower.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUperToLower.ForeColor = System.Drawing.Color.Black
        Me.BtnUperToLower.Location = New System.Drawing.Point(623, 13)
        Me.BtnUperToLower.Name = "BtnUperToLower"
        Me.BtnUperToLower.Size = New System.Drawing.Size(61, 57)
        Me.BtnUperToLower.TabIndex = 146
        Me.BtnUperToLower.Tag = "A/a"
        Me.BtnUperToLower.Text = "A/a"
        Me.BtnUperToLower.UseVisualStyleBackColor = False
        '
        'BtnSpace
        '
        Me.BtnSpace.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSpace.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSpace.ForeColor = System.Drawing.Color.Black
        Me.BtnSpace.Location = New System.Drawing.Point(624, 76)
        Me.BtnSpace.Name = "BtnSpace"
        Me.BtnSpace.Size = New System.Drawing.Size(61, 114)
        Me.BtnSpace.TabIndex = 147
        Me.BtnSpace.Tag = "Space"
        Me.BtnSpace.Text = "Space"
        Me.BtnSpace.UseVisualStyleBackColor = False
        '
        'BtnVIDER
        '
        Me.BtnVIDER.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnVIDER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVIDER.ForeColor = System.Drawing.Color.Black
        Me.BtnVIDER.Location = New System.Drawing.Point(551, 133)
        Me.BtnVIDER.Name = "BtnVIDER"
        Me.BtnVIDER.Size = New System.Drawing.Size(59, 57)
        Me.BtnVIDER.TabIndex = 148
        Me.BtnVIDER.Tag = "Vider"
        Me.BtnVIDER.Text = "Vider"
        Me.BtnVIDER.UseVisualStyleBackColor = False
        '
        'FrmConfirmerAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(765, 511)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmConfirmerAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FBA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrbNumeroMotsPass.ResumeLayout(False)
        Me.GrbLettreMotsDepass.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMotDePasse As System.Windows.Forms.TextBox
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TimerProgresse As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GrbLettreMotsDepass As System.Windows.Forms.GroupBox
    Friend WithEvents BtnVIDER As System.Windows.Forms.Button
    Friend WithEvents BtnSpace As System.Windows.Forms.Button
    Friend WithEvents BtnUperToLower As System.Windows.Forms.Button
    Friend WithEvents BtnR As System.Windows.Forms.Button
    Friend WithEvents BtnI As System.Windows.Forms.Button
    Friend WithEvents BtnZ As System.Windows.Forms.Button
    Friend WithEvents BtnQ As System.Windows.Forms.Button
    Friend WithEvents BtnH As System.Windows.Forms.Button
    Friend WithEvents BtnY As System.Windows.Forms.Button
    Friend WithEvents BtnP As System.Windows.Forms.Button
    Friend WithEvents BtnG As System.Windows.Forms.Button
    Friend WithEvents BtnW As System.Windows.Forms.Button
    Friend WithEvents BtnN As System.Windows.Forms.Button
    Friend WithEvents BtnE As System.Windows.Forms.Button
    Friend WithEvents BtnX As System.Windows.Forms.Button
    Friend WithEvents BtnO As System.Windows.Forms.Button
    Friend WithEvents BtnF As System.Windows.Forms.Button
    Friend WithEvents BtnV As System.Windows.Forms.Button
    Friend WithEvents BtnM As System.Windows.Forms.Button
    Friend WithEvents BtnD As System.Windows.Forms.Button
    Friend WithEvents BtnT As System.Windows.Forms.Button
    Friend WithEvents BtnK As System.Windows.Forms.Button
    Friend WithEvents BtnB As System.Windows.Forms.Button
    Friend WithEvents BtnU As System.Windows.Forms.Button
    Friend WithEvents BtnL As System.Windows.Forms.Button
    Friend WithEvents BtnC As System.Windows.Forms.Button
    Friend WithEvents BtnS As System.Windows.Forms.Button
    Friend WithEvents BtnJ As System.Windows.Forms.Button
    Friend WithEvents BtnA As System.Windows.Forms.Button
    Friend WithEvents GrbNumeroMotsPass As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNEUF As System.Windows.Forms.Button
    Friend WithEvents BtnZERO As System.Windows.Forms.Button
    Friend WithEvents BtnHUIT As System.Windows.Forms.Button
    Friend WithEvents BtnSEPT As System.Windows.Forms.Button
    Friend WithEvents BtnSIX As System.Windows.Forms.Button
    Friend WithEvents BtnQUATRE As System.Windows.Forms.Button
    Friend WithEvents BtnCINQ As System.Windows.Forms.Button
    Friend WithEvents BtnTROIS As System.Windows.Forms.Button
    Friend WithEvents BtnUN As System.Windows.Forms.Button
    Friend WithEvents BtnDEUX As System.Windows.Forms.Button
End Class
