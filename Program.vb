Module Program
    Public Likes As Integer
    Public Comment As Integer
    Public CommentLike As Integer
    Public Share As Integer
    Public Rewatch As Integer
    Public Skip As Integer

    Sub Main()
        Likes = 0
        Comment = 0
        CommentLike = 0
        Share = 0
        Rewatch = 0
        Skip = 0
    End Sub

    Sub Restart()
        Console.WriteLine("Likes: ", Likes, "Comments: ", Comment, "Comment Likes: ", CommentLike, "Shares: ", Share, "Rewatches: ", Rewatch, "Skips: ", Skip)
        Likes = 0
        Comment = 0
        CommentLike = 0
        Share = 0
        Rewatch = 0
        Skip = 0
    End Sub

End Module
