Imports System.Net.Sockets
Imports System.Text
Imports Newtonsoft.Json
Imports System.IO
Imports Newtonsoft.Json.Linq
Imports System.Net

Public Class FRMmenu

    Private Sub BTNrefresh_Click(sender As Object, e As EventArgs)
        

    End Sub
    Sub DGC()

        Dim DGCjson As String = WebRequest.PubAPI(My.Settings.DGCurl.ToString)
        Dim DGCjResults As JObject = JObject.Parse(DGCjson)
        If DGCjson.StartsWith("Error") Then
            LBLdgc1.Text = "Error Unable to connect to Pool!"
        Else
            Dim DGCworker As Integer = DGCjResults("workers")
            Dim DGChashrate As Integer = DGCjResults("hashrate")
            Dim DGCshares As Integer = DGCjResults("shares_this_round")
            Dim DGClast As Integer = DGCjResults("last_block")
            Dim DGCnethash As Integer = DGCjResults("network_hashrate")
            LBLdgc1.Text = "Workers: " & DGCworker & " Pool Hashrate: " & DGChashrate / 1000 & "MH" & " Current Round Shares: " & DGCshares & " Last Block: " & DGClast & " Network Hashrate: " & Math.Round(DGCnethash / 1000000) & "MH"
        End If

    End Sub
    Sub ASR()
        Dim ASRjson As String = WebRequest.PubAPI(My.Settings.ASRurl.ToString)
        Dim ASRjResults As JObject = JObject.Parse(ASRjson)
        If ASRjson.StartsWith("Error") Then
            LBLasr1.Text = "Error Unable to connect to Pool!"
        Else
            Dim ASRworker As Integer = ASRjResults("workers")
            Dim ASRhashrate As Integer = ASRjResults("hashrate")
            Dim ASRshares As Integer = ASRjResults("shares_this_round")
            Dim ASRlast As Integer = ASRjResults("last_block")
            Dim ASRnethash As Integer = ASRjResults("network_hashrate")
            LBLasr1.Text = "Workers: " & ASRworker & " Pool Hashrate: " & ASRhashrate / 1000 & "MH" & " Current Round Shares: " & ASRshares & " Last Block: " & ASRlast & " Network Hashrate: " & ASRnethash / 100000 & "MH"
        End If

    End Sub
    Sub HBN()
        Dim HBNjson As String = WebRequest.PubAPI(My.Settings.HBNurl.ToString)
        Dim HBNjResults As JObject = JObject.Parse(HBNjson)
        If HBNjson.StartsWith("Error") Then
            LBLhbn1.Text = "Error Unable to connect to Pool!"
        Else
            Dim HBNworker As Integer = HBNjResults("workers")
            Dim HBNhashrate As Integer = HBNjResults("hashrate")
            Dim HBNshares As Integer = HBNjResults("shares_this_round")
            Dim HBNlast As Integer = HBNjResults("last_block")
            Dim HBNnethash As Integer = HBNjResults("network_hashrate")
            LBLhbn1.Text = "Workers: " & HBNworker & " Pool Hashrate: " & HBNhashrate / 1000 & "MH" & " Current Round Shares: " & HBNshares & " Last Block: " & HBNlast & " Network Hashrate: " & HBNnethash / 100000 & "MH"
        End If
    End Sub
    Sub GFT()
        Dim GFTjson As String = WebRequest.PubAPI(My.Settings.GFTurl.ToString)
        Dim GFTjResults As JObject = JObject.Parse(GFTjson)
        If GFTjson.StartsWith("Error") Then
            LBLgft1.Text = "Error Unable to connect to Pool!"
        Else
            Dim GFTworker As Integer = GFTjResults("workers")
            Dim GFThashrate As Integer = GFTjResults("hashrate")
            Dim GFTshares As Integer = GFTjResults("shares_this_round")
            Dim GFTlast As Integer = GFTjResults("last_block")
            Dim GFTnethash As Integer = GFTjResults("network_hashrate")
            LBLgft1.Text = "Workers: " & GFTworker & " Pool Hashrate: " & GFThashrate / 1000 & "MH" & " Current Round Shares: " & GFTshares & " Last Block: " & GFTlast & " Network Hashrate: " & GFTnethash / 100000 & "MH"
        End If

    End Sub
    Sub DOGE()
        Dim DOGEjson As String = WebRequest.PubAPI(My.Settings.DOGEurl.ToString)
        Dim DOGEjResults As JObject = JObject.Parse(DOGEjson)
        If DOGEjson.StartsWith("Error") Then
            LBLdoge1.Text = "Error Unable to connect to Pool!"
        Else
            Dim DOGEworker As Integer = DOGEjResults("workers")
            Dim DOGEhashrate As Integer = DOGEjResults("hashrate")
            Dim DOGEshares As Integer = DOGEjResults("shares_this_round")
            Dim DOGElast As Integer = DOGEjResults("last_block")
            Dim DOGEnethash As Int64 = DOGEjResults("network_hashrate")
            LBLdoge1.Text = "Workers: " & DOGEworker & " Pool Hashrate: " & DOGEhashrate / 1000 & "MH" & " Current Round Shares: " & DOGEshares & " Last Block: " & DOGElast & " Network Hashrate: " & DOGEnethash / 100000 & "MH"
        End If

    End Sub
    Sub LOT()

        Dim LOTjson As String = WebRequest.PubAPI(My.Settings.LOTurl.ToString)
        Dim LOTjResults As JObject = JObject.Parse(LOTjson)
        If LOTjson.StartsWith("Error") Then
            LBLlot1.Text = "Error Unable to connect to Pool!"
        Else
            Dim LOTworker As Integer = LOTjResults("workers")
            Dim LOThashrate As Integer = LOTjResults("hashrate")
            Dim LOTshares As Integer = LOTjResults("shares_this_round")
            Dim LOTlast As Integer = LOTjResults("last_block")
            Dim LOTnethash As Int64 = LOTjResults("network_hashrate")
            LBLlot1.Text = "Workers: " & LOTworker & " Pool Hashrate: " & LOThashrate / 1000 & "MH" & " Current Round Shares: " & LOTshares & " Last Block: " & LOTlast & " Network Hashrate: " & LOTnethash / 100000 & "MH"
        End If

    End Sub
    Sub MOON()
        Dim MOONjson As String = WebRequest.PubAPI(My.Settings.MOONurl.ToString)
        Dim MOONjResults As JObject = JObject.Parse(MOONjson)
        If MOONjson.StartsWith("Error") Then
            LBLmoon1.Text = "Error Unable to connect to Pool!"
        Else
            Dim MOONworker As Integer = MOONjResults("workers")
            Dim MOONhashrate As Integer = MOONjResults("hashrate")
            Dim MOONshares As Integer = MOONjResults("shares_this_round")
            Dim MOONlast As Integer = MOONjResults("last_block")
            Dim MOONnethash As Int64 = MOONjResults("network_hashrate")
            LBLmoon1.Text = "Workers: " & MOONworker & " Pool Hashrate: " & MOONhashrate / 1000 & "MH" & " Current Round Shares: " & MOONshares & " Last Block: " & MOONlast & " Network Hashrate: " & MOONnethash / 100000 & "MH"
        End If

    End Sub
    Sub qbt()
        Dim qbtjson As String = WebRequest.PubAPI(My.Settings.QBTurl.ToString)
        Dim qbtjResults As JObject = JObject.Parse(qbtjson)
        If qbtjson.StartsWith("Error") Then
            LBLqbt1.Text = "Error Unable to connect to Pool!"
        Else
            Dim qbtworker As Integer = qbtjResults("workers")
            Dim qbthashrate As Integer = qbtjResults("hashrate")
            Dim qbtshares As Integer = qbtjResults("shares_this_round")
            Dim qbtlast As Integer = qbtjResults("last_block")
            Dim qbtnethash As Int64 = qbtjResults("network_hashrate")
            LBLqbt1.Text = "Workers: " & qbtworker & " Pool Hashrate: " & qbthashrate / 1000 & "MH" & " Current Round Shares: " & qbtshares & " Last Block: " & qbtlast & " Network Hashrate: " & qbtnethash / 100000 & "MH"
        End If

    End Sub
    Sub nrb()
        Dim nrbjson As String = WebRequest.PubAPI(My.Settings.NRBurl.ToString)
        Dim nrbjResults As JObject = JObject.Parse(nrbjson)
        If nrbjson.StartsWith("Error") Then
            LBLnrb1.Text = "Error Unable to connect to Pool!"
        Else
            Dim nrbworker As Integer = nrbjResults("workers")
            Dim nrbhashrate As Integer = nrbjResults("hashrate")
            Dim nrbshares As Integer = nrbjResults("shares_this_round")
            Dim nrblast As Integer = nrbjResults("last_block")
            Dim nrbnethash As Int64 = nrbjResults("network_hashrate")
            LBLnrb1.Text = "Workers: " & nrbworker & " Pool Hashrate: " & nrbhashrate / 1000 & "MH" & " Current Round Shares: " & nrbshares & " Last Block: " & nrblast & " Network Hashrate: " & nrbnethash / 100000 & "MH"
        End If

    End Sub
    Sub rpc()
        Dim rpcjson As String = WebRequest.PubAPI(My.Settings.RPCurl.ToString)
        Dim rpcjResults As JObject = JObject.Parse(rpcjson)
        If rpcjson.StartsWith("Error") Then
            LBLrpc1.Text = "Error Unable to connect to Pool!"
        Else
            Dim rpcworker As Integer = rpcjResults("workers")
            Dim rpchashrate As Integer = rpcjResults("hashrate")
            Dim rpcshares As Integer = rpcjResults("shares_this_round")
            Dim rpclast As Integer = rpcjResults("last_block")
            Dim rpcnethash As Int64 = rpcjResults("network_hashrate")
            LBLrpc1.Text = "Workers: " & rpcworker & " Pool Hashrate: " & rpchashrate / 1000 & "MH" & " Current Round Shares: " & rpcshares & " Last Block: " & rpclast & " Network Hashrate: " & rpcnethash / 100000 & "MH"
        End If
    End Sub
    Sub tagc()
        Dim tagcjson As String = WebRequest.PubAPI(My.Settings.TAGurl.ToString)
        Dim tagcjResults As JObject = JObject.Parse(tagcjson)
        If tagcjson.StartsWith("Error") Then
            LBLtag1.Text = "Error Unable to connect to Pool!"
        Else
            Dim tagcworker As Integer = tagcjResults("workers")
            Dim tagchashrate As Integer = tagcjResults("hashrate")
            Dim tagcshares As Integer = tagcjResults("shares_this_round")
            Dim tagclast As Integer = tagcjResults("last_block")
            Dim tagcnethash As Int64 = tagcjResults("network_hashrate")
            LBLtag1.Text = "Workers: " & tagcworker & " Pool Hashrate: " & tagchashrate / 1000 & "MH" & " Current Round Shares: " & tagcshares & " Last Block: " & tagclast & " Network Hashrate: " & tagcnethash / 100000 & "MH"
        End If

    End Sub
    Sub yum()
        Dim yumjson As String = WebRequest.PubAPI(My.Settings.YUMurl.ToString)
        Dim yumjResults As JObject = JObject.Parse(yumjson)
        If yumjson.StartsWith("Error") Then
            LBLyum1.Text = "Error Unable to connect to Pool!"
        Else
            Dim yumworker As Integer = yumjResults("workers")
            Dim yumhashrate As Integer = yumjResults("hashrate")
            Dim yumshares As Integer = yumjResults("shares_this_round")
            Dim yumlast As Integer = yumjResults("last_block")
            Dim yumnethash As Int64 = yumjResults("network_hashrate")
            LBLyum1.Text = "Workers: " & yumworker & " Pool Hashrate: " & yumhashrate / 1000 & "MH" & " Current Round Shares: " & yumshares & " Last Block: " & yumlast & " Network Hashrate: " & yumnethash / 100000 & "MH"
        End If
    End Sub
    Private Sub FRMpools_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LBLdgc1.Text = ""
        'LBLarg1.Text = ""
        'LBLasr1.Text = ""
        'LBLgft1.Text = ""
        ' LBLlot1.Text = ""
        'LBLhbn1.Text = ""
        'LBLdoge1.Text = ""
        'LBLmoon1.Text = ""
        'LBLnrb1.Text = ""
        'LBLqbt1.Text = ""
        LBLrpc1.Text = ""
        LBLtag1.Text = ""
        LBLyum1.Text = ""
    End Sub

    Private Sub BTNarg_Click(sender As Object, e As EventArgs) Handles BTNarg.Click
        Me.Hide()
        ARG.Show()
    End Sub
End Class
