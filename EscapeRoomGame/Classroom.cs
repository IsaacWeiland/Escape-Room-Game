namespace EscapeRoomGame;

public class Classroom
{
    public static bool _lightBulbBroken = false;
    public static void Area()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("You stand at the entrance of a disheveled classroom.");
            Creep.Scare();
            Thread.Sleep(1000);
            Console.WriteLine("[1] Investigate the chalkboard.\n[2] Investigate the desks.\n[3] Investigate the storage closet.\n[4] Leave.");
            switch (Player.InputParse4())
            {
                case 1:
                    Console.WriteLine("You went over to the chalkboard, avoiding the rubble and scrap along the way.");
                    Thread.Sleep(2000);
                    Console.WriteLine("The board has a diamond, a heart, and a spade written on it.");
                    Creep.Chance();
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("You checked all the desks. Some of them are toppled over. Some are broken.");
                    Thread.Sleep(2000);
                    Console.WriteLine("Inside one of the desks you found a necklace.\nIt's a strand of 5 diamonds.");
                    Creep.Chance();
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("You walked into the storage closet.");
                    Console.ReadLine();
                    StorageCloset();
                    break;
                case 4:
                    Console.WriteLine("You returned to the tunnel.");
                    Console.ReadLine();
                    Cave.RightTunnel();
                    break;
            }
        }
    }

    public static void StorageCloset()
    {
        while (true)
        {
            Console.Clear();
            if (!_lightBulbBroken)
            {
                Console.WriteLine("You stand inside the closet, it's bigger than it seems.\nThe single lightbulb is flickering.");
            }
            else
            {
                Console.WriteLine("You stand inside the closet.\nIt's dark.");
            }
            Creep.Scare();
            Console.WriteLine("[1] Investigate the shelves.\n[2] Turn off the light.\n[3] Leave.");
            switch (Player.InputParse3())
            {
                case 1:
                    if (Player.Inventory.Contains("strange device"))
                    {  
                        Console.WriteLine("You investigated the shelves.\nThey are rusted and covered in dust.");
                        Console.WriteLine("On one of the shelves there is a playing card.\nA king of hearts.");
                        Creep.Chance();
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You investigated the shelves.\nThey are rusted and covered in dust.");
                        Thread.Sleep(2000);
                        Console.WriteLine(
                            "On one of the shelves there's a strange device.\nYou decided to take it with you.");
                        Player.Inventory.Add("strange device");
                        Console.WriteLine("Under the device there is a playing card.\nA king of hearts.");
                        Creep.Chance();
                        Console.ReadLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("You flicked the lightswitch.");
                    _lightBulbBroken = true;
                    Console.WriteLine("You heard a pop with glass shattering.\nSomething else shuffled.");
                    Thread.Sleep(3000);
                    Console.WriteLine("You turned your flashlight on.\nOne of the walls has a spade with an 'a' written on it.");
                    Creep.Chance();
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("You returned to the classroom.");
                    Console.ReadLine();
                    Area();
                    break;
            }
        }
    }
}