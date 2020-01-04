//Sabrina Turney
//C# II

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDevice
{
    public interface IMeasuringDevice
    //Define an interface called IMeasuringDevice. Add it to your project in its own IMeasuringDevice.cs source file.
    {
        decimal MetricValue();
        //This method will return a decimal that represents the metric value of the most recent measurement that was captured.

        decimal ImperialValue();
        //This method will return a decimal that represents the imperial value of the most recent measurement that was captured.

        void StartCollecting();
        //This method will start the device running. It will begin collecting measurements and record them.

        void StopCollecting();
        //This method will stop the device. It will cease collecting measurements.

        int[] GetRawData();
        //This method will retrieve a copy of all of the recent data that the measuring device has captured. 
        //The data will be returned as an array of integer values.

    }
}
