using DesignPatterns.Prototype;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype1 prototype1 = new ConcretePrototype1(1);
            ConcretePrototype1 clone1 = (ConcretePrototype1)prototype1.Clone();
            Console.WriteLine($"Cloned concrete type with id {clone1.Id}");

            ConcretePrototype2 prototype2 = new ConcretePrototype2(2);
            ConcretePrototype2 clone2 = (ConcretePrototype2)prototype2.Clone();
            Console.WriteLine($"Cloned concrete type with id {0}", clone2.Id);

            Console.ReadKey();
        }
    }
}
