namespace SGTCalculator
{
    public class DataTypes
    {
        public void Demo()
        {
            int integer; // definition,  in case we have initialized nothing, 
                         // the variable will have a default value, most numbers default value(0)
            integer = 257; // inicialization

            char ch = 'a'; // definition and inicialization

            double d = (double) integer; // wide casting - >
                                         // smaller data type converting to bigger data type (no issues)
            d = d + 0.5;

            byte b = (byte) integer;  // narrow cast -> data loss bigger data to smaller data

            Console.WriteLine($"Converted integer {integer} to byte {b}");
        }
    }
}
