using System.Collections.Generic;

namespace OpenClosedApp
{
    public interface IFilter<T>
    {
         IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}