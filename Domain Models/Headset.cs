using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Models
{
    public abstract class Headset
    {
        private string brand;

        public string getBrand()
        {
            return brand;
        }

        private string color;
        public string getColor()
        {
            return color;
        }

        private int frequencyRange;
        public int getFrequencyRange()
        {
            return frequencyRange;
        }

        private bool microphone;
        public bool getMicrophone()
        {
            return microphone;
        }

        private string typeOfConnection;
        public string getTypeOfConnection()
        {
            return typeOfConnection;
        }

        private bool noiseCancellation;
        public bool getNoiseCanellation()
        {
            return noiseCancellation;
        }

        private string closeOrOpen;
        public string getCloseOrOpen()
        {
            return closeOrOpen;
        }

        private string itemCondition;
        public string getItemCondition()
        {
            return itemCondition;
        }

        public void getDetails()
        {
            Console.WriteLine("GetDetails");
        }
    }

    public class BluetoothHeadphones : Headset
    {
        public BluetoothHeadphones(string brand, string color, int frequencyRange, bool microphone,
            string typeOfConnection, bool noiseCancellation, string closeOrOpen, string itemCondition) 
            : base (brand, color, frequencyRange, microphone, typeOfConnection, noiseCancellation, closeOrOpen, itemCondition)
        {

        }
    }
}
