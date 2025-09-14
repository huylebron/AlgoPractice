namespace LeetCode.Sortring;

public class ArraybyIncreasingFrequency
{
    public int[] FrequencySort(int[] nums)
    {
        var freq = new Dictionary<int, int>();
        foreach (int y in nums)
        {
            if (freq.ContainsKey(y))
                freq[y]++;
            else
                freq[y] = 1;
        }

        return nums.OrderBy(x => freq[x]).ThenByDescending(x => x).ToArray(); 
    }

    public static void Main1(string[] args)
    {
        ArraybyIncreasingFrequency arr = new ArraybyIncreasingFrequency();
        int[] nums = {1,1,2,2,2,3};
        int[] res = arr.FrequencySort(nums);
        Console.WriteLine(string.Join(",", res));
    }
}