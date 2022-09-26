using System.Text;

namespace heartSpam;

public class HeartGenerator
{ 
    public string MakeSpam(int len)
    {
        string[] possibleHearts =
        {
            "❤", "🧡", "💛", "💚", "💙", "💜", "🤎", "🖤", "🤍", "💔", "❣", "💕", "💞", "💓", "💗", "💖", "💘", "💝",
            "💟", "❤️‍🔥", "❤️‍🩹"
        };
        var rnd = new Random();

        var spam = new StringBuilder();

        for (var i = 0; i < len; i++)
        {
            var index = rnd.Next(possibleHearts.Length);
            spam.Append(possibleHearts[index]);
        }

        return spam.ToString();
    }
}