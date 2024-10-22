/*Object class is the parent of all C# classes*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod1
{
    public class Animal // Template class declaration
    {
        //data fields/instance variables/attributes
        //string name;
        int age;
        string species;

        //right click data fields -> Quick action and refactoring -> Encapsulate fields
        //Properties access / modify --- getter /setter  ---- accessor/mutator  ---- retrieve/update
        //public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Species { get => species; set => species = value; }


        //prop + tab
        //public string Name { get; set; }


        //propfull+tab
        private string name; // private datafield

        public string Name // public property
        {
            get 
            { 
                return name; 
            }
            set 
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Name cannot be null");
                }
            }
        }

        public void Eat() //user defined method  -- opeartion/functionality
        {
            Console.WriteLine("Eating.....");
        }

        public override string ToString() // return the string representation of an object
        {
            //return base.ToString();
            return $"{Name} is a {Species} who is {Age} years old";
        }
    }
}
