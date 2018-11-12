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

            Console.WriteLine("Hello! What is your name?");
            string OwnerFirstName = Console.ReadLine();

            Console.WriteLine("\r\nThank you {0}. What is your last name?", OwnerFirstName);
            string OwnerLastName = Console.ReadLine();

            //now got user first and last name. Now asking for address
            Console.WriteLine("\r\nNow I have your name " + OwnerFirstName + " " + OwnerLastName + ". Welcome to Dog Health Record.\r\nWhat is your street address?");
            string UserAddress = Console.ReadLine();
         
            //Asking the user for what city does the user live
            Console.WriteLine("\r\nWhat City do you live?");
            string userCity = Console.ReadLine();

            //Asking for the user State 
            Console.WriteLine("\r\nWhat State do you live in?");
            string UserState = Console.ReadLine();

            //Asking for user zip code
            Console.WriteLine("\r\nWhat is your ZipCode?");
            
            //Call function of the menu
            choicesMenu();
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
