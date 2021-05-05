using System;

// Name: Jones, James
// Date: 05/05/2021
// Course: DEV2300-O 01: Application Program Development
// Synopsis: Game development code excercise, TicTacToe

namespace Game
{
    class Program
    {

        // Application entry point
        public static void Main(string[] args)
        {
            //Need a bool to allow the user to play multiple times if they choose.
            bool playTicTacToe = true;
            while (playTicTacToe)
            {
                //Instantiate
                TicTacToe.Play();

                //Play Again?
                playTicTacToe = PlayAgain();
            }

            //Exit message
            Console.WriteLine("Maybe next time. Have a great day!");

        }

        //Allow the user to play the TicTacToe game again?
        private static bool PlayAgain()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Would you like to play again? [Y/N]: ");

            string response = Console.ReadLine().ToUpper();
            return (response == "Y") ? true : false;
        }




    // End class
    }
}
