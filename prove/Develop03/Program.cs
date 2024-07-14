using System.IO;
using System;


class Program
{
    static void Main(string[] args)
    {


        RandomScriptures gospels = new RandomScriptures();

        gospels.AddingScripture(new Reference("Proverbs", 10, 16), "The labour of the righteous tendeth to life: the fruit of the wicked to sin.");
        gospels.AddingScripture(new Reference("Proverbs", 16, 1, 2), "The preparations of the heart in man, and the answer of the tongue, is from the Lord. All the ways of a man are clean in his own eyes; but the Lord weigheth the spirits.");
        gospels.AddingScripture(new Reference("Lamentations", 2, 14), "Thy prophets have seen vain and foolish things for thee: and they have not discovered thine iniquity, to turn away thy captivity; but have seen for thee false burdens and causes of banishment." );
        gospels.AddingScripture(new Reference("Genesis", 1, 30), "And to every beast of the earth, and to every fowl of the air, and to every thing that creepeth upon the earth, wherein there is life, I have given every green herb for meat: and it was so.");
        gospels.AddingScripture(new Reference("Matthew", 3, 11), "indeed baptize you with water unto repentance: but he that cometh after me is mightier than I, whose shoes I am not worthy to bear: he shall baptize you with the Holy Ghost, and with fire:");
        gospels.AddingScripture(new Reference("Romans", 2, 13, 14), "(For not the hearers of the law are just before God, but the doers of the law shall be justified. For when the Gentiles, which have not the law, do by nature the things contained in the law, these, having not the law, are a law unto themselves:");
        gospels.AddingScripture(new Reference("Revelation", 3, 14), "14 And unto the angel of the church of the Laodiceans write; These things saith the Amen, the faithful and true witness, the beginning of the creation of God;");
        gospels.AddingScripture(new Reference("Moroni", 2, 3), "Now Christ spake these words unto them at the time of his first appearing; and the multitude heard it not, but the disciples heard it; and on as many as they laid their hands, fell the Holy Ghost.");
        gospels.AddingScripture(new Reference("D&C", 4, 6, 7), "Remember faith, virtue, knowledge, temperance, patience, brotherly kindness, godliness, charity, humility, diligence.Ask, and ye shall receive; knock, and it shall be opened unto you. Amen.");
        gospels.AddingScripture(new Reference("D&C", 95, 3), "For the preparation wherewith I design to prepare mine apostles to prune my vineyard for the last time, that I may bring to pass my strange act, that I may pour out my Spirit upon all flesh");

        
        while (true)
        {
            Scripture gospel = gospels.RandomScripture();
            
            if (gospel == null)
            {
                if (gospel.Learned())
                {
                    Console.WriteLine("Type Enter to countinue");
                    break;
                }

                while (gospel.Learned())
                {
                    Console.WriteLine(gospel.ShowText());
                    Console.WriteLine("Press Enter to continue or type  'Q' to Exit");
                    string input = Console.ReadLine();
                    Console.Clear();

                    if (input.ToUpper() == "Q" )
                    {
                        return;
                    
                    }

                    if (gospel.Learned())
                    {
                        Console.WriteLine("You've memorized the Gospel");
                        break;
                    }                
                }
            }


        }

        
    }
}