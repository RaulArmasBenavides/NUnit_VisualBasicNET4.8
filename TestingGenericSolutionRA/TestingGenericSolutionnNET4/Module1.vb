Module Module1
    Sub Main()
        Dim bo As New Bw2
        bo.ExecuteFunctionCustom(HardCodeJSON(), "192.168.1.1")
    End Sub


    Public HardCodeJSON As Func(Of String) = Function()
                                                 Return "{
	                                                            ""MethodName"": ""InputFeedJSON"",
	                                                            ""provider"":""PUBT"",
	                                                            ""payload"": ""xxx""
                                                         }"
                                             End Function
End Module
