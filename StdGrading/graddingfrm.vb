Public Class graddingfrm
    Public ScoresDict As Dictionary(Of Integer, Array) = New Dictionary(Of Integer, Array)() 'declare public scores dictionary 
    Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub graddingfrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Len(ListBox1.Text) < 0 Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
        Else
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        TextBox5.Text = 0
        TextBox6.Text = 0
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim CurrRec As Array
        Dim ID As String
        Dim chunk() As String = Split(ListBox1.Text) ' taking id of sellected item
        ID = Trim(chunk(0)) 'removing whit space
        CurrRec = ScoresDict(ID) 'taking the row as a list
        TextBox1.Text = CurrRec(0) 'unpacking items to the textbox
        TextBox2.Text = CurrRec(1)
        TextBox3.Text = CurrRec(2)
        TextBox4.Text = CurrRec(3)
        TextBox5.Text = CurrRec(4)
        TextBox6.Text = CurrRec(5)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        addorgradefrm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim CurrRec As Array
        Dim ID As String
        Dim chunk() As String = Split(ListBox1.Text) ' taking id of sellected item
        ID = Trim(chunk(0)) 'removing whit space
        CurrRec = ScoresDict(ID) 'taking the row as a list
        CurrRec(0) = TextBox1.Text 'adding items to the scores dictionary
        CurrRec(1) = TextBox2.Text
        CurrRec(2) = TextBox3.Text
        CurrRec(3) = TextBox4.Text
        CurrRec(4) = TextBox5.Text
        CurrRec(5) = TextBox6.Text

        'Calculating Mark Grade And Status
        Dim attendancy, proj1, proj2, proj3, proj4, exam, mark As Double
        attendancy = TextBox1.Text
        proj1 = TextBox2.Text
        proj2 = TextBox3.Text
        proj3 = TextBox4.Text
        proj4 = TextBox5.Text
        exam = TextBox6.Text

        mark = ((attendancy / 20) * 10) + (((proj1 + proj2 + proj3 + proj4) / 100) * 50) + ((exam / 100) * 40) ' calculating total mark
        'grade out of 5
        Label1.Text = Math.Round((mark / 100) * 5)
        Label2.Text = mark.ToString & "/" & "100"
        ' pass or fail
        If mark >= 60 Then
            Label4.Text = "Pass"
            Label4.ForeColor = Color.Green
        Else
            Label4.Text = "Fail"
            Label4.ForeColor = Color.Red
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If Val(TextBox1.Text) < 0 Or Val(TextBox1.Text) > 20 Then
            MsgBox("Attendency Must Be in the Range of 0 to 20", vbExclamation, "Error")
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        If Val(TextBox2.Text) < 0 Or Val(TextBox2.Text) > 20 Then
            MsgBox("Project 1 Must Be in the Range of 0 to 20", vbExclamation, "Error")
        End If
    End Sub

    Private Sub TextBox4_Leave(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        If Val(TextBox4.Text) < 0 Or Val(TextBox4.Text) > 20 Then
            MsgBox("Project 2 Must Be in the Range of 0 to 20", vbExclamation, "Error")
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        If Val(TextBox3.Text) < 0 Or Val(TextBox3.Text) > 20 Then
            MsgBox("Projct 3 Must Be in the Range of 0 to 20", vbExclamation, "Error")
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox5.TextChanged
        If Val(TextBox5.Text) < 0 Or Val(TextBox5.Text) > 40 Then
            MsgBox("Project 4 Must Be in the Range of 0 to 40", vbExclamation, "Error")
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged
        If Val(TextBox6.Text) < 0 Or Val(TextBox6.Text) > 100 Then
            MsgBox("Exam Score Must Be in the Range of 0 to 100", vbExclamation, "Error")
        End If
    End Sub
End Class