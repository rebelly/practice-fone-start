using System; // УБРАТЬ SWITCH

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
        public int square_width
        {
            get { return h * sh; }
        }
        public int square_base
        {
            get { return h * g; }
        }
        public int square_depth
        {
            get { return sh * g; }
        }
        public int vol
        {
            get { return h * sh * g; }
        }
        public int diag
        {
            get { return (int)Math.Round(Math.Sqrt(h * h + sh * sh + g * g), 3); }
        }
        public int per
        {
            get { return 4 * (sh + g + h); }
        }
        public int rad
        {
            get { return (int)Math.Round(Math.Sqrt(h * h + sh * sh + g * g), 3) / 2; }
        }
        public int square
        {
            get
            {
                return 2 * (sh * h + sh * g + h * g);
            }
        }
        public void move_x(int step_x)
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
        static int max(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }
        static int min(int a, int b)
        {
            if (a > b) return b;
            else return a;
        }
        public void depth_change(int change)
        {
            this.g += change;
        }
        public void union(rect_par rect2)
        {
            int x1_l = this.x;
            int y1_l = this.y + this.sh;
            int x1_r = this.x + this.g;
            int y1_r = this.y; // координаты точек одно прямоугольника
            int x2_l = rect2.x;
            int y2_l = rect2.y + rect2.sh;
            int x2_r = rect2.x + rect2.g;
            int y2_r = rect2.y; // координаты точек второго прямоугольника

            int bord_lft = rect_par.max(x1_l, x2_l);
            int bord_rght = rect_par.min(x1_r, x2_r);
            int bord_top = rect_par.max(y1_r, y2_r);
            int bord_bot = rect_par.min(y1_l, y2_l); // находим пересечение 
            int sh1 = bord_rght - bord_lft;
            int g1 = bord_bot - bord_top;
            if (sh1 > 0 & g1 > 0)
                Console.WriteLine($"Ширина пересечения равна {sh1}, глубина {g1}");
            else Console.WriteLine($"Пересечение равно нулю");
        }
        public string length
        {
            get { return $"Длина стороны a равна {h}, длина стороны b равна {sh}, длина стороны с равна {g}"; }
        }
        public int Depth
        {
            set
            {
                if (value > 0) g = value;
                else Console.WriteLine("Глубина должна быть больше 0");
            }
            get { return g; }
        }
        public int Height
        {
            set
            {
                if (value > sh + h) h = value;
                else Console.WriteLine("Высота должна быть больше чем сумма глубины и ширины");
            }
            get { return h; }
        }
        public int Width
        {
            set
            {
                if (value > g && value < h) sh = value;
                else Console.WriteLine("Ширина должна быть больше глубины, но меньше высоты");
            }
            get { return sh; }
        }
        public static rect_par cool_rect(int x, int y, int sh, int g, int h)
        {
            if (x > 0 & y > 0  )
            {
                if (y + x < sh + g+h) return new rect_par(h,sh,g, x, y ); 
            }
            Console.WriteLine("Паралепипед должен находится в первой четверти, а сумма координат долнжа быть меньше суммы ширины высоты и глубины");
            Console.WriteLine("Вызван конструктор по умолчанию");
            return new rect_par();

        }
        public bool iscube
        {
            get
            {
                return sh == g && g == h;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 0, если хотите вручную заполнить класс и введите любой другой символ, если хотите заполнить его данными по умолчанию ");
            rect_par rect;
            char choice = char.Parse(Console.ReadLine());
            if (choice == '0')
            {
                Console.Write("Введите длину основания ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("\n Введите высоту паралипипида ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("\n Введите глубину паралипипида ");
                int c = int.Parse(Console.ReadLine());
                Console.Write("\n Введите координаты куба по Ох ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("\n Введите координаты куба по Оу ");
                int y = int.Parse(Console.ReadLine());
                rect = rect_par.cool_rect(a, b, c, x, y);
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
            Console.WriteLine("11 если хотите увидеть диагональ паралепипида");
            Console.WriteLine("12 если хотите увидеть периметр паралепипида");
            Console.WriteLine("13 если хотите увидеть радиус шара, описанного вокруг паралепипида ");
            Console.WriteLine("14 если хотите увидеть площадь паралепипида");
            Console.WriteLine("15 если хотите увидеть пересечение оснований двух паралепипидов");
            Console.WriteLine("0, если хотите выйти из программы");
            int req = int.Parse(Console.ReadLine());
            while (req != 0)
            {
                if (req == 1)
                {
                    Console.WriteLine($"Площадь боковых граней равна {rect.square_width}");
                }
                else if (req == 3)
                {
                    Console.WriteLine($"Площадь  основных граней равна {rect.square_base}");


                }
                else if (req == 2)
                {
                    Console.WriteLine($"Площадь  передней и задней грани равна {rect.square_depth}");
                }
                else if (req == 4)
                {
                    Console.WriteLine($"Объем равен {rect.vol}");
                }
                else if (req == 5)
                {
                    Console.WriteLine($"{rect.length}");
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
                else if (req == 11)
                {
                    Console.WriteLine($"Длина диагонали паралепипеда: {rect.diag} ");
                }
                else if (req == 12)
                {
                    Console.WriteLine($"Полный периметр паралепипеда: {rect.per} ");
                }
                else if (req == 13)
                {
                    Console.WriteLine($"Радиус описанного вокруг паралепипеда шара:    {rect.rad} ");
                }
                else if (req == 14)
                {
                    Console.WriteLine($"Площадь паралепипида: {rect.square} ");
                }
                else if (req == 15)
                {
                    rect_par rect4 = new rect_par(0, 2, 2, 6, 1);
                    Console.WriteLine($"Площадь персекающихся оснований равна: ");
                    rect.union(rect4);
                }
                else Console.WriteLine("Неизвестная команда");
                req = int.Parse(Console.ReadLine());


            }


        }
    }
}
