﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.fileCrawlerPathPicker = New PicDedupe.Framework.PathPicker()
        Me.folderSplitter = New System.Windows.Forms.SplitContainer()
        Me.fileCrawlerFolderListView = New PicDedupe.Framework.FolderListView()
        CType(Me.folderSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.folderSplitter.Panel1.SuspendLayout()
        Me.folderSplitter.SuspendLayout()
        Me.SuspendLayout()
        '
        'fileCrawlerPathPicker
        '
        Me.fileCrawlerPathPicker.DialogTitel = Nothing
        Me.fileCrawlerPathPicker.Location = New System.Drawing.Point(12, 11)
        Me.fileCrawlerPathPicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fileCrawlerPathPicker.Name = "fileCrawlerPathPicker"
        Me.fileCrawlerPathPicker.Path = Nothing
        Me.fileCrawlerPathPicker.Size = New System.Drawing.Size(1031, 39)
        Me.fileCrawlerPathPicker.TabIndex = 0
        '
        'folderSplitter
        '
        Me.folderSplitter.Location = New System.Drawing.Point(12, 67)
        Me.folderSplitter.Name = "folderSplitter"
        Me.folderSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'folderSplitter.Panel1
        '
        Me.folderSplitter.Panel1.Controls.Add(Me.fileCrawlerFolderListView)
        Me.folderSplitter.Size = New System.Drawing.Size(1031, 641)
        Me.folderSplitter.SplitterDistance = 380
        Me.folderSplitter.TabIndex = 1
        '
        'fileCrawlerFolderListView
        '
        Me.fileCrawlerFolderListView.FullRowSelect = True
        Me.fileCrawlerFolderListView.HideSelection = False
        Me.fileCrawlerFolderListView.Location = New System.Drawing.Point(23, 26)
        Me.fileCrawlerFolderListView.Name = "fileCrawlerFolderListView"
        Me.fileCrawlerFolderListView.Size = New System.Drawing.Size(982, 331)
        Me.fileCrawlerFolderListView.TabIndex = 0
        Me.fileCrawlerFolderListView.UseCompatibleStateImageBehavior = False
        Me.fileCrawlerFolderListView.View = System.Windows.Forms.View.Details
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 720)
        Me.Controls.Add(Me.folderSplitter)
        Me.Controls.Add(Me.fileCrawlerPathPicker)
        Me.Name = "FormMain"
        Me.Text = "Form1"
        Me.folderSplitter.Panel1.ResumeLayout(False)
        CType(Me.folderSplitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.folderSplitter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fileCrawlerPathPicker As PathPicker
    Friend WithEvents folderSplitter As SplitContainer
    Friend WithEvents fileCrawlerFolderListView As FolderListView
End Class
