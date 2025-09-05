namespace LeetCode.Array;

public class SortArrayByParity
{
    public int[] SortArrayByParityImp(int[] nums)
    {
       
        int left = 0;
        int right = nums.Length - 1;

        while ( left < right )
        {
            if (nums[left] % 2 > nums[right] % 2)
            {
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp; 
                
            }
        if (nums[right] % 2 == 1) right--;
        if (nums[left] % 2 == 0) left++;
        }

    


        return nums; 


    }
}