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

        public static string PrintOwnerScreen(string mOwnerFirstName,string mOwnerLastName)
        {
            Console.WriteLine("Hello " + mOwnerFirstName + " " + mOwnerLastName);

        }
    }
}
