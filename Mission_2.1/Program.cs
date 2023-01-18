using System;
// Ethan Spilker 1/18/2023
//Dice Rolling Program: This program lets you simulate rolling a specific number of dice and tells you the output

namespace Mission_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Import random into the program and ask the user for the number of rolls
            Random rnd = new Random();
            Console.Write("Welcome to the Dice Throwing Simulator!");
            Console.Write("\n\nHow many dice rolls would you like to simulate? ");

            // Create empty arrays for later use. One for The dice numbers that are rolled
            // One to hold the percentage of how mnay times that number was rolled
            // and one to hold the *'s that are used later 
            int Dice_Rolls = Convert.ToInt32(Console.ReadLine());
            int[] myNum = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            double[] percent = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            string[] star = { "", "", "", "", "", "", "", "", "", "", ""};

            //Loop to roll dice the number of times the user has specified
            for (int counter = 0; counter <= Dice_Rolls; counter++)
            {
                //Generate a random numbers to simulate rolling two dice
                int RandNum1 = rnd.Next(1, 7);
                int RandNum2 = rnd.Next(1, 7);
                int RandNum = RandNum1 + RandNum2;

                //Increment each number in the array based on the dice rolled
                if (RandNum == 2) { myNum[0] = myNum[0] + 1; }
                else if (RandNum == 3) { myNum[1]++; }
                else if (RandNum == 4) { myNum[2]++; }
                else if (RandNum == 5) { myNum[3]++; }
                else if (RandNum == 6) { myNum[4]++; }
                else if (RandNum == 7) { myNum[5]++; }
                else if (RandNum == 8) { myNum[6]++; }
                else if (RandNum == 9) { myNum[7]++; }
                else if (RandNum == 10) { myNum[8]++; }
                else if (RandNum == 11) { myNum[9]++; }
                else if (RandNum == 12) { myNum[10]++; }
                


            }

            //loop to calculate the percentage of each number rolled
            for (int i = 0; i <= 10; i++)
            {
                //Number conversions so the math plays nice with everything
                percent[i] = (Convert.ToDouble(myNum[i]) / Dice_Rolls) * 100;
                Math.Round(percent[i]);

                //Adds a the number of *'s to the string
                star[i] = new String('*', Convert.ToInt32(percent[i]));

                
            }
            //Prints the results
            Console.Write("\n\nDICE ROLLING SIMULATION RESULTS"
                     + "\nEach * represents 1% of the total number of rolls." +
                     "\nTotal number of rolls = " + Dice_Rolls +
                     "\n\n2: " + star[0] +
                     "\n3: " + star[1] +
                     "\n4: " + star[2] + "\n5: " + star[3] + "\n6: " + star[4] + "\n7: " + star[5] +
                     "\n8: " + star[6] + "\n9: " + star[7] + "\n10: " + star[8] + "\n11: " + star[9] +
                     "\n12: " + star[10]);
        }
    }
}
