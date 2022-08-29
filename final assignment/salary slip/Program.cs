using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

    public class salarySlip
    {
        private string designation;
       
        public void setdes(string str)
        {
            designation = str;
        }
        protected void getdes()
        {
            Console.WriteLine("Your designation is " + designation);
        }
       protected int basic = 1500;

        public void Display(double total)
        {
            getdes();
            Console.WriteLine("Your Salary is $" + total);
        }
        public virtual void calculatesalary()
        {
            double total = 0f;
            Display(total);
        }

    }
    class engineer : salarySlip
    {
        private double total;

        public override void calculatesalary()
        {
            int fuel_allowance = 100;
            int medical_allowance = 500;
            total = basic+fuel_allowance+medical_allowance;
            
            Display(total);
        }
    }
    class manager : salarySlip
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

    class analyst : salarySlip
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
            Console.WriteLine("Enter your designation:engineer/manager/analyst");
            string s = Console.ReadLine();

         salarySlip salary;



            if (s == "engineer")
            {
                engineer engsalary = new engineer();
                engsalary.setdes (s);
                salary = engsalary;
               salary.calculatesalary();
            }

           else if (s == "manager")
            {
                manager managersalary = new manager();
                managersalary.setdes(s);
                salary = managersalary;
                salary.calculatesalary();
            }

            else if (s == "analyst")

            {
                analyst analystsalary = new analyst();
                analystsalary.setdes(s);
                salary = analystsalary;
                salary.calculatesalary();
            }

            
        }
    }



}