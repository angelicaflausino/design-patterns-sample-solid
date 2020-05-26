using System.Collections.Generic;

namespace DependencyInversionApp
{
    //low-level
    public class Relationships
    {
        private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();

        public List<(Person, Relationship, Person)> Relations => relations;

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }
    }
}