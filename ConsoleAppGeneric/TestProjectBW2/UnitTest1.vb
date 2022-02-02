Imports ConsoleApp1
Imports NUnit.Framework

Namespace TestProjectBW2

    Public Class Tests

        <SetUp>
        Public Sub Setup()
        End Sub

        <Test>
        Public Sub Test1()
            Dim b As New Bw2
            Console.WriteLine(b.GetSerieByYear())
        End Sub

    End Class

End Namespace