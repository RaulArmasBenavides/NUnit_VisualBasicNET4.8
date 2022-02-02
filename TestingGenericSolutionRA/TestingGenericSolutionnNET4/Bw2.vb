Public Class Bw2

    Public Function GetSerieByYear() As String
        Dim newcode As String = ""
        Dim dif As Integer
        dif = Year(Date.Now) - 2021
        newcode = (41 + dif).ToString()
        Return newcode
    End Function

End Class
