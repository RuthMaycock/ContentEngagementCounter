Public Class Form1

    Dim Likes = 0
    Dim Comment = 0
    Dim CommentLike = 0
    Dim Share = 0
    Dim Rewatch = 0
    Dim Skip = 0
    Dim output As String

    Sub Restart()
        output = "Likes: " & Likes & " Comments: " & Comment & " Comment Likes: " & CommentLike & " Shares: " & Share & " Rewatches: " & Rewatch & " Skips: " & Skip
        Console.WriteLine(output)
        Likes = 0
        Comment = 0
        CommentLike = 0
        Share = 0
        Rewatch = 0
        Skip = 0
    End Sub
    Private Sub LikeButton_Click(sender As Object, e As EventArgs) Handles LikeButton.Click
        Likes += 1
    End Sub

    Private Sub CommentLike_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CommentLike += 1
    End Sub

    Private Sub Share_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Share += 1
    End Sub

    Private Sub Comment_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Comment += 1
    End Sub

    Private Sub Rewatch_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Rewatch += 1
    End Sub

    Private Sub Skip_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Skip += 1
    End Sub

    Private Sub Restart_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Restart()
    End Sub
End Class
