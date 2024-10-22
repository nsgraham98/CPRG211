using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab1.Relation;

namespace Lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person p2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person p3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person p4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            Relation sister = new Relation("s");
            Relation brother = new Relation("b");

            Person.DisplayPersonInfo(p2);
            Console.WriteLine(p3.ToString());
            Person.ChangeFavoriteColor(p1, "White");
            Person.DisplayPersonInfo(p1);
            Person.GetAgeInTenYears(p4);

            Relation.ShowRelationship(p2, p4, sister);
            Relation.ShowRelationship(p1, p3, brother);

            //list of person objs
            List<Person> people = new List<Person>();
            people.Add(p1); people.Add(p2); people.Add(p3); people.Add(p4);

            //average age
            double average = 0;
            foreach (Person person in people)
            { average += person.Age; }
            average = average / people.Count;
            Console.WriteLine($"Average age is: {average} \n");

            //lowest age
            string youngest = "";
            int age1 = p1.Age;
            foreach (Person person in people)
            {
                if (person.Age < age1)
                {
                    youngest = person.FirstName;
                    age1 = person.Age;
                }
            }
            Console.WriteLine($"The youngest person is: {youngest}\n");

            //oldest age
            string oldest = "";
            int age2 = p1.Age;
            foreach (Person person in people)
            {
                if (person.Age > age2)
                {
                    oldest = person.FirstName;
                    age2 = person.Age;
                }
            }
            Console.WriteLine($"The oldest person is: {oldest}\n");

            //Name starts with 'M'
            foreach (Person person in people)
            {
                string firstInitial = person.FirstName.Substring(0, 1);
                if (firstInitial == "M")
                {
                    Console.WriteLine(person.ToString());
                }
            }

            //person who like blue
            foreach (Person person in people)
            {
                if (person.FavoriteColor == "Blue")
                {
                    Console.WriteLine(person.ToString());
                }
            }

            Console.ReadLine();
        }
    }
}
