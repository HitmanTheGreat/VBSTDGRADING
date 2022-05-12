Public Class addstudentfrm
    Public StudentsDict As Dictionary(Of Integer, Array) = New Dictionary(Of Integer, Array)() 'declare public student dictionary
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Len(TextBox1.Text) > 0 And Len(TextBox2.Text) > 0 And Len(TextBox3.Text) > 0 And Len(TextBox4.Text) > 0 Then
            Dim record(0 To 4) As String
            record(0) = TextBox2.Text ' adding name the data into a list
            record(1) = TextBox3.Text ' adding lastname the data into a list
            record(2) = TextBox4.Text ' adding email the data into a list
            record(3) = DateTimePicker1.Text ' adding DOB name the data into a list
            record(4) = DateTimePicker2.Text ' adding Date of start the data into a list
            Try
                StudentsDict.Add(TextBox1.Text, record) 'adding the list into a dictionary
                ListBox1.Items.Add(record(0))
            Catch Exception As Exception
                MsgBox(Exception.Message.ToString, vbExclamation, "Error")
            End Try
        Else
            MsgBox("Complete Filling The Form", vbExclamation, "Error")
        End If

    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As System.EventArgs) Handles TextBox1.Leave
        If Len(TextBox1.Text) < 5 Then
            MsgBox("ID cant be less that 5 charecters", vbExclamation, "Error")
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As System.EventArgs) Handles TextBox2.Leave
        If Len(TextBox2.Text) < 1 Then
            MsgBox("Enter first name", vbExclamation, "Error")
        End If
    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As System.EventArgs) Handles TextBox3.Leave
        If Len(TextBox3.Text) < 1 Then
            MsgBox("Enter last name", vbExclamation, "Error")
        End If
    End Sub


    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        If Len(TextBox4.Text) < 1 Then
            MsgBox("Enter email ", vbExclamation, "Error")
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        addorgradefrm.Show()
        Me.Hide()
    End Sub

    Private Sub addstudentfrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class