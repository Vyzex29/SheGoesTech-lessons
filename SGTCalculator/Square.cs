using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGTCalculator
{
    internal class Square : Shape
    {
        public int SideLenght { get; set; }

        public override void CalculateArea()
        {
            Console.WriteLine($"Square area is {SideLenght * SideLenght}");
        }
    }
}
