using System;

namespace HomeWork2
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(RomanNumber.Plus(new RomanNumber(15), new RomanNumber(18)));
            try
            {
                Console.WriteLine(RomanNumber.Minus(new RomanNumber(18), new RomanNumber(15)));
            }
            catch (RomanNumberException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(RomanNumber.Multy(new RomanNumber(35), new RomanNumber(10)));
            try
            {
                Console.WriteLine(RomanNumber.Divid(new RomanNumber(70), new RomanNumber(35)));
            }
            catch (RomanNumberException e)
            {
                Console.WriteLine(e.Message);
            }
            RomanNumber[] romanNumberArray = new RomanNumber[10];
            for (int i = 0; i < 10; i++)
            {
                ushort rand = (ushort)(new Random().Next(1, 1000));
                romanNumberArray[i] = new RomanNumber(rand);
                Console.Write(romanNumberArray[i] + " ");
            }
            Console.WriteLine();

            Array.Sort(romanNumberArray);

            for (int i = 0; i < 10; i++)
            {
                Console.Write(romanNumberArray[i] + " ");
            }


        }
    }
}
