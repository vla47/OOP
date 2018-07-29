using System;

namespace OOP {
    
    abstract class Animal {
        protected int age;

        public int Age 
        {
            get { return age; }
            set { age = value; }
        }

        public void Sleep() {
            Console.WriteLine("Zzzzzzzzz");
        }

        public void Eat() {
            Console.WriteLine("Num num num");
        }

    }
}