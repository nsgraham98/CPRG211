using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod1
{
    public class Person
    {
        string name;
        int id;
        double sal;
        char gender;
        bool isVaccinated;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public double Sal { get => sal; set => sal = value; }
        public char Gender { get => gender; set => gender = value; }
        public bool IsVaccinated { get => isVaccinated; set => isVaccinated = value; }

        public Person()
        {
            
        }
        public Person (string name, int id, double sal, char gender, bool isVaccinated) // formal arguments
        {
            this.name = name;
            Id = id;
            Sal = sal;
            Gender = gender;
            IsVaccinated = isVaccinated;
            
        }
    }
}
