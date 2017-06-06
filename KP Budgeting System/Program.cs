using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 Spencer Henze
 ITM 320
 9/9/16
 Homework 2 */

namespace KP_Budgeting_System
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayGreeting();
            int guests = NumberGuests();  //use the NumberGuests() method to ask user how many guests, then store the value as "guests" in main
            double food = CalculateFoodCost(guests); //use the CalculateFoodCost() method to calculate the cost of food. Pass in the needed variable "guests" from Main, then store the resulting value as "food" in main

            int drinkOption = GetDrinkOption(); //use the GetDrinkOption() method to ask user which drink option, then store the value as "drinkOption" in main
            double drinkCost = CalculateDrinkCost(drinkOption, guests);  //use the CalculateDrinkCost() method to calculate the cost of drinks given the selected option. Pass in the needed variables "guests" and "drinkOption" from Main, then store the resulting value as "drinkCost" in main

            int decorOption = GetDecorOption(); //use the GetDecorOption(); to ask the user which decor option they want. Store the returned value as "decorOption" in main.
            double decorCost = CalculateDecorCost(decorOption, guests);   //use the GetDecorOption() method to calculate the cost of decor given the selected option. Pass in the needed variables "guests" and "decorOption" from Main, then store the resulting value as "decorCost" in main
            // now get a subtotal

            double subtotal = food + drinkCost + decorCost;  //use the variables stored in main (that came from the connected methods) to simply sum up the costs.

            // get discount amount
            double discounts = CalculateDiscount(drinkOption, subtotal); //use the CalculateDiscount() method to find the discount amount that the user gets based on their drink option selection. Store that value as "discount" in main. (will either be 5% of subtotal, or 0)


            // we only want the discount to be shown and applied if option 2 (the "healthy option" was selected) so here we specify that if drink option 2 was selected:
            if (drinkOption == 2)  // so if drink option 2 (healthy otion) was selected...
            { 
                Console.WriteLine("\nYour subtotal is: $" + subtotal); // First display the subtotal,
                Console.WriteLine("\nYou qualify for a 5% discount!");  // then inform the user they qualify for a discount,
            }

            // subtract the discount (either 5% of subtotal or 0 depending on their drink option)and output grand total:
            double grandTotal = subtotal - discounts;
            Console.WriteLine("\n\nYour Grand Total is: $" + grandTotal); // show the string and the value for grandTotal

            Console.ReadLine(); //keep the console open

        } //End of MAIN

        public static void DisplayGreeting()
        {
            Console.WriteLine("Welcome to the KP Budgeting System! \nwhere all of your budgeting dreams come true.");
        } //End DisplayGreeting()


        public static int NumberGuests() //gets the number of guests from the user, converts it to an int and retunrs it to Main to be stored so that it can be used in future methods.
        {
            int guests = 0;
            Console.WriteLine("\nHow many guests will be at the party?\n");
            guests = Convert.ToInt32(Console.ReadLine());
            return guests;

        } //End NumberGuests()

        public static double CalculateFoodCost(int guests) //calculates the cost of food based on the number of guests, converts it to an double and retunrs it to Main to be stored so that it can be used in future methods.
        {
            double foodCost = 0;
            foodCost = guests * 25;
            return foodCost;
            
        } // End CalculateFoofCost()


        public static int GetDrinkOption() //gets the drink selection from the user, converts it to an int and retunrs it to Main to be stored so that it can be used in future methods.
        {
            int drinks = 0;
            Console.WriteLine("\nPlease select a drinks option: \n \n1 = Alcohol \n2 = Healthy Option\n");
            drinks = Convert.ToInt32(Console.ReadLine());
            return drinks;
        } //End GetDrinkOption()

        public static double CalculateDrinkCost(int drinkOption, int guests) //calculates the cost of drinks based on the number of guests and the drink selection made before. Then it converts it to an double and retunrs it to Main to be stored so that it can be used in future methods.
        {
            double drinkCost = 0;
            if (drinkOption == 1)
            {
                drinkCost = 20 * guests;
            }
            else if (drinkOption == 2)
            {
                drinkCost = 5 * guests;
            }
            return drinkCost;
        } //End CalculateDrinkCost()

        public static int GetDecorOption() // same as the GetDrinkOption() method above but for decor.
        {
            int decor = 0;
            Console.WriteLine("\nPlease select a decor option: \n1 = Fancy \n2 = Regular\n");
            decor = Convert.ToInt32(Console.ReadLine());
            return decor;
        } //End GetDecorOption()

        public static double CalculateDecorCost(int decorOption, int guests) //same as the CalculateDrinkCost() method above but for decor cost.
        {
            double decorCost = 0;
            if (decorOption == 1)
            {
                decorCost = (15 * guests) + 50;
            }
            else if (decorOption == 2)
            {
                decorCost = (7.50 * guests) + 30;
            }
            return decorCost;

        } // End CalculateDecorCost()

        public static double CalculateDiscount(int drinkOption, double subtotal) // this method looks at what drink option was selected and returns a value that is either 5% of the subtotal (from main) or 0 depending on what drink selection was chosen.
        {
            double discount = 0;
            if (drinkOption == 2)
            {
                discount = .05 * subtotal;
            }

            return discount;
        } //End of CalculateDiscount ()

    }
}
