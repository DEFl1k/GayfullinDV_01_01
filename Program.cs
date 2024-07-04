using System;

namespace GayfullinDV_01_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Potomok product = new Potomok();
            Console.WriteLine("Введите название");
            product.Name = Console.ReadLine();
            Console.WriteLine("Введите кол-во белка");
            product.Belok = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во жиров");
            product.Zhiri = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во углеводов");
            product.Uglevods = double.Parse(Console.ReadLine());

            Console.WriteLine(product.Info());

            Console.ReadKey();
        }

        public class Pitanie
        {
            public string Name { get; set; }
            public double Belok { get; set; }
            public double Uglevods { get; set; }

            public double Q()
            {
                return Uglevods * 4 + Belok * 4;
            }

            public virtual string Info()
            {
                return $"Название: {Name}, Кол-во белка: {Belok}г, Кол-во углеводов: {Uglevods}г, Q: {Q()}";
            }
        }

        public class Potomok : Pitanie
        {
            public double Zhiri { get; set; }

            public double Qp()
            {
                if (Zhiri >= 0 && Zhiri <= 10)
                {
                    return Q() * 1.2 + Zhiri * 9;
                }

                else if (Zhiri > 10)
                {
                    return Q() * 1.5 + Zhiri * 10;
                }
                return 0;
            }

            public override string Info()
            {
                return  $"Название: {Name}, Кол-во белка: {Belok}г, Кол-во углеводов: {Uglevods}г, Q: {Q()}, Кол-во жиров: {Zhiri}г, Qp: {Qp()}";
            }
        }
    }
}
