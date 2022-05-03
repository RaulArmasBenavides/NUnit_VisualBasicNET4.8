Imports System.IO
Imports System.Web.Script.Serialization

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

    Public Function GetConstMyDynamicControlDictionaryoNew() As Dictionary(Of String, String)
        Dim dictionaryControlsExternal As New Dictionary(Of String, String) From {{"_COOPERA_Rucknah_Bemerkun_InputControl", "_COOPERA_Rucknahmeverpflichtung_Label"},
                                                                                                {"_COOPERA_sicherheit_Bemerkung_InputControl", "_COOPERA_Hinterlage_sicherheit_Label"},
                                                                                                {"_COOPERA_Nachhal_Bemerkun_InputControl", "_COOPERA_Nachhaltigkeit_Label"},
                                                                                                {"_COOPERA_Eigentumsanzeige_Account_ID_InputControl", "_COOPERA_Eigentumsanzeige_Label"}}
        Return dictionaryControlsExternal
    End Function


    Public Function GetConstMyDynamicControlDictionaryoOLD() As Dictionary(Of String, String)
        Dim dictionaryControlsExternal As New Dictionary(Of String, String)
        dictionaryControlsExternal.Add("_COOPERA_Rucknah_Bemerkun_InputControl", "_COOPERA_Rucknahmeverpflichtung_Label")
        dictionaryControlsExternal.Add("_COOPERA_sicherheit_Bemerkung_InputControl", "_COOPERA_Hinterlage_sicherheit_Label")
        dictionaryControlsExternal.Add("_COOPERA_Nachhal_Bemerkun_InputControl", "_COOPERA_Nachhaltigkeit_Label")
        dictionaryControlsExternal.Add("_COOPERA_Versicherungs_Account_InputControl", "_COOPERA_Versicherungs_Label")
        dictionaryControlsExternal.Add("_COOPERA_Eigentumsanzeige_Account_ID_InputControl", "_COOPERA_Eigentumsanzeige_Label")
        Return dictionaryControlsExternal
    End Function





    'Private Function GetContractNumber(ByVal code As Long) As String
    '    Dim newcodeyear As Integer = 0
    '    Dim codeyear As String = String.Empty, newcode As String = String.Empty
    '    Dim aux As Integer = 0, auxyear As Integer = 0, auxsec As Integer = 0

    '    aux = ExecuteSQLCotractInteger01(CLng(Me.Properties("COOPERA_NumberContract").Value))
    '    If aux > 0 Then
    '        Dim auxstring As String = Strings.Format(aux, "0000000")
    '        auxyear = CInt(auxstring.Substring(0, 2))
    '        auxsec = CInt(auxstring.Substring(3, 4))
    '    End If

    '    'validating year sequence
    '    newcodeyear = 41 + Year(Date.Now) - 2021
    '    codeyear = (newcodeyear).ToString()

    '    'codedimension (contract type)
    '    Dim codeDimension As String = Portal.CurrentInstance.Cache.GetItemTextFormatted(code, "[{Dimension_Code}]")

    '    'sequence
    '    If newcodeyear <> auxyear Or aux <= 0 Then
    '        auxsec = 1
    '    Else
    '        auxsec = auxsec + 1
    '    End If
    '    Me.Properties("COOPERA_NumberContract").Value = auxsec
    '    newcode = Strings.Format(auxsec, "0000")
    '    Return String.Concat(codeyear, codeDimension, newcode)
    'End Function
    Public func3 As Func(Of Integer, String) = Function(x)

                                                   Return (x + 1).ToString()
                                                   End Function

    ' Call the lambda.



    Public Function ExecuteFunctionCustom(ByVal data As String, ByVal sourceIp As String) As String
        Dim result As String = ""
        Dim jss As New JavaScriptSerializer
        Dim jsond As Dictionary(Of String, Object) = jss.Deserialize(Of Dictionary(Of String, Object))(data)
        Dim methodName As String = CStr(jsond("MethodName"))

        Select Case methodName
            Case "InputFeedJSON" 'New Input JSON
                result = InputFeedJSON(jsond)
        End Select

        Return result
    End Function


    Public Function InputFeedJSON(ByVal jsonObj As Dictionary(Of String, Object)) As String
        Dim TempPath As String = String.Empty
        Dim FullTempPath As String = String.Empty
        Dim TargetPath As String = String.Empty
        Dim FullTargetPath As String = String.Empty
        Dim msFileName As String = String.Empty
        Dim _array As Byte()
        TempPath = "C:\Users\raula\Downloads\move1"
        TargetPath = "C:\Users\raula\Downloads\target1"
        Try
            'if the temp directory not exists ,create a new directory 
            If Not Directory.Exists(TempPath) Then
                MkDir(TempPath)
            End If
            msFileName = CStr(jsonObj("provider")) + Now.ToString("MM_dd_yyyy_hh_mm_ss") + ".xml"
            FullTempPath = Path.Combine(TempPath, msFileName)
            FullTargetPath = Path.Combine(TargetPath, msFileName)

            'save in a temp directory
            If Not File.Exists(FullTempPath) Then
                _array = System.Text.Encoding.Default.GetBytes(CStr(jsonObj("payload")))
                File.WriteAllBytes(FullTempPath, _array)
            End If

            'create destination file
            If Not File.Exists(FullTargetPath) Then
                File.Create(FullTargetPath).Dispose()
            End If

            File.Copy(FullTempPath, FullTargetPath, True)
            'copy file to new remote directory 
            'Shell("cmd.exe /k NET USE \\Servidor\RecursoCompartido /user:Dominio\usuario password")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return "SUCCESS"
    End Function

End Class
