namespace heartSpam;

public class HeartGenerator
{ 
    public string[] MakeSpam(int len)
    {
        string[] possibleHearts =
        {
            "❤", "🧡", "💛", "💚", "💙", "💜", "🤎", "🖤", "🤍", "💔", "❣", "💕", "💞", "💓", "💗", "💖", "💘", "💝",
            "💟", "❤️‍🔥", "❤️‍🩹"
        };
        var rnd = new Random();

        var spam = new string[len];

        for (var i = 0; i < spam.Length; i++)
        {
            var index = rnd.Next(possibleHearts.Length);
            spam[i] = possibleHearts[index];
        }

        return spam;
    }
}