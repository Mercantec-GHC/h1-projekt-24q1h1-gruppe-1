using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Models
{
    internal class HeadPhoneList
    {
        List<object> list = new List<object>
        {
            new WiredHeadphones("Sony", "S1","Black", "20-20000hz", false, "3.5m", false, "Closed", "New", "Detachable"),
            new WiredHeadphones("Bose","E2","Silver", "20-30000", false, "3.5mm", true, "Closed", "New", "Integrated"),
            new WiredHeadphones("Audeze","LCD-X", "Black","10-40000",false,"3.5mm", false, "Open", "Used","Detachable"),
            new BluetoothHeadphones("JBL","X1", "Black", "15-30000hz", true, "Bluetooth", true, "Closed", "New", 5.0),
            new BluetoothHeadphones("Beats","Y1", "Red", "25-20000hz", true, "Bluetooth", true, "Closed", "Refurbished", 4.2),
            new BluetoothHeadphones("Bose","Quiet Comfort", "White", "20-50000hz", true, "Bluetooth", true, "Open", "Used", 5.1),
    };
    }
}





