namespace CircleObjectsJT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;
            int count = 0;

            bool start = true;
            while(start)
            {
                
                try //exception handling, accepts only numbers / decimals.
                {
                    Console.WriteLine("Enter the radius of a circle"); //prompt user to enter the number of sides for a pair of dice
                    radius = double.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Your input was invalid, please enter a number");
                    Console.WriteLine();
                    continue;
                }
                Console.WriteLine();

                if (radius <= 0)
                {
                    Console.WriteLine("Invalid input, you entered a number less than 0. Please enter a positive number or decimal.");
                    Console.WriteLine();
                }

                Circle c = new Circle(radius);

                //calc radius (round to 2 decimals)
                Console.WriteLine($"The circumference is {c.CalculateCircumference(radius)}");

                Console.WriteLine();

                //calc area (round to 2 decimals)
                Console.WriteLine($"The circumference is {c.CalculateArea(radius)}");
                
                Console.WriteLine();

                Console.WriteLine("------------------------------------------------");

                count++;
                start = restart(count);
            }
        }

        public static bool restart(int count)
        {
            Console.WriteLine("Do you want to create another circle? Y/N");
            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                Console.WriteLine($"Goodbye. You created {count} circles");
                return  false;
            }
            else //if user input is not "y" or "n"
            {
                Console.WriteLine("I'm sorry, I'm afraid I can't do that, invalid input. Please try again.");
                return restart(count);
            }
        }
    }
}