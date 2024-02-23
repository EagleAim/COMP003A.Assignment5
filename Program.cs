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
            PrintSeparator("Triangle");
            {
                Console.WriteLine("\t Please input ONE of any charecter");
                var inputLetter = Console.ReadLine();
                char letter = Convert.ToChar(inputLetter);


                Console.WriteLine("\t Please input a POSITIVE WHOLE NUMBER");
                var inputNumber = Console.ReadLine();
                int number = Convert.ToInt32(inputNumber);
               

                IsoscelesTriangleBuilder(letter, number);

            }

            PrintSeparator("Favorite Charecter");
            {

                CharacterInfo("Tourge", 1981);

                CharacterInfo("Tina", 2004);

                CharacterInfo("ClapTrap", 2017);

                CharacterInfo("Brick", 2002);

                CharacterInfo("Maya", 1994);
            }
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
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    Console.WriteLine($"{inputCharecter}");
                }
            }

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size - 1; j++)
                {
                    Console.WriteLine($"{inputCharecter}");
                }
            }

            /// <summary>
            /// A triangle genorator taking a custom charecter and number from a user.
            /// </summary>
        }

        static void AgeCaculator(int year)
        { 
            int currentYear = 2024 - Convert.ToInt32(year);

            ///<summary>
            ///A Age calcualor
            /// </summary>
        }

        static void CharacterInfo(string name, int birthYear)
        {
            AgeCaculator(birthYear);
            int yearBorn = 2024 - Convert.ToInt32(birthYear);
            Console.WriteLine($"{name} is {yearBorn}!");
            ///<summary>
            ///A input for the name and print of how old they are
            /// </summary>
        }


    }
}
