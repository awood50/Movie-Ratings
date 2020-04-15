/*  Programmer:Andrew Wood    
 * Date:  2/5/19   
 * Purpose:This program allows for a user to rate movies and calculates average
 */



using System;
using static System.Console;

namespace MovieRatingsProgram
{
    class MovieRatingsProgram
    {
        private const int limit = 3; //setting a constant of 3 for the max number of attempts

        private static int InputMethod() //method that will take the input from user and return their rating
        {
            WriteLine("Enter the star rating between 0 and 4. Enter a negative number to quit."); //displays message
            string aValue = ReadLine(); //takes in the string value of the user
            int stars = int.Parse(aValue); //converts the string to an integer
            return stars; //returns input
        }

        private static int DeterminationLoop(int stars) //method declaration that will determine if the input is valid 
        {

            int attempts = 1; //new int for number of attempts 
            while ((stars > 4 || stars < 0) && attempts < limit) //while loop for conditional rating input
            {
                WriteLine("Incorrect value. Please enter a value from 0 to 4"); //displays if rating is invalid input
                string aValue = ReadLine(); //takes in the string value of the user
                stars = int.Parse(aValue); //converts the string input to an integer
                attempts = attempts + 1; //regulates the attempts variable
            }

            if (attempts < limit) //if the number of attemtps is less than the limit, program will run
            {

                return stars;
            }


            return -1; //otherwise the method will return a -1 to end program
        }


        private static void CompleteProgram(double finaltotal, double counter) //method that will calculate average and complete the program
        {
            if (counter > 0) //conditional if to calculate average 
            {
                double average = finaltotal / counter; //calculates average 
                WriteLine("The average rating is " + average + " stars."); //displays average

            }
            WriteLine("The program has completed."); //displays final message
        }

        static void Main(string[] args)
        {

            int count = 0; //int to keep track of average totals
            int total = 0; //int to keep track of total


            int stars = InputMethod(); //call to the input method to get the rating 

            while (stars >= 0) //while loop for while the rating is positive 
            {
                stars = DeterminationLoop(stars); //calls the deterination method in order to make sure input is within specified parameters 
                if (stars >= 0 && stars <= 4) //checks to see if rating is in betweeen 0 and 4
                {
                    count = count + 1; //adds 1 to count 
                    total = total + stars; //adds stars and total together
                }
                else
                {
                    WriteLine("You have not entered a valid rating 3 times. New user begins now"); //displays if conditions are not met 
                }
                WriteLine("Enter the star rating between 0 and 4. Enter a negative number to quit."); //displays input message 
                string aValue = ReadLine(); //takes in string input from user
                stars = int.Parse(aValue); //converts string input to integer
            }


            CompleteProgram(total, count); //method call to complete program and calculate the average


        }

    }
}
