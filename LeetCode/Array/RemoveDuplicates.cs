namespace LeetCode.Array;

public class RemoveDuplicates
{
    public int RemoveDuplicatesImp(int[] nums)
    {
        if (nums.Length == 0) return 0;


        int i = 0; // chi so gih 
        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[j] != nums[i])
            {
                i++;
                nums[i] = nums[j];
            }
            
            
        }

        return i + 1; 

    }


    public static void Main(string[] args)
    {
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        RemoveDuplicates sol = new RemoveDuplicates();
        int newLength = sol.RemoveDuplicatesImp(nums);

        Console.WriteLine($"Độ dài mới:{newLength} ");

        Console.Write("Mảng sau khi xóa trùng: ");
        for (int i = 0; i < newLength; i++)
        {
            Console.Write($"{nums[i]}");
        }
    }
}