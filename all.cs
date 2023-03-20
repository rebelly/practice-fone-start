using System;

namespace ConsoleApp1
{
    class rect_par
    {
        public int a;
        public int b;
        public int c;
        public rect_par(int a, int b, int c)
        {
            a = a;
            b = b;
            c = c;
        }
        public int square_width()
        {
            return a * b;
        }
        public int square_base()
        {
            return a * c;
        }
        public int square_depth()
        {
            return b * c;
        }
        public int vol()
        {
            return a * b * c;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите длину основания");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\n Введите длину ребер, равен ширине:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("\n Введите длину ребер, равных глубине ");
            int c = int.Parse(Console.ReadLine());
            rect_par rect = new rect_par(a,b,c);
            Console.WriteLine("Введите 1 если хотите увидеть площадь боковых граней, 2 если хотите увидеть площадь передних и задних граней, 3 если хотите увидеть площаадь оснований, 4 если хотите увидеть объем паралепипеда и 5, если хотите выйти из программы");

            int req = int.Parse(Console.ReadLine());
            while (req != 5)
            {
                if (req == 2)
                {
                    Console.WriteLine("Площадь боковых граней равна {rect_par.square_width(a,b)}");
                }
                if (req == 1)
                {
                    Console.WriteLine("Площадь  основных граней равна {rect_par.square_base(a,c)}");


                }
                if (req == 2)
                {
                    Console.WriteLine("Площадь  передней и задней грани равна {rect_par.square_height(a,b)}");
                }
                if )

            }


        }
    }
}
