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

            userChoiceMenu();
        }

        private static void userChoiceMenu()
        {
            Console.WriteLine("[O] to return to back to owner\r\n")
        }
    }
}
