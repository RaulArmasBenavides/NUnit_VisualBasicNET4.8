Module Module1
    Sub Main()
        Dim bo As New Bw2
        'bo.ExecuteFunctionCustom(HardCodeJSON(), "192.168.1.1")
        'IP:
        Dim originalTitle As String = "IP:HL Telemedicine to appoint Jason M. Bottiglieri, a highly experienced healthcare"
        Console.WriteLine(bo.Convert(originalTitle))
        Console.ReadLine()
    End Sub


    Public HardCodeJSON As Func(Of String) = Function()
                                                 Return "{
	                                                            ""MethodName"": ""InputFeedJSON"",
	                                                            ""provider"":""PUBT"",
	                                                            ""payload"": ""xxx""
                                                         }"
                                             End Function
End Module
