using System.Diagnostics;
using System;

//O Conceito de Single Responsability especifica que qualquer classe em particular deve ter apenas um 
// único motivo para mudar

namespace SingleResponsabilityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //classe responsavel por adicionar as entradas do diário
            var j = new Journal();
            j.AddEntry("I cried today");
            j.AddEntry("I ate a bug");
            Console.WriteLine(j);

            //classe responsavel por persistir o diário em arquivo de texto
            var p = new Persistence();
            var filename = @"c:\temp\journal.txt";
            var command = @"cmd exe " + filename;
            p.SaveToFile(j, filename, true);
            Process.Start(@"cmd.exe ", command);
        }
    }
}
