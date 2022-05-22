Public Class scientific_calculator

    'deklarasi / declaration
    Dim first_number As Decimal
    Dim second_number As Decimal
    Dim result As Decimal
    Dim operation As String
    Dim hasil As Decimal



    Private Sub btn_c_Click(sender As Object, e As EventArgs) Handles btn_c.Click
        txt_entry.Text = ""
        txt_history_entry.Text = ""

    End Sub

    Private Sub btn_ce_Click(sender As Object, e As EventArgs) Handles btn_ce.Click
        txt_entry.Text = ""

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If txt_entry.Text < " " Then
            txt_entry.Text = Mid(txt_entry.Text, 1, Len(txt_entry.Text) - 1 + 1)
        Else
            txt_entry.Text = Mid(txt_entry.Text, 1, Len(txt_entry.Text) - 1)
        End If
    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        If txt_entry.Text = "" Then
            txt_entry.Text = "1"
        Else
            txt_entry.Text = txt_entry.Text + "1"
        End If

    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        If txt_entry.Text = "" Then
            txt_entry.Text = "2"
        Else
            txt_entry.Text = txt_entry.Text + "2"
        End If
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        If txt_entry.Text = "" Then
            txt_entry.Text = "3"
        Else
            txt_entry.Text = txt_entry.Text + "3"
        End If
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        If txt_entry.Text = "" Then
            txt_entry.Text = "4"
        Else
            txt_entry.Text = txt_entry.Text + "4"
        End If
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        If txt_entry.Text = "" Then
            txt_entry.Text = "5"
        Else
            txt_entry.Text = txt_entry.Text + "5"
        End If
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        If txt_entry.Text = "" Then
            txt_entry.Text = "6"
        Else
            txt_entry.Text = txt_entry.Text + "6"
        End If
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        If txt_entry.Text = "" Then
            txt_entry.Text = "7"
        Else
            txt_entry.Text = txt_entry.Text + "7"
        End If
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        If txt_entry.Text = "" Then
            txt_entry.Text = "8"
        Else
            txt_entry.Text = txt_entry.Text + "8"
        End If
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        If txt_entry.Text = "" Then
            txt_entry.Text = "9"
        Else
            txt_entry.Text = txt_entry.Text + "9"
        End If
    End Sub

    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        If txt_entry.Text = "" Then
            txt_entry.Text = "0."
        Else
            txt_entry.Text = txt_entry.Text + "0"
        End If
    End Sub

    Private Sub btn_dot_Click(sender As Object, e As EventArgs) Handles btn_dot.Click
        If txt_entry.Text = "" Then
            MsgBox("ERORR", vbInformation)
        Else
            txt_entry.Text = txt_entry.Text + "."
        End If
    End Sub

    Private Sub btn_divide_Click(sender As Object, e As EventArgs) Handles btn_divide.Click
        operation = " / "
        txt_history_entry.Text = txt_entry.Text
        txt_entry.Text = ""
    End Sub

    Private Sub btn_multiple_Click(sender As Object, e As EventArgs) Handles btn_multiple.Click
        operation = " x "
        txt_history_entry.Text = txt_entry.Text
        txt_entry.Text = ""
    End Sub

    Private Sub btn_minus_Click(sender As Object, e As EventArgs) Handles btn_minus.Click
        operation = " - "
        txt_history_entry.Text = txt_entry.Text
        txt_entry.Text = ""
    End Sub

    Private Sub btn_plus_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        operation = " + "
        txt_history_entry.Text = txt_entry.Text
        txt_entry.Text = ""
    End Sub



    Private Sub btn_equals_Click(sender As Object, e As EventArgs) Handles btn_equals.Click

        first_number = Val(txt_history_entry.Text)
        second_number = Val(txt_entry.Text)
        If operation = " / " Then
            result = first_number / second_number
        ElseIf operation = " x " Then
            result = first_number * second_number
        ElseIf operation = " - " Then
            result = first_number - second_number
        ElseIf operation = " + " Then
            result = first_number + second_number
        ElseIf operation = " mod " Then
            result = first_number Mod second_number
        ElseIf operation = " ^ " Then
            result = first_number ^ second_number
        ElseIf operation = " log " Then
            result = Math.Log(second_number, first_number)
        ElseIf operation = " C " Then

            Dim n, i, r, z As Integer
            Dim faktorial_1, faktorial_2, faktorial_3 As Integer
            Dim pengurangan As Integer

            pengurangan = first_number - second_number

            faktorial_1 = 1
            n = first_number
            For i = 1 To n
                faktorial_1 = faktorial_1 * i
            Next

            faktorial_2 = 1
            r = second_number
            For i = 1 To r
                faktorial_2 = faktorial_2 * i
            Next

            faktorial_3 = 1
            z = pengurangan
            For i = 1 To pengurangan
                faktorial_3 = faktorial_3 * i
            Next

            result = faktorial_1 / (faktorial_2 * faktorial_3)
            
        End If

        txt_entry.Text = result

        txt_history_entry.Text = first_number & operation & second_number

    End Sub

    Private Sub btn_mod_Click(sender As Object, e As EventArgs) Handles btn_mod.Click
        operation = " mod "
        txt_history_entry.Text = txt_entry.Text + " mod "
        txt_entry.Text = ""
    End Sub

    Private Sub btn_sin_Click(sender As Object, e As EventArgs) Handles btn_sin.Click
        If txt_entry.Text = "" Then
            MsgBox("error", MsgBoxStyle.Information)
        Else
            txt_history_entry.Text = "sin(" + txt_entry.Text + ")"
            hasil = Math.Round(Math.Sin(Val(txt_entry.Text) / 57.3), 4)
            txt_entry.Text = hasil
        End If
    End Sub

    Private Sub btn_cos_Click(sender As Object, e As EventArgs) Handles btn_cos.Click
        If txt_entry.Text = "" Then
            MsgBox("error", MsgBoxStyle.Information)
        Else
            txt_history_entry.Text = "cos(" + txt_entry.Text + ")"
            hasil = Math.Round(Math.Cos(Val(txt_entry.Text) / 57.3), 4)
            txt_entry.Text = hasil
        End If
    End Sub

    Private Sub btn_tan_Click(sender As Object, e As EventArgs) Handles btn_tan.Click
        If txt_entry.Text = "" Then
            MsgBox("error", MsgBoxStyle.Information)
        Else
            txt_history_entry.Text = "tan(" + txt_entry.Text + ")"
            hasil = Math.Round(Math.Tan(Val(txt_entry.Text) / 57.3), 4)
            txt_entry.Text = hasil
        End If
    End Sub

    Private Sub btn_kuadrat_Click(sender As Object, e As EventArgs) Handles btn_kuadrat.Click
        operation = " ^ "
        txt_history_entry.Text = txt_entry.Text + " ^ "
        txt_entry.Text = ""
    End Sub

    Private Sub btn_ln_Click(sender As Object, e As EventArgs) Handles btn_ln.Click
        If txt_entry.Text = "" Then
            MsgBox("error", MsgBoxStyle.Information)
        Else
            txt_history_entry.Text = "ln(" + txt_entry.Text + ")"
            hasil = Math.Log(txt_entry.Text)
            txt_entry.Text = hasil
        End If
    End Sub

    Private Sub btn_log_Click(sender As Object, e As EventArgs) Handles btn_log.Click
        operation = " log "
        txt_history_entry.Text = txt_entry.Text + " log "
        txt_entry.Text = ""
    End Sub

    Private Sub btn_rootsign_Click(sender As Object, e As EventArgs) Handles btn_rootsign.Click
        If txt_entry.Text = "" Then
            MsgBox("error", MsgBoxStyle.Information)
        Else
            txt_history_entry.Text = "√(" + txt_entry.Text + ")"
            hasil = Math.Sqrt(txt_entry.Text)
            txt_entry.Text = hasil
        End If
    End Sub

    Private Sub btn_percent_Click(sender As Object, e As EventArgs) Handles btn_percent.Click
        If txt_entry.Text = "" Then
            MsgBox("error", MsgBoxStyle.Information)
        Else
            txt_history_entry.Text = txt_entry.Text + " %"
            hasil = txt_entry.Text / 100
            txt_entry.Text = hasil
        End If
    End Sub

    Private Sub btn_factorial_Click(sender As Object, e As EventArgs) Handles btn_factorial.Click
        Dim n, f, i As Integer
        f = 1
        n = Val(txt_entry.Text)
        For i = 1 To n
            f = f * i
        Next
        txt_history_entry.Text = txt_entry.Text + " !"
        txt_entry.Text = f
    End Sub

    Private Sub btn_x2_Click(sender As Object, e As EventArgs) Handles btn_x2.Click
        If txt_entry.Text = "" Then
            MsgBox("error", MsgBoxStyle.Information)
        Else
            txt_history_entry.Text = txt_entry.Text + " ^ 2"
            hasil = txt_entry.Text ^ 2
            txt_entry.Text = hasil
        End If
    End Sub

    Private Sub btn_phi_Click(sender As Object, e As EventArgs) Handles btn_phi.Click
        txt_entry.Text = Math.PI
    End Sub

    Private Sub btn_nCr_Click(sender As Object, e As EventArgs) Handles btn_nCr.Click

        operation = " C "
        txt_history_entry.Text = txt_entry.Text
        txt_entry.Text = ""

    End Sub
End Class
