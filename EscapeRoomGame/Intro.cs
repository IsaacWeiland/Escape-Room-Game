using System.Net;
using System.Net.Mime;

namespace EscapeRoomGame;

public class Intro
{
    public static void GameIntro()
    {
        Console.WriteLine("Welcome to the game\nPress enter key to start");
        Console.ReadLine();
        Room.Yours();
    }

    public static void Outro()
    {
        Console.WriteLine("You escaped the nightmare.");
        Console.ReadLine();
        Environment.Exit(0);
    }
}