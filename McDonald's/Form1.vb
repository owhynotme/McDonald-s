Public Class Form1
    Dim gst As Integer

    Private Sub Burger_CheckBox_CheckedChanged(sender As Object, e As EventArgs)

        If Burger_CheckBox.Checked Then
            Qty_burger.Enabled = True
            Qty_burger.Clear()

        Else
            Qty_burger.Enabled = False
            Qty_burger.Text = 0
        End If
    End Sub

    'Private Sub Fries_CheckBox3_CheckedChanged(sender As Object, e As EventArgs)

    '    If Fries_CheckBox3.Checked Then
    '        Qty_Fries.Enabled = True
    '        Qty_Fries.Clear()

    '    Else
    '        Qty_Fries.Enabled = False
    '        Qty_Fries.Text = 0
    '    End If
    'End Sub

    'Private Sub McpuffCheckBox_CheckedChanged(sender As Object, e As EventArgs)
    '    If McpuffCheckBox.Checked Then
    '        Qty_Mcpuff.Enabled = True
    '        Qty_Mcpuff.Clear()
    '    Else
    '        Qty_Mcpuff.Enabled = False
    '        Qty_Mcpuff.Text = 0
    '    End If
    'End Sub

    'Private Sub HappymealCheckBox_CheckedChanged(sender As Object, e As EventArgs)
    '    If HappymealCheckBox.Checked Then
    '        Qty_Happymeal.Enabled = True
    '        Qty_Happymeal.Clear()
    '    Else
    '        Qty_Happymeal.Enabled = False
    '        Qty_Happymeal.Text = 0
    '    End If
    'End Sub

    'Private Sub McflurryCheckBox_CheckedChanged(sender As Object, e As EventArgs)
    '    If McflurryCheckBox.Checked Then
    '        Qty_Mcflurry.Enabled = True
    '        Qty_Mcflurry.Clear()
    '    Else
    '        Qty_Mcflurry.Enabled = False
    '        Qty_Mcflurry.Text = 0
    '    End If
    'End Sub

    'Private Sub CokeCheckBox_CheckedChanged(sender As Object, e As EventArgs)
    '    If CokeCheckBox.Checked Then
    '        Qty_Coke.Enabled = True
    '        Qty_Coke.Clear()
    '    Else
    '        Qty_Coke.Enabled = False
    '        Qty_Coke.Text = 0
    '    End If

    'End Sub

    'Private Sub RedbullCheckBox_CheckedChanged(sender As Object, e As EventArgs)
    '    If RedbullCheckBox.Checked Then
    '        Qty_Redbull.Enabled = True
    '        Qty_Redbull.Clear()
    '    Else
    '        Qty_Redbull.Enabled = False
    '        Qty_Redbull.Text = 0
    '    End If
    'End Sub

    'Private Sub IceteaCheckBox_CheckedChanged(sender As Object, e As EventArgs)
    '    If IceteaCheckBox.Checked Then
    '        Qty_Icetea.Enabled = True
    '        Qty_Icetea.Clear()
    '    Else
    '        Qty_Icetea.Enabled = False
    '        Qty_Icetea.Text = 0
    '    End If

    'End Sub

    'Private Sub LemonteaCheckBox_CheckedChanged(sender As Object, e As EventArgs)
    '    If LemonteaCheckBox.Checked Then
    '        Qty_Lemontea.Enabled = True
    '        Qty_Lemontea.Clear()
    '    Else
    '        Qty_Lemontea.Enabled = False
    '        Qty_Lemontea.Text = 0
    '    End If
    'End Sub

    'Private Sub Button_Make_Bill_Click(sender As Object, e As EventArgs)
    '    Total_Bill.Text = Label_Burger.Text * Qty_burger.Text + LabelFries.Text * Qty_Fries.Text + LabelMcpuff.Text * Qty_Mcpuff.Text + LabelHappymeal.Text * Qty_Happymeal.Text + LabelMcflurry.Text * Qty_Mcflurry.Text + LabelCoke.Text * Qty_Coke.Text + LabelRedbull.Text * Qty_Redbull.Text + LabelIcetea.Text * Qty_Icetea.Text + Qty_Lemontea.Text * Qty_Lemontea.Text
    '    gst = Total_Bill.Text * 0.5
    '    GST_TextBox.Text = Total_Bill.Text - gst
    '    If Total_Bill.Text > 1000 Then
    '        Discount_Textbox.Text = Total_Bill.Text * 0.12
    '    End If

    '    Final_Bill_TextBox.Text = Total_Bill.Text - Discount_Textbox.Text + GST_TextBox.Text

    'End Sub

    'Private Sub Reset_Button_Click(sender As Object, e As EventArgs)
    '    Burger_CheckBox.Checked = False
    '    Qty_burger.Clear()
    '    Fries_CheckBox3.Checked = False
    '    Qty_Fries.Clear()
    '    McpuffCheckBox.Checked = False
    '    Qty_Mcpuff.Clear()
    '    HappymealCheckBox.Checked = False
    '    Qty_Happymeal.Text = 0
    '    McflurryCheckBox.Checked = False
    '    Qty_Mcflurry.Clear()
    '    CokeCheckBox.Checked = False
    '    Qty_Coke.Clear()
    '    RedbullCheckBox.Checked = False
    '    Qty_Redbull.Clear()
    '    IceteaCheckBox.Checked = False
    '    Qty_Icetea.Clear()
    '    LemonteaCheckBox.Checked = False
    '    Qty_Lemontea.Clear()
    '    Total_Bill.Clear()
    '    GST_TextBox.Clear()
    '    Discount_Textbox.Clear()
    '    Final_Bill_TextBox.Clear()

    'End Sub


End Class
