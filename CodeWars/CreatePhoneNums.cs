using System.Text;

namespace CodeWars;

public class CreatePhoneNums
{
   public  string CreatePhonNumsImp(string[] numbers)
   {
       return $"{ulong.Parse(string.Concat(numbers)):(0000) 000-000}";

   }
    
    
}