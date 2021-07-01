namespace HomeAirCond.Interfaces
{
    interface IAirCond
    {
        void SetState(DeviceState state);
        void SetTemperature(float newTemperature);
    }
}