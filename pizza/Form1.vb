Public Class Form1

    Private Sub Button_Click(ByVal sender As System.Object,
                             ByVal e As System.EventArgs)

        Dim btn As Button = DirectCast(sender, Button)

        Select Case btn.Name
            Case "Button1.Click"
                tabs.SelectTab(TabPage1)
            Case "Button2.Click"
                tabs.SelectTab(TabPage2)
            Case "Button3.Click"
                tabs.SelectTab(TabPage3)
        End Select

    End Sub

    Public Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        tabs.SelectedIndex = 0
        Button6 = New Button()
    End Sub
    

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabPage2 = New TabPage()
    End Sub
End Class


