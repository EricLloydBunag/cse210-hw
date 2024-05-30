using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video
        {
            _author = "ProminenceCrown",
            _title = "Spear Techniques Throughout History",
            _length = 690,
            _comments = new List<Comment>(){
            new Comment("Jimmy", "Nice"),
            new Comment("Mike", "I knew spears were the best"),
            new Comment("Tom", "wouldnt work in a street fight"),
            new Comment("Donald", "new video lesgooo")
            }
        };

        Video video2 = new Video{
            _author = "PyroCrest57",
            _title = "My Players Are Gremlins And They're Aware",
            _length = 420,
            _comments = new List<Comment>(){
                new Comment("Malarkey", "Fellow DM here. I feel you so much XD"),
                new Comment("KaiteG", "I feel like I'm being called out"),
                new Comment("Viperwolf8810", "definitely more fun this way"),
                new Comment("Alex_Wolfe", "That's why you plan according to your players' personalities")
            }
        };

        Video video3 = new Video{
            _author = "CodingGuy1",
            _title = "Making Your Programs Look Cleaner And More Readable",
            _length = 367,
            _comments = new List<Comment>(){
                new Comment("Prom", "This video is so easy to follow!"),
                new Comment("DD", "thanks for making the video! i understood it clearly"),
                new Comment("DragonMead", "Nicely done bro")
            }
        };

        List<Video> videos = new List<Video>(){
            video1, video2, video3
        }; 

        foreach (Video v in videos){
            v.DisplayVideoDetails();
            v.DisplayComments();
        }
    }
}