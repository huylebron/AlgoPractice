namespace LeetCode.Array;

public class KeepMultiplyingFoundValuesbyTwo
{
    public int FindFinalValue(int[] nums, int original)
    {

        // while (true)
        // {
        //     bool found = false; 
        //     
        //     foreach (int x  in nums)
        //     {
        //         if (x == original)
        //         {
        //             found = true; 
        //             break;
        //             
        //         }
        //         
        //     }
        //
        //     if (found)
        //     {
        //         original *=  2; 
        //     }
        //     else
        //     {
        //         break;
        //     }
        //     
        //     
        // }
        //
        // return original; 
        
        
        //Cach 2 using hashSet 

        HashSet<int> numset = new HashSet<int>(nums);
        
        while (numset.Contains(original))
        {
            original *= 2; 
        }
        
        return original; 
        
        //cach 3 

     
    }
    
}