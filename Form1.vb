Imports System.IO
Imports PlaylistsNET.Content
Imports PlaylistsNET.Models

Public Class Form1

    'content is an object that holds all of the playlist data
    Dim content As New WplContent

    Dim playlist As New WplPlaylist

    'paths stores all of the file paths to play
    Dim paths As New List(Of String)

    Private Sub Load_Data()

        'writes the content to the textbox
        tbOutput.Text = content.ToText(playlist)

        'writes the content to Output
        Console.WriteLine(content.ToText(playlist))

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'stream is used to access the file
        Dim stream As New FileStream("PlayList.wpl", FileMode.Open, FileAccess.Read)
        'Dim myStreamWriter As New StreamWriter(stream)

        'loads the wpl content into the playlist
        playlist = content.GetFromStream(stream)

        'loads the paths from playlist
        'paths = playlist.GetTracksPaths()

        Load_Data()

        stream.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'stream is used to access the file
        Dim stream As New FileStream("PlayList.wpl", FileMode.Truncate, FileAccess.Write)
        'Dim myStreamWriter As New StreamWriter(stream, Encoding.Default, 4096)
        Dim myStreamWriter As New StreamWriter(stream)

        'Writes content to the file
        myStreamWriter.WriteLine(content.ToText(playlist))
        myStreamWriter.Flush()

        Load_Data()

        'close the stream
        stream.Close()

    End Sub

    Private Sub btnSelectFile_Click(sender As Object, e As EventArgs) Handles btnSelectFile.Click

        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then
            tbFilePath.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub btnAddCue_Click(sender As Object, e As EventArgs) Handles btnAddCue.Click

        Dim entry As WplPlaylistEntry
        entry = New WplPlaylistEntry With {
            .AlbumArtist = "Unknown Artist",
            .TrackArtist = "Unknown Artist",
            .AlbumTitle = "Unknown Album",
            .Path = tbFilePath.Text,
            .TrackTitle = tbTitle.Text
        }

        playlist.PlaylistEntries.Add(entry)

        tbFilePath.Text = ""
        tbOutput.Text = ""

        Load_Data()

    End Sub

End Class
