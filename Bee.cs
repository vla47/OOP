using System;

namespace OOP {
    
    class Bee: Animal, IFlier {

       public void Fly() {
            Console.WriteLine("whoo Hooo!");
        }
    }
}