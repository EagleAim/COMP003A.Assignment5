/*
 * Author: Logan King
 * Course: COMP-03A
 * Purpouse: To show our ability with Methods and XML comments
 */


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
            Console.WriteLine("******************************************************");
            Console.WriteLine("Triangle Section");
            Console.WriteLine("******************************************************");


            Console.WriteLine("\n Please input ONE charecter");
            

            Console.WriteLine("\n Please enter a positive whole number");
           
           
            for (int i = 1; i<=size ; i++)
            {
                for (int j = 1; j<=size; j++)
                {
                    Console.WriteLine($"{inputCharecter}");
                }
            }

            for (int i = 1;i<=size; i++)
            {
                for (int j = 1; j<=size-1; j++)
                {
                    Console.WriteLine($"{inputCharecter}");
                }
            }

        }
    }
}
