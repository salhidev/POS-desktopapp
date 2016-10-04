Public Class Frm_Générer_CB


#Region "***** FONCTIONS *****"
    '
    '/*========================================================================================================================*/
    '
    Private Function DirNotBin(ByVal CurDir As String) As String
        '/* retourne une chaine contenant le repertoire de l'appli (pas de l'executable...) */
        '
        '/* case Debug */
        If CurDir.Substring(CurDir.Length - 10, 10) = "\bin\Debug" Then Return CurDir.Substring(0, CurDir.Length - 10)
        '/* case Release */
        If CurDir.Substring(CurDir.Length - 12, 12) = "\bin\Release" Then Return CurDir.Substring(0, CurDir.Length - 12)
        '/* case v7 -> v8 */
        If CurDir.Substring(CurDir.Length - 4, 4) = "\bin" Then Return CurDir.Substring(0, CurDir.Length - 4)
        '/* case else... */
        Return CurDir
        '
    End Function
    '
    '/*----------------------------------------------------------------------------------------------------*/
    '
    Private Function FilterChars(ByVal Z As String) As String
        '/* retourne une chaine contenant les caractères valides en code 128 en cas */
        '/* d'entrée au clavier; afin d'encoder correctement les caractères de contrôle, */
        '/* si entrée par fichier (cas d'un traitement auto.), il convient de modifier le test. */
        '
        Dim I As Integer
        Dim S As String = ""
        '
        For I = 1 To Len(Z)
            '
            '/***** TEST en cas d'entrée par fichier (mode "automatique") *****/
            'If Mid$(Z, I, 1) >= Chr(&H7F) Then 
            '
            '/***** TEST en cas d'entrée clavier *****/
            If Mid$(Z, I, 1) < Chr(&H20) Or Mid$(Z, I, 1) >= Chr(&H7F) Then
                S &= "#"            '/* Caractère invalide, remplacé ARBITRAIREMENT PAR MOI par "#", na! (on peut changer... (ndlr)) */
            Else
                S &= Mid(Z, I, 1)   '/* Caractère OK, r.a.s. */
            End If
        Next
        '
        Return S
        '
    End Function
    '
    '/*----------------------------------------------------------------------------------------------------*/
    '
    Private Function IMG_SHOW(ByVal Imagefile As String, ByVal xSize As Integer, ByVal ySize As Integer) As Boolean
        '/* Fonction d'affichage du bitmap dans la PictureBox après génération */
        '
        Try
            '
            If Not (WRK_IMG Is Nothing) Then WRK_IMG.Dispose()
            '
            WRK_IMG = New Bitmap(Imagefile)
            PBX_CODE.ClientSize = New Size(xSize, ySize)
            PBX_CODE.Image = CType(WRK_IMG, Image)
            '
            Return True
            '
        Catch ex As Exception
            Dim MS As String = ex.Message
            '
            Return False
            '
        End Try
        '
    End Function
    '
    '/*----------------------------------------------------------------------------------------------------*/
    '
    Private Function FilterFileName(ByVal Z As String) As String
        '/* Fonction de filtrage du nom de fichier pour le bitmap (nom généré directement */
        '/* depuis l'entrée clavier / fichier => risque de caractères invalides */
        '
        Dim I As Integer
        Dim S As String = Z
        '
        For I = 1 To FORBIDDEN.Length
            S = S.Replace(Mid(FORBIDDEN, I, 1), "_")
        Next
        '
        Return S
        '
    End Function
    '
    '/*========================================================================================================================*/
    '
