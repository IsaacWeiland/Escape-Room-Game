namespace EscapeRoomGame;

public class Intro
{
    public static void GameIntro()
    {
        Console.WriteLine("Welcome to the game\nPress enter key to start");
        Console.ReadLine();
        Room.Yours();
    }
}