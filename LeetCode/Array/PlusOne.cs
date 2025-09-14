namespace LeetCode.Array;

public class PlusOne
{
    public int[] PlusOneImp(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits; 
            }

            digits[i] = 0; 
            
        }

        int[] result = new int[digits.Length + 1];
        result[0] = 1;

        return result; 

    }

    public static void Main(string[] args)
    {
        int[] digits = {9,9,9}; 
        PlusOne sol = new PlusOne();
        int [] result = sol.PlusOneImp(digits);
        Console.Write("Mảng sau khi cộng 1: ");
        foreach (int num in result)
        {
            Console.Write(num);
            Console.ReadKey();
            
        }
        
    }
}