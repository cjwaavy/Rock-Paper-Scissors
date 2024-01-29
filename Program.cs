using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scisors!");
            bool playing = true;
            string[] options = new String[] { "rock", "paper", "scissors" };
            while (playing)
            {
                bool roundActive = true;
                Random rand = new Random();
                while (roundActive)
                {
                    string computerChoice = options[rand.Next(3)];
                    Console.WriteLine("make your choice: rock, paper, or scissors? or exit if you want to leave");
                    string choice = Console.ReadLine().ToLower();
                    if(choice.Equals("exit"))
                    {
                        playing = false;
                        break;
                    }
                    bool choiceProcessing = true;
                        if(choice.Equals(computerChoice))
                        {
                            Console.WriteLine("its a tie!");
                        }
                }
            }
            Console.WriteLine("Game Over");
        }
    }
}
