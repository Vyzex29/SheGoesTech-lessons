using Animal;
using SGTCalculator;

var cat = new Cat("Poli",10, 0);
/*cat.Sleep();
cat.Ate();
cat.Meow();
cat.SayHello();
*/
Bird bird = new Bird("Pigeon", 1);
/*
bird.Sleep();
bird.Ate();
bird.Fly();
bird.SayHello();
*/
List<Animal.Animal> zoo = new List<Animal.Animal>();
zoo.Add(bird);
zoo.Add(cat);

foreach (Animal.Animal animal in zoo)
{
    animal.Ate();
    animal.SayHello();
    animal.Sleep();
}

int g = 6;

List<Shape> shapes = new List<Shape>();
shapes.Add(new Circle { Radius = 5 });
shapes.Add(new Square { SideLenght = 5 });

foreach (var shape in shapes)
{
    shape.CalculateArea();
}