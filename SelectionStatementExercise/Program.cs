namespace SelectionStatementExercise
{
    public class Program
    {
        //Exercise 1

        static void Main(string[] args)
        {
            var r = 11;

            var favNumber = r;

            Console.WriteLine("Try to guess my favorite number");

            var userInput = int.Parse(Console.ReadLine());


            // If user input is less than print Too Low

            if (userInput < favNumber)

            {
                Console.WriteLine("Too Low");


            }

            // If user input is greater than print Too High

            else if (userInput > favNumber)

            {
                Console.WriteLine("Too High");

            }

            // If user input is neither print Nevermind

            else 

            {
                Console.WriteLine("Nevermind");


            }





        }
    }
}
