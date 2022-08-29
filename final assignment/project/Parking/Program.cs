using System;

namespace MyApp
{

    
    public class Calculate_fare //Parent Class 
    {
        private string id;
        protected double hours;

        public void sethours_id(double h, string str)
        {
            hours = h;
            id = str;
        }
        protected string getid()
        {
            return id;
        }


        public double gethours()
        {
            return hours;
        }

        public void Display(double total) // To display the parking fare
        {
            Console.WriteLine("Your vehicle id is" +getid());
            Console.WriteLine("The garage charges are $" + total);
        }
        public virtual void calculatefare() //virtual function to calculate fare
        {
            double total = 0f;
            Display(total);

        }

    }
    class Bike : Calculate_fare //child function to calculate fare for bike
    {
        private double total;

        public override void calculatefare()
        {

            total = 2.00f;
            if (hours > 3 && hours < 24)
            {

                total = (float)(total + (hours - 3) * 0.5);
                if (total >= 10)
                {
                    total = 10;
                }
            }
            else if (hours >= 24)
            {
                total = 10;
            }

            Display(total);
        }
    }
    class Cars : Calculate_fare //child function to calculate fare for car
    {

        private double total;
        public override void calculatefare()
        {
            total = 4.00f;
            if (hours > 3 && hours < 24)
            {
                total = (float)(total + (hours - 3) * 1);

                if (total >= 20)
                {
                    total = 20;
                }
            }
            else if (hours >= 24)
            {
                total = 20;
            }

            Display(total);
        }

    }
    class Bus : Calculate_fare  //child function to calculate fare for bus
    {
        private double total;
        public override void calculatefare()
        {
            total = 6.00f;
            if (hours > 3 && hours < 24)
            {
                total = (float)(total + (hours - 3) * 1.5);

                if (total >= 30)
                {
                    total = 30;
                }
            }
            else if (hours >= 24)
            {
                total = 30;
            }
            Display(total);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the vehicle type:Bike/Car/Bus");
            string s = Console.ReadLine();

            Console.WriteLine("Enter the id");
            string id = Console.ReadLine();
            Console.WriteLine("Enter number of hours");
            double hr = Convert.ToDouble(Console.ReadLine());

            Calculate_fare bas; // Object declaration

            if (s == "Bike")
            {
                bas = new Bike();
                bas.sethours_id(hr, id);
                bas.calculatefare();
            }
            else if (s == "Car")

            {
                bas = new Cars();
                bas.sethours_id(hr, id);
                bas.calculatefare();
            }

            else if (s == "Bus")
            {
                bas = new Bus();
                bas.sethours_id(hr, id);
                bas.calculatefare();

            }
        }
    }



}