using System;

// O Princípio de Substituição de Liskov basicamente diz que você sempre deve ser capaz 
// de fazer o upcast para um tipo base e a operação deve ser genuína (garantida)

namespace LiskovSubstitutionApp
{
    class Program
    {
        static public int Area(Rectangle r) => r.Width * r.Height;
        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(2,3);
            Console.WriteLine($"{rc} has area {Area(rc)}");

            Square sq = new Square();
            sq.Width = 4;
            Console.WriteLine($"{sq} has area {Area(sq)}");

        }
    }
}
