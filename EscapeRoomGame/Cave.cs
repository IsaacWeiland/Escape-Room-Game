using System.Collections.Concurrent;

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
                        Console.WriteLine("Thanks to the flashlight, you can now see.");
                        Thread.Sleep(1000);
                        Console.WriteLine("You notice that the walls are no longer man made, and the air is damp.");
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
                    Console.WriteLine("You have a flashlight.\n It has no power.");
                    Thread.Sleep(1000);
                    Console.WriteLine("If only there was a way for you to power it.");
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
            Creep.Scare();
            Thread.Sleep(1000);
            Console.WriteLine("[1] Explore the left tunnel.\n[2] Explore the right area\n[3] Investigate the clearing.\n[4] Leave.");
            switch (Player.InputParse4())
            {
                case 1:
                    Console.WriteLine("You went down the left tunnel.");
                    Console.ReadLine();
                    LeftTunnel();
                    break;
                case 2:
                    Console.WriteLine("You went down the right tunnel.");
                    Console.ReadLine();
                    RightTunnel();
                    break;
                case 3:
                    Console.WriteLine("You investigated the clearing.");
                    Thread.Sleep(1000);
                    Console.WriteLine("You appear to be inside of a cave.");
                    Thread.Sleep(1000);
                    Console.WriteLine("It looks like someone had been living here.");
                    Console.ReadLine();
                    Creep.Chance();
                    break;
                case 4:
                    Console.WriteLine("You returned to the entrance.");
                    Console.ReadLine();
                    Entrance();
                    break;
            }
        }
    }

    public static void LeftTunnel()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("You are at the end of the tunnel.");
            Creep.Scare();
            Thread.Sleep(1000);
            if (Player.LeftTunnelExplored)
            {
                Console.WriteLine("[1] Investigate the area.\n[2] Use the USB port \n[3] Leave.");
                switch (Player.InputParse3())
                {
                    case 1:
                        Console.WriteLine("You investigated the area.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Oddly enough there is an outlet.\nIt has only one port for USB.");
                        Creep.Chance();
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("There is a USB port here.");
                        if (Player.Inventory.Contains("usb cable") && Player.Inventory.Contains("strange device") && !Player.PasswordFilled)
                        {
                            Console.WriteLine("Would you like to plug the device into the port?\n[1] Yes.\n[2] No.");
                            if (Player.InputParse2() == 1)
                            {
                                Console.WriteLine("You plugged the device into the wall.");
                                Thread.Sleep(1000);
                                Console.WriteLine("It's asking for a password.");
                                if (Player.PasswordCheck(Player.InputPassword()))
                                {
                                    Console.WriteLine("The password is correct.");
                                    Player.PasswordFilled = true;
                                    Console.WriteLine("You feel as if something changed somewhere.");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("You decided to leave it for now.");
                                    Console.ReadLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("You left the port as is.");
                                Creep.Chance();
                                Console.ReadLine();
                            }
                        }
                        else if (Player.Inventory.Contains("usb cable") && !Player.PasswordFilled)
                        {
                            Console.WriteLine("Is there something you can use with the USB cable?");
                            Creep.Chance();
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("There is nothing you can do with it.");
                            Creep.Chance();
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("You returned to the clearing.");
                        Console.ReadLine();
                        Clearing();
                        break;
                }
            }
            else
            {
                Console.WriteLine("[1] Investigate the area.\n[2] Leave.");
                switch (Player.InputParse2())
                {
                    case 1:
                        Console.WriteLine("You investigated the area.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Oddly enough there is an outlet.\nIt has only one port for USB.");
                        Creep.Chance();
                        Console.ReadLine();
                        Player.LeftTunnelExplored = true;
                        break;
                    case 2:
                        Console.WriteLine("You returned to the clearing.");
                        Console.ReadLine();
                        Clearing();
                        break;
                }
            }
        }
    }

    public static void RightTunnel()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("The tunnel continues on.");
            Creep.Scare();
            Thread.Sleep(1000);
            Console.WriteLine("[1] Continue down the tunnel.\n[2] Investigate the area.\n[3] Leave.");
            switch (Player.InputParse3())
            {
                case 1:
                    Console.WriteLine("You continued down the tunnel.");
                    Thread.Sleep(3000);
                    Console.WriteLine("There is a door here.\nEnter?\n[1] Yes.\n[2] No.");
                    switch (Player.InputParse2())
                    {
                        case 1:
                            Console.WriteLine("You entered the door.");
                            Console.ReadLine();
                            Classroom.Area();
                            break;
                        case 2:
                            Console.WriteLine("You headed back to the hall.");
                            Console.ReadLine();
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("You investigated the area.");
                    if (Player.PasswordFilled)
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("There is a small opening in one of the walls.");
                        Thread.Sleep(1000);
                        Console.WriteLine("You picked up a key.");
                        Player.Inventory.Add("closet key");
                        Console.ReadLine();
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("A portion of the wall seems off.\nThere doesn't seem to be anything you can do with it at the moment.");
                        Creep.Chance();
                        Console.ReadLine();
                    }
                    break;
                case 3:
                    Console.WriteLine("You returned to the clearing");
                    Console.ReadLine();
                    Clearing();
                    break;
            }
        }
    }
}