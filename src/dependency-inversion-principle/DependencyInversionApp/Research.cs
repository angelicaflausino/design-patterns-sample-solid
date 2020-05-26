using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
namespace DependencyInversionApp
{
    /*public class Research
    {
        public Research(Relationships relationships)
        {
            var relations = relationships.Relations;

            foreach(var r in relations.Where(x => x.Item1.Name == "John" && x.Item2 == Relationship.Parent ))
            {
                Console.WriteLine($"John has a child called {r.Item3.Name}");
            }
        }
    }*/

    public class Research : IRelationShipBrowser
    {
        public List<(Person, Relationship, Person)> Relations = new List<(Person, Relationship, Person)>();

        public Research(Relationships relationships)
        {
            Relations = relationships.Relations;
        }

        public Research(IRelationShipBrowser browser)
        {
            foreach(var p in browser.FindAllChildrenOf("John"))
            Console.WriteLine($"John has a child called {p.Name}");
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return Relations.Where(x => x.Item1.Name == name && x.Item2 == Relationship.Parent).Select(x => x.Item3);
        }
    }
}