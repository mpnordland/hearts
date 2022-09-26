namespace heartSpam;
using System.Text.RegularExpressions;

public static class Program
{
    public static void Main(string[] args)
    {

        int len;
        if (args.Length == 0 || String.IsNullOrWhiteSpace(args[0]))
        {
            len = GetHeartSpamLengthInteractively();

            Console.WriteLine($"generating {len} characters of heartspam");
            Console.WriteLine("your spam is:");
        }
        else if (!Int32.TryParse(args[0], out len))
        {
            Console.WriteLine($"{args[0]} is not a valid number. please enter an integer.");
            System.Environment.Exit(-1);
        }

        var heartGenerator = new HeartGenerator();
        Console.WriteLine(heartGenerator.MakeSpam(len));

    }
    static int GetHeartSpamLengthInteractively()
    {
        ConsoleKeyInfo input;
        var cleanInput = "";

        Console.WriteLine("how long do you want the spam? (any non digit characters will be ignored)");
        do
        {
            // capture input but don't echo it immediately
            input = Console.ReadKey(intercept: true);
            if (char.IsDigit(input.KeyChar))
            {
                cleanInput += input.KeyChar;
                Console.Write(input.KeyChar);
            }
        } while (input.Key != ConsoleKey.Enter);
        Console.WriteLine(); //Output the enter key


        var len = Convert.ToInt32(cleanInput);
        return len;
    }

        foreach (var s in output)
        {
            Console.Write(s);
        }

        Console.WriteLine();
    }
}