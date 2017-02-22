Class MainWindow
    Private Sub StartButton_Click(sender As Object, e As RoutedEventArgs) Handles StartButton.Click
        Dim vid As Window
        vid = New video()
        vid.Show()
        vid = Nothing
        Close()
    End Sub
End Class
