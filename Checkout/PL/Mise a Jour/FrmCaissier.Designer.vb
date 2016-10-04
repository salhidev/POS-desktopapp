<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCaissier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCaissier))
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCAISSIER_ID = New System.Windows.Forms.TextBox()
        Me.rdbCAISSIER_SEX = New System.Windows.Forms.GroupBox()
        Me.RdFCAISSIER_SEX = New System.Windows.Forms.RadioButton()
        Me.RdMCAISSIER_SEX = New System.Windows.Forms.RadioButton()
        Me.txtCAISSIER_CODEPOSTAL = New System.Windows.Forms.TextBox()
        Me.txtCAISSIER_TEL = New System.Windows.Forms.TextBox()
        Me.lblCAISSIER_CODEPOSTAL = New System.Windows.Forms.Label()
        Me.lblCAISSIER_TEL = New System.Windows.Forms.Label()
        Me.RtbCAISSIER_ADRESSE = New System.Windows.Forms.RichTextBox()
        Me.TxtCAISSIER_MOTDEPASSE = New System.Windows.Forms.TextBox()
        Me.lblCAISSIER_MOTDEPASSE = New System.Windows.Forms.Label()
        Me.lblCAISSIER_ADRESSE = New System.Windows.Forms.Label()
        Me.DtpCAISSIER_DATENAISS = New System.Windows.Forms.DateTimePicker()
        Me.lblCAISSIER_DATENAISS = New System.Windows.Forms.Label()
        Me.CmbCAISSIER_VILLE = New System.Windows.Forms.ComboBox()
        Me.lblCAISSIER_VILLE = New System.Windows.Forms.Label()
        Me.TxtCAISSIER_NOM = New System.Windows.Forms.TextBox()
        Me.TxtCAISSIER_PRENOM = New System.Windows.Forms.TextBox()
        Me.CmbCAISSIER_PAYS = New System.Windows.Forms.ComboBox()
        Me.LblCAISSIER_CIN = New System.Windows.Forms.Label()
        Me.LblCAISSIER_PAYS = New System.Windows.Forms.Label()
        Me.TxtCAISSIER_CIN = New System.Windows.Forms.TextBox()
        Me.TxtCAISSIER_TYPE = New System.Windows.Forms.TextBox()
        Me.LblCAISSIER_NOM = New System.Windows.Forms.Label()
        Me.LblCAISSIER_PRENOM = New System.Windows.Forms.Label()
        Me.LblCAISSIER_TYPE = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Btn_Quitter = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.rdbCAISSIER_SEX.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Monotype Corsiva", 29.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(250, 20)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(131, 47)
        Me.lblTitre.TabIndex = 66
        Me.lblTitre.Text = "Caissier"
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtCAISSIER_ID)
        Me.GroupBox3.Controls.Add(Me.rdbCAISSIER_SEX)
        Me.GroupBox3.Controls.Add(Me.txtCAISSIER_CODEPOSTAL)
        Me.GroupBox3.Controls.Add(Me.txtCAISSIER_TEL)
        Me.GroupBox3.Controls.Add(Me.lblCAISSIER_CODEPOSTAL)
        Me.GroupBox3.Controls.Add(Me.lblCAISSIER_TEL)
        Me.GroupBox3.Controls.Add(Me.RtbCAISSIER_ADRESSE)
        Me.GroupBox3.Controls.Add(Me.TxtCAISSIER_MOTDEPASSE)
        Me.GroupBox3.Controls.Add(Me.lblCAISSIER_MOTDEPASSE)
        Me.GroupBox3.Controls.Add(Me.lblCAISSIER_ADRESSE)
        Me.GroupBox3.Controls.Add(Me.DtpCAISSIER_DATENAISS)
        Me.GroupBox3.Controls.Add(Me.lblCAISSIER_DATENAISS)
        Me.GroupBox3.Controls.Add(Me.CmbCAISSIER_VILLE)
        Me.GroupBox3.Controls.Add(Me.lblCAISSIER_VILLE)
        Me.GroupBox3.Controls.Add(Me.TxtCAISSIER_NOM)
        Me.GroupBox3.Controls.Add(Me.TxtCAISSIER_PRENOM)
        Me.GroupBox3.Controls.Add(Me.CmbCAISSIER_PAYS)
        Me.GroupBox3.Controls.Add(Me.LblCAISSIER_CIN)
        Me.GroupBox3.Controls.Add(Me.LblCAISSIER_PAYS)
        Me.GroupBox3.Controls.Add(Me.TxtCAISSIER_CIN)
        Me.GroupBox3.Controls.Add(Me.TxtCAISSIER_TYPE)
        Me.GroupBox3.Controls.Add(Me.LblCAISSIER_NOM)
        Me.GroupBox3.Controls.Add(Me.LblCAISSIER_PRENOM)
        Me.GroupBox3.Controls.Add(Me.LblCAISSIER_TYPE)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(15, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(545, 268)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'txtCAISSIER_ID
        '
        Me.txtCAISSIER_ID.Location = New System.Drawing.Point(83, 231)
        Me.txtCAISSIER_ID.Name = "txtCAISSIER_ID"
        Me.txtCAISSIER_ID.Size = New System.Drawing.Size(64, 20)
        Me.txtCAISSIER_ID.TabIndex = 238
        Me.txtCAISSIER_ID.Visible = False
        '
        'rdbCAISSIER_SEX
        '
        Me.rdbCAISSIER_SEX.Controls.Add(Me.RdFCAISSIER_SEX)
        Me.rdbCAISSIER_SEX.Controls.Add(Me.RdMCAISSIER_SEX)
        Me.rdbCAISSIER_SEX.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCAISSIER_SEX.ForeColor = System.Drawing.Color.Maroon
        Me.rdbCAISSIER_SEX.Location = New System.Drawing.Point(258, 200)
        Me.rdbCAISSIER_SEX.Name = "rdbCAISSIER_SEX"
        Me.rdbCAISSIER_SEX.Size = New System.Drawing.Size(270, 51)
        Me.rdbCAISSIER_SEX.TabIndex = 12
        Me.rdbCAISSIER_SEX.TabStop = False
        Me.rdbCAISSIER_SEX.Text = "Sexe"
        '
        'RdFCAISSIER_SEX
        '
        Me.RdFCAISSIER_SEX.AutoSize = True
        Me.RdFCAISSIER_SEX.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdFCAISSIER_SEX.ForeColor = System.Drawing.SystemColors.InfoText
        Me.RdFCAISSIER_SEX.Location = New System.Drawing.Point(175, 19)
        Me.RdFCAISSIER_SEX.Name = "RdFCAISSIER_SEX"
        Me.RdFCAISSIER_SEX.Size = New System.Drawing.Size(32, 20)
        Me.RdFCAISSIER_SEX.TabIndex = 14
        Me.RdFCAISSIER_SEX.TabStop = True
        Me.RdFCAISSIER_SEX.Tag = "F"
        Me.RdFCAISSIER_SEX.Text = "F"
        Me.RdFCAISSIER_SEX.UseVisualStyleBackColor = True
        '
        'RdMCAISSIER_SEX
        '
        Me.RdMCAISSIER_SEX.AutoSize = True
        Me.RdMCAISSIER_SEX.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdMCAISSIER_SEX.ForeColor = System.Drawing.SystemColors.InfoText
        Me.RdMCAISSIER_SEX.Location = New System.Drawing.Point(76, 19)
        Me.RdMCAISSIER_SEX.Name = "RdMCAISSIER_SEX"
        Me.RdMCAISSIER_SEX.Size = New System.Drawing.Size(37, 20)
        Me.RdMCAISSIER_SEX.TabIndex = 13
        Me.RdMCAISSIER_SEX.TabStop = True
        Me.RdMCAISSIER_SEX.Tag = "M"
        Me.RdMCAISSIER_SEX.Text = "M"
        Me.RdMCAISSIER_SEX.UseVisualStyleBackColor = True
        '
        'txtCAISSIER_CODEPOSTAL
        '
        Me.txtCAISSIER_CODEPOSTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCAISSIER_CODEPOSTAL.Location = New System.Drawing.Point(374, 141)
        Me.txtCAISSIER_CODEPOSTAL.Name = "txtCAISSIER_CODEPOSTAL"
        Me.txtCAISSIER_CODEPOSTAL.Size = New System.Drawing.Size(125, 20)
        Me.txtCAISSIER_CODEPOSTAL.TabIndex = 10
        '
        'txtCAISSIER_TEL
        '
        Me.txtCAISSIER_TEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCAISSIER_TEL.Location = New System.Drawing.Point(374, 174)
        Me.txtCAISSIER_TEL.Name = "txtCAISSIER_TEL"
        Me.txtCAISSIER_TEL.Size = New System.Drawing.Size(125, 20)
        Me.txtCAISSIER_TEL.TabIndex = 11
        '
        'lblCAISSIER_CODEPOSTAL
        '
        Me.lblCAISSIER_CODEPOSTAL.AutoSize = True
        Me.lblCAISSIER_CODEPOSTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCAISSIER_CODEPOSTAL.Location = New System.Drawing.Point(258, 144)
        Me.lblCAISSIER_CODEPOSTAL.Name = "lblCAISSIER_CODEPOSTAL"
        Me.lblCAISSIER_CODEPOSTAL.Size = New System.Drawing.Size(87, 13)
        Me.lblCAISSIER_CODEPOSTAL.TabIndex = 236
        Me.lblCAISSIER_CODEPOSTAL.Text = "Code Postal : "
        '
        'lblCAISSIER_TEL
        '
        Me.lblCAISSIER_TEL.AutoSize = True
        Me.lblCAISSIER_TEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCAISSIER_TEL.Location = New System.Drawing.Point(260, 177)
        Me.lblCAISSIER_TEL.Name = "lblCAISSIER_TEL"
        Me.lblCAISSIER_TEL.Size = New System.Drawing.Size(85, 13)
        Me.lblCAISSIER_TEL.TabIndex = 237
        Me.lblCAISSIER_TEL.Text = "Tel Caissier : "
        '
        'RtbCAISSIER_ADRESSE
        '
        Me.RtbCAISSIER_ADRESSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtbCAISSIER_ADRESSE.Location = New System.Drawing.Point(374, 85)
        Me.RtbCAISSIER_ADRESSE.Name = "RtbCAISSIER_ADRESSE"
        Me.RtbCAISSIER_ADRESSE.Size = New System.Drawing.Size(156, 40)
        Me.RtbCAISSIER_ADRESSE.TabIndex = 9
        Me.RtbCAISSIER_ADRESSE.Text = ""
        '
        'TxtCAISSIER_MOTDEPASSE
        '
        Me.TxtCAISSIER_MOTDEPASSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCAISSIER_MOTDEPASSE.Location = New System.Drawing.Point(374, 52)
        Me.TxtCAISSIER_MOTDEPASSE.Name = "TxtCAISSIER_MOTDEPASSE"
        Me.TxtCAISSIER_MOTDEPASSE.Size = New System.Drawing.Size(125, 20)
        Me.TxtCAISSIER_MOTDEPASSE.TabIndex = 8
        '
        'lblCAISSIER_MOTDEPASSE
        '
        Me.lblCAISSIER_MOTDEPASSE.AutoSize = True
        Me.lblCAISSIER_MOTDEPASSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCAISSIER_MOTDEPASSE.Location = New System.Drawing.Point(255, 52)
        Me.lblCAISSIER_MOTDEPASSE.Name = "lblCAISSIER_MOTDEPASSE"
        Me.lblCAISSIER_MOTDEPASSE.Size = New System.Drawing.Size(100, 13)
        Me.lblCAISSIER_MOTDEPASSE.TabIndex = 231
        Me.lblCAISSIER_MOTDEPASSE.Text = "Mots De Passe :"
        '
        'lblCAISSIER_ADRESSE
        '
        Me.lblCAISSIER_ADRESSE.AutoSize = True
        Me.lblCAISSIER_ADRESSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCAISSIER_ADRESSE.Location = New System.Drawing.Point(260, 88)
        Me.lblCAISSIER_ADRESSE.Name = "lblCAISSIER_ADRESSE"
        Me.lblCAISSIER_ADRESSE.Size = New System.Drawing.Size(60, 13)
        Me.lblCAISSIER_ADRESSE.TabIndex = 232
        Me.lblCAISSIER_ADRESSE.Text = "Adresse :"
        '
        'DtpCAISSIER_DATENAISS
        '
        Me.DtpCAISSIER_DATENAISS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpCAISSIER_DATENAISS.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpCAISSIER_DATENAISS.Location = New System.Drawing.Point(374, 15)
        Me.DtpCAISSIER_DATENAISS.Name = "DtpCAISSIER_DATENAISS"
        Me.DtpCAISSIER_DATENAISS.Size = New System.Drawing.Size(152, 20)
        Me.DtpCAISSIER_DATENAISS.TabIndex = 7
        '
        'lblCAISSIER_DATENAISS
        '
        Me.lblCAISSIER_DATENAISS.AutoSize = True
        Me.lblCAISSIER_DATENAISS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCAISSIER_DATENAISS.Location = New System.Drawing.Point(255, 16)
        Me.lblCAISSIER_DATENAISS.Name = "lblCAISSIER_DATENAISS"
        Me.lblCAISSIER_DATENAISS.Size = New System.Drawing.Size(105, 13)
        Me.lblCAISSIER_DATENAISS.TabIndex = 228
        Me.lblCAISSIER_DATENAISS.Text = "Date Naissance :"
        '
        'CmbCAISSIER_VILLE
        '
        Me.CmbCAISSIER_VILLE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCAISSIER_VILLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCAISSIER_VILLE.FormattingEnabled = True
        Me.CmbCAISSIER_VILLE.Items.AddRange(New Object() {"Casa" & Global.Microsoft.VisualBasic.ChrW(9), "Rabat", "Marrakech", "Safi", "Salé", "Agadir", "Tanger", "Laâyoune", "Oujda", "Fés", "Mohammedia", "Taroudant", "Zagoura", "El jadida", "Beni mellal", "Settat", "Paris", "Marseille", "Bourdeaux", "Toulouz", "Renne", "Nice", "Autre.."})
        Me.CmbCAISSIER_VILLE.Location = New System.Drawing.Point(83, 155)
        Me.CmbCAISSIER_VILLE.Name = "CmbCAISSIER_VILLE"
        Me.CmbCAISSIER_VILLE.Size = New System.Drawing.Size(140, 21)
        Me.CmbCAISSIER_VILLE.TabIndex = 5
        '
        'lblCAISSIER_VILLE
        '
        Me.lblCAISSIER_VILLE.AutoSize = True
        Me.lblCAISSIER_VILLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCAISSIER_VILLE.Location = New System.Drawing.Point(16, 155)
        Me.lblCAISSIER_VILLE.Name = "lblCAISSIER_VILLE"
        Me.lblCAISSIER_VILLE.Size = New System.Drawing.Size(39, 13)
        Me.lblCAISSIER_VILLE.TabIndex = 224
        Me.lblCAISSIER_VILLE.Text = "Ville :"
        '
        'TxtCAISSIER_NOM
        '
        Me.TxtCAISSIER_NOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCAISSIER_NOM.Location = New System.Drawing.Point(83, 15)
        Me.TxtCAISSIER_NOM.Name = "TxtCAISSIER_NOM"
        Me.TxtCAISSIER_NOM.Size = New System.Drawing.Size(140, 20)
        Me.TxtCAISSIER_NOM.TabIndex = 1
        '
        'TxtCAISSIER_PRENOM
        '
        Me.TxtCAISSIER_PRENOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCAISSIER_PRENOM.Location = New System.Drawing.Point(83, 51)
        Me.TxtCAISSIER_PRENOM.Name = "TxtCAISSIER_PRENOM"
        Me.TxtCAISSIER_PRENOM.Size = New System.Drawing.Size(140, 20)
        Me.TxtCAISSIER_PRENOM.TabIndex = 2
        '
        'CmbCAISSIER_PAYS
        '
        Me.CmbCAISSIER_PAYS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCAISSIER_PAYS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCAISSIER_PAYS.FormattingEnabled = True
        Me.CmbCAISSIER_PAYS.Items.AddRange(New Object() {"Maroc ", "France", "Autre.."})
        Me.CmbCAISSIER_PAYS.Location = New System.Drawing.Point(83, 190)
        Me.CmbCAISSIER_PAYS.Name = "CmbCAISSIER_PAYS"
        Me.CmbCAISSIER_PAYS.Size = New System.Drawing.Size(140, 21)
        Me.CmbCAISSIER_PAYS.TabIndex = 6
        '
        'LblCAISSIER_CIN
        '
        Me.LblCAISSIER_CIN.AutoSize = True
        Me.LblCAISSIER_CIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCAISSIER_CIN.Location = New System.Drawing.Point(15, 122)
        Me.LblCAISSIER_CIN.Name = "LblCAISSIER_CIN"
        Me.LblCAISSIER_CIN.Size = New System.Drawing.Size(36, 13)
        Me.LblCAISSIER_CIN.TabIndex = 217
        Me.LblCAISSIER_CIN.Text = "CIN :"
        '
        'LblCAISSIER_PAYS
        '
        Me.LblCAISSIER_PAYS.AutoSize = True
        Me.LblCAISSIER_PAYS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCAISSIER_PAYS.Location = New System.Drawing.Point(15, 193)
        Me.LblCAISSIER_PAYS.Name = "LblCAISSIER_PAYS"
        Me.LblCAISSIER_PAYS.Size = New System.Drawing.Size(42, 13)
        Me.LblCAISSIER_PAYS.TabIndex = 218
        Me.LblCAISSIER_PAYS.Text = "Pays :"
        '
        'TxtCAISSIER_CIN
        '
        Me.TxtCAISSIER_CIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCAISSIER_CIN.Location = New System.Drawing.Point(83, 122)
        Me.TxtCAISSIER_CIN.Name = "TxtCAISSIER_CIN"
        Me.TxtCAISSIER_CIN.Size = New System.Drawing.Size(140, 20)
        Me.TxtCAISSIER_CIN.TabIndex = 4
        '
        'TxtCAISSIER_TYPE
        '
        Me.TxtCAISSIER_TYPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCAISSIER_TYPE.Location = New System.Drawing.Point(83, 84)
        Me.TxtCAISSIER_TYPE.Name = "TxtCAISSIER_TYPE"
        Me.TxtCAISSIER_TYPE.Size = New System.Drawing.Size(140, 20)
        Me.TxtCAISSIER_TYPE.TabIndex = 3
        '
        'LblCAISSIER_NOM
        '
        Me.LblCAISSIER_NOM.AutoSize = True
        Me.LblCAISSIER_NOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCAISSIER_NOM.Location = New System.Drawing.Point(15, 19)
        Me.LblCAISSIER_NOM.Name = "LblCAISSIER_NOM"
        Me.LblCAISSIER_NOM.Size = New System.Drawing.Size(44, 13)
        Me.LblCAISSIER_NOM.TabIndex = 221
        Me.LblCAISSIER_NOM.Text = "Nom  :"
        '
        'LblCAISSIER_PRENOM
        '
        Me.LblCAISSIER_PRENOM.AutoSize = True
        Me.LblCAISSIER_PRENOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCAISSIER_PRENOM.Location = New System.Drawing.Point(15, 51)
        Me.LblCAISSIER_PRENOM.Name = "LblCAISSIER_PRENOM"
        Me.LblCAISSIER_PRENOM.Size = New System.Drawing.Size(57, 13)
        Me.LblCAISSIER_PRENOM.TabIndex = 222
        Me.LblCAISSIER_PRENOM.Text = "Prenom :"
        '
        'LblCAISSIER_TYPE
        '
        Me.LblCAISSIER_TYPE.AutoSize = True
        Me.LblCAISSIER_TYPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCAISSIER_TYPE.Location = New System.Drawing.Point(12, 89)
        Me.LblCAISSIER_TYPE.Name = "LblCAISSIER_TYPE"
        Me.LblCAISSIER_TYPE.Size = New System.Drawing.Size(43, 13)
        Me.LblCAISSIER_TYPE.TabIndex = 223
        Me.LblCAISSIER_TYPE.Text = "Type :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 402)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MT Extra", 10.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.Label1.Location = New System.Drawing.Point(246, 375)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 16)
        Me.Label1.TabIndex = 239
        Me.Label1.Text = "NB : ** Les champs soulignés sont obligatoire **"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.Button4)
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Controls.Add(Me.Btn_Quitter)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox5.Location = New System.Drawing.Point(30, 293)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(511, 61)
        Me.GroupBox5.TabIndex = 238
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Gestion :"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Silver
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = Global.Caisse.My.Resources.Resources.btRetour32
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(194, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(133, 32)
        Me.Button4.TabIndex = 211
        Me.Button4.Text = "     &Vider"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button5.BackColor = System.Drawing.Color.Silver
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button5.Image = Global.Caisse.My.Resources.Resources.btEnregistrer32
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(55, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(133, 32)
        Me.Button5.TabIndex = 209
        Me.Button5.Text = "       &Valider"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Btn_Quitter
        '
        Me.Btn_Quitter.BackColor = System.Drawing.Color.Silver
        Me.Btn_Quitter.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Quitter.ForeColor = System.Drawing.Color.Black
        Me.Btn_Quitter.Image = Global.Caisse.My.Resources.Resources.btFermer32
        Me.Btn_Quitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Quitter.Location = New System.Drawing.Point(333, 16)
        Me.Btn_Quitter.Name = "Btn_Quitter"
        Me.Btn_Quitter.Size = New System.Drawing.Size(133, 32)
        Me.Btn_Quitter.TabIndex = 210
        Me.Btn_Quitter.Text = "     Fermer"
        Me.Btn_Quitter.UseVisualStyleBackColor = False
        '
        'FrmCaissier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(732, 484)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCaissier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FBA"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.rdbCAISSIER_SEX.ResumeLayout(False)
        Me.rdbCAISSIER_SEX.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbCAISSIER_SEX As System.Windows.Forms.GroupBox
    Friend WithEvents RdFCAISSIER_SEX As System.Windows.Forms.RadioButton
    Friend WithEvents RdMCAISSIER_SEX As System.Windows.Forms.RadioButton
    Friend WithEvents txtCAISSIER_CODEPOSTAL As System.Windows.Forms.TextBox
    Friend WithEvents txtCAISSIER_TEL As System.Windows.Forms.TextBox
    Friend WithEvents lblCAISSIER_CODEPOSTAL As System.Windows.Forms.Label
    Friend WithEvents lblCAISSIER_TEL As System.Windows.Forms.Label
    Friend WithEvents RtbCAISSIER_ADRESSE As System.Windows.Forms.RichTextBox
    Friend WithEvents TxtCAISSIER_MOTDEPASSE As System.Windows.Forms.TextBox
    Friend WithEvents lblCAISSIER_MOTDEPASSE As System.Windows.Forms.Label
    Friend WithEvents lblCAISSIER_ADRESSE As System.Windows.Forms.Label
    Friend WithEvents DtpCAISSIER_DATENAISS As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCAISSIER_DATENAISS As System.Windows.Forms.Label
    Friend WithEvents CmbCAISSIER_VILLE As System.Windows.Forms.ComboBox
    Friend WithEvents lblCAISSIER_VILLE As System.Windows.Forms.Label
    Friend WithEvents TxtCAISSIER_NOM As System.Windows.Forms.TextBox
    Friend WithEvents TxtCAISSIER_PRENOM As System.Windows.Forms.TextBox
    Friend WithEvents CmbCAISSIER_PAYS As System.Windows.Forms.ComboBox
    Friend WithEvents LblCAISSIER_CIN As System.Windows.Forms.Label
    Friend WithEvents LblCAISSIER_PAYS As System.Windows.Forms.Label
    Friend WithEvents TxtCAISSIER_CIN As System.Windows.Forms.TextBox
    Friend WithEvents TxtCAISSIER_TYPE As System.Windows.Forms.TextBox
    Friend WithEvents LblCAISSIER_NOM As System.Windows.Forms.Label
    Friend WithEvents LblCAISSIER_PRENOM As System.Windows.Forms.Label
    Friend WithEvents LblCAISSIER_TYPE As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Btn_Quitter As System.Windows.Forms.Button
    Friend WithEvents txtCAISSIER_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
