Public Class FRM_CODE_128
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
        '/* retourne une chaine contenant les caract�res valides en code 128 en cas */
        '/* d'entr�e au clavier; afin d'encoder correctement les caract�res de contr�le, */
        '/* si entr�e par fichier (cas d'un traitement auto.), il convient de modifier le test. */
        '
        Dim I As Integer
        Dim S As String = ""
        '
        For I = 1 To Len(Z)
            '
            '/***** TEST en cas d'entr�e par fichier (mode "automatique") *****/
            'If Mid$(Z, I, 1) >= Chr(&H7F) Then 
            '
            '/***** TEST en cas d'entr�e clavier *****/
            If Mid$(Z, I, 1) < Chr(&H20) Or Mid$(Z, I, 1) >= Chr(&H7F) Then
                S &= "#"            '/* Caract�re invalide, remplac� ARBITRAIREMENT PAR MOI par "#", na! (on peut changer... (ndlr)) */
            Else
                S &= Mid(Z, I, 1)   '/* Caract�re OK, r.a.s. */
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
        '/* Fonction d'affichage du bitmap dans la PictureBox apr�s g�n�ration */
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
        '/* Fonction de filtrage du nom de fichier pour le bitmap (nom g�n�r� directement */
        '/* depuis l'entr�e clavier / fichier => risque de caract�res invalides */
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
    Dim FILE_PATH As String = DirNotBin(Application.StartupPath)
    '
    Dim INI_FILE As String = FILE_PATH & "\CODE_128.ini"    '/* Fichier de param�tres initiaux */
    Dim COD_FILE As String = FILE_PATH & "\CODE_128.txt"    '/* Fichier des configurations du code ("11"=module sombre/"00"=module clair) */
    Dim CHR_FILE As String = FILE_PATH & "\CHAR_128.txt"    '/* Fichier des caract�res semi-graphiques ("1"=point sombre/"0"=point clair) */
    Dim SND_FILE As String = FILE_PATH & "\ERR_ALERTE.wav"  '/* Fichier wave pour un signal sonore quelconque (pas encore utilis� ici) */
    '
    Dim IMG_PATH As String = FILE_PATH & "\_GENERE"         '/* R�pertoire de sortie pour images bitmap */
    Dim IMG_FILE As String                                  '/* Nom du fichier image (construit par la suite) */
    '
    Dim WRK_IMG As Bitmap                                   '/* Bitmap de travail */
    '
    '/*----------------------------------------------------------------------------------------------------*/
    '
    Const COPYRIGHT_TEXT As String = "Copyright � Eric DRAPIER, Oct.1999-Feb.2010"
    '
    '/*------------------------------------------------------------------------------------------------------------------------*/
    '
    Dim CB_ForeColor As Brush = Brushes.Black               '/* Couleur d'avant-plan du bitmap */
    Dim PXL_ForeColor As Color = Color.Black
    '
    Dim CB_BackColor As Brush = Brushes.White               '/* Couleur d'arri�re-plan du bitmap */
    Dim PXL_BackColor As Color = Color.White
    '
    '/*------------------------------------------------------------------------------------------------------------------------*/
    '
    Dim TBL_SYMBOLS(106) As String                          '/* Table de la symbologie Code128 */
    Dim NDX_SYMBOL As Integer                               '/* Index courant */
    Dim MIN_SYMBOL As Integer = 0                           '/* Index minima */
    Dim MAX_SYMBOL As Integer = 106                         '/* Index maxima */
    '
    Dim TBL_CHARACTERS(150, 7) As String                    '/* Table des caract�res graphiques (151 matrices sur 8 lignes) */
    Dim NDX_CHARACTER As Integer                            '/* Index courant caract�re */
    Dim NDX_CHARACTER_LINE As Integer                       '/* Index courant ligne dans le caract�re */
    Dim MIN_CHARACTER As Integer = 0                        '/* Index minima */
    Dim MAX_CHARACTER As Integer = 150                      '/* Index maxima */
    '
    Dim FORBIDDEN As String
    '
    '/*------------------------------------------------------------------------------------------------------------------------*/
    '
    '/* D�finition des index "sp�ciaux" dans les tables */
    '
    '/* Table des symboles */
    '
    Const BAR_START_A As Integer = 103      '/* Caract�re de d�but en jeu "A" */
    Const BAR_START_B As Integer = 104      '/* Caract�re de d�but en jeu "B" */
    Const BAR_START_C As Integer = 105      '/* Caract�re de d�but en jeu "C" */
    Const BAR_STOP_X As Integer = 106       '/* Caract�re de fin en tous jeux */
    '
    Const BAR_TO_MODE_A As Integer = 101    '/* Caract�re de bascule en jeu "A" */
    Const BAR_TO_MODE_B As Integer = 100    '/* Caract�re de bascule en jeu "B" */
    Const BAR_TO_MODE_C As Integer = 99     '/* Caract�re de bascule en jeu "C" */
    '
    Const BAR_SHIFT As Integer = 98         '/* Caract�re de d�calage de mode */
    '
    Const BAR_FNC1 As Integer = 102         '/* Caract�re de fonction FNC1 */
    Const BAR_FNC2 As Integer = 97          '/* Caract�re de fonction FNC2 */
    Const BAR_FNC3 As Integer = 96          '/* Caract�re de fonction FNC3 */
    Dim BAR_FNC4 As Integer                 '/* Caract�re de fonction FNC4 (variable selon jeu "A" ou jeux "B" ou "C") */
    '
    '/* Table des matrices de caract�res */
    '
    Const CHR_START_A As Integer = 128      '/* Caract�re de d�but en jeu "A" */
    Const CHR_START_B As Integer = 129      '/* Caract�re de d�but en jeu "B" */
    Const CHR_START_C As Integer = 130      '/* Caract�re de d�but en jeu "C" */
    Const CHR_STOP_X As Integer = 131       '/* Caract�re de fin en tous jeux */
    '
    Const CHR_TO_MODE_A As Integer = 133    '/* Caract�re de bascule en jeu "A" */
    Const CHR_TO_MODE_B As Integer = 134    '/* Caract�re de bascule en jeu "B" */
    Const CHR_TO_MODE_C As Integer = 135    '/* Caract�re de bascule en jeu "C" */
    '
    Const CHR_SHIFT As Integer = 132        '/* Caract�re de d�calage de mode */
    '
    Const CHR_FNC1 As Integer = 136         '/* Caract�re de fonction FNC1 */
    Const CHR_FNC2 As Integer = 137         '/* Caract�re de fonction FNC2 */
    Const CHR_FNC3 As Integer = 138         '/* Caract�re de fonction FNC3 */
    Const CHR_FNC4 As Integer = 139         '/* Caract�re de fonction FNC4 */ 
    '
    Const CHR_CHKSUM As Integer = 150       '/* Caract�re repr�sentant la Checksum */
    '
    '/***** NOTE : repris de la norme AFNOR NF EN 799; concerne l'interpr�tation en clair */ 
    '
    'ANNEXE A.2	Interpr�tation en clair
    '
    'Une interpr�tation en clair des caract�res de donn�es (qui doivent correspondre aux caract�res
    'transmis par le d�codeur) doit �tre imprim�e avec le symbole "Code 128" qui les encode. Les
    'caract�res de d�but/fin et les caract�res sp�ciaux ne doivent pas �tre imprim�s. La dimension
    'et la police des carct�res ne sont pas pr�cis�es, et l'interpr�tation peut �tre imprim�e o�
    'que ce soit dans la zone entourant le symbole, tant que les limites de marges sont respect�es
    '(voir 4.3.).
    '
    '/* => dans cette source, j'ai volontairement choisi d'"imprimer" tous les caract�res, */
    '/* STARTs, STOP, SHIFT, bascule entre modes, checksum, etc en clair � des fins de test */
    '/* il suffit de remplacer les index sp�ciaux CHR_xxxxx = nnnn as integer par */ 
    '/* CHR_xxxxx as integer = 32 pour remplacer la matrice par une matrice blanche (espace) */
    '
    '/***** Pour information *****/
    '/* Le jeu "A" se compose de la suite &h20 � &h5F suivie de la suite &h00 � &h1F, suivie */
    '/* elle-m�me des caract�res FNC3, FNC2, SHIFT, ToModeC, ToModeB, FNC4, FNC1, StartA, */
    '/* StartB, StartC, Stop, dans l'ordre. */
    '
    '/* Le jeu "B" se compose de la suite &h20 � &h7F, suivie des caract�res FNC3, FNC2, */
    '/* SHIFT, ToModeC, FNC4, ToModeA, FNC1, StartA, StartB, StartC, Stop, dans l'ordre. */
    '
    '/* Le jeu "C" se compose des paires de chiffres 00 � 99, suivies des caract�res ToModeB, */
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
    Dim CODE_128_CHR(7) As String           '/* Interpr�tation en clair sous forme de "1" et de "0" */
    '
    Dim P_CTL As Integer                    '/* Indicateur "caract�res de contr�le" */
    Dim P_MIN As Integer                    '/* Indicateur "minuscules" */
    '
    Dim SUM As Long                         '/* Checkdigit : somme */
    Dim PND As Integer                      '/* Checkdigit : pond�ration */
    '
    '/*========================================================================================================================*/
    '
