using System;

namespace InterfaceSegragationApp
{
    // O princípio da segragação de interfaces determina criar interfaces com menores responsabilidades, para que outra interface possa segrega-la
    // Invés de criar uma interface com multiplas funções, deve-se criar interfaces especializadas e se necessário segregar a interface com outras
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
