using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7Q1
{
    internal class Car
    {
        private string make;
        private string model;
        private int year;
        private double currentSpeed;

        // Properties for each data member
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double CurrentSpeed
        {
            get { return currentSpeed; }
            private set { currentSpeed = value; } 
        }
        public Car() : this("Unknown", "Generic",2025, 0)
        {
        }
        public Car(string make, string model, int year) : this(make, model, year, 0)
        {
        }
        public Car(string make, string model, int year, double currentSpeed)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.currentSpeed = currentSpeed;
        }

        public Car(Car otherCar)
        {
            this.make = otherCar.make;
            this.model = otherCar.model;
            this.year = otherCar.year;
            this.currentSpeed = otherCar.currentSpeed;
        }
        public void Accelerate(double speedIncrease)
        {
            if (speedIncrease > 0)
            {
                CurrentSpeed += speedIncrease;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Current Speed: {CurrentSpeed} ");
        }
    }
}