#End Region
#Region "***** DECLARATIONS *****"
    '
    '/*========================================================================================================================*/
    '
    'Dim FILE_PATH As String = DirNotBin(Application.StartupPat)
    Dim FILE_PATH As String = Application.StartupPath
    'Dim FILE_PATH As String = "C:\Users\Elbazini\Desktop\Projet_Point_de_Vente_ &_Caisses_FinalV22Mai\Caisse\bin\Debug"

    '
    Dim INI_FILE As String = FILE_PATH & "\CODE_128.ini"    '/* Fichier de paramètres initiaux */
    Dim COD_FILE As String = FILE_PATH & "\CODE_128.txt"    '/* Fichier des configurations du code ("11"=module sombre/"00"=module clair) */
    Dim CHR_FILE As String = FILE_PATH & "\CHAR_128.txt"    '/* Fichier des caractères semi-graphiques ("1"=point sombre/"0"=point clair) */
    Dim SND_FILE As String = FILE_PATH & "\ERR_ALERTE.wav"  '/* Fichier wave pour un signal sonore quelconque (pas encore utilisé ici) */
    '
    Dim IMG_PATH As String = FILE_PATH & "\_GENERE"         '/* Répertoire de sortie pour images bitmap */
    Dim IMG_FILE As String                                  '/* Nom du fichier image (construit par la suite) */
    '
    Dim WRK_IMG As Bitmap                                   '/* Bitmap de travail */
    '
    '/*----------------------------------------------------------------------------------------------------*/
    '
    Const COPYRIGHT_TEXT As String = "Copyright © FBA ,14/05/2012"
    '
    '/*------------------------------------------------------------------------------------------------------------------------*/
    '
    Dim CB_ForeColor As Brush = Brushes.Black               '/* Couleur d'avant-plan du bitmap */
    Dim PXL_ForeColor As Color = Color.Black
    '
    Dim CB_BackColor As Brush = Brushes.White               '/* Couleur d'arrière-plan du bitmap */
    Dim PXL_BackColor As Color = Color.White
    '
    '/*------------------------------------------------------------------------------------------------------------------------*/
    '
    Dim TBL_SYMBOLS(106) As String                          '/* Table de la symbologie Code128 */
    Dim NDX_SYMBOL As Integer                               '/* Index courant */
    Dim MIN_SYMBOL As Integer = 0                           '/* Index minima */
    Dim MAX_SYMBOL As Integer = 106                         '/* Index maxima */
    '
    Dim TBL_CHARACTERS(150, 7) As String                    '/* Table des caractères graphiques (151 matrices sur 8 lignes) */
    Dim NDX_CHARACTER As Integer                            '/* Index courant caractère */
    Dim NDX_CHARACTER_LINE As Integer                       '/* Index courant ligne dans le caractère */
    Dim MIN_CHARACTER As Integer = 0                        '/* Index minima */
    Dim MAX_CHARACTER As Integer = 150                      '/* Index maxima */
    '
    Dim FORBIDDEN As String
    '
    '/*------------------------------------------------------------------------------------------------------------------------*/
    '
    '/* Définition des index "spéciaux" dans les tables */
    '
    '/* Table des symboles */
    '
    Const BAR_START_A As Integer = 103      '/* Caractère de début en jeu "A" */
    Const BAR_START_B As Integer = 104      '/* Caractère de début en jeu "B" */
    Const BAR_START_C As Integer = 105      '/* Caractère de début en jeu "C" */
    Const BAR_STOP_X As Integer = 106       '/* Caractère de fin en tous jeux */
    '
    Const BAR_TO_MODE_A As Integer = 101    '/* Caractère de bascule en jeu "A" */
    Const BAR_TO_MODE_B As Integer = 100    '/* Caractère de bascule en jeu "B" */
    Const BAR_TO_MODE_C As Integer = 99     '/* Caractère de bascule en jeu "C" */
    '
    Const BAR_SHIFT As Integer = 98         '/* Caractère de décalage de mode */
    '
    Const BAR_FNC1 As Integer = 102         '/* Caractère de fonction FNC1 */
    Const BAR_FNC2 As Integer = 97          '/* Caractère de fonction FNC2 */
    Const BAR_FNC3 As Integer = 96          '/* Caractère de fonction FNC3 */
    Dim BAR_FNC4 As Integer                 '/* Caractère de fonction FNC4 (variable selon jeu "A" ou jeux "B" ou "C") */
    '
    '/* Table des matrices de caractères */
    '
    Const CHR_START_A As Integer = 128      '/* Caractère de début en jeu "A" */
    Const CHR_START_B As Integer = 129      '/* Caractère de début en jeu "B" */
    Const CHR_START_C As Integer = 130      '/* Caractère de début en jeu "C" */
    Const CHR_STOP_X As Integer = 131       '/* Caractère de fin en tous jeux */
    '
    Const CHR_TO_MODE_A As Integer = 133    '/* Caractère de bascule en jeu "A" */
    Const CHR_TO_MODE_B As Integer = 134    '/* Caractère de bascule en jeu "B" */
    Const CHR_TO_MODE_C As Integer = 135    '/* Caractère de bascule en jeu "C" */
    '
    Const CHR_SHIFT As Integer = 132        '/* Caractère de décalage de mode */
    '
    Const CHR_FNC1 As Integer = 136         '/* Caractère de fonction FNC1 */
    Const CHR_FNC2 As Integer = 137         '/* Caractère de fonction FNC2 */
    Const CHR_FNC3 As Integer = 138         '/* Caractère de fonction FNC3 */
    Const CHR_FNC4 As Integer = 139         '/* Caractère de fonction FNC4 */ 
    '
    Const CHR_CHKSUM As Integer = 150       '/* Caractère représentant la Checksum */
    '
    '/***** NOTE : repris de la norme AFNOR NF EN 799; concerne l'interprétation en clair */ 
    '
    'ANNEXE A.2	Interprétation en clair
    '
    'Une interprétation en clair des caractères de données (qui doivent correspondre aux caractères
    'transmis par le décodeur) doit être imprimée avec le symbole "Code 128" qui les encode. Les
    'caractères de début/fin et les caractères spéciaux ne doivent pas être imprimés. La dimension
    'et la police des carctères ne sont pas précisées, et l'interprétation peut être imprimée où
    'que ce soit dans la zone entourant le symbole, tant que les limites de marges sont respectées
    '(voir 4.3.).
    '
    '/* => dans cette source, j'ai volontairement choisi d'"imprimer" tous les caractères, */
    '/* STARTs, STOP, SHIFT, bascule entre modes, checksum, etc en clair à des fins de test */
    '/* il suffit de remplacer les index spéciaux CHR_xxxxx = nnnn as integer par */ 
    '/* CHR_xxxxx as integer = 32 pour remplacer la matrice par une matrice blanche (espace) */
    '
    '/***** Pour information *****/
    '/* Le jeu "A" se compose de la suite &h20 à &h5F suivie de la suite &h00 à &h1F, suivie */
    '/* elle-même des caractères FNC3, FNC2, SHIFT, ToModeC, ToModeB, FNC4, FNC1, StartA, */
    '/* StartB, StartC, Stop, dans l'ordre. */
    '
    '/* Le jeu "B" se compose de la suite &h20 à &h7F, suivie des caractères FNC3, FNC2, */
    '/* SHIFT, ToModeC, FNC4, ToModeA, FNC1, StartA, StartB, StartC, Stop, dans l'ordre. */
    '
    '/* Le jeu "C" se compose des paires de chiffres 00 à 99, suivies des caractères ToModeB, */
    '/* ToModeA, FNC1, StartA, StartB, StartC, Stop, dans l'ordre. */
    '
    '/*------------------------------------------------------------------------------------------------------------------------*/
    '
    Dim INDEX_A As String = ""              '/* Index du jeu "A" */
    Dim INDEX_B As String = ""              '/* Index du jeu "B" */
    '
    Dim MODE_A As Boolean                   '/* Indicateur de mode d'encodage (jeu "A") */
    Dim MODE_B As Boolean                   '/* Indicateur de mode d'encodage (jeu "B") */
    Dim MODE_C As Boolean                   '/* Indicateur de mode d'encodage (jeu "C") */
    '
    '/*------------------------------------------------------------------------------------------------------------------------*/
    '
    Dim ZE_DATA As String = ""              '/* Variable de travail pour le code-barre */
    Dim ZE_MASK As String = ""              '/* Variable de travail pour le "masque" */
    Dim ZE_CODE As String = ""              '/* Variable de travail pour le nom du bitmap */
    '
    Dim CODE_128_BAR As String              '/* Code barre sous forme de "1" et de "0" */
    Dim CODE_128_CHR(7) As String           '/* Interprétation en clair sous forme de "1" et de "0" */
    '
    Dim P_CTL As Integer                    '/* Indicateur "caractères de contrôle" */
    Dim P_MIN As Integer                    '/* Indicateur "minuscules" */
    '
    Dim SUM As Long                         '/* Checkdigit : somme */
    Dim PND As Integer                      '/* Checkdigit : pondération */
    '
    '/*========================================================================================================================*/
    '
