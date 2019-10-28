using System;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];

            names[0] = "Ulf";
            names[1] = "Rand";
            names[2] = "Hasse";
            names[3] = "Mikael";
            names[4] = "Peter";

            for (int index = 0; index < names.Length; index++)


            {
                Console.WriteLine(names[index]);
            }

        }// main


        static void ArrayEx1()

        {
            string[] names = new string[5];

            names[0] = "Ulf";
            names[1] = "Rand";
            names[2] = "Hasse";
            names[3] = "Mikael";
            names[4] = "Peter";

            for (int index = 0; index < names.Length; index++)


            {
                Console.WriteLine(names[index]);
            }
        }//ArrayEx1

        static void ArrayEx2 ()

        {
            string[] names = new string[] { "Ulf", "Rand", "Hasse", "Mikael", "Peter" };

                 foreach( string name in names)

                {
                Console.WriteLine(name);
            }
        }//ArrayEx2
    }

}
