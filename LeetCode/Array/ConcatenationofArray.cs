namespace LeetCode.Array;

public class ConcatenationofArray
{
    public int[] GetConcatenation(int[] nums)
    {
        return nums.Concat(nums).ToArray();

    }

    public static void Main1(string[] args)
    {
        ConcatenationofArray sol = new ConcatenationofArray();
        int[] nums = {1,2,1};
        int[] result = sol.GetConcatenation(nums);
        Console.WriteLine("[" + string.Join(", ", result) + "]");
        Console.ReadKey();
        
        
        

    }
}