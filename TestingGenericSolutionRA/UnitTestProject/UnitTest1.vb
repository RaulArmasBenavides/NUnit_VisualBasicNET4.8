Imports NUnit.Framework
Imports TestingGenericSolutionnNET4

Namespace UnitTestProject

    Public Class Tests

        <SetUp>
        Public Sub Setup()
        End Sub

        <Test>
        Public Sub GetSerieByYear_Test()
            Dim b As New Bw2
            b.GetSerieByYear()
        End Sub

        <Test>
        Public Sub EliminarString_Test()
            Dim b As New Bw2
            Dim res As String = String.Empty
            res = b.RemoveSubString("_COOPERA_Schuld_Account01_InputControl", "_InputControl")
            Console.WriteLine(res)
        End Sub


        <Test>
        Private Function RoundAwayFromZero(ByVal param As Decimal) As Decimal
            Return Math.Round(param, MidpointRounding.AwayFromZero)
        End Function

    End Class

End Namespace