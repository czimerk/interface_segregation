using HomeAirCond.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAirCond.Interfaces
{
    interface IWBAirCond : IWifiAirCond, IBluetoothAirCond
    {
    }
}
