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
            string DogAgeString = Console.ReadLine();

            Console.WriteLine("Please also enter in weeks or years to right next to your {0} Age.", DogAgeString);
            string DogAgeType = Console.ReadLine();

            Console.WriteLine("\r\nWhat type of first breed is {0}", DogName);
            string DogBreed1 = Console.ReadLine();

            Console.WriteLine("\r\nIs {0} a mixed breed?\r\n[Y]es or [N]o",DogName);
            string DogBreed2 = Console.ReadLine();

            SecondaryBreedOption(DogName, DogGender, DogAgeString, DogAgeType, DogBreed1,DogBreed2);
            
            //Vaccine Schedule
            Console.WriteLine("\r\nHere is {0} Vaccine Schedule:\r\n", DogName);

            VaccineSchedule(DogAgeString,DogName);
            SecBreedOption(DogBreed2,DogName);
            userChoiceMenu();
        }

        private static void SecondaryBreedOption(string dogName,string dogGender,string dogAgeString,string dogAgeType,string dogBreed1, string dogBreed2)
        {
            if (dogBreed2 == "yes" || dogBreed2 == "Yes")
            {
                Console.WriteLine(dogName + " is a " + dogGender + " and is " + dogAgeString + " " + dogAgeType + " with " + dogBreed1 + " and " + dogBreed2);

            } else if (dogBreed2 == "no" || dogBreed2 == "No")

            {

                Console.WriteLine(dogName + " is a " + dogGender + " and is " + dogAgeString + " " + dogAgeType + " with " + dogBreed1);
            }
        }

        public static void VaccineSchedule(string dogAgeString,string dogName)
        {
            int dogAge;
            while (!int.TryParse(dogAgeString, out dogAge))
            {

                //the user that there is a problem
                Console.WriteLine("Please enter a number");

                //Re-catching the user's response using the same variable
                dogAgeString = Console.ReadLine();

            }

            //Matching the user's dog age with right vaccine with if/else statement
            if (dogAge == 6 && dogAge>=8)
            {

                Console.WriteLine("Since {0} is 6 to 8 week.\r\nYou will need Distemper, Hepatitis, Parvirus, Parainfluenza, and Bordatella.", dogName);

            } else if (dogAge==10 && dogAge>=12)
                
            {

                Console.WriteLine("Since {0} is 10 to 12 week.\r\nYou will need Distemper, Hepatitis, Parvirus, Parainfluenza, Cornoavirus, and Leptospirosis (optional).", dogName);

            } else if (dogAge==14 && dogAge >= 16)

            {

                Console.WriteLine("Since {0} is 14 to 16 week.\r\nYou will need Distemper, Hepatitis, Parvirus, Parainfluenza, and Lyme.", dogName);

            } else if (dogAge <= 17)

            {

                Console.WriteLine("{0} is 17 weeks and above here is {0} Vaccine Schedule:\r\nFor Annual- You will need Rabies, Distemper, Hepatitis, Parvirus, Parainfluenza, and Bordatella.\r\nRemember Every 3 years- Distemper, Hepatitis, Parvirus, Parainfluenza, and Leptospirosis (optional).", dogName);

            }

 
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
