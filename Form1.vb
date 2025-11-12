Public Class Form1
    Private Sub Btn_ShowMsg_Click(sender As Object, e As EventArgs) Handles Btn_ShowMsg.Click




    End Sub

    Private Sub iPhone16_Click(sender As Object, e As EventArgs) Handles iphone16.Click

        Dim StrBrand As String
        Dim StrModel As String
        Dim IntBattery As Integer
        Dim DoubScreenSize As Double
        Dim DecPrice As Decimal
        Dim BoolAvailability

        StrBrand = "Apple"
        StrModel = "iPhone 16"
        IntBattery = 4500
        DoubScreenSize = 6.7
        DecPrice = 799.99
        BoolAvailability = True

        MessageBox.Show(StrBrand & Environment.NewLine & StrModel & Environment.NewLine &
                        IntBattery & Environment.NewLine & DoubScreenSize & Environment.NewLine &
                        DecPrice & Environment.NewLine & BoolAvailability)

    End Sub

End Class