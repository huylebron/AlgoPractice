namespace LeetCode.Stack;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0) return false;


        var stack = new Stack<Char>();
        var match = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        foreach (char c in s)
        {

            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }

            else
            {
                if (stack.Count == 0 || stack.Pop() != match[c])
                {
                    return false; 
                }
            }
        }

        return stack.Count == 0; 
        

    }

    public static void Main1(string[] args)
    {
        var sol = new ValidParentheses();
        
        Console.WriteLine(sol.IsValid("()"));      // True
        Console.WriteLine(sol.IsValid("()[]{}"));  // True
        Console.WriteLine(sol.IsValid("(]"));      // False
        Console.WriteLine(sol.IsValid("([)]"));    // False
        Console.WriteLine(sol.IsValid("{[]}"));   
    }
}