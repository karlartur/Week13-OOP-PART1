using System;

namespace OOP_Part1
{
    class Program
    {
        class Dog
        {
            string name;
            int spots;
            double happiness;


            public Dog (string _name, int _spots) //constuctur
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The dog {name} with {spots} spots has been created.");
            }
            //getters for class properties
            public string Name
            {
                get { return name; }
            }   
            public int Spots
            {
                get { return spots; }
            }
            public double Happiness
            {
                get { return happiness; }
            }
            public void Barks()
            {
                Console.WriteLine("Woof-Woof!");
                happiness += 0.2;//happiness = happiness + 0.2
            }
            public void WagTail()
            {
                Console.WriteLine("Wiggle-wiggle");
            }
            public void ReName(string newName)
            {
                name = newName;
            }
        }



        static void Main(string[] args)
        {
            Dog myDog = new Dog("Koer", 15);
            //myDog.happiness = 10;
            //myDog.name = "Legolas";
            while(myDog.Happiness != 1)
            {
                myDog.Barks();
            }
            myDog.WagTail();
            Console.WriteLine("Renmae your dog:");
            string userInput = Console.ReadLine();
            myDog.ReName(userInput);
            Console.WriteLine($"Name: {myDog.Name}");
            Console.WriteLine($"Level of happiness: {myDog.Happiness}");
        }
    }
}
