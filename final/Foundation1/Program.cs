using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        // First video is my own, found here: https://www.youtube.com/watch?v=6lQ9SEhWTRw
        // All comments on all of the videos are real comments that I found
        Video nervous_FGC = new Video("Leagues Until Legend #1", "Nervous_FGC", 828); 
        Comment nervous1 = new Comment("@EriqL810", "Look at this Ken player smh, should already be number 1");
        Comment nervous2 = new Comment("@HoidinatorHOTC", "Look at this ken player smh, should already be number 1");
        Comment nervous3 = new Comment("@The_Blazelighter", "Look at this number 1 player smh, should already be ken");
        Comment nervous4 = new Comment("@bakerfalcon", "Look at this ken player smh, should already be number 1");

        // Second video is from a favorite content creators, Scott the Woz, found here: https://www.youtube.com/watch?v=Qx88zndTGp8
        Video scott = new Video("Horror Games - Scott the Woz", "Scott The Woz", 1802);
        Comment scomment1 = new Comment("@TheADHDGamer420","Crazy how despite 250+ episodes there hasn’t been an episode that’s literally just about horror games");
        Comment scomment2 = new Comment("@YadonTheCat", "Just to put Alone in the Dark into perspective, it came out the same year as Wolfenstein 3D, and a year before Virtua Fighter, which was a big powerful arcade game rather than for computers");
        Comment scomment3 = new Comment("@zucumberzeez","Finally, a Scott The Woz holiday video released on time 🙏");
        Comment scomment4 = new Comment("@ottomaticallyawesome", "I love for the Rocky reference at the end, Scott changes the aspect ratio to 1.85:1, just the Rocky movies. Such attention to detail, I love it!");

        // Third video as an internet classic, found here: https://www.youtube.com/watch?v=ZZ5LpwO-An4
        Video heman = new Video("HEYYEYAAEYAAAEYAEYAA", "ProtoOfSnagem", 126);
        Comment hemancomment1 = new Comment("@Sliberrrrr", "this video came out in 2010 and you still see comments that say 1 hour ago");
        Comment hemancomment2 = new Comment("@TheDiamondMc88", "If internet was a movie , this would be its trailer.");
        Comment hemancomment3 = new Comment("@aestheticcat8976", "Thanks YouTube recommendations, I almost forgot this piece of art 😂");
        Comment hemancomment4 = new Comment("@BlurryTheDogLover", "You don’t realize how much this was part of my childhood");

        // The last video is a new mainstream video from the trending tab here: https://www.youtube.com/watch?v=ARRUyyQahRw
        Video rivals = new Video("Marvel Rivals 5 Most OP S+ Tier Heroes (And How To Play Them)", "Marvel Rivals Merchant", 765);
        Comment rivalcomment1 = new Comment("@finnsmith7552", "Jeff needs its own category");
        Comment rivalcomment2 = new Comment("@EJPlayzMarvelRivals", "This game a year from now going to be nuts. The amount of different heroes and villains they could add is endless. Waiting for juggernaut the most");
        Comment rivalcomment3 = new Comment("@damiencross7334", "Scarlet witch is ridiculous. I was dropping 40 kill games. Holding down one button. Her ultimate wipes whole teams. She is the most effortless character in the game. Been having a lot of fun with venom and iron fist.");
        Comment rivalcomment4 = new Comment("@electo4fours982", "People are sleeping on Groot. No where near overpowered, but his control over terrain, his heavy damage, his pairing of Jeff healing him or rocket dealing extra damage on his back all comes together to form a defensive unit.");

        nervous_FGC.AddComment(nervous1);
        nervous_FGC.AddComment(nervous2);
        nervous_FGC.AddComment(nervous3);
        nervous_FGC.AddComment(nervous4);

        scott.AddComment(scomment1);
        scott.AddComment(scomment2);
        scott.AddComment(scomment3);
        scott.AddComment(scomment4);

        heman.AddComment(hemancomment1);
        heman.AddComment(hemancomment2);
        heman.AddComment(hemancomment3);
        heman.AddComment(hemancomment4);

        rivals.AddComment(rivalcomment1);
        rivals.AddComment(rivalcomment2);
        rivals.AddComment(rivalcomment3);
        rivals.AddComment(rivalcomment4);

        List<Video> videos = new List<Video>{nervous_FGC, scott, heman, rivals};

        foreach (Video video in videos)
        {
            video.DisplayVideo();
            int totalComments = video.GetCommentNumber();
            Console.WriteLine($"This video has {totalComments} comments:");
            Console.WriteLine();
            List<Comment> comments = video.GetComments();
            foreach (Comment comment in comments)
            {
                comment.DisplayComment();
            }
            Console.WriteLine();
        }

    }
}