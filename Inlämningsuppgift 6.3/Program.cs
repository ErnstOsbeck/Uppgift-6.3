using System; 

namespace uppgift_6._3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Addera tre tal");
            Console.WriteLine("2. Största av två tal");
            Console.WriteLine("3. Avsluta programmet");
            Meny(int.Parse(Console.ReadLine()));
        }
        static void Meny(int val)
        {
            switch(val)
            {
                case 1:
                    Addera(1, 2, 3);
                    break;
                case 2:
                    Störst(1, 2);
                    break;
                case 3:
                    break;
            }
        }
        static void Addera(int tal1, int tal2, int tal3)
        {
            int summa = tal1 + tal2 + tal3;
            Console.WriteLine(summa);
        }
        static void Störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                Console.WriteLine(tal1);
            }
            else if (tal1 < tal2)
            {
                Console.WriteLine(tal2);
            }
        }
    }
}