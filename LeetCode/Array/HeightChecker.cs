namespace LeetCode.Array;

public class HeightChecker
{
    public static  int HeightCheckerimp (int[] height)
    {
        // int[] sorted = (int[])height.Clone(); 
        //
        // System.Array.Sort(sorted);
        // int missMatch = 0;
        //
        // for (int i = 0; i < height.Length; i++)
        // {
        //     if (height[i] != sorted[i])
        //     {
        //         missMatch++;
        //     }
        // }
        //
        // return missMatch; 


        int[] count = new int[101];
        foreach (int h in height) count[h]++;

        int misMatch = 0;
        int index = 0;

        for (int h = 1; h <= 100; h++)
        {
            while (count[h]-- > 0 )
            {

                if (height[index] != h) misMatch++;
                index++;

            }
        }

        return misMatch; 




    }

    public static void Main1(string[] args)
    {
        
        int [] height = {1,2,1,2,1,2};
        Console.WriteLine("Số vị trí không đúng: " + HeightCheckerimp(height));
        Console.ReadKey();
    }
}