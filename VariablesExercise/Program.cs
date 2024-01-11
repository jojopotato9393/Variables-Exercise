namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // declare
            string myName;
            //initialize
            myName = "Joseph";
            int myAge = 17;
            char initial = 'J';
            bool isCodingFun = true;
            double Time = 10.21;
            decimal Compleated = 0.09m;


            Console.WriteLine($"My Name is {myName}, I am {myAge} years old.");

            Console.WriteLine($"you can call me {initial}, its {Time}AM for me. I am {Compleated} done with TrueCoders.");

            Console.WriteLine($"I think Coding is great {isCodingFun}.");

            Console.WriteLine("How long have you been with true Coders?");
           string response  = Console.ReadLine();
            Console.WriteLine($" {response} wow thats a long time.");
        }
    }
}
