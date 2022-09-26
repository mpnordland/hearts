namespace heartSpam;
using System.Text.RegularExpressions;

public static class Program
{
    public static void Main()
    {
        var cleanInput = "";
        var heartGenerator = new HeartGenerator();
        ConsoleKeyInfo input;

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

        var output = heartGenerator.MakeSpam(len);

        Console.WriteLine("your spam is:");

        foreach (var s in output)
        {
            Console.Write(s);
        }

        Console.WriteLine();
    }
}