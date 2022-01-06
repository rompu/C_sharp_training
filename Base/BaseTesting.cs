using System;

namespace Base
{
    class BaseTesting
    {
        static void Main(string[] args)
        {

            var dog = new Dog();

            dog.Name = "Lucky";
            dog.Breed = "Golden retriver";
            dog.Weight = 30;
            dog.GetInfo();

            var circle = new Circle(5);
            Console.WriteLine("Circle area {0}", circle.Area());
        }
    }
    class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public string Location { get; set; }
        public Animal()
        {
            Location = "Finland";
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Name: " +Name);
            Console.WriteLine("Weight: "+Weight);
            Console.WriteLine("Location: "+Location);
        }

    }

    class Dog : Animal
    {
        public string Breed { get; set; }
        public string Bark()
        {
            return "wof wof";
        }

        public override void GetInfo() //why override? works also if base class method is non-virtual and current is non-override
        {
            base.GetInfo(); //here the getInfo method from the base class is called
            Console.WriteLine("Breed: " +Breed);
        }
    }
    public class Shape
    {
        public const double PI = Math.PI;
        protected double x, y;

        public Shape()
        {
        }

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Area()
        {
            return x * y;
        }
    }

    public class Circle : Shape
    {
        public Circle(double r) : base(r, 0) //calls the base class constructor
        {
        }

        public double Area()
        {
            return PI * x * x;
        }
    }
}
