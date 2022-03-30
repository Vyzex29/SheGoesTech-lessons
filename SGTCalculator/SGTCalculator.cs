using Animal;
using SGTCalculator;

Cat cat = new Cat();
Console.WriteLine($"{cat.Name}, {cat.Age}");
cat.Name = "Muris";
cat.Age = -10;
Console.WriteLine($"{cat.Name}, {cat.Age}");
cat.Sleep();
cat.Ate(1);
Console.WriteLine($"{cat.Name} ate {cat.ShowAmountOfFoodConsumed()} kilos");

var cat1 = new Cat("Poli",10);
cat1.Sleep();
cat1.Ate(10);
Console.WriteLine($"{cat1.Name} ate {cat1.ShowAmountOfFoodConsumed()} kilos");

Console.WriteLine(MathExample.SumAandB(5, 3));