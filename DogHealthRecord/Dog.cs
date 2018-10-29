using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHealthRecord
{
    class Dog
    {
        string mDog;
        int mDogAge;
        string mDogBreed1;
        string mDogBreed2;

        //Create the constructor function
        public Dog (string _dog, int _DogAge,string _DogBreed1,string _DogBreed2)
        {
            //Use the incomming parameters to inialize our original member variables
            mDog = _dog;
            mDogAge = _DogAge;
            mDogBreed1 = _DogBreed1;
            mDogBreed2 = _DogBreed2;
        }

        //Getters
        public string GetDog()
        {
            return mDog;

        }

        public int GetDogAge()
        {
            return mDogAge;
        
        }

        public string GetDogBreed1()
        {
            return mDogBreed1;
        }

        public string GetDogBreed2()
        {
            return mDogBreed2;
        }
    }
}
