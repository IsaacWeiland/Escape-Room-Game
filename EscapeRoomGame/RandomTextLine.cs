namespace EscapeRoomGame;

public class RandomTextLine
{
    public static void Stage1()
    {
        Random r = new Random();
        int randNum = r.Next(1, 6);
        if (randNum == 5)
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
        int randNum = r.Next(1, 6);
        if (randNum == 5)
        {
            Random nr = new Random();
            int subRandNum = nr.Next(1, 8);
            switch (subRandNum)
            {
                case 1:
                    Console.WriteLine("You are not alone.");
                    break;
                case 2:
                    Console.WriteLine("There is someone watching you.");
                    break;
                case 3:
                    Console.WriteLine("You can hear rustling nearby.");
                    break;
                case 4:
                    Console.WriteLine("You can hear scratching.");
                    break;
                case 5:
                    Console.WriteLine("You can see a shadow in the corner.");
                    break;
                case 6:
                    Console.WriteLine("You can hear murmurs.");
                    break;
                case 7:
                    Console.WriteLine("It felt like something ran by you.");
                    break;
            }
        }
    }

    public static void Stage3()
    {
        Random r = new Random();
        int randNum = r.Next(1, 6);
        if (randNum == 5)
        {
            Random nr = new Random();
            int subRandNum = nr.Next(1, 8);
            switch (subRandNum)
            {
                case 1:
                    Console.WriteLine("There's a shadow by the entrance.");
                    break;
                case 2:
                    Console.WriteLine("Something is trying to talk to you.");
                    break;
                case 3:
                    Console.WriteLine("Something ran past you.");
                    break;
                case 4:
                    Console.WriteLine("Something grabbed your shoulder.");
                    break;
                case 5:
                    Console.WriteLine("There are glowing eyes in the distance.");
                    break;
                case 6:
                    Console.WriteLine("You can hear growling near you.");
                    break;
                case 7:
                    Console.WriteLine("You can hear footsteps behind you.");
                    break;
            }
        }
    }
}