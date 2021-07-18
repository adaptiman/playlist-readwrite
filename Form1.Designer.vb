<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tbOutput = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tbFilePath = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSelectFile = New System.Windows.Forms.Button()
        Me.tbTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddCue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbOutput
        '
        Me.tbOutput.Location = New System.Drawing.Point(12, 92)
        Me.tbOutput.Multiline = True
        Me.tbOutput.Name = "tbOutput"
        Me.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbOutput.Size = New System.Drawing.Size(966, 779)
        Me.tbOutput.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(797, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(181, 65)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'tbFilePath
        '
        Me.tbFilePath.Location = New System.Drawing.Point(208, 911)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.Size = New System.Drawing.Size(770, 31)
        Me.tbFilePath.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnSelectFile
        '
        Me.btnSelectFile.Location = New System.Drawing.Point(12, 894)
        Me.btnSelectFile.Name = "btnSelectFile"
        Me.btnSelectFile.Size = New System.Drawing.Size(181, 65)
        Me.btnSelectFile.TabIndex = 5
        Me.btnSelectFile.Text = "Select File"
        Me.btnSelectFile.UseVisualStyleBackColor = True
        '
        'tbTitle
        '
        Me.tbTitle.Location = New System.Drawing.Point(208, 972)
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.Size = New System.Drawing.Size(770, 31)
        Me.tbTitle.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(140, 975)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Title"
        '
        'btnAddCue
        '
        Me.btnAddCue.Location = New System.Drawing.Point(12, 12)
        Me.btnAddCue.Name = "btnAddCue"
        Me.btnAddCue.Size = New System.Drawing.Size(181, 65)
        Me.btnAddCue.TabIndex = 8
        Me.btnAddCue.Text = "Add Cue"
        Me.btnAddCue.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 1034)
        Me.Controls.Add(Me.btnAddCue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbTitle)
        Me.Controls.Add(Me.btnSelectFile)
        Me.Controls.Add(Me.tbFilePath)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbOutput)
        Me.Name = "Form1"
        Me.Text = "WPL Read/Write"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbOutput As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents tbFilePath As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnSelectFile As Button
    Friend WithEvents tbTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddCue As Button
End Class
