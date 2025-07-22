using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;

namespace Appweek12
{
    internal class Program
    {
        static void Main(string args)
        {
            string s1 = "Hello World";
            string[] token = s1.Split(); //split by space or tap
            Console.WriteLine(token[0]);
            Console.WriteLine(token[1]);
            // tokens array has to string elements : Hello , World
            Console.WriteLine("--------------Using a loop : -------------");
            for (int i = 0; i < token.Length; i++)
            {
                Console.WriteLine(token[i]);
            }
            Console.WriteLine("\n------------- Seperate by , -------------");
            string s2 = "h,e,l,l,o,w,o,r,l,d";
            char Del1 = ',';
            string[] token1 = s2.Split(Del1);
            for (int i = 0; i < token1.Length; i++)
            {
                Console.WriteLine(token[i]);
            }
            Console.WriteLine("\n------------ Using Different Delimeters--------------");
            string s3 = "H,e,l,l,o Wor ld";
            char[] Del2 = { ',', ' ', '\t' };
            string[] Token3 = s3.Split(Del2);
            for (int i = 0; i < Token3.Length; i++) 
            {
                Console.WriteLine(Token3[i]);
            }
        }
    }       
}