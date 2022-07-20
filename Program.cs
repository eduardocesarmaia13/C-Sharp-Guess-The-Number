using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Adivinhe o número entre " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Chute: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " o número é menor!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " o número é maior!");
                    }
                    guesses++;
                }
                Console.WriteLine("Número: " + number);
                Console.WriteLine("VOCÊ ACERTOU!");
                Console.WriteLine("Chutes Total: " + guesses);

                Console.WriteLine("Gostaria de jogar novamente? (S/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "S")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Obrigado por jogar! =)");

            Console.ReadKey();
        }
    }
}