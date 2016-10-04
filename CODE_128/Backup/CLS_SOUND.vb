Public Class CLS_SOUND
    '
    Declare Auto Function PlaySound Lib "winmm.dll" (ByVal name As String, ByVal hmod As Integer, ByVal flags As Integer) As Integer
    Declare Auto Function PlaySound Lib "winmm.dll" (ByVal name As Byte(), ByVal hmod As Integer, ByVal flags As Integer) As Integer
    '
    Public Const SND_SYNC As Integer = &H0 ' play synchronously 
    Public Const SND_ASYNC As Integer = &H1 ' play asynchronously 
    Public Const SND_MEMORY As Integer = &H4  'Play wav in memory
    Public Const SND_ALIAS As Integer = &H10000 'Play system alias wav 
    Public Const SND_NODEFAULT As Integer = &H2
    Public Const SND_FILENAME As Integer = &H20000 ' name is file name 
    Public Const SND_RESOURCE As Integer = &H40004 ' name is resource name or atom 
    '
End Class

