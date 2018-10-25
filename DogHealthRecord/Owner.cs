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
        
    }
}
