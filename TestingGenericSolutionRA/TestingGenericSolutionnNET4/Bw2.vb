Public Class Bw2

    Public Function GetSerieByYear() As String
        Dim newcode As String = ""
        Dim dif As Integer
        dif = Year(Date.Now) - 2021
        newcode = (41 + dif).ToString()
        Return newcode
    End Function

    Public Function RemoveSubString(_originalstring As String, _substring As String) As String

        Dim result As String = String.Empty
        Dim position As Long
        Dim _length As Long
        Dim _rigth As String

        _rigth = _originalstring

        _length = Len(_substring)
        position = InStr(1, _rigth, _substring)
        If position = 0 Then
            result = _originalstring
        Else
            While Not position = 0
                result = result & Left(_rigth, position - 1)
                _rigth = Mid(_rigth, position + _length + 1)
                position = InStr(1, _rigth, _substring)
            End While
        End If
        Return result
    End Function

    Public Function RoundAwayFromZero(ByVal param As Decimal) As Decimal
        Return Math.Ceiling(param)
    End Function

End Class
