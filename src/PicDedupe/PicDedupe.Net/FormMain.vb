﻿Public Class FormMain

    Private WithEvents _fileCrawler As FileCrawler

    Private Async Sub fileCrawlerPathPicker_PathChanged(sender As Object, e As PathChangedEventArgs) Handles fileCrawlerPathPicker.PathChanged
        Await UpdatePathView(e.Path)
    End Sub

    Private Sub _fileCrawler_ProgressUpdate(sender As Object, e As ProgressUpdateEventArgs) Handles _fileCrawler.ProgressUpdate

    End Sub

    Private Sub _fileCrawler_TopLevelDirectoriesAvailable(sender As Object, e As TopLevelDirectoriesAvailableEventArgs) Handles _fileCrawler.TopLevelDirectoriesAvailable
        Invoke(Sub()
                   For Each item In e.TopLevelDirectories
                       Me.fileCrawlerFolderListView.Items.Add(New FolderListViewItem(item))
                   Next
               End Sub)
    End Sub

    Private Async Function UpdatePathView(path As String) As Task
        Dim files = Await Task.Run(
            Function()
                _fileCrawler = New FileCrawler(New IO.DirectoryInfo(path))
                Return _fileCrawler.GetFiles()
            End Function)

    End Function

End Class
