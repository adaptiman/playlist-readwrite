Imports System.IO
Imports PlaylistsNET.Content
Imports PlaylistsNET.Models

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        'I don't know what this variable is for
        Dim content As WplContent
        content = New WplContent

        Dim stream As New FileStream("PlayList.wpl", FileMode.Open, FileAccess.Read)
        Dim playlist As WplPlaylist = content.GetFromStream(stream)
        Dim paths As List(Of String) = playlist.GetTracksPaths()
        tbOutput.Lines = paths.ToArray
        Console.WriteLine(paths.ToString)
    End Sub
End Class
