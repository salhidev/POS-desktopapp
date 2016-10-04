Public Class Prototype

    Public _ID As String
    Public _Libele As String

    Public Sub New(ByVal id As String, ByVal libele As String)

        _ID = id
        _Libele = libele

    End Sub

    Public Function RetournerLibele() As String
        Return _Libele
    End Function

End Class
