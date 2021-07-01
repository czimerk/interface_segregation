using HomeAirCond.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAirCond.Products
{
    //Air conditioner with bluetooth, no wifi
    internal class BAirCond : AirCond, IBluetoothAirCond
    {
       
        public bool ConnectBluetooth(string ssid, string password)
        {
            var success = true;
            //....
            return success;
        }

        public BluetoothResponse ReceiveControlMessage(float temperature, DeviceState state)
        {
            SetTemperature(temperature);
            SetState(state);
            //....
            
            return new BluetoothResponse();
        }

        
    }
}
