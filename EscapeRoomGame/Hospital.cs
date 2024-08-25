using System.Diagnostics;
using System.Threading.Channels;

namespace EscapeRoomGame;

public class Hospital
{
    public static void Intersection()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("You find yourself inside a derelict hospital hallway.");
            Creep.Scare();
            Thread.Sleep(1000);
            Console.WriteLine("[1] Walk down the east hall.\n[2] Walk down the west hall.\n" +
                              "[3] Investigate the northern door.\n[4] Investigate the southern door.\n[5] Investigate current area.");
            switch (Player.InputParse5())
            {
                case 1:
                    Console.WriteLine("You walked down the eastbound hall.");
                    Console.ReadLine();
                    EastHall();
                    break;
                case 2:
                    Console.WriteLine("You walked down the westbound hall.");
                    Console.ReadLine();
                    WestHall();
                    break;
                case 3:
                    Console.WriteLine("You went through the northernmost door.");
                    Console.ReadLine();
                    Cave.Entrance();
                    break;
                case 4:
                    Console.WriteLine("You went through the southernmost door.");
                    Console.ReadLine();
                    Room.Yours();
                    break;
                case 5:
                    Console.WriteLine("You investigated your surroundings.");
                    Thread.Sleep(1000);
                    Console.WriteLine("There are directional signs you can make out, but they're in a language you do not understand.");
                    Creep.Chance();
                    Console.ReadLine();
                    break;
            }
        }
    }

    public static void EastHall()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("You are at the end of the hall.\nThere are 3 doors.");
            Creep.Scare();
            Thread.Sleep(1000);
            Console.WriteLine("[1] Enter the east door.\n[2] Enter the north door.\n[3] Enter the south door.\n[4] Walk westward.\n[5] Investigate current area.");
            switch (Player.InputParse5())
            {
                case 1:
                    Console.WriteLine("You tried going through the east door, but it's completely covered in rubble.");
                    Thread.Sleep(1000);
                    Console.WriteLine("There is something amidst the rubble...");
                    Thread.Sleep(1000);
                    Console.WriteLine("You found and picked up a USB cable.");
                    Player.Inventory.Add("usb cable");
                    Creep.Chance();
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("You went through the north door.");
                    Console.ReadLine();
                    EastHallNorthDoor();
                    break;
                case 3:
                    Console.WriteLine("You went through the south door.");
                    Console.ReadLine();
                    EastHallSouthDoor();
                    break;
                case 4:
                    Console.WriteLine("You returned to the intersection.");
                    Console.ReadLine();
                    Intersection();
                    break;
                case 5:
                    Console.WriteLine("You checked your surroundings.");
                    Thread.Sleep(1000);
                    Console.WriteLine("The east door is covered in rubble and impossible to go through.");
                    Creep.Chance();
                    Console.ReadLine();
                    break;
            }
        }
    }

    public static void EastHallNorthDoor()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("It's an operating room.");
            Creep.Scare();
            Thread.Sleep(1000);
            Console.WriteLine("[1] Investigate the room.\n[2] Leave.");
            switch (Player.InputParse2())
            {
                case 1:
                    Console.WriteLine("You investigated the room.");
                    Thread.Sleep(1000);
                    Console.WriteLine("There's dried blood on the table.");
                    Creep.Chance();
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("You returned to the hall.");
                    Console.ReadLine();
                    EastHall();
                    break;
            }
        }
    }

    public static void EastHallSouthDoor()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("A room with several tables.");
            Creep.Scare();
            Console.WriteLine("[1] Investigate the room.\n[2] Leave.");
            Thread.Sleep(1000);
            switch (Player.InputParse2())
            {
                case 1:
                    Console.WriteLine("You investigated the room.");
                    Thread.Sleep(1000);
                    if (!Player.Inventory.Contains("flashlight"))
                    {
                        Console.WriteLine("Among the tables clutter with rusted medical tools and expired bottles of medicine,");
                        Console.WriteLine("you found various human remains in jars.");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine("you found a flashlight.");
                        Player.Inventory.Add("flashlight");
                        Creep.Chance();
                        Console.ReadLine();
                    }
                    else
                    {
                     Console.WriteLine("The contents on the table still unease you");
                     Creep.Chance();
                     Console.ReadLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("You returned to the hall.");
                    Console.ReadLine();
                    EastHall();
                    break;
            }
        }
    }

    public static void WestHall()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("There's a lobby area with large windows.\nIt's completely dark out.");
            Creep.Scare();
            Thread.Sleep(1000);
            Console.WriteLine("[1] Attempt to break windows.\n[2] Investigate area.\n[3] Leave.");
            switch (Player.InputParse3())
            {
                case 1:
                    Console.WriteLine("You attempted to break the windows.");
                    Thread.Sleep(1000);
                    Console.WriteLine("It would seem they will not break no matter what you do.");
                    Creep.Chance();
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("You checked the area.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Despite the flickering lights and enveloping darkness from the outside, you feel a sense of comfort in this room.");
                    Creep.Chance();
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("You returned to the intersection.");
                    Console.ReadLine();
                    Intersection();
                    break;
            }
        }
    }
}