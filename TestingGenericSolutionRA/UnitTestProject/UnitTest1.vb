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

    End Class

End Namespace