#End Region
#Region "***** FORM LOAD/UNLOAD *****"
    '
    '/*========================================================================================================================*/
    '/* Chargement de la form */
    '
    Private Sub FRM_CODE_128_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
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
    Private Sub CMD_GO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_GO.Click
        '
        ZE_DATA = FilterChars(TXB_INCODE.Text)
        ZE_CODE = ZE_DATA
        LBL_INTERPRETE.Text = ZE_DATA
        '
        GENERATE_MASK()     '/* G�n�ration du masque d'analyse pour l'encodage */
        GENERATE_START()    '/* D�termination du Start mode (A/B/C) */
        GENERATE_CODE()     '/* Encodage */
        GENERATE_IMAGE()    '/* G�n�ration du bitmap */
        '
        Dim X As Boolean = IMG_SHOW(IMG_FILE, 626, 170) '/* Affichage du bitmap g�n�r� */
        If Not X Then
            MsgBox("Erreur lors de la g�n�ration du code-barre")
        End If
        '
    End Sub
    '
    '/*------------------------------------------------------------------------------------------------------------------------*/
    '/* Fermeture de la form */
    '
    Private Sub CMD_STOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_STOP.Click
        '
        Me.Close()
        '
    End Sub
    '
    '/*------------------------------------------------------------------------------------------------------------------------*/
    '/* Affichage de la form "Au sujet de..."; les mentions sont r�cup�r�es de l'assembly */
    '
    Private Sub CMD_ABOUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_ABOUT.Click
        '
        Dim F_ABOUT As New FRM_CODE_128_ABOUT
        F_ABOUT.ShowDialog(Me)
        F_ABOUT.Dispose()
        '
    End Sub
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
        INDEX_A = ""    '/* Cr�ation de l'index du Jeu de code "A" */
        For I = 32 To 95 : INDEX_A &= Chr(I) : Next
        For I = 0 To 31 : INDEX_A &= Chr(I) : Next
        '
        INDEX_B = ""    '/* Cr�ation de l'index du Jeu de code "B" */
        For I = 32 To 127 : INDEX_B &= Chr(I) : Next
        '
    End Sub
    '
    '/*------------------------------------------------------------------------------------------------------------------------*/
    '/* Jeu du son pass� en param�tre - (pas encore utilis� ici) */
    '
    Private Sub BEEP(ByVal WRK_SOUND As String)
        '
        CLS_SOUND.PlaySound(WRK_SOUND, 0, CLS_SOUND.SND_FILENAME Or CLS_SOUND.SND_ASYNC)
        '
    End Sub
    '
    '/*========================================================================================================================*/
    '
