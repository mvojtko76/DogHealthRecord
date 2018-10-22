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

        //Create constructor function
        public Owner (string _OwnerFirstName, string _OwnerLastName)
        {
            //Use the in commend parameters to inialize our orignial member variables
            mOwnerFirstName = _OwnerFirstName;
            mOwnerLastName = _OwnerLastName;
            
        }
        
    }
}
