using System.Collections.Generic;

// O Open-Closed principle afirma que as classes devem ser abertas para extensão,
// mas devem estar fechadas para modificações

namespace OpenClosedApp
{
    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach(var p in products)
            {
                if(p.Size == size)
                    yield return p;
            }
        }

        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach(var p in products)
            {
                if(p.Color == color)
                    yield return p;
            }
        }
    }
}