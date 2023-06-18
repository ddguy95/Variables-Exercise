namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {   // Declaring and initialize variables
            string name = "John";
            int age = 31;
            char middeInitial = 'D';
            bool isOver18 = true;
            double currentTemp = 85.5;
            decimal currentPrice = 29.99m;


            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Midde Initial: {middeInitial}");
            Console.WriteLine($"Is Over 18: {isOver18}");
            Console.WriteLine($"Current Temp: {currentTemp}");
            Console.WriteLine($"Current Price: {currentPrice}");
        }
    }
}