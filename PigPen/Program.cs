using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigPen {
	class Program {

		Random rnd = new Random();							//making a new instance class of random with variable 
		List<Player> playerscores = new List<Player>();     //placed here due to scope

		int RollDie() {
			return rnd.Next(1, 7);
		}

		int PlayerCount() {
			int NumbOfPlayers = 0;
			bool isInt = false;
			while (isInt == false) {
				Console.Write("How many players are there? ");
				isInt = Int32.TryParse(Console.ReadLine(), out NumbOfPlayers);
				if (isInt == false) {
					Console.WriteLine("That is not a number...try again.");
				}
			}
			for (int idx = 1; idx <= NumbOfPlayers; idx++) {
				Player player = new Player(idx,0);
				playerscores.Add(player);
			}
			return NumbOfPlayers;
		}

		//round 1 of 5
		void Round1(int NumbofPlayers) {

			Console.WriteLine("-----------------");
			Console.WriteLine("-----Round 1-----");
			Console.WriteLine("-----------------");

			for (int idx = 1; idx <= NumbofPlayers; idx++) {
				Console.WriteLine("");
				Console.WriteLine($"-----Player {idx} Turn-----");
				int Score = 0;
				bool EndTurn = false;
				while (!EndTurn) {
					int die = RollDie();
					if (die != 1) {
						Score += die;
						Console.WriteLine($"You rolled a -{die}- and your current score this round is -{Score}-");
						Console.Write("Would you like to roll again? (Y/N) ");						
						string answer = Console.ReadLine();
						answer = answer.ToUpper();
						bool ValidResponse = false;
						while (ValidResponse != true) {
							if (answer == "Y") {
								EndTurn = false;
								ValidResponse = true; 
							} else if (answer == "N") {
								EndTurn = true;
								ValidResponse = true;
							} else {
								Console.WriteLine("Select only Y or N");
								answer = Console.ReadLine().ToUpper();
							}
						}
						EndTurn = answer.StartsWith("N"); //start with function which determines if answer variable starts with a Y
					} else {
						EndTurn = true;
						Score = 0;
						Console.WriteLine("Sorry you rolled a 1 and your turn is over");
					}
				}

				//Tally score for each player 
				playerscores[idx - 1].PlayerScore = Score;

				//output player score for round
				Console.WriteLine($"Player {idx} Score after Round 1: {playerscores[idx-1].PlayerScore}");
			}
		}

		//round 2 of 5
		void Round2(int NumbofPlayers) {

			Console.WriteLine("");
			Console.WriteLine("-----------------");
			Console.WriteLine("-----Round 2-----");
			Console.WriteLine("-----------------");

			//for loop that runs once for each player
			for (int idx = 1; idx <= NumbofPlayers; idx++) {
				Console.WriteLine("");
				Console.WriteLine($"-----Player {idx} Turn-----");
				int Score = 0;
				bool EndTurn = false;
				while (!EndTurn) {
					int die = RollDie();
					if (die != 1) {
						Score += die;
						Console.WriteLine($"You rolled a -{die}- and your current score this round is -{Score}-");
						Console.Write("Would you like to roll again? ");
						string answer = Console.ReadLine();
						answer = answer.ToUpper(); //converts the answer to upper case
						EndTurn = answer.StartsWith("N"); //start with function which determines if answer variable starts with a Y
					} else {
						EndTurn = true;
						Score = 0;
						Console.WriteLine("Sorry you rolled a 1 and your turn is over");
					}
				}

				//NEED TO TALLY UP THE SCORE HERE FOR EACH PLAYER ITERATION FOR ROUND 1 via ".add"//
				playerscores[idx - 1].PlayerScore += Score;

				//output player score for round
				Console.WriteLine($"Player {idx} Score after Round 2: {playerscores[idx - 1].PlayerScore}");
			}
		}

		//Round 3 of 5
		void Round3(int NumbofPlayers) {

			Console.WriteLine("");
			Console.WriteLine("-----------------");
			Console.WriteLine("-----Round 3-----");
			Console.WriteLine("-----------------");

			//for loop that runs once for each player
			for (int idx = 1; idx <= NumbofPlayers; idx++) {
				Console.WriteLine("");
				Console.WriteLine($"-----Player {idx} Turn-----");
				int Score = 0;
				bool EndTurn = false;
				while (!EndTurn) {
					int die = RollDie();
					if (die != 1) {
						Score += die;
						Console.WriteLine($"You rolled a -{die}- and your current score this round is -{Score}-");
						Console.Write("Would you like to roll again? ");
						string answer = Console.ReadLine();
						answer = answer.ToUpper(); //converts the answer to upper case
						EndTurn = answer.StartsWith("N"); //start with function which determines if answer variable starts with a Y
					} else {
						EndTurn = true;
						Score = 0;
						Console.WriteLine("Sorry you rolled a 1 and your turn is over");
					}
				}

				//NEED TO TALLY UP THE SCORE HERE FOR EACH PLAYER ITERATION FOR ROUND 1 via ".add"//
				playerscores[idx - 1].PlayerScore += Score;

				//output player score for round
				Console.WriteLine($"Player {idx} Score after Round 3: {playerscores[idx - 1].PlayerScore}");
			}
		}

		//Round 4 of 5
		void Round4(int NumbofPlayers) {

			Console.WriteLine("");
			Console.WriteLine("-----------------");
			Console.WriteLine("-----Round 4-----");
			Console.WriteLine("-----------------");

			//for loop that runs once for each player
			for (int idx = 1; idx <= NumbofPlayers; idx++) {
				Console.WriteLine("");
				Console.WriteLine($"-----Player {idx} Turn-----");
				int Score = 0;
				bool EndTurn = false;
				while (!EndTurn) {
					int die = RollDie();
					if (die != 1) {
						Score += die;
						Console.WriteLine($"You rolled a -{die}- and your current score this round is -{Score}-");
						Console.Write("Would you like to roll again? ");
						string answer = Console.ReadLine();
						answer = answer.ToUpper(); //converts the answer to upper case
						EndTurn = answer.StartsWith("N"); //start with function which determines if answer variable starts with a Y
					} else {
						EndTurn = true;
						Score = 0;
						Console.WriteLine("Sorry you rolled a 1 and your turn is over");
					}
				}

				//NEED TO TALLY UP THE SCORE HERE FOR EACH PLAYER ITERATION FOR ROUND 1 via ".add"//
				playerscores[idx - 1].PlayerScore += Score;

				//output player score for round
				Console.WriteLine($"Player {idx} Score after Round 4: {playerscores[idx - 1].PlayerScore}");
			}
		}

		//Round 5 of 5
		void Round5(int NumbofPlayers) {

			Console.WriteLine("");
			Console.WriteLine("-----------------");
			Console.WriteLine("-----Round 5-----");
			Console.WriteLine("-----------------");

			//for loop that runs once for each player
			for (int idx = 1; idx <= NumbofPlayers; idx++) {
				Console.WriteLine("");
				Console.WriteLine($"-----Player {idx} Turn-----");
				int Score = 0;
				bool EndTurn = false;
				while (!EndTurn) {
					int die = RollDie();
					if (die != 1) {
						Score += die;
						Console.WriteLine($"You rolled a -{die}- and your current score this round is -{Score}-");
						Console.Write("Would you like to roll again? ");
						string answer = Console.ReadLine();
						answer = answer.ToUpper(); //converts the answer to upper case
						EndTurn = answer.StartsWith("N"); //start with function which determines if answer variable starts with a Y
					} else {
						EndTurn = true;
						Score = 0;
						Console.WriteLine("Sorry you rolled a 1 and your turn is over");
					}
				}

				//NEED TO TALLY UP THE SCORE HERE FOR EACH PLAYER ITERATION FOR ROUND 1 via ".add"//
				playerscores[idx - 1].PlayerScore += Score;

				//output player score for round
				Console.WriteLine($"Player {idx} Score after Round 5: {playerscores[idx - 1].PlayerScore}");
			}
		}


		void Run() {
			bool quit = false;
			while (!quit) {
			int NumbOfPlayers = PlayerCount();
				//ADD CODE HERE TO INSTANTIATE PLAYER VIA PLAYER CLASS WITH PROPERTY OF SCORE AND PLAYER NUMBER (BOTH INTS)
				Round1(NumbOfPlayers);
				Round2(NumbOfPlayers);
				Round3(NumbOfPlayers);
				Round4(NumbOfPlayers);
				Round5(NumbOfPlayers);

				Console.WriteLine("------------------------------");

				//PRINT FINAL SCORE & CONGRATULATE THE WINNER
				for (int idx = 1; idx <= NumbOfPlayers; idx++) {
					Console.WriteLine($"Player {idx} Final Score: {playerscores[idx - 1].PlayerScore}");
				}	
				
				int winningscore = playerscores.Max(p => p.PlayerScore);
				foreach(Player player in playerscores) {
					if (player.PlayerScore == winningscore) {
						Console.WriteLine($"Winner is Player {player.PlayerNumber} with a score of {player.PlayerScore}");
					}
				}

				//asking user if they want to play again
				Console.Write("Do you want to play again? ");
				string answer = Console.ReadLine();
				answer = answer.ToUpper(); //converts the answer to upper case
				quit = answer.StartsWith("N"); //start with function which determines if answer variable starts with a Y				
			}
		}

		static void Main(string[] args) {

			(new Program()).Run();

		}
	}
}
