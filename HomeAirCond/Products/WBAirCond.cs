using HomeAirCond.Interfaces;

namespace HomeAirCond.Products
{
    public class WBAirCond : WAirCond, IWBAirCond
    {

        public bool ConnectBluetooth(string ssid, string password)
        {
            var success = true;
            //....
            return success;
        }

        //nem jó interface implementáció, mert elfedi az ősosztály metódusát
        //public BluetoothResponse ReceiveControlMessage(float temperature, DeviceState state)

        BluetoothResponse IBluetoothAirCond.ReceiveControlMessage(float temperature, DeviceState state)
        {
            SetState(state);
            SetTemperature(temperature);
            //...
            return new BluetoothResponse();
        }

    }
}
