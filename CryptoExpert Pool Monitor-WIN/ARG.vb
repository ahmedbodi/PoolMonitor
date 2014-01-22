Imports Newtonsoft.Json.Linq

Public Class ARG

    Private Sub ARG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBLarg1.Text = ""
        ARG()
    End Sub
    Sub ARG()
        Dim ARGjson As String = WebRequest.PubAPI(My.Settings.ARGurl.ToString)
        Dim ARGjResults As JObject = JObject.Parse(ARGjson)
        If ARGjson.StartsWith("Error") Then
            LBLarg1.Text = "Error Unable to connect to Pool!"
        Else
            Dim ARGworker As Integer = ARGjResults("workers")
            Dim ARGhashrate As Integer = ARGjResults("hashrate")
            Dim ARGshares As Integer = ARGjResults("shares_this_round")
            Dim ARGlast As Integer = ARGjResults("last_block")
            Dim ARGnethash As Integer = ARGjResults("network_hashrate")
            LBLarg1.Text = "Workers: " & ARGworker & " Pool Hashrate: " & ARGhashrate / 1000 & "MH" & " Current Round Shares: " & ARGshares & " Last Block: " & ARGlast & " Network Hashrate: " & ARGnethash / 100000 & "MH"
        End If

    End Sub
End Class