using System;

namespace OOPCAT
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hunger;


            public Cat(string _name, string _color) //constuctur
            {
                name = _name;
                color = _color;
                hunger = 0;
                
            }
            //getters for class properties
            public string Name
            {
                get { return name; }
            }
            public string Color
            {
                get { return color; }
            }
            public double Hunger
            {
                get { return hunger; }
            }
            public void Sleep()
            {
                Console.WriteLine("z-z-z-z-z-z-z-z-z-z-z-z-z");
                hunger += 0.2;//hungry = hungry + 0.2
            }
            public void Meow()
            {
                Console.WriteLine("Meow-meow");
            }
            
            public void ReName(string newName)
            {
                name = newName;
            }
        }
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Marco", "white");
            
            while (myCat.Hunger != 1)
            {
                myCat.Sleep();
            }
            myCat.Meow();
            
        }
    }
}