#End Region
#Region "***** FORM LOAD/UNLOAD *****"

    Private Sub Frm_Générer_CB_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
    End Sub

    Private Sub Frm_Générer_CB_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
    End Sub
    '
    '/*========================================================================================================================*/
    '/* Chargement de la form */
    '
    Private Sub FRM_CODE_128_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Me.StartPosition = FormStartPosition.CenterScreen

        Dim F As Integer = FreeFile()
        '
        Try
            FileOpen(F, INI_FILE, OpenMode.Input, OpenAccess.Read)
            '
            Input(F, Me.Left)
            Input(F, Me.Top)
            '
            If Me.Top < 0 Or Me.Left < 0 Or Me.Top > (Screen.PrimaryScreen.Bounds.Height - 30) Or Me.Left > (Screen.PrimaryScreen.Bounds.Width - 30) Then
                Error 11 '/* simul division par zero */
            End If
            '
        Catch
            Me.Left = 120
            Me.Top = 120
            '
        Finally
            FileClose(F)
            '
        End Try
        '
        INITIALIZE()
        '
    End Sub
    '
    '/*------------------------------------------------------------------------------------------------------------------------*/
    '/* Fermeture de la form */
    '
    Private Sub FRM_CODE_128_Unload(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        '
        Dim F As Integer = FreeFile()
        '
        FileOpen(F, INI_FILE, OpenMode.Output, OpenAccess.Write)
        '
        PrintLine(F, Me.Left)
        PrintLine(F, Me.Top)
        '
        FileClose(F)
        '
        End
        '
    End Sub
    '
    '/*========================================================================================================================*/
    '
#End Region
#Region "***** COMMANDES *****"
    '
    '/*========================================================================================================================*/
    ' 
    Private Sub CMD_GO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            ZE_DATA = FilterChars(TXB_INCODE.Text)
            ZE_CODE = ZE_DATA
            LBL_INTERPRETE.Text = ZE_DATA
            '
            GENERATE_MASK()     '/* Génération du masque d'analyse pour l'encodage */
            GENERATE_START()    '/* Détermination du Start mode (A/B/C) */
            GENERATE_CODE()     '/* Encodage */
            GENERATE_IMAGE()    '/* Génération du bitmap */
            '
            Dim X As Boolean = IMG_SHOW(IMG_FILE, 626, 170) '/* Affichage du bitmap généré */
            If Not X Then
                MsgBox("Erreur lors de la génération du code-barre")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        MsgBox(" Code Barre Bien Généré ")
        FrmArticle.Pbx_CB.SizeMode = PictureBoxSizeMode.StretchImage
        FrmArticle.Pbx_CB.Image = PBX_CODE.Image
        FrmArticle.Pbx_CB.SizeMode = PictureBoxSizeMode.StretchImage
        Me.Hide()

    End Sub
    '
    '/*------------------------------------------------------------------------------------------------------------------------*/
    '/* Fermeture de la form */
    '
    Private Sub CMD_STOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '
        Me.Close()
        '
    End Sub
    '
    '/*------------------------------------------------------------------------------------------------------------------------*/
    '/* Affichage de la form "Au sujet de..."; les mentions sont récupérées de l'assembly */
    '
    'Private Sub CMD_ABOUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '
    '    Dim F_ABOUT As New FRM_CODE_128_ABOUT
    '    F_ABOUT.ShowDialog(Me)
    '    F_ABOUT.Dispose()
    '    '
    'End Sub
    '
    '/*========================================================================================================================*/
    '
#End Region
#Region "***** PROCEDURES *****"
    '
    '/*========================================================================================================================*/
    '/* Initialisation */ 
    '
    Private Sub INITIALIZE()
        '
        Dim I As Integer
        '
        FORBIDDEN = Chr(&H22) & "/\*?<>|:" & Chr(&H7F)
        For I = 0 To 31
            FORBIDDEN &= Chr(I)
        Next
        '
        LOAD_TABLES()   '/* Chargement des tables de codes */
        '
        INDEX_A = ""    '/* Création de l'index du Jeu de code "A" */
        For I = 32 To 95 : INDEX_A &= Chr(I) : Next
        For I = 0 To 31 : INDEX_A &= Chr(I) : Next
        '
        INDEX_B = ""    '/* Création de l'index du Jeu de code "B" */
        For I = 32 To 127 : INDEX_B &= Chr(I) : Next
        '
    End Sub
    '
    '/*------------------------------------------------------------------------------------------------------------------------*/
    '/* Jeu du son passé en paramètre - (pas encore utilisé ici) */
    '
    'Public Sub BEEP(ByVal WRK_SOUND As String)
    '    '
    '    CLS_SOUND.PlaySound(WRK_SOUND, 0, CLS_SOUND.SND_FILENAME Or CLS_SOUND.SND_ASYNC)
    '    '
    'End Sub
    '
    '/*========================================================================================================================*/
    '
#End Region
#Region "***** PROCEDURES CODE 128 = PARTIE I : GENERATE_MASK() *****"
    '
    '/*========================================================================================================================*/
    '/* I) On génère un "masque" permettant de synthétiser les différentes    */
    '/*    sortes de caractères afin de préparer l'optimisation de l'encodage */
    '/*    pour augmenter la densité du code-barre                            */
    '/*========================================================================================================================*/
    '
    Private Sub GENERATE_MASK()
        '
        Dim SWITCH As Boolean
        Dim I As Integer
        Dim W As Integer
        '
        ZE_MASK = ""
        '
        For I = 1 To Len(ZE_DATA)
            '
            W = Asc(Mid(ZE_DATA, I, 1)) : SWITCH = False
            '
            '/* on teste le caractère extrait et, (au sens du code 128) :      */
            '/*     si c'est un caractère de contrôle, on ajoute "#" au masque */
            '/*     si c'est un caractère numérique, on ajoute "9" au masque   */
            '/*     si c'est un caractère minuscule, on ajoute "x" au masque   */
            '/*     si c'est un caractère majuscule, on ajoute "X" au masque   */
            '/*     ce qui en fin de traitement donne une chaine du genre      */
            '/*     "xx9999XX9#9X#99xxX9#X99X9X9"                              */
            '
            If W < 32 Then ZE_MASK &= "#" : SWITCH = True '/* # : CtlChar */
            If W > 95 And W < 128 Then ZE_MASK &= "x" : SWITCH = True '/* x : lowercase */
            If W > 47 And W < 58 Then ZE_MASK &= "9" : SWITCH = True '/* 9 : Numeric */
            If Not SWITCH Then ZE_MASK &= "X" '/* X : UPPERCASE */
            '
        Next
        '
        LBL_MASQUE.Text = ZE_MASK
        '
    End Sub
    '
    '/*========================================================================================================================*/
    '
#End Region
#Region "***** PROCEDURES CODE 128 = PARTIE II : GENERATE_START() *****"
    '
    '/*========================================================================================================================*/
    '/* II) On détermine le caractère de début en fonction du "masque" généré : */
    '/*                                                                         */
    '/* 1) Si la donnée commence par 4 caractères numériques ou plus :          */
    '/*    -> utiliser le caractère de début C [StartC]                         */
    '/* 2) Si un caractère de contrôle ASCII (par exemple NUL) se trouve        */
    '/*    dans la donnée avant un caractère minuscule :                        */
    '/*    -> utiliser le caractère de début A [StartA]                         */
    '/* 3) autrement :                                                          */
    '/*    -> utiliser le caractère de début B [StartB]                         */
    '/*========================================================================================================================*/
    '
    Private Sub GENERATE_START()
        '
        MODE_A = False : MODE_B = False : MODE_C = False        '/* raz des indicateurs de mode */
        '
        Dim CHR_START_X As Integer
        Dim BAR_START_X As Integer
        '
        CODE_128_BAR = ""                                       '/* raz des variables de travail */
        ReDim CODE_128_CHR(7)
        '
        If Mid(ZE_MASK, 1, 4) = "9999" Then                     '/* Règle II-1) */
            CHR_START_X = CHR_START_C
            BAR_START_X = BAR_START_C                           '/* StartC sélectionné */
            MODE_C = True
        Else
            P_CTL = InStr(ZE_MASK, "#") '/* Position du premier caractère de contrôle */
            P_MIN = InStr(ZE_MASK, "x") '/* Position du premier caractère minuscule */
            '
            If P_CTL > 0 And (P_MIN = 0 Or P_CTL < P_MIN) Then  '/* Règle II-2) */
                CHR_START_X = CHR_START_A
                BAR_START_X = BAR_START_A                       '/* StartA sélectionné */
                MODE_A = True
            Else                                                '/* Règle II-3) */
                CHR_START_X = CHR_START_B
                BAR_START_X = BAR_START_B                       '/* StartB sélectionné */
                MODE_B = True
            End If
        End If
        '
        CODE_128_BAR = TBL_SYMBOLS(BAR_START_X)                 '/* Ajout des barres du start sélectionné */
        '
        ADD_CHAR(CHR_START_X)                                   '/* Ajout de la matrice du start sélectionné */
        '
        SUM = BAR_START_X                                       '/* Init. de la somme à la valeur du start */
        PND = 1                                                 '/* Init. de la pondération */
        '
    End Sub
    '
    '/*========================================================================================================================*/
    '
#End Region
#Region "***** PROCEDURES CODE 128 = PARTIE III : GENERATE_CODE() *****"
    '
    '/*========================================================================================================================*/
    '/* III) On génère les barres en fonction du "masque" généré :              */
    '/*                                                                         */
    '/* 1) Si le caractère de début C [StartC] est utilisé et que la donnée     */
    '/*    commence avec un nombre impair de caractères numériques :            */
    '/*    -> insérer un caractère de basculement en mode A [ToModeA] ou C      */ 
    '/*       [ToModeC] avant le dernier chiffre en suivant les règles II-2)    */
    '/*       et II-3) afin de faire la distinction entre les modes A et B      */
    '/*                                                                         */
    '/* 2) Si 4 caractères numériques ou plus se trouvent ensemble lorsqu'ils   */
    '/*    sont en mode A ou B :                                                */
    '/*     a) s'il y a un nombre pair de caractères numériques :               */
    '/*        -> insérer un caractère de mode C [ToModeC] avant le premier     */ 
    '/*           chiffre pour passer en mode C                                 */  
    '/*     b) s'il y a un nombre impair de caractères numériques :             */
    '/*        -> insérer un caractère de mode C [ToModeC] immédiatement après  */
    '/*           le premier chiffre pour passer en mode C.                     */    
    '/*                                                                         */
    '/* 3) Lorsque l'on se trouve en mode B et qu'un caractère de contrôle      */
    '/*    ASCII se trouve dans la donnée :                                     */
    '/*     a) s'il y a un caractère minuscule immédiatement après le           */
    '/*        caractère de contrôle:                                           */
    '/*        -> insérer un caractère de basculement unitaire [Shift] avant le */
    '/*           caractère de contrôle                                         */
    '/*     b) autrement :                                                      */    
    '/*        -> insérer un caractère de mode A [ToModeA] avant le caractère   */
    '/*           de contrôle pour passer en mode A.                            */
    '/*                                                                         */
    '/* 4) Lorsque l'on se trouve en mode A et qu'un caractère minuscule se     */
    '/*    trouve dans la donnée :                                              */
    '/*     a) si un caractère de contrôle se trouve dans la donnée après ce    */
    '/*        caractère et avant un autre caractère minuscule :                */
    '/*        -> insérer un caractère de basculement unitaire [Shift] avant le */
    '/*           caractère minuscule                                           */
    '/*     b) autrement :                                                      */
    '/*        -> insérer un caractère de mode B [ToModeB] avant le caractère   */
    '/*           minuscule pour passer en mode B.                              */
    '/*                                                                         */
    '/* 5) Lorsque l'on se trouve en mode C et qu'un caractère non numérique    */
    '/*    se trouve dans la donnée :                                           */
    '/*    -> insérer un caractère de basculement global en mode A [ToModeA] ou */
    '/*       un caractère de mode B [ToModeB] avant ce caractère en suivant    */
    '/*       les règles II-2) et II-3) pour distinguer entre les modes A et B. */
    '/*========================================================================================================================*/
    '
    Private Sub GENERATE_CODE()
        '
        Dim P As Integer
        Dim V As Integer
        Dim U As Integer
        '
        While Len(ZE_MASK) > 0
            '
            If MODE_C Then    '/* On est en mode "C" */
                '
                If Mid(ZE_MASK, 1, 2) = "99" Then   '/* Règle III-1) (en fait on traite le cas MODE C ET nombre pair de numériques) */
                    '
                    V = CInt(Val(Mid(ZE_DATA, 1, 2)))   '/* Valeur de la paire de numériques */
                    '
                    CODE_128_BAR &= TBL_SYMBOLS(V)  '/* Ajout du symbole (jeu C, n° de la paire de num.) */
                    ADD_CHAR(140 + (V \ 10))    '/* Premier caractère de la paire */
                    ADD_CHAR(140 + (V Mod 10))  '/* Second caractère de la paire */
                    '
                    SUM += (V * PND)    '/* Somme pondérée */
                    PND += 1            '/* Augmentation du facteur de pondération */
                    '
                    ZE_DATA = Mid(ZE_DATA, 3) : ZE_MASK = Mid(ZE_MASK, 3)   '/* Caractère suivant */
                    '
                Else                                '/* Règle III-5) */
                    '
                    P_CTL = InStr(ZE_MASK, "#") '/* Position du premier caractère de contrôle */
                    P_MIN = InStr(ZE_MASK, "x") '/* Position du premier caractère minuscule */
                    '
                    If P_CTL > 0 And (P_MIN = 0 Or P_CTL < P_MIN) Then
                        '
                        CODE_128_BAR &= TBL_SYMBOLS(BAR_TO_MODE_A)  '/* Insertion passage en mode "A" */
                        ADD_CHAR(CHR_TO_MODE_A)
                        '
                        SUM += (BAR_TO_MODE_A * PND)    '/* Somme pondérée */
                        PND += 1                        '/* Augmentation du facteur de pondération */
                        '
                        MODE_A = True : MODE_B = False : MODE_C = False '/* Mise à jour des indicateurs de mode */
                        '
                    Else
                        '
                        CODE_128_BAR &= TBL_SYMBOLS(BAR_TO_MODE_B)  '/* Insertion passage en mode "B" */
                        ADD_CHAR(CHR_TO_MODE_B)
                        '
                        SUM += (BAR_TO_MODE_B * PND)    '/* Somme pondérée */
                        PND += 1                        '/* Augmentation du facteur de pondération */
                        '
                        MODE_A = False : MODE_B = True : MODE_C = False '/* Mise à jour des indicateurs de mode */
                        '
                    End If
                    '
                End If
                '
            Else    '/* On est en mode "A" ou en mode "B" */
                '
                If Mid(ZE_MASK, 1, 4) = "9999" Then     '/* Règle III-2) */
                    '
                    CODE_128_BAR &= TBL_SYMBOLS(BAR_TO_MODE_C)  '/* Insertion passage en mode "C" */
                    ADD_CHAR(CHR_TO_MODE_C)
                    '
                    SUM += (BAR_TO_MODE_C * PND)    '/* Somme pondérée */
                    PND += 1                        '/* Augmentation du facteur de pondération */
                    '
                    MODE_A = False : MODE_B = False : MODE_C = True '/* Mise à jour des indicateurs de mode */
                    '
                Else
                    '
                    If MODE_B And Mid(ZE_MASK, 1, 1) = "#" Then
                        '
                        If Mid(ZE_MASK, 1, 2) = "#x" Then   '/* Règle III-3) */
                            '
                            CODE_128_BAR &= TBL_SYMBOLS(BAR_SHIFT)  '/* Insertion bascule unitaire */
                            ADD_CHAR(CHR_SHIFT)
                            '
                            SUM += (BAR_SHIFT * PND)    '/* Somme pondérée */
                            PND += 1                    '/* Augmentation du facteur de pondération */
                            '
                            P = InStr(INDEX_A, Mid(ZE_DATA, 1, 1))  '/* Position dans l'index du jeu "A")
                            '
                            CODE_128_BAR &= TBL_SYMBOLS(P - 1) '/* Ajout du symbole (jeu "A") */
                            ADD_CHAR(Asc(Mid(ZE_DATA, 1, 1)))
                            '
                            U = InStr(INDEX_B, Mid(ZE_DATA, 1, 1)) - 1
                            SUM += U * PND  '/* Somme pondérée */
                            PND += 1                                '/* Augmentation du facteur de pondération */   
                            '
                            ZE_DATA = Mid(ZE_DATA, 2) : ZE_MASK = Mid(ZE_MASK, 2)   '/* Caractère suivant */
                            '
                        Else
                            '
                            CODE_128_BAR &= TBL_SYMBOLS(BAR_TO_MODE_A)  '/* Insertion passage en mode "A" */
                            ADD_CHAR(CHR_TO_MODE_A)
                            '
                            SUM += (BAR_TO_MODE_A * PND)    '/* Somme pondérée */
                            PND += 1                        '/* Augmentation du facteur de pondération */
                            '
                            MODE_A = True : MODE_B = False : MODE_C = False '/* Mise à jour des indicateurs de mode */
                            '
                        End If
                        '
                    End If
                    '
                    If MODE_A And Mid(ZE_MASK, 1, 1) = "x" Then '/* Règle III-4) */
                        '
                        If Mid(ZE_MASK, 1, 2) = "x#" Then
                            '
                            CODE_128_BAR &= TBL_SYMBOLS(BAR_SHIFT)  '/* Insertion bascule unitaire */
                            ADD_CHAR(CHR_SHIFT)
                            '
                            SUM += (BAR_SHIFT * PND)    '/* Somme pondérée */
                            PND += 1                    '/* Augmentation du facteur de pondération */
                            '
                            P = InStr(INDEX_B, Mid(ZE_DATA, 1, 1))  '/* Position dans l'index du jeu "B")
                            '
                            CODE_128_BAR &= TBL_SYMBOLS(P - 1)  '/* Ajout du symbole (jeu "B") */
                            ADD_CHAR(Asc(Mid(ZE_DATA, 1, 1)))
                            '
                            U = InStr(INDEX_A, Mid(ZE_DATA, 1, 1)) - 1
                            SUM += U * PND  '/* Somme pondérée */
                            PND += 1                                '/* Augmentation du facteur de pondération */
                            '
                            ZE_DATA = Mid(ZE_DATA, 2) : ZE_MASK = Mid(ZE_MASK, 2)   '/* Caractère suivant */
                            '
                        Else
                            '
                            CODE_128_BAR &= TBL_SYMBOLS(BAR_TO_MODE_B)  '/* Insertion passage en mode "B" */
                            ADD_CHAR(CHR_TO_MODE_B)
                            '
                            SUM += (BAR_TO_MODE_B * PND)    '/* Somme pondérée */
                            PND += 1                        '/* Augmentation du facteur de pondération */
                            '
                            MODE_A = False : MODE_B = True : MODE_C = False '/* Mise à jour des indicateurs de mode */
                            '
                        End If
                        '
                    End If
                    '
                    If MODE_A Then BAR_FNC4 = 101 Else BAR_FNC4 = 100 '/* Positionnement du FNC4 selon le mode */
                    '
                    '/* les caractères de contrôle éventuels ont été insérés    */
                    '/* les indicateurs de mode sont positionnés                */
                    '/* le cas du mode "C" est déjà traité                      */
                    '/* -> on traite selon le jeu "A" ou le jeu "B"...          */
                    '
                    If MODE_A Then P = InStr(INDEX_A, Mid(ZE_DATA, 1, 1)) '/* Position dans l'index du jeu "A")
                    If MODE_B Then P = InStr(INDEX_B, Mid(ZE_DATA, 1, 1)) '/* Position dans l'index du jeu "B")
                    '
                    '/****************************************************************************************************/
                    '
                    If P = 0 Then Stop '/* Abort on error (chr not found) */
                    '/* mis ici à titre "documentaire", ça voudrait dire que ce n'est aucun jeu et pas filtré */
                    '
                    '/****************************************************************************************************/
                    '
                    CODE_128_BAR &= TBL_SYMBOLS(P - 1)  '/* Ajout du caractère de données */
                    ADD_CHAR(Asc(Mid(ZE_DATA, 1, 1)))   '/* Ajout du caractère de données */
                    '
                    U = P - 1
                    SUM += U * PND  '/* Somme pondérée */
                    PND += 1                                '/* Augmentation du facteur de pondération */
                    '
                    ZE_DATA = Mid(ZE_DATA, 2) : ZE_MASK = Mid(ZE_MASK, 2)   '/* Caractère suivant */
                    '
                End If
                '
            End If
            '
        End While
        '
        '/* Calcul et ajout du check-digit */
        '
        V = CInt(SUM - (Int(SUM / 103) * 103))
        CODE_128_BAR &= TBL_SYMBOLS(V)
        ADD_CHAR(CHR_CHKSUM)
        '
        '/* Ajout du <Stop> */
        '
        CODE_128_BAR$ &= TBL_SYMBOLS(BAR_STOP_X)
        ADD_CHAR(CHR_STOP_X)
        '
    End Sub
    '
    '/*------------------------------------------------------------------------------------------------------------------------*/
    '/* Routine d'ajout aux 8 lignes du caractère */
    '
    Private Sub ADD_CHAR(ByVal V_CHR As Integer)
        '
        Dim I As Integer
        '
        For I = 0 To 7
            CODE_128_CHR(I) &= TBL_CHARACTERS(V_CHR, I)
        Next
        '
    End Sub
    '
    '
    '/*========================================================================================================================*/
    '
