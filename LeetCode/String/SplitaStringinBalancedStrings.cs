namespace LeetCode.String;

public class SplitaStringinBalancedStrings
{
    public int BalancedStringSplit(string s)
    {
        int count = 0;
        int balance = 0;

        foreach (var chr in s)
        {
            if (chr == 'L') balance += 1 ;
            else
            {
                balance -= 1; 
            }

            if (balance == 0)
            {
                count++;
                
            }
            
            
            
            
        }

        return count; 

    }
}