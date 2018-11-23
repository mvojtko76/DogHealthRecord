using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHealthRecord
{
    class Owner
    {      

        public static void OwnerInfo()
        {
            Console.WriteLine("Dog Health Record\r\n");

            Console.WriteLine("Hello! What is your First Name?");
            string OwnerFirstName = Console.ReadLine();

            //ValidatedFirstName(OwnerFirstName);

            Console.WriteLine("\r\nThank you {0}. What is your Last Name?", OwnerFirstName);
            string OwnerLastName = Console.ReadLine();

            ValidatedLastName(OwnerLastName);

            //now got user first and last name. Now asking for address
            Console.WriteLine("\r\nThank You " + OwnerFirstName + " " + OwnerLastName + "! Now I have your name. Welcome to Dog Health Record.\r\nWhat is your street address?");
            string UserAddress = Console.ReadLine();

            ValidatedUserAddress(UserAddress);
         
            //Asking the user for what city does the user live
            Console.WriteLine("\r\nWhat City do you live?");
            string userCity = Console.ReadLine();

            //Asking for the user State 
            Console.WriteLine("\r\nWhat State do you live in?");
            string UserState = Console.ReadLine();

            ValidatedState(UserState);

            //Asking for user zip code
            Console.WriteLine("\r\nWhat is your ZipCode?");
            string OwnerZipCode = Console.ReadLine();

            validatedOwnerZipCode(OwnerZipCode);

            Console.WriteLine("\r\nYour Address is:\r\n{0},\r\n{1}, {2} {3}", UserAddress, userCity, UserState.ToUpper(), OwnerZipCode);
            //Call function of the menu
            choicesMenu();
        }

        public static void ValidatedUserAddress(string userAddress)
        {
            //This should run if the user leaves it blank or empty spaces
            while (string.IsNullOrEmpty(userAddress))
            {
                //Alert the user to the problem
                Console.WriteLine("I am sorry but you can't leave this blank.");

                //Re-cathching the user's response using the same variable
                userAddress = Console.ReadLine();
                break;
            }
        }

        private static void ValidatedLastName(string ownerLastName)
        {
            //This should run if the user leaves it blank or empty spaces
            while (string.IsNullOrEmpty(ownerLastName))
            {
                //Alert the user to the problem
                Console.WriteLine("I am sorry but you can't leave this blank.");

                //Re-cathching the user's response using the same variable
                ownerLastName = Console.ReadLine();
                break;
            }
        }

        private static void ValidatedFirstName(string ownerFirstName)
        {
            //This should run if the user leaves it blank or empty spaces
            while (string.IsNullOrEmpty(ownerFirstName))
            {
                //Alert the user to the problem
                Console.WriteLine("I am sorry but you can't leave this blank.");

                //Re-cathching the user's response using the same variable
                ownerFirstName = Console.ReadLine();

            }
        }

        public static void ValidatedState(string userState)
        {
            //This should run if the user leaves it blank or empty spaces
            while (string.IsNullOrEmpty(userState))
            {
                //Alert the user to the problem
                Console.WriteLine("I am sorry but you can't leave this blank.");
                userState = Console.ReadLine();

                //Re-cathching the user's response using the same variable
                userState = Console.ReadLine();

            }
            
        }

        private static void validatedOwnerZipCode(string ownerZipCode)
        {
            //This should run if the user leaves it blank or empty spaces
            while (string.IsNullOrEmpty(ownerZipCode))
            {
                //Alert the user to the problem
                Console.WriteLine("I am sorry but you can't leave this blank.");
                ownerZipCode = Console.ReadLine();

                //Re-cathching the user's response using the same variable
                ownerZipCode = Console.ReadLine();
               
            }
             
        }

        private static void choicesMenu()
        {
            Console.WriteLine("\r\n[D] for Dogs\r\n[V] for Veterniary\r\n[E] for Exit");
            string UserChoiceMenu = Console.ReadLine();

            UserMenu(UserChoiceMenu);
        }

        private static void UserMenu(string UserChoiceMenu)
        {
            if (UserChoiceMenu == "D"||UserChoiceMenu=="d")// Dog Class
            {
                Dog.DogInfo();

            } else if (UserChoiceMenu == "V"||UserChoiceMenu=="v") //  Veterniary Class
            {

                Vet.VetInfor();
            } else if(UserChoiceMenu == "E"||UserChoiceMenu=="e")
            {

                return;
            }

                
        }
    }
}
