'Joshua Makuch
'RCET 3371
'Fall 2023
'Dice Roll
'https://github.com/JoshuaMakuch/S5-WK3-2-DiceRoll

Option Strict On
Option Explicit On

Public Class DiceRollForm

    'Stores the dice roll results in a two dimensional array with 10,000 possible rolls
    Dim resultArray(1, 10000) As Integer
    'Creates an instance of the random class and the new generates a new seed each run through to provide pseudo randomness
    Dim random As New Random()

    'When the generate button is pressed
    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click

        'Generates two random integers from 1 to 6 and stores them into the result array
        For n As Integer = 0 To CInt((resultArray.Length() / 2)) - 1
            'Generates a random integer from 1 to 6 inclusively and stores them into the result array
            resultArray(0, n) = random.Next(1, 7)
            resultArray(1, n) = random.Next(1, 7)
        Next

        'Iterates through the resultArray after clearing it and pushes the data into the display list box
        DisplayListBox.Items.Clear()
        For n As Integer = 0 To CInt((resultArray.Length() / 2)) - 1
            'This will add the two dice rolls and push the result to the list box
            DisplayListBox.Items.Add(resultArray(0, n) + resultArray(1, n))
        Next

    End Sub

    'When the quit button is pressed
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

    'When the user selects a number in the list box, fill the display list box index label
    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        SelectedIndexLabel.Text = "You Selected Roll: " & vbCrLf & DisplayListBox.SelectedIndex.ToString
        SelectedIndexLabel.Text = SelectedIndexLabel.Text & vbCrLf & "Roll 1: " & resultArray(0, DisplayListBox.SelectedIndex)
        SelectedIndexLabel.Text = SelectedIndexLabel.Text & vbCrLf & "Roll 2: " & resultArray(1, DisplayListBox.SelectedIndex)
    End Sub

End Class
