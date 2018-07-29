using System;

namespace OOP {

    class Eagle: Animal, IFlier, IPredator {

        public void Attack() {
            Console.WriteLine("POW!");
        }

        public void Fly() {
            Console.WriteLine("whoo Hooo!");
        }
    }
}