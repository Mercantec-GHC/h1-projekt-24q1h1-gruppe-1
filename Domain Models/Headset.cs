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
        public uint Id { get; set; }
        private static uint lastId = 0;
        public string Url { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public string frequencyRange { get; set; }
        public bool microphone { get; set; }
        string typeOfConnection { get; set; }
        bool noiseCancellation { get; set; }
        string closeorOpen { get; set; }
        string itemCondition { get; set; }
        string cableType { get; set; }

        public Headset(string brand, string model, string color, string frequencyRange, bool microphone, string typeOfConnection, bool noiseCancellation, string closeOrOpen, string itemCondition, string cableType)
        {
            this.Url = $"headset/{lastId}";
            Id = lastId++;
            this.brand = brand ;
            this.model = model ;
            this.color = color ;
            this.frequencyRange = frequencyRange ;
            this.microphone = microphone ;
            this.typeOfConnection = typeOfConnection ;
            this.noiseCancellation = noiseCancellation ;
            this.closeorOpen = closeOrOpen ;
            this.itemCondition = itemCondition ;
            this.cableType = cableType ;
        }

        public virutal void DisplayHeadsets()
        {
            Console.WriteLine($"{this.brand}");
            Console.WriteLine($"{this.model}");
            Console.WriteLine($"{this.color}");
            Console.WriteLine($"{this.frequencyRange}");
            Console.WriteLine($"{this.microphone}");
            Console.WriteLine($"{this.typeOfConnection}");
            Console.WriteLine($"{this.noiseCancellation}");
            Console.WriteLine($"{this.closeorOpen}");
            Console.WriteLine($"{this.itemCondition}");
            Console.WriteLine($"{this.cableType}");

        }
    } 
    
    public class WiredHeadphones : Headset
    {
        public WiredHeadphones(string brand, string model, string color, string frequencyRange, bool microphone,
           string typeOfConnection, bool noiseCancellation, string closeOrOpen, string itemCondition, string cableType)
           : base(brand, model, color, frequencyRange, microphone, typeOfConnection, noiseCancellation, closeOrOpen, itemCondition)
        {

        }
      
    }

     public class BluetoothHeadphones : Headset
     {
        public double bluetoothVersion { get; set; }

        public BluetoothHeadphones(string brand, string model, string color, string frequencyRange, bool microphone,
            string typeOfConnection, bool noiseCancellation, string closeOrOpen, string itemCondition, double bluetoothVersion) 
            : base (brand,model, color, frequencyRange, microphone, typeOfConnection, noiseCancellation, closeOrOpen, itemCondition)
        {

        }
        public override void DisplayHeadsets()
        {
            base.DisplayHeadsets()
            Console.WriteLine($"This headset comes with {bluetoothVersion}");
        }

     
     }
}