#End Region
#Region "***** PROCEDURES CODE 128 = PARTIE IV : GENERATE_IMAGE() *****"
    '
    '/*========================================================================================================================*/
    '/*  IV) On génère le bitmap */
    '/*========================================================================================================================*/
    '
    Private Sub GENERATE_IMAGE()
        '
        Dim FILE_SEQ As Integer     '/* Compteur pour les homonymes */
        '
        Dim Y_MAX As Integer = 150                      '/* hauteur du bitmap à générer */
        Dim X_MAX_B As Integer = CODE_128_BAR.Length    '/* Largeur maxi des barres */
        Dim X_MAX_C As Integer = CODE_128_CHR(0).Length '/* Largeur maxi des caractères */
        '
        Dim CODE_128_BMP As New Bitmap(X_MAX_B + 40, Y_MAX, Imaging.PixelFormat.Format32bppRgb)
        CODE_128_BMP.SetResolution(300, 300)
        '
        Dim CODE_128_GRF As Graphics = Graphics.FromImage(CODE_128_BMP)
        CODE_128_GRF.Clear(PXL_BackColor)
        '
        Dim X, Y As Integer
        '
        '/* Génération des barres */
        '
        For X = 0 To X_MAX_B - 1
            If CODE_128_BAR.Substring(X, 1) = "1" Then
                CODE_128_GRF.FillRectangle(CB_ForeColor, X + 20, Y + 10, 1, Y_MAX - 35)
            Else
                CODE_128_GRF.FillRectangle(CB_BackColor, X + 20, Y + 10, 1, Y_MAX - 35)
            End If
        Next
        '
        '/* Génération des caractères */
        '
        For Y = 0 To 7
            For X = 0 To X_MAX_C - 1
                If CODE_128_CHR(Y).Substring(X, 1) = "1" Then
                    CODE_128_GRF.FillRectangle(CB_ForeColor, X + 20, Y_MAX - 15 + Y, 1, 1)
                Else
                    CODE_128_GRF.FillRectangle(CB_BackColor, X + 20, Y_MAX - 15 + Y, 1, 1)
                End If
            Next
        Next
        '
        FILE_SEQ = 0
        '
        Dim OK As Boolean = False
        Dim ZE_NAME As String = ZE_CODE
        '
        If ZE_NAME.Length > 64 Then ZE_NAME = Mid(ZE_NAME, 1, 64)
        '
        IMG_FILE = IMG_PATH & "\" & FilterFileName(ZE_NAME) & ".bmp" '/* nom du bitmap */
        '
        While Not OK
            Try
                CODE_128_BMP.Save(IMG_FILE) '/* sauvegarde du bitmap */
                OK = True
            Catch ex As Exception   '/* il existe déja : +1 dans le compteur et on retry */
                IMG_FILE = IMG_PATH & "\" & ZE_CODE & "." & Format(FILE_SEQ, "DUP-0000") & ".bmp"
                FILE_SEQ += 1
                OK = False
            End Try
        End While
        '
    End Sub
    '
    '/*========================================================================================================================*/
    '
