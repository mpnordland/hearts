using System.Text.RegularExpressions;

var cleanInput = "";
string[] possibleHearts = {"❤", "🧡", "💛", "💚", "💙", "💜", "🤎", "🖤", "🤍", "💔", "❣", "💕", "💞", "💓", "💗", "💖", "💘", "💝", "💟", "❤️‍🔥", "❤️‍🩹"};
var rnd = new Random();

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
var spam = new string[len];

for (var i = 0; i < spam.Length; i++)
{
    var index = rnd.Next(possibleHearts.Length);
    spam[i] = possibleHearts[index];
}

Console.WriteLine("your spam is:");
foreach (var s in spam)
{
    Console.Write(s);
}
Console.WriteLine();