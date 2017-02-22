Public Class video
    uiModeOptions.Items.Add("invisible")
    uiModeOptions.Items.Add("none")
    uiModeOptions.Items.Add("mini")
    uiModeOptions.Items.Add("full")
    Public Sub uiModeOptions_OnSelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles uiModeOptions.SelectedIndexChanged
        ' Get selected UI mode in the list box as string.
        Dim lb As System.Windows.Forms.ListBox = sender
        Dim newMode As String = lb.SelectedItem

        'set UI mode selected
        player.uiMode = newMode
    End Sub
End Class