#End Region
#Region "***** INIT DES TABLES *****"
    '
    '/*========================================================================================================================*/
    ' 
    Private Sub LOAD_TABLES()
        '
        Dim F As Integer
        '
        '/* Chargement des symboles (barres) */
        '
        F = FreeFile()
        '
        FileOpen(F, COD_FILE, OpenMode.Input, OpenAccess.Read)
        '
        For NDX_SYMBOL = MIN_SYMBOL To MAX_SYMBOL
            TBL_SYMBOLS(NDX_SYMBOL) = LineInput(F)
        Next
        '
        FileClose(F)
        '
        '/* Chargement des caractères (semi-graphique) */
        '
        F = FreeFile()
        '
        FileOpen(F, CHR_FILE, OpenMode.Input, OpenAccess.Read)
        '
        For NDX_CHARACTER = MIN_CHARACTER To MAX_CHARACTER
            For NDX_CHARACTER_LINE = 0 To 7
                TBL_CHARACTERS(NDX_CHARACTER, NDX_CHARACTER_LINE) = LineInput(F)
            Next
        Next
        '
        FileClose(F)
        '
    End Sub
    '
    '/*========================================================================================================================*/
    '
#End Region

    Private Sub CMD_GO_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_GO.Click
        CMD_GO_Click(sender, e)

        Dim Code As String = 6 & "  " & "|" & LBL_INTERPRETE.Text & LBL_MASQUE.Text
        FrmArticle.txtCodeBarre.Text = Code
        FrmArticle.Show()
    End Sub

 
    Private Sub Fermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fermer.Click
        Me.Close()

    End Sub
End Class