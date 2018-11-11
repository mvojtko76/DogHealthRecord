using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHealthRecord
{
    class Owner
    {
        //Setting up members variable for 
        string mOwnerFirstName;
        string mOwnerLastName;
        string mAddress;
        string mCity;
        string mState;
        double mZipCode;

        //Create constructor function
        public Owner (string _OwnerFirstName, string _OwnerLastName, string _Address, string _City, string _State, double _zipCode)
        {
            //Use the in commend parameters to inialize our orignial member variables
            mOwnerFirstName = _OwnerFirstName;
            mOwnerLastName = _OwnerLastName;
            mAddress = _Address;
            mCity = _City;
            mState = _State;
            mZipCode = _zipCode;
        }

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

            choicesMenu();
        }

        private static void choicesMenu()
        {
            Console.WriteLine("[D] for Dogs\r\n[V] for Veterniary\r\n [E] for Exit");
            string UserChoiceMenu = Console.ReadLine();

            UserMenu(UserChoiceMenu);
        }

        private static void UserMenu(string UserChoiceMenu)
        {
            if (UserChoiceMenu == "D")// Dog Class
            {
                Dog.DogInfo();

            } else if (UserChoiceMenu == "V") //  Veterniary Class
            {

                Vet.VetInfor();
            } else if(UserChoiceMenu == "E")
            {

                //break;
            }

                
        }
    }
}
