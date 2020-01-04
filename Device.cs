//Sabrina Turney
//C# II

using System;

namespace VirtualDevice
{
    //Define a class called Device. Add it to your project in its own Device.cs source file. Make it publicly accessible and give it
    //GetMeasurement.This method will return a random integer between 1 and 10 as a measurement of some imaginary object.

    public class Device
    {
        private Random random;

   
        //Create a device.
        public Device()
        {
            random = new Random();
        }


        //Return a random measurement of 1 to 10.
        public int GetMeasurement()
        {
            return random.Next(1, 11);
        }
    }
}
