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


        '<Test>
        'Public Function RoundAwayFromZero(ByVal param As Decimal) As Decimal
        '    Return Math.Round(param, MidpointRounding.AwayFromZero)
        'End Function

        <Test>
        Public Sub GetConstMyDynamicControlDictionaryoNew()
            Dim dictionaryControlsExternal As New Dictionary(Of String, String) From {{"_COOPERA_Rucknah_Bemerkun_InputControl", "_COOPERA_Rucknahmeverpflichtung_Label"},
                                                                                      {"_COOPERA_sicherheit_Bemerkung_InputControl", "_COOPERA_Hinterlage_sicherheit_Label"},
                                                                                      {"_COOPERA_Nachhal_Bemerkun_InputControl", "_COOPERA_Nachhaltigkeit_Label"},
                                                                                      {"_COOPERA_Eigentumsanzeige_Account_ID_InputControl", "_COOPERA_Eigentumsanzeige_Label"}}
        End Sub

        <Test>
        Public Sub GetConstMyDynamicControlDictionaryoOLD()
            Dim dictionaryControlsExternal As New Dictionary(Of String, String)
            dictionaryControlsExternal.Add("_COOPERA_Rucknah_Bemerkun_InputControl", "_COOPERA_Rucknahmeverpflichtung_Label")
            dictionaryControlsExternal.Add("_COOPERA_sicherheit_Bemerkung_InputControl", "_COOPERA_Hinterlage_sicherheit_Label")
            dictionaryControlsExternal.Add("_COOPERA_Nachhal_Bemerkun_InputControl", "_COOPERA_Nachhaltigkeit_Label")
            dictionaryControlsExternal.Add("_COOPERA_Versicherungs_Account_InputControl", "_COOPERA_Versicherungs_Label")
            dictionaryControlsExternal.Add("_COOPERA_Eigentumsanzeige_Account_ID_InputControl", "_COOPERA_Eigentumsanzeige_Label")
        End Sub






    End Class

End Namespace