Public Class Form1
    ' Variables to hold the ongoing equation and whether it's a new input
    Dim equation As String = "" ' This will store the full expression like '5 + 4 * 2 - 3'
    Dim isNewInput As Boolean = False ' Track whether a new input (number) starts

    ' Method to handle number inputs
    Private Sub Number_Click(sender As Object, e As EventArgs) Handles Button0.Click, Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        Dim button As Button = CType(sender, Button)

        ' Append the clicked number to the display
        If isNewInput Then
            Display.Text = button.Text
            isNewInput = False
        Else
            Display.Text &= button.Text
        End If

        ' Append the number to the equation
        equation &= button.Text
    End Sub

    ' Method to handle the addition operation
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        AppendOperator("+")
    End Sub

    ' Method to handle the subtraction operation
    Private Sub ButtonSubtract_Click(sender As Object, e As EventArgs) Handles ButtonSubtract.Click
        AppendOperator("-")
    End Sub

    ' Method to handle the multiplication operation
    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        AppendOperator("*")
    End Sub

    ' Method to handle the division operation
    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        AppendOperator("/")
    End Sub

    ' Method to handle the decimal point
    Private Sub Dot_Click(sender As Object, e As EventArgs) Handles Dot.Click
        If Not Display.Text.Contains(".") Then
            Display.Text &= "."
            equation &= "."
        End If
    End Sub

    ' Method to handle the equals button click
    Private Sub ButtonEquals_Click(sender As Object, e As EventArgs) Handles ButtonEquals.Click
        Try
            ' Evaluate the equation string
            Dim result As Double = New DataTable().Compute(equation, Nothing)

            ' Display the full equation and result
            equation &= " = " & result.ToString()
            Display.Text = equation
        Catch ex As Exception
            ' In case of any error in the equation (e.g., division by zero), show an error message
            Display.Text = "Error"
        End Try

        ' Reset after calculation
        equation = ""
        isNewInput = True
    End Sub

    ' Method to handle the clear button
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Display.Text = ""
        equation = ""
        isNewInput = True
    End Sub

    ' Appends an operator to the equation and the display
    Private Sub AppendOperator(op As String)
        If Not isNewInput Then
            equation &= " " & op & " "
            Display.Text &= " " & op & " "
            isNewInput = True
        End If
    End Sub
End Class
