namespace heartSpam;
using System.Text.RegularExpressions;

public static class Program {
    public static void Main()
    {
        var cleanInput = "";
        var heartGenerator = new HeartGenerator();

        do
        {
            Console.WriteLine("how long do you want the spam? (any non digit characters will be ignored)");
            var input = Console.ReadLine();
            if (input is not null && input.Any(char.IsDigit))
            {
                cleanInput = Regex.Replace(input, "[^0-9]", "");
            }

            Console.WriteLine(cleanInput + input);
        } while (cleanInput == "");

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