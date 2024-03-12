using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Models
{
    public abstract class Headset
    {
        public Headset(string brand,string color,int frequencyRange,bool microphone,string typeOfConnection,bool noiseCancellation,string closeOrOpen,string itemCondition)
        {
            Brand = brand;
            Color = color;
            FrequencyRange = frequencyRange;
            Microphone = microphone;
            TypeOfConnection = typeOfConnection;
            NoiseCancellation = noiseCancellation;
            CloseOrOpen = closeOrOpen;
            ItemCondition = itemCondition;
        }
        private string Brand;

        public string getBrand()
        {
            return Brand;
        }

        private string Color;
        public string getColor()
        {
            return Color;
        }

        private int FrequencyRange;
        public int getFrequencyRange()
        {
            return FrequencyRange;
        }

        private bool Microphone;
        public bool getMicrophone()
        {
            return Microphone;
        }

        private string TypeOfConnection;
        public string getTypeOfConnection()
        {
            return TypeOfConnection;
        }

        private bool NoiseCancellation;
        public bool getNoiseCanellation()
        {
            return NoiseCancellation;
        }

        private string CloseOrOpen;
        public string getCloseOrOpen()
        {
            return CloseOrOpen;
        }

        private string ItemCondition;
        public string getItemCondition()
        {
            return ItemCondition;
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
