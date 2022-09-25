using System.Text.RegularExpressions;

Console.WriteLine("how long do you want the spam?");

bool valid_input = false;
string clean_input = ""; 

while (!valid_input)
{
    string dirty_input = (Console.ReadLine());

    clean_input = Regex.Replace(dirty_input, "[^0-9]", "");
    
    if (clean_input != "")
    {
        valid_input = true;
    }
    else
    {
        Console.WriteLine("enter a number!");
    }
}

int len = Convert.ToInt32(clean_input);

string[] possible_hearts = {"❤", "🧡", "💛", "💚", "💙", "💜", "🤎", "🖤", "🤍", "💔", "❣", "💕", "💞", "💓", "💗", "💖", "💘", "💝", "💟", "❤️‍🔥", "❤️‍🩹"};

Random rnd = new Random();

string[] spam = new string[len];

int index;

for (int i = 0; i < spam.Length; i++)
{
    index = rnd.Next(possible_hearts.Length);
    spam[i] = possible_hearts[index];
}

Console.WriteLine("your spam is:");
foreach (string s in spam)
{
    Console.Write(s);
}
Console.WriteLine();