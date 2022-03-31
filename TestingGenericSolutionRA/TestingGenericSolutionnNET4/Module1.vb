Module Module1

    Sub Main()
        Dim bo As New Bw2
        'bo.GetSerieByYear()

        'Dim res As String = String.Empty
        'res = bo.RemoveSubString("_COOPERA_Schuld_Account01_InputControl".Substring(1), "_InputControl")
        'Console.WriteLine(res)
        'Console.WriteLine(bo.RoundAwayFromZero(3.2))
        'Console.ReadLine()
        Dim en As Dictionary(Of String, String)
        en = bo.GetConstMyDynamicControlDictionaryoNew()
        Console.WriteLine(en)
        Console.ReadLine()



        bo.func3.Invoke(3)
    End Sub

End Module
