using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Wages : Employee
    {
        double rate;
        double hours;

        public double Rate { get => rate; set => rate = value; }
        public double Hours { get => hours; set => hours = value; }

        public Wages() { }

        public Wages(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours) : base(id, name, address, phone, sin, dob, dept)
        {
            this.Rate = rate;
            this.Hours = hours;
        }
        public static double GetPay(Wages emp)
        {
            if (emp.Hours > 40)
            {
                double pay = (emp.Rate * 40) + (1.5*(emp.Rate * (emp.Hours - 40)));
                return pay;
            }
            else
            {
                double pay = emp.Hours * emp.Rate;
                return pay;
            }
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"Wage Employee\nId: {Id}\nName: {Name}\nAddress: {Address}\nPhone: {Phone}\nSIN: {Sin}\nDOB: {Dob}\nDepartment: {Dept}\nRate: {Rate}\nHours: {Hours}";
        }
    }
}
