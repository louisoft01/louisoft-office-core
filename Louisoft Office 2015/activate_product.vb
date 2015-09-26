Public Class activate_product

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Close()
        My.Computer.FileSystem.DeleteFile("help.loh")
        My.Computer.FileSystem.DeleteFile("startup.wav")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = ("175-866-OEM-788-845") Then
            MsgBox("Product Activated")
            My.Settings.Activate = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class