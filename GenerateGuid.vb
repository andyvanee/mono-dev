Module GenerateGuid
  Sub Main()
    Dim uuid As String = ""
    If uuid = "" Then
        uuid = Guid.NewGuid().ToString("N")
    End If
    Console.WriteLine(uuid)
  End Sub
End Module
