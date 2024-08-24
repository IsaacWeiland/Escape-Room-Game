namespace EscapeRoomGame;

public class Player
{
    public static List<string> Inventory { get; set; } = new List<string>();
    public static int InputParse2()
    {
        var inputSuccess = int.TryParse(Console.ReadLine(), out int parseSucceed);
        while (!inputSuccess || parseSucceed > 2 || parseSucceed < 1)
        {
            Console.WriteLine("Please enter a 1 or 2.");
            inputSuccess = int.TryParse(Console.ReadLine(), out parseSucceed);
        }
        return parseSucceed;
    }
    public static int InputParse3()
    {
        var inputSuccess = int.TryParse(Console.ReadLine(), out int parseSucceed);
        while (!inputSuccess || parseSucceed > 3 || parseSucceed < 1)
        {
            Console.WriteLine("Please enter a number 1 - 3.");
            inputSuccess = int.TryParse(Console.ReadLine(), out parseSucceed);
        }
        return parseSucceed;
    }
    public static int InputParse4()
    {
        var inputSuccess = int.TryParse(Console.ReadLine(), out int parseSucceed);
        while (!inputSuccess || parseSucceed > 4 || parseSucceed < 1)
        {
            Console.WriteLine("Please enter a number 1 - 4.");
            inputSuccess = int.TryParse(Console.ReadLine(), out parseSucceed);
        }
        return parseSucceed;
    }
    public static int InputParse5()
    {
        var inputSuccess = int.TryParse(Console.ReadLine(), out int parseSucceed);
        while (!inputSuccess || parseSucceed > 5 || parseSucceed < 1)
        {
            Console.WriteLine("Please enter a number 1 - 5.");
            inputSuccess = int.TryParse(Console.ReadLine(), out parseSucceed);
        }
        return parseSucceed;
    }
}