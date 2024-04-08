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
        public string typeOfConnection { get; set; }
        public bool noiseCancellation { get; set; }
        public string closedOrOpen { get; set; }
        public string itemCondition { get; set; }
        public int price { get; set; }
        public string imageUrl { get; set; }
        public string description { get; set; }

        public Headset(string brand, string model, string color, string frequencyRange, bool microphone, string typeOfConnection, bool noiseCancellation, string closedOrOpen, string itemCondition, int price, string imageUrl, string description)
        {
            this.Url = $"headset/{lastId}";
            Id = lastId++;
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.frequencyRange = frequencyRange;
            this.microphone = microphone;
            this.typeOfConnection = typeOfConnection;
            this.noiseCancellation = noiseCancellation;
            this.closedOrOpen = closedOrOpen;
            this.itemCondition = itemCondition;
            this.price = price;
            this.imageUrl = imageUrl;
            this.description = description;
        }
    }

    public class WiredHeadphones : Headset
    {
        public WiredHeadphones(string brand, string model, string color, string frequencyRange, bool microphone,
           string typeOfConnection, bool noiseCancellation, string closedOrOpen, string itemCondition, int price, string imageUrl, string description)
           : base(brand, model, color, frequencyRange, microphone, typeOfConnection, noiseCancellation, closedOrOpen, itemCondition, price, imageUrl, description)
        {

        }
    }

    public class BluetoothHeadphones : Headset
    {
        public BluetoothHeadphones(string brand, string model, string color, string frequencyRange, bool microphone,
            string typeOfConnection, bool noiseCancellation, string closedOrOpen, string itemCondition, int price, string imageUrl, string description)
            : base(brand, model, color, frequencyRange, microphone, typeOfConnection, noiseCancellation, closedOrOpen, itemCondition, price, imageUrl, description)
        {

        }
    }
}