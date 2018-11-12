using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHealthRecord
{
    class Vet
    {
        
        public static void VetInfor()
        {
            Console.WriteLine("Vetinernary Information\r\nPlease enter your Veternary Clinic");
            string VetClinic = Console.ReadLine();

            Console.WriteLine("\r\nWhat is your Vet name");
            string VetName = Console.ReadLine();

            Console.WriteLine("\r\nWhat is {0} street address is?", VetClinic);
            string VetStreet = Console.ReadLine();

            Console.WriteLine("\r\nWhat is {0} City located at?", VetClinic);
            string VetCity = Console.ReadLine();

            Console.WriteLine("\r\nWhat is {0} State located at?", VetClinic);
            string VetZipCode = Console.ReadLine();

            userChoiceMenu();
        }

        private static void userChoiceMenu()
        {
            Console.WriteLine("[O] to return to back to owner\r\n[D] for Dog");
            string choicesMenu = Console.ReadLine();

            if (choicesMenu == "O" || choicesMenu == "o")
            {
                Owner.OwnerInfo();

            }
            else if (choicesMenu == "D" || choicesMenu == "d")
            {
                Dog.DogInfo();
            }

            ValidatedUserResponse(choicesMenu);
        }

        private static void ValidatedUserResponse(string choicesMenu)
        {
            //This should run if the user leaves it blank or empty spaces
            while (string.IsNullOrWhiteSpace(choicesMenu))
            {
                //Alert the user to the problem
                Console.WriteLine("I am sorry but you can't leave this blank.");

                //Re-ask the user the questions
                Console.WriteLine("Please type in your menu choice and press enter!");

                //Re-Catch the user's response
                string userResponse1 = Console.ReadLine();
            }
        }
    }
}
