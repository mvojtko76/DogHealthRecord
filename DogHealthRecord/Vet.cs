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
            //Asking the user for what is the Vet name
            Console.WriteLine("Vetinernary Information\r\nPlease enter your Veternary Clinic");
            string VetClinic = Console.ReadLine();

            //Asking the user for what is the Vet name
            Console.WriteLine("\r\nWhat is your Vet name");
            string VetName = Console.ReadLine();

            //Asking the user for what is the street address is their vet located at
            Console.WriteLine("\r\nWhat is {0} street address is?", VetClinic);
            string VetStreet = Console.ReadLine();

            //Asking the user for what city does the vet live in
            Console.WriteLine("\r\nWhat is {0} City located at?", VetClinic);
            string VetCity = Console.ReadLine();

            //Asking the user for the state where their Vet located at
            Console.WriteLine("\r\nWhat is {0} State located at?", VetClinic);
            string VetState = Console.ReadLine();


            //Asking the user for what zip code is their Vet live in
            Console.WriteLine("\r\nWhat is {0} ZipCode located at",VetClinic);
            string VetZipCodeString = Console.ReadLine();

            validatedZipCode(VetZipCodeString);


            userChoiceMenu();
        }

        private static void validatedZipCode(string vetZipCodeString)
        {
            //This should run if the user leaves it blank or empty spaces
            if (string.IsNullOrEmpty(vetZipCodeString))
            {
                //Alert the user to the problem
                Console.WriteLine("I am sorry but you can't leave this blank.");
                return;
                
            } else if (vetZipCodeString.Length != 4)
            {
                Console.WriteLine("Please enter correct data.");
                return;
            }

            

        
    
        }
        private static void userChoiceMenu()
        {
            Console.WriteLine("[O] to return to back to Owner\r\n[D] for Dog\r\n[E] for Exit");
            string choicesMenu = Console.ReadLine();

            if (choicesMenu == "O" || choicesMenu == "o")
            {
                Owner.OwnerInfo();

            }
            else if (choicesMenu == "D" || choicesMenu == "d")
            {
                Dog.DogInfo();
            }
            else if (choicesMenu == "E" || choicesMenu == "e")
            {

                return;
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
