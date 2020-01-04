//Sabrina Turney
//C# II

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VirtualDevice
{
    public partial class MainWindow : Window
    {
        private IMeasuringDevice measuringDevice;
        private Units measuringDeviceUnit;


        //Initializing the app form:
        public MainWindow()
        {
            InitializeComponent();
            measuringDeviceUnit = Units.Imperial;
            measuringDevice = new MeasureLengthDevice(measuringDeviceUnit);
        }



        //To start and stop collecting data (the big button, the whole point!)
        private void startStopButton_Click(object sender, RoutedEventArgs e)
        {
            if(startStopButton.Content.Equals("Start Collecting Data"))
            {
                statusLabel.Content = "Collecting data...";
                startStopButton.Content = "Stop Collecting Data";
                measuringDevice.StartCollecting();
            }
            else
            {
                statusLabel.Content = "Stopped.";
                startStopButton.Content = "Start Collecting Data";
                measuringDevice.StopCollecting();
            }
        }


        //Show the most recent captured measurement:
        private void getMostRecentMeasurementButton_Click(object sender, RoutedEventArgs e)
        {

            //Changes based on Imperial vs Metric, as required.
            if (unitOfMeasurementComboBox.Text.Equals("Inches"))
            {
                recentMeasurementLabel.Content = measuringDevice.ImperialValue() + "in @ " + DateTime.Now;
            }
            else if(unitOfMeasurementComboBox.Text.Equals("Centimeters"))
            {
                recentMeasurementLabel.Content = measuringDevice.MetricValue() + "cm @ " + DateTime.Now;
            }
        }

 
        //Shows "raw data", AKA the "get" method's results.
        private void getRawDataButton_Click(object sender, RoutedEventArgs e)
        {
            int[] data = measuringDevice.GetRawData();
            decimal[] measurements = new decimal[data.Length];
            
            //Converts between Imperial vs Metric.
            for (int i = 0; i < data.Length; i++)
            {
                decimal measurement = data[i];

                if (unitOfMeasurementComboBox.Text.Equals("Inches") && measuringDeviceUnit != Units.Imperial)
                {
                    measurement = measurement * (decimal)0.393701;
                }
                else if(unitOfMeasurementComboBox.Text.Equals("Centimeters") && measuringDeviceUnit != Units.Metric)
                {
                    measurement = measurement * (decimal)2.54;
                }

                measurements[i] = measurement;
            }

            //Results show in my list box!
            rawDataListBox.Items.Clear();

            foreach (decimal measurement in measurements)
            {
                if (unitOfMeasurementComboBox.Text.Equals("Inches"))
                    rawDataListBox.Items.Add(measurement + "in");
                else if (unitOfMeasurementComboBox.Text.Equals("Centimeters"))
                    rawDataListBox.Items.Add(measurement + "cm");
            }
        }
    }
}
