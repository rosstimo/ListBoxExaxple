Option Strict On
Option Explicit On

Public Class ListBoxExampleForm
    Private Sub ListBoxExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'LoadFakeData()

        TimesTable(12)
        'UpdateListBox(DataKeeper(""))
        Rescale()
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
        Rescale()
    End Sub

    Sub Rescale()
        Me.Text = Me.Height.ToString
        DisplayListBox.Top = 20
        DisplayListBox.Left = 100
        DisplayListBox.Height = CInt(Me.Height - 120)
        DisplayListBox.Width = CInt(Me.Width - 150)
        'DisplayListBox.Location = (Me.Top, CInt(Me.Width * 0.4))
    End Sub

    Sub TimesTable(firstNumber As Integer)
        Dim temp$
        Dim rowData As String
        Const padLen% = 6
        'Console.Clear()


        'Console.WriteLine($"Enjoy your {firstNumber} x {firstNumber} Multiplication Table:" & vbNewLine)

        For row = 1 To firstNumber
            For column = 1 To firstNumber
                temp = CStr(row * column)
                rowData &= temp.PadLeft(padLen)
            Next
            DataKeeper(rowData)
            rowData = ""
        Next

    End Sub

    Private Sub DisplayFileMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayFileMenuItem.Click
        UpdateListBox(DataKeeper(""))
    End Sub

    Private Sub ClearFileMenuItem_Click(sender As Object, e As EventArgs) Handles ClearFileMenuItem.Click
        DisplayListBox.Items.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
