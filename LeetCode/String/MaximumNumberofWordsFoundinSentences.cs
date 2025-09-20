namespace LeetCode;

public class MaximumNumberofWordsFoundinSentences
{
    public int MosWordsFound(string[] sentences)
    {
        List<int> count = new List<int>();

        foreach (var sen in sentences)
        {
            
            count.Add(sen.Split(' ').Count());
            
            
        }

        return count.Max(); 


    }

    public static void Main(string[] args)
    {

        MaximumNumberofWordsFoundinSentences sol = new MaximumNumberofWordsFoundinSentences();
        
        string[] sentences = { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };
        int result = sol.MosWordsFound(sentences);
        Console.WriteLine(result); // Output: 6
        
        

    }
}