using System.Collections.Generic;
using System.IO;
using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Video> commentaries = new List<Video>();
        
        
        
        Video videoA = new Video("Vivaldi: The four seasons", "Halidonmusic",180);

        Comment videocomment1A = new Comment("@classicfollower", "I was searching for the Vivaldi browser and ended up listening to this masterpiece."); 
        Comment videocomment2A = new Comment("@Kentallen", "Vivaldi Four seasons is my go to for the best of the Masters.  Enjoy!"); 
        Comment videocomment3A = new Comment("@laconchitalover", "Vivaldi's music became my best mood booster Thanks halidonmusic"); 
        Comment videocomment4A = new Comment("@francolucca", "Appreciating this music for us rare new  youngers is rare !"); 

        videoA.CommentsList(videocomment1A);
        videoA.CommentsList(videocomment2A);
        videoA.CommentsList(videocomment3A);
        videoA.CommentsList(videocomment4A);
        commentaries.Add(videoA);



        Video videB = new Video("The Church of Jesus Christ of Latter-day Saints","The Will of God",480);

        Comment videoBcomment1 = new Comment("@koketaluv24","Im not mormon but i love the meaning behind this story.... I too was cut down by god, only to grow stronger.");
        Comment videoBcomment2 = new Comment("@richardm5884","President Henry B. Eyring is known by some to have said: If we are not being rebuked by the Spirit, then we need to change the way we are praying.");
        Comment videoBcomment3 = new Comment("@elizat3898","I come back to this video whenever I feel God has asked too much. I need a reminder of Who is in charge. He knows all");
        Comment videoBcomment4 = new Comment("@justanotherone9648","He is the Potter and I am the clay, mold me and make, Lord, have thine own way");

        videB.CommentsList(videoBcomment1);
        videB.CommentsList(videoBcomment2);
        videB.CommentsList(videoBcomment3);
        videB.CommentsList(videoBcomment4);
        commentaries.Add(videB);

        Video videoC = new Video("TEDx Talks","The ADHD Brain: A Model for the Future | Rovena Caster",467);

        Comment videoCcomment1 = new Comment("@brucewade7719","A great view, it us quite difficult living in this neurotypical world.");
        Comment videoCcomment3 = new Comment("@germainpinganau","Has the world actually been built for neurotypical ? Is it not just the sum of interest and visions of the bigger number.");
        Comment videoCcomment2 = new Comment("@lunos5025","My daughter is ill and has been diagnosed from the lgs syndrome and adhd");
        Comment videoCcomment4 = new Comment("@TheBookBurner","Very accurate, even the simplest accommodations, WITH legal precedent are incredibly hard to receive. If even the bare legal minimum was accessible it would improve millions of live");

        videoC.CommentsList(videoCcomment1);
        videoC.CommentsList(videoCcomment2);
        videoC.CommentsList(videoCcomment3);
        videoC.CommentsList(videoCcomment4);
        commentaries.Add(videoC);
        
        foreach (Video video in commentaries)
        {
            Console.WriteLine("");
            video.DisplayComments();
            // Console.WriteLine();
            video.Comentaries();
            Console.WriteLine();
            Console.WriteLine();
            
        
        }
    }
}