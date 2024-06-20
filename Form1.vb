Public Class Form1
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim astFruit(9) As String
        Dim stTarget As String
        Dim bFound As Boolean

        astFruit(0) = "Apple"
        astFruit(1) = "Mango"
        astFruit(2) = "Strawberry"
        astFruit(3) = "Kiwi"
        astFruit(4) = "Grape"
        astFruit(5) = "Tomato"
        astFruit(6) = "Lemon"
        astFruit(7) = "Melon"
        astFruit(8) = "Fig"
        astFruit(9) = "Banana"

        stTarget = InputBox("Which fruit are you looking for?")

        For i = 0 To 9
            If UCase(astFruit(i)) = UCase(stTarget) Then
                bFound = True
                Exit For
            End If
        Next

        If bFound = True Then
            MessageBox.Show("Found it")
        Else
            MessageBox.Show("Not Found")
        End If

    End Sub
End Class
