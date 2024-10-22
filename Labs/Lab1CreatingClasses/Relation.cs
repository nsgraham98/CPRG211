using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Relation
    {
        private string relationshipType;
        public string RelationshipType { get => relationshipType; set => relationshipType = value; }

        public enum Relationship
        {
            Brother,//0
            Sister,//1
            Father,//2
            Mother//3
        }
        public Relation(string relationshipType)
        { 
            RelationshipType = relationshipType;
        }
        
        public static void ShowRelationship(Person p1, Person p2, Relation r)
        {
            switch(r.RelationshipType)
            {
                case ("b"):
                    Console.WriteLine($"Relationship between {p1.FirstName} and {p2.FirstName} is: {Relationship.Brother}");
                    break;
                case ("s"):
                    Console.WriteLine($"Relationship between {p1.FirstName} and {p2.FirstName} is: {Relationship.Sister}");
                    break;
                case ("f"): Console.WriteLine($"Relationship between {p1.FirstName} and {p2.FirstName} is: {Relationship.Father}");
                    break;
                case ("m"):
                    Console.WriteLine($"Relationship between {p1.FirstName} and {p2.FirstName} is: {Relationship.Mother}");
                    break;
            }
        }

        






    }
}
