namespace EscapeRoomGame;

public class Player
{
    public static bool LeftTunnelExplored = false;
    public static bool PasswordFilled = false;
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

    public static int InputPassword()
    {
        var inputSuccess = int.TryParse(Console.ReadLine(), out int passwordGuess);
        while (!inputSuccess || passwordGuess < 1000 || passwordGuess > 9999)
        {
            Console.WriteLine("The device left a message:\nERROR: PASSWORD IS 4 NUMBERS LONG");
            Thread.Sleep(1000);
            Console.WriteLine("Would you like to try again?");
            Console.WriteLine("[1] Yes.\n[2] No.");
            if (InputParse2() == 1)
            {
                Console.WriteLine("Enter a password.");
                inputSuccess = int.TryParse(Console.ReadLine(), out passwordGuess);
            }
            else
            {
                inputSuccess = true;
            }
        }

        return passwordGuess;
    }

    public static bool PasswordCheck(int passwordInput)
    {
        bool didGuess = false;
        if (passwordInput == 5131) //5 of diamonds king of hearts ace of spades
        {
            didGuess = true;
        }
        else
        {
            Creep.Chance();
            Console.WriteLine("The password was incorrect.");
            Thread.Sleep(1000);
            Console.WriteLine("Would you like to try again?");
            Console.WriteLine("[1] Yes.\n[2] No.");
            if (InputParse2() == 1)
            {
                Console.WriteLine("Enter a password.");
                PasswordCheck(InputPassword());
            }
        }
        return didGuess;
    }
}