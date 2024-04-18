using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Models
{
    public class Headset
    {
        public int id { get; set; }
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

        public Headset(int id, string brand, string model, string color, string frequencyRange, bool microphone, bool noiseCancellation, string closedOrOpen, string itemCondition, int price, string imageUrl, string description)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.frequencyRange = frequencyRange;
            this.microphone = microphone;
            this.noiseCancellation = noiseCancellation;
            this.closedOrOpen = closedOrOpen;
            this.itemCondition = itemCondition;
            this.price = price;
            this.imageUrl = imageUrl;
            this.description = description;
        }
    }
}