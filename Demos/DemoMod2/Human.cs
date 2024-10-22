using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod2
{
    public class Human
    {
        int id;
        string name;
        int age;
        int sin;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Sin { get => sin; set => sin = value; }
        
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                { 
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }

        public Human() { }

        public Human(int id, string name, int age, int sin)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.sin = sin;
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"Person info: \nID: {Id}\nName: {Name}\nAge: {Age}\nSIN: {Sin}\n";
        }
    }
}
