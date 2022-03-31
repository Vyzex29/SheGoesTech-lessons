namespace Animal
{
    internal class Animal
    {
        public string Name { get; set; } // prop , presing tab x2

        public int Age { get; set; }

        protected bool IsMammal = true; // WILL BE INHERITED ONLY TO THE CHILD CLASSES

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping. zzzzZZZ");
        }

        public virtual void Ate()
        {
            Console.WriteLine($"{Name}: om nom nom");
        }

        public virtual void SayHello()
        {
            Console.WriteLine("Animal greets you");
        }

    }
}
