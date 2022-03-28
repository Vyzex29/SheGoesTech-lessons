namespace SGTCalculator 
{

    public class SGTCalculator
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Bobby",3,10,"12-16", "American Staffordshire Terrier", 25,"Brown", true, 'M');

            dog1.SetName("Bobby");
            Dog dog2 = new Dog("Snowflake", 5, 20, "10-12", "Caucasian Shepherd Dog", 120, "Brown",true, 'F');

            dog2.SetName("Snowflake");

            Console.WriteLine($"{dog1.GetName()}, {dog2.GetName()}");

            dog1.Eat();

            dog2.Eat();
            
            Dog noArgumentConsturctorDog = new Dog();

            Console.WriteLine($"{noArgumentConsturctorDog.GetName()}");
            noArgumentConsturctorDog.Eat();

        }
    }
}


