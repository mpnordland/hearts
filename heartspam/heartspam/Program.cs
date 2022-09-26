namespace heartSpam;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public static class Program
{
    public static async Task Main(string[] args)
    {

        int len;
        if (args.Length == 0 || String.IsNullOrWhiteSpace(args[0]))
        {
            len = GetHeartSpamLengthInteractively();

            Console.WriteLine($"generating {len} characters of heartspam");
            Console.WriteLine("your spam is:");
        }
        else if (args[0] == "-")
        {
            len = -1;
        }
        else if (!Int32.TryParse(args[0], out len))
        {
            Console.WriteLine($"{args[0]} is not a valid number. please enter an integer.");
            System.Environment.Exit(-1);
        }

        var heartGenerator = new HeartGenerator();
        if (len < 0)
        {
            try 
            {
                var stdOut = Console.OpenStandardOutput();
                while (stdOut.CanWrite){
                    Console.Write(heartGenerator.MakeSpam(20));
                    await Console.Out.FlushAsync();
                }
            }
            catch (IOException){}
        }
        else
        {
            Console.WriteLine(heartGenerator.MakeSpam(len));
        }

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
}