#End Region
#Region "***** PROCEDURES CODE 128 = PARTIE I : GENERATE_MASK() *****"
    '
    '/*========================================================================================================================*/
    '/* I) On g�n�re un "masque" permettant de synth�tiser les diff�rentes    */
    '/*    sortes de caract�res afin de pr�parer l'optimisation de l'encodage */
    '/*    pour augmenter la densit� du code-barre                            */
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
            '/* on teste le caract�re extrait et, (au sens du code 128) :      */
            '/*     si c'est un caract�re de contr�le, on ajoute "#" au masque */
            '/*     si c'est un caract�re num�rique, on ajoute "9" au masque   */
            '/*     si c'est un caract�re minuscule, on ajoute "x" au masque   */
            '/*     si c'est un caract�re majuscule, on ajoute "X" au masque   */
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
    '/* II) On d�termine le caract�re de d�but en fonction du "masque" g�n�r� : */
    '/*                                                                         */
    '/* 1) Si la donn�e commence par 4 caract�res num�riques ou plus :          */
    '/*    -> utiliser le caract�re de d�but C [StartC]                         */
    '/* 2) Si un caract�re de contr�le ASCII (par exemple NUL) se trouve        */
    '/*    dans la donn�e avant un caract�re minuscule :                        */
    '/*    -> utiliser le caract�re de d�but A [StartA]                         */
    '/* 3) autrement :                                                          */
    '/*    -> utiliser le caract�re de d�but B [StartB]                         */
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
        If Mid(ZE_MASK, 1, 4) = "9999" Then                     '/* R�gle II-1) */
            CHR_START_X = CHR_START_C
            BAR_START_X = BAR_START_C                           '/* StartC s�lectionn� */
            MODE_C = True
        Else
            P_CTL = InStr(ZE_MASK, "#") '/* Position du premier caract�re de contr�le */
            P_MIN = InStr(ZE_MASK, "x") '/* Position du premier caract�re minuscule */
            '
            If P_CTL > 0 And (P_MIN = 0 Or P_CTL < P_MIN) Then  '/* R�gle II-2) */
                CHR_START_X = CHR_START_A
                BAR_START_X = BAR_START_A                       '/* StartA s�lectionn� */
                MODE_A = True
            Else                                                '/* R�gle II-3) */
                CHR_START_X = CHR_START_B
                BAR_START_X = BAR_START_B                       '/* StartB s�lectionn� */
                MODE_B = True
            End If
        End If
        '
        CODE_128_BAR = TBL_SYMBOLS(BAR_START_X)                 '/* Ajout des barres du start s�lectionn� */
        '
        ADD_CHAR(CHR_START_X)                                   '/* Ajout de la matrice du start s�lectionn� */
        '
        SUM = BAR_START_X                                       '/* Init. de la somme � la valeur du start */
        PND = 1                                                 '/* Init. de la pond�ration */
        '
    End Sub
    '
    '/*========================================================================================================================*/
    '
