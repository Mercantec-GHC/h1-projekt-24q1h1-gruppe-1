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
            new WiredHeadphones("Sony", "Black", 20000, false, "3.5m", false, "Closed", "New", "Detachable"),
            new WiredHeadphones("Bose", "Silver", 22000, false, "3.5mm", true, "Closed", "New", "Integrated"),
            new WiredHeadphones("Audeze","Black",40000,false,"3.5mm", false, "Open", "Used","Detachable"),
            new BluetoothHeadphones("JBL", "Black", 20000, true, "Bluetooth", true, "Closed", "New", 5.0),
            new BluetoothHeadphones("Beats", "Red", 22000, true, "Bluetooth", true, "Closed", "Refurbished", 4.2),
            new BluetoothHeadphones("Bose", "White", 18000, true, "Bluetooth", true, "Open", "Used", 5.1),
    };
    }
}
