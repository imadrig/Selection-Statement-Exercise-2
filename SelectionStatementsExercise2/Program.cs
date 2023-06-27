namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string userInput = Console.ReadLine();


            switch (userInput)
            {
                case "Math":
                case "math":

                    Console.WriteLine($"{userInput} is fun to learn!");
                     break;

                case "Social Studies":
                case "social studies":
                    Console.WriteLine($"{userInput} was my favorite subject too!");
                    break;

                case "P.E.":
                case "p.e.":
                case "PE":
                case "pe":

                    Console.WriteLine($"{userInput} was a great subject!");
                    break;

                case "History":
                case "history":
                    Console.WriteLine($"{userInput} is important to learn!");
                    break;

                case "Science":
                case "science":
                    Console.WriteLine($"{userInput} is a blast to learn!");
                    break;

                default:
                    Console.WriteLine($"{userInput} is amazing!");
                    break;

            }
        }
    }
}