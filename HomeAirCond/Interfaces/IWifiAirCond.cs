using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAirCond.Interfaces
{
    interface IWifiAirCond
    {
        bool ConnectWifi(string ssid, string password);
        WifiResponse ReceiveControlMessage(float temperature, DeviceState state);
    }
}
