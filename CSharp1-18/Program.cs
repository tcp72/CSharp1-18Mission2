using System;

namespace CSharp1_18
{
    class Program
    {   //I added "public" keyword
        public static void Main(string[] args)//this will always be exactly like this in every C# program
        {
            //intro text and get the number or rolls needed identified
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            string val;
            int numRollsNeeded;
            Console.WriteLine("How many dice rolls would you like to simulate?\n");
            val = Console.ReadLine();
            // convert to integer
            numRollsNeeded = Convert.ToInt32(val); //this holds the number of rolls they want to simulate


  
            //Print results:
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \" * \" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRollsNeeded + "\n");
            //logic for the asterisks

            //Get individual die rolls
            //import the Random class
            Random r = new Random(); //give it a name "r"; declare then instantiate that random number

            int[] arrayOfTotals = new int[12];
            //int individualTotal = 0;

            for (int i = 0; i < numRollsNeeded; i++) //starts counting at 0 so 0-99 is 100 times; will print out a roll 100 times
            {
                arrayOfTotals[r.Next(6) + r.Next(6)]++; //makes the total number in each location = num times rolled
            }

            for (int i = 0; i < 11; i++)//enter 12 times
            {
                int whichDie = i + 2;
                string asterisk = "";

                //Console.Write(whichDie);
                for (int iCount = 0; iCount < arrayOfTotals[i]; iCount++) //(Math.Round(arrayOfTotals[i]/numRollsNeeded)); iCount++)
                {                     
                    asterisk = asterisk + "*";     
                }
                Console.WriteLine(whichDie + ": " + asterisk);
            }

            //end logic for the asterisks
            Console.WriteLine("\nThank you for using the dice throwing simulator.  Goodbye! ");
        }
    }
}
/*
 

            int[] roll1 = new int[6]; //array of integers named roll1; has 6 options; instantiate, starts w/ nulls; 0-5 (so like 1-6)
            int[] roll2 = new int[6];
            int[] totalRoll = new int[200000];// + 1]; //total roll that will hold the totals for each roll

          //while loop or do while loop if not know how many times
            for (int i = 0; i < 6; i++) //make an int counter called "i" that starts at 0; condition to go; what do w/ counter each time
                                        // for loop when know how many times you'll run it before
            {
                Console.WriteLine(i + " is the counter number");
                roll1[i] = 0; //set each instance of "roll1" = 0 so it is not null
                              //Console.WriteLine(idk[i]);
                roll2[i] = 0;
            }
            



            Console.WriteLine(roll1[5] + " for the first roll"); //this shows how many times 6 was rolled
            Console.WriteLine(roll2[5] + " for the other roll"); //this shows how many times 6 was rolled

            int number = 5;
            Console.WriteLine((number + 1) + ": " + roll1[number] + " for the first roll"); // number of times a 6 was rolled
            Console.WriteLine((number + 1) + ": " + roll2[number] + " for the other (second) roll"); // number of times a 6 was rolled

            //for 



for (int i = 0; i < numRollsNeeded; i++) //starts counting at 0 so 0-99 is 100 times; will print out a roll 100 times
{
    arrayOfTotals[r.Next(6) + r.Next(6)]++;

    //Console.WriteLine(r.Next(1, 7)); //min is 1 inclusive and max is 7 exclusive
    int roll = r.Next(6);
    Console.WriteLine(roll + " is the roll and " + i + " is the counter");
    roll1[roll] = roll1[roll] + 1;       //in class he did blah[r.Next(6)]++ but I think mine is the same; then increment 1; or blah[roll] = blah[roll] + 1

    int otherRoll = r.Next(6);
    Console.WriteLine(otherRoll + " is the other roll and " + i + " is the counter");
    roll2[otherRoll] = roll2[otherRoll] + 1;       //in class he did blah[r.Next(6)]++ but I think mine is the same; then increment 1; or blah[roll] = blah[roll] + 1

    //get the total overall
    //totalRoll[i] = roll1[i] + roll2[i];
    //totalRoll[i]
    Console.WriteLine(totalRoll[i] + " is the total roll for this spot.");
}
*/

//i = i + 1;   is same as   i++;
//int[] ran

//int[] blah = { 45, 20, 67, 10 };//array of integers named blah, then the values.
//Console.WriteLine(blah[1]); //print out the stuff in position 1