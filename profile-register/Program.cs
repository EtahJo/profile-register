using System;

namespace ProfileRegister
{
    class Program
    {
        public static void Main()
        {
            string[] names = new string[4];
            int[] age = new int[4];
            int presentIndex;

            presentIndex = 1;
            while (presentIndex<names.Length+1)
            {
                Console.Write("Enter Name {0} :",presentIndex);
                names[presentIndex - 1] = Console.ReadLine();
                Console.Write("Enter {0}'s age", names[presentIndex-1]);
                int.TryParse(Console.ReadLine(),out age[presentIndex - 1]);
                presentIndex += 1;
            }

            Console.WriteLine("----------------------");
            presentIndex = names.Length;
            while (presentIndex>=1)
            {
                Console.WriteLine("{0} is {1} years old", names[presentIndex - 1], age[presentIndex-1]);

                presentIndex -= 1;
            }
        }
    }
}