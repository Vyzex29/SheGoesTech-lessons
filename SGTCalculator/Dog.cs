namespace SGTCalculator
{
    public class Dog
    {
        public Dog()
        {
            Name = "default";
            Age = 1;
            Height = 10;
            Breed = "not defined";
            Color = "Black";
        }

        public Dog(string name, int age, float Height,
            string Lifespan, string Breed, int weight, string Color,
            bool HadRabbiesVaccine, char Gender)
        {
            Name = name;
            Age = age;
            this.Height = Height;
            this.Lifespan = Lifespan;
            this.Breed = Breed;
            Weight = weight;
            this.Color = Color;
            this.HadRabbiesVaccine = HadRabbiesVaccine;
            this.Gender = Gender;
        }

        private string Name { get; set; }

        private int Age { get; set; }

        private float Height { get; set; }

        private string Lifespan { get; set; }

        private string Breed { get; set; }

        private int Weight { get; set; }

        private string Color { get; set; }

        private bool HadRabbiesVaccine { get; set; }

        private char Gender { get; set; }


        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Name = name;
            }
            else
            {
                Console.WriteLine("Name is not supposed to be empty");
            }
        }

        public void Eat()
        {
            Console.WriteLine($"{Name}, is chewing happily om-nom-nom");
        }
    }
}
