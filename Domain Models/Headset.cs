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
        public Headset(string brand, string model,string color,string frequencyRange,bool microphone,string typeOfConnection,bool noiseCancellation,string closeOrOpen,string itemCondition)
        {
            Brand = brand;
            Model = model;
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

        private string Model;

        public string getModel()
        {
           return Model;
        }

        private string Color;
        public string getColor()
        {
            return Color;
        }

        private string FrequencyRange;
        public string getFrequencyRange()
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

    public class WiredHeadphones : Headset
    {
        public WiredHeadphones(string brand, string model, string color, string frequencyRange, bool microphone,
           string typeOfConnection, bool noiseCancellation, string closeOrOpen, string itemCondition, string cableType)
           : base(brand, model, color, frequencyRange, microphone, typeOfConnection, noiseCancellation, closeOrOpen, itemCondition)
        {
            Cabletype = cableType;
        }

        private string Cabletype {set; get; }

        public string GetCabletype() 
        {
            return Cabletype; 
        }  
    }

    public class BluetoothHeadphones : Headset
    {
        public BluetoothHeadphones(string brand, string model, string color, string frequencyRange, bool microphone,
            string typeOfConnection, bool noiseCancellation, string closeOrOpen, string itemCondition, double bluetoothVersion) 
            : base (brand,model, color, frequencyRange, microphone, typeOfConnection, noiseCancellation, closeOrOpen, itemCondition)
        {
            BluetoothVersion = bluetoothVersion;
        }

        //Double da bluetooth kan være f.eks. 5.3
        private double BluetoothVersion { set; get; }

        public double GetBluetoothVersion()
        {
            return BluetoothVersion; 
        }
    }
}


