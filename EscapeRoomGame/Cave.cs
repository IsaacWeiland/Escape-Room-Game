namespace EscapeRoomGame;

public class Cave
{
    public static void Entrance()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("It is completely black.");
            if (Player.Inventory.Contains("flashlight") && Player.Inventory.Contains("batteries"))
            {
                Console.WriteLine("Would you like to use the flashlight and batteries?\n[1] Yes\n[2] No");
                switch (Player.InputParse2())
                {
                    case 1:
                        Console.WriteLine("You put the batteries in the flashlight.");
                        Console.WriteLine("Thanks to the flashlight, you notice that the walls are no longer man made.");
                        Creep.Scare();
                        Thread.Sleep(1000);
                        Console.WriteLine("The hall only continues one way.\n[1] Continue down the hall.\n[2] Leave.");
                        switch (Player.InputParse2())
                        {
                            case 1:
                                Console.WriteLine("You continued down the hall.");
                                Thread.Sleep(2000);
                                Clearing();
                                break;
                            case 2:
                                Console.WriteLine("You returned to the intersection.");
                                Thread.Sleep(2000);
                                Hospital.Intersection();
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("You decided not put the batteries in the flashlight.");
                        Thread.Sleep(1000);
                        Console.WriteLine("You decided to return to the intersection.");
                        Console.ReadLine();
                        Hospital.Intersection();
                        break;
                }
            }
            else
            {
                if (Player.Inventory.Contains("flashlight"))
                {
                    Console.WriteLine("I have a flashlight.\n It has no power.");
                    Thread.Sleep(1000);
                    Console.WriteLine("If only there was a way for me to power it.");
                    Console.WriteLine("You decided to return to the intersection.");
                    Console.ReadLine();
                    Hospital.Intersection();
                }
                else
                {
                    Console.WriteLine("You decided to return to the intersection.");
                    Console.ReadLine();
                    Hospital.Intersection();
                }
            }
        }
    }

    public static void Clearing()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("You find yourself at a clearing in the cave.");
        }
    }
}