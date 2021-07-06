using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace HomeAirCond.Interfaces.Wrong
{
    interface IAirCond
    {
        void SetState(DeviceState state);
        void SetTemperature(float newTemperature);
        bool ConnectWifi(string ssid, string password);
        WifiResponse ReceiveControlMessage(float temperature, DeviceState state);
        void SetLights(Color c);

    }
}
