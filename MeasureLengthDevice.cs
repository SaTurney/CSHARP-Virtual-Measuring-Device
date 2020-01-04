//Sabrina Turney
//C# II

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace VirtualDevice
{

    //Define a class called MeasureLengthDevice. Add it to your project in its own MeasureLengthDevice.cs source file.
    //This class will implement the IMeasuringDevice interface. 
    //You may generate stubs for your implementation methods using the Implement Interface Wizard.

    public class MeasureLengthDevice
        : Device, IMeasuringDevice
    {
        private Units unitsToUse;
        //Units - This field will determine whether the generated measurements are 
        //interpreted in metric (e.g. centimeters) or imperial (e.g. inches) units. Its value will be determined from user input.

        private int[] dataCaptured;
        //integer array - This field will store a history of a limited set of recently captured measurements. 
        //Once the array is full, the class should start overwriting the oldest elements while continuing to record the newest captures.

        private int mostRecentMeasure;
        //integer - This field will store the most recent measurement captured for convenience of display.

        private DispatcherTimer timer;
        //Provide a mechanism to start and stop the measurement cycle (StartCollecting / StopCollecting).


        //Timer that actually captures timer ticks with units.
        public MeasureLengthDevice(Units unitsToUse)
        {
            this.unitsToUse = unitsToUse;
            dataCaptured = new int[10];
            mostRecentMeasure = 0;

            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(TimerTick);
            timer.Interval = new TimeSpan(0, 0, 15);
        }

        //Returning a decimal representation of the metric unit that was captured.
        public decimal MetricValue()
        {
            if (unitsToUse == Units.Metric)
                return mostRecentMeasure;

            //Converting the inches to centimeters.
            return (decimal)(mostRecentMeasure * 2.54);
        }

        //Returning a decimal representation of the imperial unit that was captured.
        public decimal ImperialValue()
        {
            if (unitsToUse == Units.Imperial)
                return mostRecentMeasure;

            //Converting the centimeters to inches.
            return (decimal)(mostRecentMeasure * 0.393701);
        }

        //Start the device, collect measurements, and record the measurements taken.
        public void StartCollecting()
        {
            timer.Start();
        }


        //Method that makes time pass and captures at that point.
        private void TimerTick(object sender, EventArgs e)
        {
            mostRecentMeasure = GetMeasurement();

            // Always push the most recent data on top of the list
            for (int i = dataCaptured.Length - 1; i > 0; i--)
                dataCaptured[i] = dataCaptured[i - 1];

            dataCaptured[0] = mostRecentMeasure;
        }

        //Stop the device and collecting measurements
        public void StopCollecting()
        {
            timer.Stop();
        }

 
        //From most recently collected data to oldest data collected, raw data is displayed.
        public int[] GetRawData()
        {
            // Count how many data is there 
            int size = 0;

            for (int i = 0; i < dataCaptured.Length; i++)
                if (dataCaptured[i] != 0)
                    size++;

            int[] data = new int[size];
            
            for (int i = 0; i < size; i++)
                data[i] = dataCaptured[i];

            return data; 
        }
    }
}
