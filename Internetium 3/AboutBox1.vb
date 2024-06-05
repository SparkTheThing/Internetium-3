Public NotInheritable Class AboutBox1
    Private Sub AboutBox1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.BackMusic, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
        My.Computer.Audio.Stop()
    End Sub

End Class
