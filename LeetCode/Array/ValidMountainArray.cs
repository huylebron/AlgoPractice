using System.Data.Common;

namespace LeetCode.Array;

public class ValidMountainArray
{
    public bool ValidMountainArrayImp(int[] arr)
    {
        int n = arr.Length;

        if (n < 3) return false;

        int i = 0;
        while (i +1 <n && arr[i] < arr[i+1] )
        {
            

            i++;

        }

        if (i == 0 || i == n - 1) return false;

        while (i + 1 < n && arr[i] > arr[i+1]  )

        {

            i++;
            
        }


        return i == n - 1; 

    }







    public static void Main1(string[] args)
    {
        ValidMountainArray valid = new ValidMountainArray();
        
        int[] arr1 = {0,3,2,1};
        Console.WriteLine(valid.ValidMountainArrayImp(arr1));
        int[] arr2 = {2,1};
        Console.WriteLine(valid.ValidMountainArrayImp(arr2));
        int[] arr3 = {3,5,5};
        Console.WriteLine(valid.ValidMountainArrayImp(arr3));
        int[] arr4 = {0,2,4,3,1};
        Console.WriteLine(valid.ValidMountainArrayImp(arr4));
        Console.ReadKey();
    }
}