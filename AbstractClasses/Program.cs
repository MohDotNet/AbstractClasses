using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            cat c = new cat();
            c.Name = "Fido";
            c.EyeColour = "green";
            c.NumberOfLegs = 4;

            

            Console.WriteLine(c.GetAnimal() + " " + c.AnimalSpeak());
            Console.Read();
        }
    }
}
