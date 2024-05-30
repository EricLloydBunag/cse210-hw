public class Video{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;


    public void DisplayVideoDetails(){
        Console.WriteLine($"{_title} - {_author}, {_length} seconds");
    }

    public void DisplayComments(){
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments){
            Console.WriteLine(comment.GetCommentDetails());
            
        }
    }

}