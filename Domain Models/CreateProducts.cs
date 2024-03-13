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
                "New")
            { });
            AllProducts.Add(new WiredHeadphones("Bose", "E2", "Silver", "20-30000", false, "3.5mm", true, "Closed", "New")
            { });
            AllProducts.Add(new WiredHeadphones("Audeze", "LCD-X", "Black", "10-40000", false, "3.5mm", false, "Open", "Used")
            { });
            AllProducts.Add(new BluetoothHeadphones("JBL", "X1", "Black", "15-30000hz", true, "Bluetooth", true, "Closed", "New")
            { });
            AllProducts.Add(new BluetoothHeadphones("Beats", "Y1", "Red", "25-20000hz", true, "Bluetooth", true, "Closed", "Refurbished")
            { });
            AllProducts.Add(new BluetoothHeadphones("Bose", "Quiet Comfort", "White", "20-50000hz", true, "Bluetooth", true, "Open", "Used")
            { });

            return AllProducts;
        }
    }
}
