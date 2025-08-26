namespace LeetCode.Array;

public class SortedSquares
{
    public int[] SortedSquaresImp(int[] nums)
    {
        int n = nums.Length;
        int[] res = new int[n];


        int left = 0;
        int right = n - 1;
        int resIndex = n - 1;


        while (left <= right)
        {
            int left_val = Math.Abs(nums[left]);
            int right_val = Math.Abs(nums[right]);


            if (left_val > right_val)
            {

                res[resIndex] = left_val * left_val;
                left++;
                
            }
            else
            {
                res[resIndex] = right_val * right_val;
                right--;
            }

            resIndex--;



        }

        return res;
    }
}