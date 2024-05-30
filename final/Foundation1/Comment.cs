public class Comment{
    public string _comment;
    public string _commenter;

    public Comment(string commenter, string comment){
        _commenter = commenter;
        _comment = comment;
    }
    public string GetCommentDetails(){
        return $"{_commenter} - {_comment}";
    }
}