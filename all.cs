using System;

namespace ConsoleApp1
{
    class rect_par
    {
        public int h;
        public int sh;
        public int g;
        public int x;
        public int y;
        public rect_par(int a, int b, int c, int x, int y)
        {
            this.h = a;
            this.sh = b;
            this.g = c;
            this.x = x;
            this.y = y;

        }
        public rect_par()
        {
            h = 5;
            sh = 6;
            g = 7;
            x = 0;
            y = 0;
        }
        public int square_width()
        {
            return h * sh;
        }
        public int square_base()
        {
            return h * g;
        }
        public int square_depth()
        {
            return sh * g;
        }
        public int vol()
        {
            return h * sh * g;
        }
        public void  move_x(int step_x)
        {
            this.x += step_x;
        }
        public void move_y(int step_y)
        {
            this.y += step_y;
        }
        public void height_change(int change)
        {
            this.h += change;
        }
        public void width_change(int change)
        {
            this.sh += change;
        }
        public void depth_change(int change)
        {
            this.g += change;
        }
        public string length()
        {
            return $"Длина стороны a равна {h}, длина стороны b равна {sh}, длина стороны с равна {g}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 0, если хотите вручную заполнить класс и введите любой другой символ, если хотите заполнить его данными по умолчанию ");
            rect_par rect;
            char choice = char.Parse(Console.ReadLine());
            if (choice == 0) { 
            Console.Write("Введите длину основания");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\n Введите высоту паралипипида");
            int b = int.Parse(Console.ReadLine());
            Console.Write("\n Введите глубину паралипипида ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("\n Введите координаты куба по Ох ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("\n Введите координаты куба по Оу ");
            int y = int.Parse(Console.ReadLine());  
            rect = new rect_par(a, b, c, x, y);
            }
            else
            {
               rect = new rect_par();
            }
            Console.WriteLine("СПИСОК КОМАНД:"); 
            Console.WriteLine("Введите: 1 если хотите увидеть площадь боковых граней");
            Console.WriteLine("2 если хотите увидеть площадь передних и задних граней");
            Console.WriteLine("3 если хотите увидеть площадь оснований");
            Console.WriteLine("4 если хотите увидеть объем паралепипеда");
            Console.WriteLine("5 если хотите увидеть длины сторон");
            Console.WriteLine("6 если хотите сдвинуть паралепид по Ох");
            Console.WriteLine("7 если хотите сдвинуть паралепид по Оу");
            Console.WriteLine("8 если хотите увеличить высоту паралепипида ");
            Console.WriteLine("9 если хотите увеличить длину паралепипида ");
            Console.WriteLine("10 если хотите увеличить ширину паралепипида ");
            Console.WriteLine("0, если хотите выйти из программы");
            int req = int.Parse(Console.ReadLine());
            while (req != 0)
            {
                if (req == 1)
                {
                    Console.WriteLine($"Площадь боковых граней равна {rect.square_width()}");
                }
                else if (req == 3)
                {
                    Console.WriteLine($"Площадь  основных граней равна {rect.square_base()}");


                }
                else if (req == 2)
                {
                    Console.WriteLine($"Площадь  передней и задней грани равна {rect.square_depth()}");
                }
                else if (req == 4)
                {
                    Console.WriteLine($"Объем равен {rect.vol()}");
                }
                else if (req == 5)
                {
                    Console.WriteLine($"{rect.length()}");
                }
                else if (req == 6)
                {
                    Console.WriteLine("Введите на сколько сдвинуть паралепипед по оси Х");
                    int step_x = int.Parse((Console.ReadLine()));
                    rect.move_x(step_x);
                }
                else if (req == 7)
                {
                    Console.WriteLine("Введите на сколько сдвинуть паралепипед по оси Y");
                    int step_y = int.Parse((Console.ReadLine()));
                    rect.move_y(step_y);
                }
                else if (req == 8)
                {
                    Console.WriteLine("Введите на сколько увеличить высоту паралепипеда ");
                    int change = int.Parse((Console.ReadLine()));
                    rect.height_change(change);
                }
                else if (req == 9)
                {
                    Console.WriteLine("Введите на сколько увеличить длину паралепипеда ");
                    int change = int.Parse((Console.ReadLine()));
                    rect.depth_change(change);
                }
                else if (req == 10)
                {
                    Console.WriteLine("Введите  на сколько увеличить ширину паралепипеда ");
                    int change = int.Parse((Console.ReadLine()));
                    rect.width_change(change);
                }
                else Console.WriteLine("Неизвестная команда");
                req =   int.Parse(Console.ReadLine());


            }


        }
    }
}
