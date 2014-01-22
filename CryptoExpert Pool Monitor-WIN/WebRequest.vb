Imports System.Net
Imports System.IO
Imports System.Net.WebSockets
Module WebRequest
    Function PubAPI(ByVal ip As String)
        Try
            Dim webClient As New System.Net.WebClient
            Dim result As String = webClient.DownloadString(ip)
            Return result
        Catch
            Return "Error! Unable To Connect To Pool"
        End Try
    End Function
End Module