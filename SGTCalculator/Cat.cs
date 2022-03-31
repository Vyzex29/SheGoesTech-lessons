namespace Animal
{
    internal class Cat : Animal
    {
        public int FoodConsumed { get; set; }

        public Cat() : base("Kitty", 1)
        {
            FoodConsumed = 0;
        }

        public Cat(string name, int age, int foodConsumed) : base(name, age)
        {
            FoodConsumed = foodConsumed;
        }

        public override void Ate()
        {
            Console.WriteLine($"{Name} Chomps down the prey");
        }

        public void Ate(int foodConsumed)
        {
            FoodConsumed += foodConsumed;
        }

        public int ShowAmountOfFoodConsumed()
        {
            return FoodConsumed;
        }

        public void Meow()
        {
            Console.WriteLine($"{Name} meows");
        }

        public override void SayHello()
        {
            base.SayHello();
            Console.WriteLine("Meow");
        }
    }
}