#End Region
#Region "***** PROCEDURES CODE 128 = PARTIE III : GENERATE_CODE() *****"
    '
    '/*========================================================================================================================*/
    '/* III) On g�n�re les barres en fonction du "masque" g�n�r� :              */
    '/*                                                                         */
    '/* 1) Si le caract�re de d�but C [StartC] est utilis� et que la donn�e     */
    '/*    commence avec un nombre impair de caract�res num�riques :            */
    '/*    -> ins�rer un caract�re de basculement en mode A [ToModeA] ou C      */ 
    '/*       [ToModeC] avant le dernier chiffre en suivant les r�gles II-2)    */
    '/*       et II-3) afin de faire la distinction entre les modes A et B      */
    '/*                                                                         */
    '/* 2) Si 4 caract�res num�riques ou plus se trouvent ensemble lorsqu'ils   */
    '/*    sont en mode A ou B :                                                */
    '/*     a) s'il y a un nombre pair de caract�res num�riques :               */
    '/*        -> ins�rer un caract�re de mode C [ToModeC] avant le premier     */ 
    '/*           chiffre pour passer en mode C                                 */  
    '/*     b) s'il y a un nombre impair de caract�res num�riques :             */
    '/*        -> ins�rer un caract�re de mode C [ToModeC] imm�diatement apr�s  */
    '/*           le premier chiffre pour passer en mode C.                     */    
    '/*                                                                         */
    '/* 3) Lorsque l'on se trouve en mode B et qu'un caract�re de contr�le      */
    '/*    ASCII se trouve dans la donn�e :                                     */
    '/*     a) s'il y a un caract�re minuscule imm�diatement apr�s le           */
    '/*        caract�re de contr�le:                                           */
    '/*        -> ins�rer un caract�re de basculement unitaire [Shift] avant le */
    '/*           caract�re de contr�le                                         */
    '/*     b) autrement :                                                      */    
    '/*        -> ins�rer un caract�re de mode A [ToModeA] avant le caract�re   */
    '/*           de contr�le pour passer en mode A.                            */
    '/*                                                                         */
    '/* 4) Lorsque l'on se trouve en mode A et qu'un caract�re minuscule se     */
    '/*    trouve dans la donn�e :                                              */
    '/*     a) si un caract�re de contr�le se trouve dans la donn�e apr�s ce    */
    '/*        caract�re et avant un autre caract�re minuscule :                */
    '/*        -> ins�rer un caract�re de basculement unitaire [Shift] avant le */
    '/*           caract�re minuscule                                           */
    '/*     b) autrement :                                                      */
    '/*        -> ins�rer un caract�re de mode B [ToModeB] avant le caract�re   */
    '/*           minuscule pour passer en mode B.                              */
    '/*                                                                         */
    '/* 5) Lorsque l'on se trouve en mode C et qu'un caract�re non num�rique    */
    '/*    se trouve dans la donn�e :                                           */
    '/*    -> ins�rer un caract�re de basculement global en mode A [ToModeA] ou */
    '/*       un caract�re de mode B [ToModeB] avant ce caract�re en suivant    */
    '/*       les r�gles II-2) et II-3) pour distinguer entre les modes A et B. */
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
                If Mid(ZE_MASK, 1, 2) = "99" Then   '/* R�gle III-1) (en fait on traite le cas MODE C ET nombre pair de num�riques) */
                    '
                    V = CInt(Val(Mid(ZE_DATA, 1, 2)))   '/* Valeur de la paire de num�riques */
                    '
                    CODE_128_BAR &= TBL_SYMBOLS(V)  '/* Ajout du symbole (jeu C, n� de la paire de num.) */
                    ADD_CHAR(140 + (V \ 10))    '/* Premier caract�re de la paire */
                    ADD_CHAR(140 + (V Mod 10))  '/* Second caract�re de la paire */
                    '
                    SUM += (V * PND)    '/* Somme pond�r�e */
                    PND += 1            '/* Augmentation du facteur de pond�ration */
                    '
                    ZE_DATA = Mid(ZE_DATA, 3) : ZE_MASK = Mid(ZE_MASK, 3)   '/* Caract�re suivant */
                    '
                Else                                '/* R�gle III-5) */
                    '
                    P_CTL = InStr(ZE_MASK, "#") '/* Position du premier caract�re de contr�le */
                    P_MIN = InStr(ZE_MASK, "x") '/* Position du premier caract�re minuscule */
                    '
                    If P_CTL > 0 And (P_MIN = 0 Or P_CTL < P_MIN) Then
                        '
                        CODE_128_BAR &= TBL_SYMBOLS(BAR_TO_MODE_A)  '/* Insertion passage en mode "A" */
                        ADD_CHAR(CHR_TO_MODE_A)
                        '
                        SUM += (BAR_TO_MODE_A * PND)    '/* Somme pond�r�e */
                        PND += 1                        '/* Augmentation du facteur de pond�ration */
                        '
                        MODE_A = True : MODE_B = False : MODE_C = False '/* Mise � jour des indicateurs de mode */
                        '
                    Else
                        '
                        CODE_128_BAR &= TBL_SYMBOLS(BAR_TO_MODE_B)  '/* Insertion passage en mode "B" */
                        ADD_CHAR(CHR_TO_MODE_B)
                        '
                        SUM += (BAR_TO_MODE_B * PND)    '/* Somme pond�r�e */
                        PND += 1                        '/* Augmentation du facteur de pond�ration */
                        '
                        MODE_A = False : MODE_B = True : MODE_C = False '/* Mise � jour des indicateurs de mode */
                        '
                    End If
                    '
                End If
                '
            Else    '/* On est en mode "A" ou en mode "B" */
                '
                If Mid(ZE_MASK, 1, 4) = "9999" Then     '/* R�gle III-2) */
                    '
                    CODE_128_BAR &= TBL_SYMBOLS(BAR_TO_MODE_C)  '/* Insertion passage en mode "C" */
                    ADD_CHAR(CHR_TO_MODE_C)
                    '
                    SUM += (BAR_TO_MODE_C * PND)    '/* Somme pond�r�e */
                    PND += 1                        '/* Augmentation du facteur de pond�ration */
                    '
                    MODE_A = False : MODE_B = False : MODE_C = True '/* Mise � jour des indicateurs de mode */
                    '
                Else
                    '
                    If MODE_B And Mid(ZE_MASK, 1, 1) = "#" Then
                        '
                        If Mid(ZE_MASK, 1, 2) = "#x" Then   '/* R�gle III-3) */
                            '
                            CODE_128_BAR &= TBL_SYMBOLS(BAR_SHIFT)  '/* Insertion bascule unitaire */
                            ADD_CHAR(CHR_SHIFT)
                            '
                            SUM += (BAR_SHIFT * PND)    '/* Somme pond�r�e */
                            PND += 1                    '/* Augmentation du facteur de pond�ration */
                            '
                            P = InStr(INDEX_A, Mid(ZE_DATA, 1, 1))  '/* Position dans l'index du jeu "A")
                            '
                            CODE_128_BAR &= TBL_SYMBOLS(P - 1) '/* Ajout du symbole (jeu "A") */
                            ADD_CHAR(Asc(Mid(ZE_DATA, 1, 1)))
                            '
                            U = InStr(INDEX_B, Mid(ZE_DATA, 1, 1)) - 1
                            SUM += U * PND  '/* Somme pond�r�e */
                            PND += 1                                '/* Augmentation du facteur de pond�ration */   
                            '
                            ZE_DATA = Mid(ZE_DATA, 2) : ZE_MASK = Mid(ZE_MASK, 2)   '/* Caract�re suivant */
                            '
                        Else
                            '
                            CODE_128_BAR &= TBL_SYMBOLS(BAR_TO_MODE_A)  '/* Insertion passage en mode "A" */
                            ADD_CHAR(CHR_TO_MODE_A)
                            '
                            SUM += (BAR_TO_MODE_A * PND)    '/* Somme pond�r�e */
                            PND += 1                        '/* Augmentation du facteur de pond�ration */
                            '
                            MODE_A = True : MODE_B = False : MODE_C = False '/* Mise � jour des indicateurs de mode */
                            '
                        End If
                        '
                    End If
                    '
                    If MODE_A And Mid(ZE_MASK, 1, 1) = "x" Then '/* R�gle III-4) */
                        '
                        If Mid(ZE_MASK, 1, 2) = "x#" Then
                            '
                            CODE_128_BAR &= TBL_SYMBOLS(BAR_SHIFT)  '/* Insertion bascule unitaire */
                            ADD_CHAR(CHR_SHIFT)
                            '
                            SUM += (BAR_SHIFT * PND)    '/* Somme pond�r�e */
                            PND += 1                    '/* Augmentation du facteur de pond�ration */
                            '
                            P = InStr(INDEX_B, Mid(ZE_DATA, 1, 1))  '/* Position dans l'index du jeu "B")
                            '
                            CODE_128_BAR &= TBL_SYMBOLS(P - 1)  '/* Ajout du symbole (jeu "B") */
                            ADD_CHAR(Asc(Mid(ZE_DATA, 1, 1)))
                            '
                            U = InStr(INDEX_A, Mid(ZE_DATA, 1, 1)) - 1
                            SUM += U * PND  '/* Somme pond�r�e */
                            PND += 1                                '/* Augmentation du facteur de pond�ration */
                            '
                            ZE_DATA = Mid(ZE_DATA, 2) : ZE_MASK = Mid(ZE_MASK, 2)   '/* Caract�re suivant */
                            '
                        Else
                            '
                            CODE_128_BAR &= TBL_SYMBOLS(BAR_TO_MODE_B)  '/* Insertion passage en mode "B" */
                            ADD_CHAR(CHR_TO_MODE_B)
                            '
                            SUM += (BAR_TO_MODE_B * PND)    '/* Somme pond�r�e */
                            PND += 1                        '/* Augmentation du facteur de pond�ration */
                            '
                            MODE_A = False : MODE_B = True : MODE_C = False '/* Mise � jour des indicateurs de mode */
                            '
                        End If
                        '
                    End If
                    '
                    If MODE_A Then BAR_FNC4 = 101 Else BAR_FNC4 = 100 '/* Positionnement du FNC4 selon le mode */
                    '
                    '/* les caract�res de contr�le �ventuels ont �t� ins�r�s    */
                    '/* les indicateurs de mode sont positionn�s                */
                    '/* le cas du mode "C" est d�j� trait�                      */
                    '/* -> on traite selon le jeu "A" ou le jeu "B"...          */
                    '
                    If MODE_A Then P = InStr(INDEX_A, Mid(ZE_DATA, 1, 1)) '/* Position dans l'index du jeu "A")
                    If MODE_B Then P = InStr(INDEX_B, Mid(ZE_DATA, 1, 1)) '/* Position dans l'index du jeu "B")
                    '
                    '/****************************************************************************************************/
                    '
                    If P = 0 Then Stop '/* Abort on error (chr not found) */
                    '/* mis ici � titre "documentaire", �a voudrait dire que ce n'est aucun jeu et pas filtr� */
                    '
                    '/****************************************************************************************************/
                    '
                    CODE_128_BAR &= TBL_SYMBOLS(P - 1)  '/* Ajout du caract�re de donn�es */
                    ADD_CHAR(Asc(Mid(ZE_DATA, 1, 1)))   '/* Ajout du caract�re de donn�es */
                    '
                    U = P - 1
                    SUM += U * PND  '/* Somme pond�r�e */
                    PND += 1                                '/* Augmentation du facteur de pond�ration */
                    '
                    ZE_DATA = Mid(ZE_DATA, 2) : ZE_MASK = Mid(ZE_MASK, 2)   '/* Caract�re suivant */
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
    '/* Routine d'ajout aux 8 lignes du caract�re */
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
    '/*  IV) On g�n�re le bitmap */
    '/*========================================================================================================================*/
    '
    Private Sub GENERATE_IMAGE()
        '
        Dim FILE_SEQ As Integer     '/* Compteur pour les homonymes */
        '
        Dim Y_MAX As Integer = 150                      '/* hauteur du bitmap � g�n�rer */
        Dim X_MAX_B As Integer = CODE_128_BAR.Length    '/* Largeur maxi des barres */
        Dim X_MAX_C As Integer = CODE_128_CHR(0).Length '/* Largeur maxi des caract�res */
        '
        Dim CODE_128_BMP As New Bitmap(X_MAX_B + 40, Y_MAX, Imaging.PixelFormat.Format32bppRgb)
        CODE_128_BMP.SetResolution(300, 300)
        '
        Dim CODE_128_GRF As Graphics = Graphics.FromImage(CODE_128_BMP)
        CODE_128_GRF.Clear(PXL_BackColor)
        '
        Dim X, Y As Integer
        '
        '/* G�n�ration des barres */
        '
        For X = 0 To X_MAX_B - 1
            If CODE_128_BAR.Substring(X, 1) = "1" Then
                CODE_128_GRF.FillRectangle(CB_ForeColor, X + 20, Y + 10, 1, Y_MAX - 35)
            Else
                CODE_128_GRF.FillRectangle(CB_BackColor, X + 20, Y + 10, 1, Y_MAX - 35)
            End If
        Next
        '
        '/* G�n�ration des caract�res */
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
            Catch ex As Exception   '/* il existe d�ja : +1 dans le compteur et on retry */
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
        '/* Chargement des caract�res (semi-graphique) */
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
End Class
