//gursimranjot singh gill
//c# rock-paper-scissors
using System.ComponentModel;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Game
{

    //creating a class to catch custom exception
    public class MyCustomException : Exception
    {
        public MyCustomException() { }
        public MyCustomException(string message) : base(message) { }
        public MyCustomException(string message, Exception innerException) : base(message, innerException) { }
    }

    class Program
    {
        public static bool NewGame(int playerwin)
        {
            bool correctoption = true;
            bool returnvalue = true;
            while (correctoption)
            {

                Console.WriteLine();
                Console.WriteLine("Would you like to Continue?");
                Console.WriteLine("Enter 'y' for yes    'n' for no");
                string continuegame = Console.ReadLine(); //reading the input
                Console.WriteLine();
                continuegame = continuegame.ToLower();

                //condition in which if player chose to stop, the game stops or else it goes on
                if (continuegame == "n")
                {
                    Console.WriteLine($"Thank you for playing. You won {playerwin} rounds");
                    returnvalue = false;// breaked out of main while loop
                    correctoption = false;//breakes out of while loop
                }

                else if (continuegame == "y")
                {
                    returnvalue = true; // dosent break out of main while loop
                    correctoption = false; //breakes out of while loop
                } //error handeling 
                else
                {
                    Console.WriteLine("Please enter y or n"); //dosent breake out of while loop brcause the input was invalid

                }
            }
            return returnvalue;
        }

        public static void Main(string[] args)
        {

            Random random = new Random();
            bool playgame = true;
            int computerwin = 0; //to keep track of number of rounds computer won
            int playerwin = 0; //to keep track of number of rounds player won
            Console.WriteLine("Welcome to rock, paper, scissors");


            while (playgame)  //to keep the game going unless player decide to stop
            {
                try //for error handeling 
                {
                    Console.WriteLine($"Player Wins={playerwin} Computer Wins={computerwin}");
                    Console.WriteLine("Enter 'r'-rock, 'p'-paper, 's'-scissor");


                    string input = Console.ReadLine(); //reading the input
                    Console.WriteLine();
                    input = input.ToLower(); //converting it to lower in case player decide to input upperletters 

                    //conditions for accepting only r,p and s as input 
                    if (input != "r" && input != "p" && input != "s")
                    {
                        //if the condition is met, it gives the following message
                        throw new MyCustomException("Please enter r, p and s only");
                    }

                    int computernum = random.Next(0, 3); //generating a random number 

                    //displaying the player input
                    switch (input)
                    {
                        case "r":
                            Console.WriteLine("Player: Rock");
                            break;
                        case "p":
                            Console.WriteLine("Player: Paper");
                            break;
                        case "s":
                            Console.WriteLine("Player: Scissor");
                            break;
                    }


                    //displaying computer input based on random number generated  as well as defining conditions for which the computer
                    // wins or player wins or its a tie.
                    //made use of if as well as switch statements
                    if (computernum == 0)
                    {
                        Console.WriteLine("Computer: Rock");
                        Console.WriteLine();
                        switch (input)
                        {
                            case "r":
                                Console.WriteLine("Its a tie.");
                                break;
                            case "p":
                                Console.WriteLine("Player Won");
                                playerwin++;
                                break;
                            case "s":
                                Console.WriteLine("Computer Won");
                                computerwin++;
                                break;
                        }

                    }
                    else if (computernum == 1)
                    {
                        Console.WriteLine("Computer: Paper");
                        Console.WriteLine();
                        switch (input)
                        {
                            case "p":
                                Console.WriteLine("Its a tie.");
                                break;
                            case "s":
                                Console.WriteLine("Player Won");
                                playerwin++;
                                break;
                            case "r":
                                Console.WriteLine("Computer Won");
                                computerwin++;
                                break;
                        }
                    }
                    else if (computernum == 2)
                    {
                        Console.WriteLine("Computer: Scissor");
                        Console.WriteLine();
                        switch (input)
                        {
                            case "s":
                                Console.WriteLine("Its a tie.");
                                break;
                            case "r":
                                Console.WriteLine("Player Won");
                                playerwin++;
                                break;
                            case "p":
                                Console.WriteLine("Computer Won");
                                computerwin++;
                                break;
                        }
                    }
                    // error handeling in case random number dosent work as it is supposed to 
                    else
                    {
                        Console.WriteLine("Something went wrong, please try again");
                    }

                    // used a method to ask used for continuation of game
                    //easy for error checking
                    playgame = NewGame(playerwin);
                }
                //catcing the custom error
                catch (MyCustomException customEx)
                {
                    // Handle the  exception
                    Console.WriteLine("Error: " + customEx.Message);
                    Console.WriteLine();
                }
            }

        }

    }

}