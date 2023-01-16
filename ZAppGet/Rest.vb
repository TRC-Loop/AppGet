Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Module Rest
    Public Async Sub CreateUser(user As User)
        Dim Client As New Http.HttpClient()
        Dim RestURL As String = "http://stellar-castle.com/appget/api.php"
        Dim JSONData As String = JsonConvert.SerializeObject(user)
        Dim RestContent As New Http.StringContent(JSONData, Encoding.UTF8, "application/json")
        Dim RestResponse As Http.HttpResponseMessage = Await Client.PostAsync(RestURL, RestContent)
        MsgBox(RestResponse.StatusCode.ToString())
    End Sub
End Module
