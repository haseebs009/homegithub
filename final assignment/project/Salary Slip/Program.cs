using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

    public class SalarySlip //Parent class
    {
        protected int basic = 1500; 

        public void Display(double total) //To display the Gross salary
        {
           Console.WriteLine("Your Salary is $" + total);
        }
        public virtual void calculatesalary() //Virtual function to calculate salary
        {
            double total = 0f;
            Display(total);
        }

    }
    class Engineer : SalarySlip
    {
        private double total;

        public override void calculatesalary()
        {
            int fuel_allowance = 100;
            int medical_allowance = 500;
            total = basic + fuel_allowance + medical_allowance;

            Display(total);
        }
    }
    class Manager : SalarySlip
    {
        private double total;

        public override void calculatesalary()
        {
            int fuel_allowance = 250;
            int medical_allowance = 1000;
            total = basic + fuel_allowance + medical_allowance;

            Display(total);
        }
    }

    class Analyst : SalarySlip
    {
        private double total;

        public override void calculatesalary()
        {
            int fuel_allowance = 150;
            int medical_allowance = 800;
            total = basic + fuel_allowance + medical_allowance;

            Display(total);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your designation:Engineer/Manager/Analyst");
            string s = Console.ReadLine();

            SalarySlip salary;
            
            if (s == "Engineer")
            {
                Engineer engsalary = new Engineer();
                //engsalary.setdes(s);
                salary = engsalary;
                salary.calculatesalary();
            }

            else if (s == "Manager")
            {
                Manager Managersalary = new Manager();
                //Managersalary.setdes(s);
                salary = Managersalary;
                salary.calculatesalary();
            }

            else if (s == "Analyst")

            {
                Analyst Analystsalary = new Analyst();
               // Analystsalary.setdes(s);
                salary = Analystsalary;
                salary.calculatesalary();
            }


        }
    }



}