Option Strict On
Option Explicit On

Public Class ListBoxExampleForm
    Private Sub ListBoxExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadFakeData()
        UpdateListBox(DataKeeper(""))



    End Sub

    Sub UpdateListBox(displayData As List(Of String))

        'DisplayListBox.Items.Add("Hello")
        'DisplayListBox.Items.Add("Blah")
        'DisplayListBox.Items.Add("Blah Blah")

        For Each thingy In displayData
            DisplayListBox.Items.Add(thingy)
        Next

    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        Me.Text = DisplayListBox.SelectedItem.ToString
        'Me.Text = DisplayListBox.SelectedIndex.ToString
    End Sub

    Function DataKeeper(ByVal currentData As String) As List(Of String)
        Static Dim data As New List(Of String)
        data.Add(currentData)
        Return data
    End Function

    Sub LoadFakeData()

        For i = 0 To 100
            DataKeeper(StrDup(i, "*"))
        Next

    End Sub

    Private Sub ListBoxExampleForm_ResizeEnd(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Text = Me.Height.ToString
        DisplayListBox.Height = CInt(Me.Height * 0.8)
        DisplayListBox.Width = CInt(Me.Width * 0.6)
        'DisplayListBox.Location = (Me.Top, CInt(Me.Width * 0.4))
    End Sub
End Class
