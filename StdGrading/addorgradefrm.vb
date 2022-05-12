Public Class addorgradefrm

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close() 'terminates the program
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        addstudentfrm.Show() 'open add student form 
        Me.Hide() 'close current form
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        graddingfrm.Show() 'open  gradding form
        Me.Hide() 'close current form
        Dim data As String
        For Each item In addstudentfrm.StudentsDict
            data = item.Key & " : " & item.Value(0) & " " & item.Value(1) 'unpacking students to the listbox
            graddingfrm.ListBox1.Items.Add(data)
            'creating empty marks dictionary for each student 
            graddingfrm.ScoresDict(item.Key) = {0, 0, 0, 0, 0, 0}
        Next
    End Sub

    Private Sub addorgradefrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
