namespace InterfaceSegragationApp
{
    //WRONG WAY: Essa classe não irá utilizar os métodos Scan e Fax somente o Print
    public class OldFashionedPrinter : IMachine
    {
        public void Fax(Document d)
        {
            throw new System.NotImplementedException();
        }

        public void Print(Document d)
        {
            throw new System.NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new System.NotImplementedException();
        }
    }
}