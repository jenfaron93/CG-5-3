using System;

namespace DiceGame
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Who can get to 20 first? You or the computer?");
			Console.WriteLine("Each time you roll the dice, you will get back the total of the two dice.");
			Console.WriteLine("You will continue to roll until you reach 20.");
			bool playAgain = true;

			while (playAgain) //while play again is true, the player will play the whole game again
			{
				int userTotal = 0; //sets the user's total
				int computerTotal = 0; //sets the computer's total
				bool rollAgain = true; //sets roll again to true

				while (rollAgain) //while the user or computer is under 20, roll again
				{
					userTotal += Roll(); //gets back the sum of two dice and adds it to user total
					Console.WriteLine($"You got {userTotal}");

					if (userTotal < 20 && computerTotal < 20) //if either the compuer or user is less than 20, then roll again
					{
						rollAgain = true;
					}
					else //if one is over 20, then stop rolling
						rollAgain = false;

					computerTotal += Roll(); //gets back the sum of two dice and adds it to the computer's total
					Console.WriteLine($"The computer got {computerTotal}");

					if (userTotal < 20 && computerTotal < 20) //if either the compuer or user is less than 20, then roll again
					{
						rollAgain = true;
					}
					else //if one is over 20, then stop rolling
						rollAgain = false;
				}

				if (userTotal >= 20) //if the user is over 20, they won
					Console.WriteLine("You won!");
				else // else the computer won
					Console.WriteLine("You lose!");


				Console.WriteLine("Do you want to play again?");
				string response = Console.ReadLine();
				if (response == "yes")
				{
					playAgain = true;
				}
				else
					playAgain = false;

			}
		}
            

		private static int Roll(){
				Random randomNum = new Random();
				int dice1 = randomNum.Next(1, 7);
				int dice2 = randomNum.Next(1, 7);
			     int sum = dice1 + dice2;
				return sum;
		}
        
    }
}
