namespace EscapeRoomGame;

public class RandomTextLine
{
    public static void Stage1()
    {
        Random r = new Random();
        int randNum = r.Next(1, 11);
        if (randNum == 10)
        {
            Random nr = new Random();
            int subRandNum = nr.Next(1, 8);
            switch (subRandNum)
            {
                case 1:
                    Console.WriteLine("You thought you heard something in the distance.");
                    break;
                case 2:
                    Console.WriteLine("You thought you saw something move from the corner of your eye.");
                    break;
                case 3:
                    Console.WriteLine("Must have been your imagination.");
                    break;
                case 4:
                    Console.WriteLine("You feel like someone is watching you.");
                    break;
                case 5:
                    Console.WriteLine("Must have been the wind.");
                    break;
                case 6:
                    Console.WriteLine("The darkness is eerie.");
                    break;
                case 7:
                    Console.WriteLine("Your eyes must be playing tricks on you.");
                    break;
            }
        }
        else
        {
            return;
        }
    }

    public static void Stage2()
    {
        Random r = new Random();
        int randNum = r.Next(1, 11);
        if (randNum == 10)
        {
            
        }
    }

    public static void Stage3()
    {
        Random r = new Random();
        int randNum = r.Next(1, 11);
        if (randNum == 10)
        {
            
        }
    }
}