using System.Xml;

namespace EscapeRoomGame;

public class Creep
{
    public static bool Activation = false;
    public static bool Advancement = false;
    public static bool Penultimate = false;
    public static void Chance()
    {
        while (!Activation)
        {
            Random r = new Random();
            int randNum = r.Next(1, 11);
            if (randNum == 5)
            {
                Activation = true;
            }
            else
            {
                return;
            }
        }

        while (!Advancement)
        {
            Random r = new Random();
            int randNum = r.Next(1, 11);
            if (randNum == 5)
            {
                Advancement = true;
            }
            else
            {
                return;
            }
        }

        while (!Penultimate)
        {
            Random r = new Random();
            int randNum = r.Next(1, 11);
            if (randNum == 5)
            {
                Penultimate = true;
            }
            else
            {
                return;
            }
        }
    }

    public static void Scare()
    {
        if (Activation)
        {
            if (Advancement)
            {
                if (Penultimate)
                {
                    RandomTextLine.Stage3();
                    return;
                }
                else
                {
                    RandomTextLine.Stage2();
                    return;
                }
            }
            else
            {

                RandomTextLine.Stage1();
                return;
            }
        }
        else
        {
            return;
        }
    }

}