namespace Animal
{
    internal class Cat
    {
        public int FoodConsumed { get; set; }

        public string Name { get; set; } // prop , presing tab x2

        private int age;  // Hide away a field from others and secure it and add validation on it

        // propfull, pressign tab x2, naming convention wise fields - camelCase(starting from lowercase)
        public int Age // properties are PascalCase (Starts with UpperCase)
        {
            get { return age; }
            set { 
                if(value > 0)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }
            }
        }

        public Cat()
        {
            Name = "Kitty";
            Age = 1;
        }

        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping. zzzzZZZ");
        }

        public void Ate(int foodConsumed)
        {
            FoodConsumed += foodConsumed;
        }

        public int ShowAmountOfFoodConsumed()
        {
            return FoodConsumed;
        }
    }
}
