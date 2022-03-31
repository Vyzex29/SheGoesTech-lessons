using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age)
        {
        }

        public void Fly()
        {
            IsMammal = true; // because IsMammal is protected, we can only access it from the child classes
            Console.WriteLine($"{Name} flies");
        }

        public override void SayHello()
        {
            Console.WriteLine("Tweet tweet");
        }
    }
}
