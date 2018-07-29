using System;

namespace OOP {
    class Lion: Animal, IPredator {
        
        public void Attack() {
            Console.WriteLine("POW!");
        }

         public void Roar() {
            Console.WriteLine("Rahhhh!");
        }
    }
}