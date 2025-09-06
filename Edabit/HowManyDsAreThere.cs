namespace Edabit;

public class HowManyDsAreThere
{
    public static int CountDs(string s)
    {

        return s.Count(Ch => char.ToLowerInvariant(Ch) == 'd');
        
        
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(CountDs("My friend Dylan got distracted in school."));
    }
}

