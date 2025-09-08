using System.Runtime.CompilerServices;
using System.Text;

namespace CodeWars;

public class DuplicateEncoder
{
    public static string DuplicateEncoderImp(string word)
    {
        string lower = word.ToLowerInvariant();
        var count = new Dictionary<char, int>();
        foreach (char  v  in lower)
        {
            if (count.ContainsKey(v))
            {
                count[v]++;
            }
            else
            {
                count[v] = 1; 
            }
            
        }

        StringBuilder sb = new StringBuilder();

        foreach (char c in lower)
        {

            if (count[c] == 1)
            {
                sb.Append("(");
            }
            else
            {
                sb.Append(")");
            }
            
            
            
            
            
        }

        return sb.ToString(); 

    }

    public static void Main(string[] args)
    {
        string word = " Success";
        Console.WriteLine("Kết quả: " + DuplicateEncoderImp(word));
    }
    
}