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

            AllProducts.Add(new WiredHeadphones("Sony", "S1", "Black", "20-20000hz", false, "3.5m", false, "Closed",
                    "New", 200)
                { });
            AllProducts.Add(new WiredHeadphones("Bose", "E2", "Silver", "20-30000hz", false, "3.5mm", true, "Closed", "New", 300)
                { });
            AllProducts.Add(new WiredHeadphones("Audeze", "LCD-X", "Black", "10-40000hz", false, "3.5mm", false, "Open", "Used", 1500)
                { });
            AllProducts.Add(new BluetoothHeadphones("JBL", "X1", "Black", "15-30000hz", true, "Bluetooth", true, "Closed", "New", 250)
                { });
            AllProducts.Add(new BluetoothHeadphones("Beats", "Y1", "Red", "25-20000hz", true, "Bluetooth", true, "Closed", "Refurbished", 315)
                { });
            AllProducts.Add(new BluetoothHeadphones("Bose", "Quiet Comfort", "White", "20-50000hz", true, "Bluetooth", true, "Open", "Used", 300)
                { });

            return AllProducts;
        }
    }
}