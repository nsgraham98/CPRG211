using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            Console.WriteLine($"The average pay for all employees is: {AveragePay()}");
            Console.WriteLine($"The Wages employee with the highest pay is: {CalcHighestPay().Name}");
            Console.WriteLine($"The Salaried employee with the lowest pay is: {CalcLowestPay().Name}");
            CalcDistribution();
            Console.ReadLine();
        }

        
        public static List<Employee> LoadEmployees()
        {
            string path = "..\\..\\res\\employees.txt";
            List<Employee> employeeList = new List<Employee>();
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] fields = line.Split(':');
                switch (fields[0].Substring(0, 1))
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                        Salaried salaried = new Salaried(fields[0], fields[1], fields[2], fields[3], Convert.ToInt64(fields[4]), fields[5], fields[6], Convert.ToDouble(fields[7]));
                        employeeList.Add(salaried);
                        break;
                    case "5":
                    case "6":
                    case "7":
                        Wages wages = new Wages(fields[0], fields[1], fields[2], fields[3], Convert.ToInt64(fields[4]), fields[5], fields[6], Convert.ToDouble(fields[7]), Convert.ToDouble(fields[8]));
                        employeeList.Add(wages);
                        break;
                    case "8":
                    case "9":                       
                        PartTime partTime = new PartTime(fields[0], fields[1], fields[2], fields[3], Convert.ToInt64(fields[4]), fields[5], fields[6], Convert.ToDouble(fields[7]), Convert.ToDouble(fields[8]));
                        employeeList.Add(partTime);
                        break;
                }
            }
            return employeeList;
        }

        public static double AveragePay()
        {
            List<Employee> employeeList = new List<Employee>(LoadEmployees());
            double totalPay = 0;
            int count = 0;
            foreach (Employee emp in employeeList)
            {
                if(emp is Salaried)
                {
                    totalPay += Salaried.GetPay((Salaried)emp);
                    count++;
                }
                if(emp is Wages)
                {
                    totalPay += Wages.GetPay((Wages)emp);
                    count++;
                }
                if(emp is PartTime)
                {
                    totalPay += PartTime.GetPay((PartTime)emp);
                    count++;
                }                    
            }
            double finalAverage = totalPay / count;
            return finalAverage;
        }

        public static Wages CalcHighestPay()
        {
            List<Employee> employeeList = new List<Employee>(LoadEmployees());
            Wages highestWageObj = null;
            double highestPay = 0;
            foreach (Employee emp in employeeList)
            {
                if (emp is Wages)
                {
                    if ((Wages.GetPay((Wages)emp) > highestPay))
                    {
                        highestPay = Wages.GetPay((Wages)emp);
                        highestWageObj = ((Wages)emp);
                    }
                }
            }
            return highestWageObj;
        }

        public static Salaried CalcLowestPay()
        {
            List<Employee> employeeList = new List<Employee>(LoadEmployees());
            Salaried lowestSalObj = null;
            double lowestPay = double.MaxValue;
            foreach (Employee emp in employeeList)
            {

                if (emp is Salaried)
                {
                    if (Salaried.GetPay((Salaried)emp) < lowestPay)
                    {
                        lowestPay = Salaried.GetPay((Salaried)emp);
                        lowestSalObj = ((Salaried)emp);
                    }
                }
            }
            return lowestSalObj;
        }

        public static void CalcDistribution()
        {
            List<Employee> employeeList = new List<Employee>(LoadEmployees());
            double salCount = 0;
            double wageCount = 0;
            double ptCount = 0;
            double totalCount = 0;
            foreach (Employee emp in employeeList)
            {
                if (emp is Salaried)
                {
                    salCount++;
                    totalCount++;
                }
                if (emp is Wages)
                {
                    wageCount++;
                    totalCount++;
                }
                if (emp is PartTime)
                {
                    ptCount++;
                    totalCount++;
                }
            }
            Console.WriteLine($"Percentage of Salaried employees is {(salCount / totalCount) * 100}%");
            Console.WriteLine($"Percentage of Wages employees is {(wageCount / totalCount) * 100}%");
            Console.WriteLine($"Percentage of Part Time employees is {(ptCount / totalCount) * 100}%");
        }
    }
}
