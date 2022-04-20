using System;

namespace _20._04task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "bU tasKI metHodla yAzmAliSiz";
            string lowerstr = str.ToLower();
            
            Console.WriteLine(lowerstr);

            if (lowerstr.Length==0)
               System.Console.WriteLine("Empty String");
                
            else if (lowerstr.Length==1)
               System.Console.WriteLine(char.ToUpper(lowerstr[0]));
            else
               System.Console.WriteLine(char.ToUpper(lowerstr[0]) + lowerstr.Substring(1));
          
        }
        
    }
}
