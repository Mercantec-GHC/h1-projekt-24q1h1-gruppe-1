using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Models
{
    public class CreateProducts
    {
        public List<Headset> CreateListOfProducts()
        {
            List<Headset> AllProducts = new List<Headset>();

            // Existing headphones
            AllProducts.Add(new WiredHeadphones("Sony", "S1", "Black", "20-20000hz", false, "3.5m", false, "Closed", "New", 200));
            AllProducts.Add(new WiredHeadphones("Bose", "E2", "Silver", "20-30000hz", false, "3.5mm", true, "Closed", "New", 300));
            AllProducts.Add(new WiredHeadphones("Audeze", "LCD-X", "Black", "10-40000hz", false, "3.5mm", false, "Open", "Used", 1500));
            AllProducts.Add(new BluetoothHeadphones("JBL", "X1", "Black", "15-30000hz", true, "Bluetooth", true, "Closed", "New", 250));
            AllProducts.Add(new BluetoothHeadphones("Beats", "Y1", "Red", "25-20000hz", true, "Bluetooth", true, "Closed", "Refurbished", 315));
            AllProducts.Add(new BluetoothHeadphones("Bose", "Quiet Comfort", "White", "20-50000hz", true, "Bluetooth", true, "Open", "Used", 300));

            // Adding 20 more headphones with existing brand names
            AllProducts.Add(new WiredHeadphones("Sony", "S2", "White", "18-22000hz", true, "3.5mm", false, "Closed", "New", 250));
            AllProducts.Add(new WiredHeadphones("Bose", "SoundSport", "Blue", "20-20000hz", true, "3.5mm", true, "Open", "New", 120));
            AllProducts.Add(new BluetoothHeadphones("Beats", "Studio3", "Black", "20-20000hz", true, "Bluetooth", true, "Closed", "Used", 280));
            AllProducts.Add(new BluetoothHeadphones("Bose", "Sport Earbuds", "Black", "20-20000hz", true, "Bluetooth", true, "Closed", "New", 200));
            AllProducts.Add(new WiredHeadphones("Sony", "WH-1000XM3", "Black", "4-40000hz", true, "3.5mm", false, "Closed", "New", 300));
            AllProducts.Add(new WiredHeadphones("Bose", "QuietComfort 35 II", "Silver", "20-20000hz", true, "3.5mm", false, "Closed", "Used", 280));
            AllProducts.Add(new BluetoothHeadphones("Beats", "Powerbeats Pro", "Red", "20-20000hz", true, "Bluetooth", true, "Closed", "New", 250));
            AllProducts.Add(new BluetoothHeadphones("Bose", "SoundLink Color II", "Blue", "20-20000hz", true, "Bluetooth", true, "Closed", "Used", 150));
            AllProducts.Add(new WiredHeadphones("Sony", "MDR7506", "Black", "10-20000hz", true, "3.5mm", true, "Closed", "New", 130));
            AllProducts.Add(new WiredHeadphones("Bose", "SoundTrue Ultra", "Charcoal", "20-20000hz", true, "3.5mm", false, "Closed", "New", 180));
            AllProducts.Add(new BluetoothHeadphones("Beats", "BeatsX", "Black", "20-20000hz", true, "Bluetooth", true, "Closed", "New", 100));
            AllProducts.Add(new BluetoothHeadphones("Bose", "SoundSport Free", "Black", "20-20000hz", true, "Bluetooth", true, "Closed", "New", 200));
            AllProducts.Add(new WiredHeadphones("Sony", "WH-CH510", "White", "20-20000hz", true, "3.5mm", true, "Closed", "New", 60));
            AllProducts.Add(new WiredHeadphones("Bose", "SoundTrue", "Charcoal", "20-20000hz", true, "3.5mm", false, "Closed", "New", 120));
            AllProducts.Add(new BluetoothHeadphones("Beats", "Beats Solo Pro", "Gray", "20-20000hz", true, "Bluetooth", true, "Closed", "New", 300));
            AllProducts.Add(new BluetoothHeadphones("Bose", "SoundSport Pulse", "Red", "20-20000hz", true, "Bluetooth", true, "Closed", "New", 150));
            AllProducts.Add(new WiredHeadphones("Sony", "MDR-Z1R", "Black", "4-120000hz", true, "6.35mm", false, "Closed", "New", 2000));
            AllProducts.Add(new WiredHeadphones("Bose", "AE2", "Black", "20-20000hz", true, "3.5mm", false, "Closed", "New", 100));
            AllProducts.Add(new BluetoothHeadphones("Beats", "Beats Flex", "Black", "20-20000hz", true, "Bluetooth", true, "Closed", "New", 50));

            return AllProducts;
        }
    }
}