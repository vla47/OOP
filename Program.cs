using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dolphin = new Dolphin();
            dolphin.Age = 6;
            dolphin.Eat();
            dolphin.Sleep();
            ((Dolphin)dolphin).Swim();
            Console.WriteLine(dolphin.Age + " years old");
            Console.WriteLine(dolphin.GetType());

            Animal lion = new Lion();
            lion.Age = 3;
            lion.Eat();
            lion.Sleep();
            ((Lion)lion).Attack();
            ((Lion)lion).Roar();
            Console.WriteLine(lion.Age+ " years old");

            Animal eagle = new Eagle();
            eagle.Age = 4;
            eagle.Eat();
            eagle.Sleep();
            ((Eagle)eagle).Attack();
            ((Eagle)eagle).Fly();
            Console.WriteLine(eagle.Age+ " years old");

            Animal bee = new Bee();
            bee.Age = 2;
            ((Bee)bee).Fly();
            bee.Eat();
            bee.Sleep();
            Console.WriteLine(bee.Age+ " years old");
        }
    }
}
