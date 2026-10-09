namespace DiceGame
{
    class Program
    {
        static readonly Random random = new();

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*****************************************");
            Console.WriteLine("Välkommen till spelet");
            Console.WriteLine("För att avbryta spelet tryck på tangenten x.");

            Console.WriteLine("*****************************************");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*****************************************");
            Console.WriteLine("Press Enter to throw dice!"); 
      
            

            while (true)
            {
                var input = Console.ReadLine();
                if (input != "x")
                {
                    // two dice are rolled and the sum of the two dice is calculated
                    //string number = string.Parse(input!);                   
                    // if the sum is 12, show a message that say"Grattis! du har vunnit!"
                    // in terminal should ask the player if they want to play again, if yes, the program should start over, if not, the program should end
                    int die1 = random.Next(1, 7);
                    int die2 = random.Next(1, 7);

                     Console.WriteLine($"Du kastade {die1} och {die2}. Summan är {die1+die2}. ");
                    if (die1+die2 == 12)
                    {
                        Console.WriteLine("Grattis! du har vunnit! Do you want to play again? (y/n)" );
                                 if (Console.ReadLine()! == "y")
                    {
                        continue;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }   
                    }
                    }
                else
                    {
                        Environment.Exit(0);
                    }
                    }
            }
        }
    }


                   
