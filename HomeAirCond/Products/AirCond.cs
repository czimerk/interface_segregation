using HomeAirCond.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAirCond.Products
{
    public class AirCond : IAirCond
    {
        public int ProducedYear { get; set; }
        public string Serial { get; set; }
        public string Model { get; set; }

        private DeviceState _state;
        private float _temperature;

        internal AirCond()
        {
            _state = DeviceState.Off;
        }

        public void SetState(DeviceState state)
        {
            _state = state;
        }

        public void SetTemperature(float newTemperature)
        {
            _temperature = newTemperature;
        }
    }
}
