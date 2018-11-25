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

            Console.WriteLine("\r\nHow old is your dog {0}? (In numbers only)", DogName);
            string DogAgeString = Console.ReadLine();

            Console.WriteLine("Please also enter in weeks or years to right next to {0} Age.", DogName);
            string DogAgeType = Console.ReadLine();

            //Vaccine Schedule
            Console.WriteLine("\r\nHere is {0} Vaccine Schedule:\r\n", DogName);

            VaccineSchedule(DogAgeString, DogName, DogAgeType);
            Console.WriteLine("\r\nWhat type of first breed is {0}", DogName);
            string DogBreed1 = Console.ReadLine();

            Console.WriteLine("\r\nIs {0} a mixed breed?\r\n[Y]es or [N]o",DogName);
            string SecBreedOption = Console.ReadLine();

            //SecBreedOption(DogBreed2, DogName);

            if (SecBreedOption == "yes" || SecBreedOption == "Yes")
            {
                Console.WriteLine("What is {0} second breed?", DogName);
                string MixedBreed = Console.ReadLine();
                //Console.WriteLine(DogName + " is a " + DogGender + " and is " + DogAgeString + " " + DogAgeType + " with " + DogBreed1 + " and " + MixedBreed);
            }

            else if (SecBreedOption == "no" || SecBreedOption == "No")
            {
                Console.WriteLine(DogName + " is a " + DogGender + " and is " + DogAgeString + " " + DogAgeType + " with " + DogBreed1);
            }

            userChoiceMenu();
        }
 
        public static void VaccineSchedule(string dogAgeString,string dogName,string dogAgeType)
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
            if (dogAge == 6 && dogAge>=8 ||dogAgeType=="weeks"||dogAgeType=="Weeks")
            {
                Console.WriteLine("Since {0} is 6 to 8 week.\r\nYou will {1}.", dogName, string.Join(" , ", VaccineFor6to8Weeks()));

            } else if (dogAge>=10 && dogAge<=12 || dogAgeType == "weeks" || dogAgeType == "Week")               
            {
                Console.WriteLine("Since {0} is 10 to 12 week.\r\nYou will need {1}.", dogName, string.Join(" , ", VaccineFor10to12Weeks()));
            } else if (dogAge>=14 && dogAge <= 16 || dogAgeType == "weeks" || dogAgeType == "Week")
            {
                Console.WriteLine("Since {0} is 14 to 16 week.\r\nYou will need {1}.", dogName, string.Join(" , ", VaccineFor14to16Weeks()));
            }
            else if (dogAge > 16 || dogAgeType == "weeks" || dogAgeType == "Week" || dogAgeType=="Years"|| dogAgeType == "years")
            {
                Console.WriteLine("{0} is 17 weeks and above here is " + dogName + ":\r\n",dogName);
                Console.WriteLine("For Annual- You will need {0}.\r\nRemember Every 3 years- {1}.", string.Join(" , ", AnnualVaccineSchedule()), string.Join(",",ForEvery3Years()));
                    
            }
        }

        private static string [] ForEvery3Years()
        {
            
            return new string[] { "Distemper", " Hepatitis", " Parvirus", " Parainfluenza", " and Leptospirosis (optional)" };

        }

        private static string[] AnnualVaccineSchedule()
        {
            return new string[] { "Rabies", "Distemper", "Hepatitis", "Parvirus", "Parainfluenza", "and Bordatella" };
        }

        private static string [] VaccineFor14to16Weeks()
        {
            return new string[] { "Distemper", "Hepatitis", "Parvirus", "Parainfluenza", " and Lyme" };
        }

        private static string [] VaccineFor10to12Weeks()
        {
            return new string [] { "Distemper", "Hepatitis", "Parvirus","Parainfluenza","Cornoavirus", " and Leptospirosis (optional)" };
        }

        public static string [] VaccineFor6to8Weeks()
        {
            return new string[] { "Distemper", "Hepatitis", "Parvirus", "Parainfluenza", "Bordatella" };
        }

        private static void userChoiceMenu()
        {
            Console.WriteLine("[O] to return to back to owner\r\n[V] for Vet\r\n[E] for Exit");
            string choicesMenu = Console.ReadLine();

            if (choicesMenu == "O" || choicesMenu == "o")
            {
                Owner.OwnerInfo();

            } else if (choicesMenu == "V"|| choicesMenu == "v")
            {
                Vet.VetInfor();
            } else if (choicesMenu=="E" || choicesMenu == "e")
            {
                return;
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
