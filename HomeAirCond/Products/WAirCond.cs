using HomeAirCond.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAirCond.Products
{
    //Air conditioner with wifi
    public class WAirCond : AirCond, IWifiAirCond
    {
        public bool ConnectWifi(string ssid, string password)
        {
            var success = true;
            //....
            return success;
        }

        public WifiResponse ReceiveControlMessage(float temperature, DeviceState state)
        {
            SetTemperature(temperature);
            SetState(state);
            //....
            
            return new WifiResponse();
        }
    }
}
