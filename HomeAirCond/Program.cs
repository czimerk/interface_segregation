using HomeAirCond.Interfaces;
using HomeAirCond.Products;
using System.Drawing;

namespace HomeAirCond
{
    class Program
    {
        static void Main(string[] args)
        {

            //1., az ac1 interface-én nincs Wifi connect
            IAirCond ac1 = new AirCond();
            ac1.SetState(DeviceState.On);

            //2., Wifis-Bluetooth-os klíma
            IWBAirCond ac = new WBAirCond();
            //többértelmű hívás. A fordító nem tudja eldönteni, melyiket hívja
            //BluetoothResponse aResponse = ac.ReceiveControlMessage(22.0f, DeviceState.On);
            
            BluetoothResponse bResponse = (ac as IBluetoothAirCond)
                .ReceiveControlMessage(22.0f, DeviceState.On);
            
            
            WifiResponse wResponse = (ac as IWifiAirCond)
                .ReceiveControlMessage(22.0f, DeviceState.On);

            //3., Led klíma, aminek nem kell feltétlen wifi-snek vagy bluetoothosnak lennie
            ILedAirCond ledAc = new LedAirCond();
            ledAc.SetLights(Color.FromArgb(90,60,90));
            //Erről jut eszembe.
            //2 IT-s beszélget:
            //Milyen az új barátnőd?
            //Tökéletes. 90-60-90.
            //Lila?
        }
    }
}
