using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHealthRecord
{
    class Dog
    {
    
        public static void DogInfo()
        {
            Console.WriteLine("\r\nDog Information\r\nNow please enter your Dog's Name.");
            string DogName = Console.ReadLine();

            Console.WriteLine("\r\n{0} is boy or girl", DogName);
            string DogGender = Console.ReadLine();

            Console.WriteLine("\r\nHow old is your dog {0}?", DogName);
            string userAgeString = Console.ReadLine();

            Console.WriteLine("\r\nWhat type of breed is {0}", DogName);
            string DogBreed1 = Console.ReadLine();

            Console.WriteLine("\r\nIs {0} a mixed breed?\r\n[Y]es or [N]o",DogName);
            string DogBreed2 = Console.ReadLine();

            SecBreedOption(DogBreed2,DogName);
            userChoiceMenu();
        }

        private static void SecBreedOption(string DogBreed2,string DogName)
        {
            if (DogBreed2 == "Y"||DogBreed2=="y")
            {
                Console.WriteLine("What is {0} second breed?",DogName);
                string MixedBreed = Console.ReadLine();

                Console.WriteLine(MixedBreed);
            } else if (DogBreed2=="N" || DogBreed2 == "y")
            {
                Console.WriteLine("None");
            }
        }

        private static void userChoiceMenu()
        {
            Console.WriteLine("[O] to return to back to owner\r\n[V] for Vet");
            string choicesMenu = Console.ReadLine();

            if (choicesMenu == "O" || choicesMenu == "o")
            {
                Owner.OwnerInfo();

            } else if (choicesMenu == "V"|| choicesMenu == "v")
            {
                Vet.VetInfor();
            }

            ValidatedUserResponse(choicesMenu);
        }
        
        public static void ValidatedUserResponse(string choicesMenu)
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
