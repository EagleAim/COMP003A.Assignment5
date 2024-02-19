/*
 * Author: Logan King
 * Course: COMP-03A
 * Purpouse: To show our ability with Methods and XML comments
 */

using System.Transactions;

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            
        }
        static void PrintSeparator()
        {
            Console.WriteLine("".PadRight(50, '*'));
        }

        static void PrintSeparator(string fake)
        {
            PrintSeparator();
            Console.WriteLine(fake);
            PrintSeparator();   
            /// <summary>
            /// A print seportator that dosnt go anywhwere
            /// </summary>
        }


        static void IsoscelesTriangleBuilder(char inputCharecter, int size)
        {
            Console.WriteLine("\n Please input ONE charecter");
            string inputCharercter = Console.ReadLine();

            Console.WriteLine("\n Please enter a positive whole number");
            
            int size = Console.ReadLine();
            
          
            
            
            for (int i = 0; i < size; i++) 
            { 
                
            }
        }
    }
}
