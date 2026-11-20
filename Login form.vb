If TextBox1.Text = "" Then
MessageBox.Show("Please enter username")
TextBox1.Focus()
Exit Sub
ElseIf TextBox2.Text = "" ThenMessageBox.Show("Please enter password")
TextBox2.Focus()
Exit Sub
End If
If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
MessageBox.Show("welcome admin")
Else
MessageBox.Show("incorrect username or password")
End If
If CheckBox1.Checked = True Then
TextBox2.PasswordChar = ""
Else
TextBox2.PasswordChar = "*"
End If 
