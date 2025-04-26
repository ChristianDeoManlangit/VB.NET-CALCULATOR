Public Class Form1
    Dim op_Manlangit As String
    Dim num_Manlangit As Double = 0
    Dim newNum_Manlangit As Boolean = True

    Private Sub Form1_Manlangit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumber_Manlangit.Text = "0"
        btnADD_Manlangit.Tag = "add"
        btnSUB_Manlangit.Tag = "sub"
        btnMUL_Manlangit.Tag = "mul"
        btnDIV_Manlangit.Tag = "div"
        btnDiv2_Manlangit.Tag = "div2"
        btnMOD_Manlangit.Tag = "mod"
        btnExp_Manlangit.Tag = "exp"
    End Sub

    Private Sub NumberButton_Click(sender As Object, e As EventArgs) Handles btn0_Manlangit.Click, btn1_Manlangit.Click, btn2_Manlangit.Click, btn3_Manlangit.Click, btn4_Manlangit.Click, btn5_Manlangit.Click, btn6_Manlangit.Click, btn7_Manlangit.Click, btn8_Manlangit.Click, btn9_Manlangit.Click
        Dim button As Button = CType(sender, Button)
        If newNum_Manlangit OrElse txtNumber_Manlangit.Text = "0" Then
            txtNumber_Manlangit.Text = button.Text
            newNum_Manlangit = False
        Else
            txtNumber_Manlangit.Text &= button.Text
        End If
    End Sub

    Private Sub btnPeriod_Manlangit_Click(sender As Object, e As EventArgs) Handles btnPeriod_Manlangit.Click
        If Not txtNumber_Manlangit.Text.Contains(".") Then
            txtNumber_Manlangit.Text &= "."
        End If
    End Sub

    Private Sub OperatorButton_Click(sender As Object, e As EventArgs) Handles btnADD_Manlangit.Click, btnSUB_Manlangit.Click, btnMUL_Manlangit.Click, btnDIV_Manlangit.Click, btnDiv2_Manlangit.Click, btnMOD_Manlangit.Click, btnExp_Manlangit.Click
        Dim button As Button = CType(sender, Button)
        If Not newNum_Manlangit Then
            btnEQUAL_Manlangit.PerformClick()
        End If
        op_Manlangit = button.Tag.ToString()
        num_Manlangit = Val(txtNumber_Manlangit.Text)
        newNum_Manlangit = True
    End Sub

    Private Sub btnEQUAL_Manlangit_Click(sender As Object, e As EventArgs) Handles btnEQUAL_Manlangit.Click
        Select Case op_Manlangit
            Case "add"
                txtNumber_Manlangit.Text = (num_Manlangit + Val(txtNumber_Manlangit.Text)).ToString()
            Case "sub"
                txtNumber_Manlangit.Text = (num_Manlangit - Val(txtNumber_Manlangit.Text)).ToString()
            Case "mul"
                txtNumber_Manlangit.Text = (num_Manlangit * Val(txtNumber_Manlangit.Text)).ToString()
            Case "div"
                txtNumber_Manlangit.Text = (num_Manlangit / Val(txtNumber_Manlangit.Text)).ToString()
            Case "div2"
                txtNumber_Manlangit.Text = (num_Manlangit \ Val(txtNumber_Manlangit.Text)).ToString()
            Case "mod"
                txtNumber_Manlangit.Text = (num_Manlangit Mod Val(txtNumber_Manlangit.Text)).ToString()
            Case "exp"
                txtNumber_Manlangit.Text = (num_Manlangit ^ Val(txtNumber_Manlangit.Text)).ToString()
        End Select
        op_Manlangit = ""
        num_Manlangit = 0
        newNum_Manlangit = True
    End Sub

    Private Sub btnClear_Manlangit_Click(sender As Object, e As EventArgs) Handles btnClear_Manlangit.Click
        txtNumber_Manlangit.Text = "0"
        num_Manlangit = 0
        op_Manlangit = ""
        newNum_Manlangit = True
    End Sub
End Class
