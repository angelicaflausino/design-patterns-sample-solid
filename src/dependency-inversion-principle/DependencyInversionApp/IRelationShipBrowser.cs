using System.Collections.Generic;

namespace DependencyInversionApp
{
    public interface IRelationShipBrowser
    {
         IEnumerable<Person> FindAllChildrenOf(string name);
    }
}