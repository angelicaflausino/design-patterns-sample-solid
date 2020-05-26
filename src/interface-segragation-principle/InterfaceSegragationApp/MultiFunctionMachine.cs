using System;
namespace InterfaceSegragationApp
{
    //Implementa a interface segregada.
    public class MultiFunctionMachine : IMultiFunctionDevice
    {
       private IPrinter printer;
       private IScanner scanner;

       public MultiFunctionMachine(IPrinter printer, IScanner scanner)
       {
            if(printer == null)
                throw new ArgumentNullException(paramName: nameof(printer));

            if(scanner == null)
                throw new ArgumentNullException(paramName: nameof(scanner));

                this.printer = printer;
                this.scanner = scanner;
       }

       public void Print(Document d)
       {
           printer.Print(d);
       }

    //decorator pattern
       public void Scan(Document d)
       {
           scanner.Scan(d);
       }
    }
}