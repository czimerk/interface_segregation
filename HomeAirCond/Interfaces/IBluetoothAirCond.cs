namespace HomeAirCond.Interfaces
{
    public interface IBluetoothAirCond
    {
        bool ConnectBluetooth(string ssid, string password);
        BluetoothResponse ReceiveControlMessage(float temperature, DeviceState state);
    }
}