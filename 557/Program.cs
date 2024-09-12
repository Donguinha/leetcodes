using System.Text;

namespace FiveFiveSeven;

class Program
{
    private const string S = "text for example";

    public static void Main(string[] args)
    {

        Console.WriteLine(ReverseWords(S));
        
    }

    static string ReverseWords(string s)
    {
        var words = s.Split(' ');

        var resultString = new StringBuilder();

        foreach (var word in words)
        {
            for (int i = 0; i < word.Length; i++)
            {
                resultString.Append(word[word.Length - i - 1]);
            }
            
            resultString.Append(' ');
        }
        
        return resultString.ToString().TrimEnd();
    }
}