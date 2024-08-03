using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeekFourClosingTask
{
    public class Computer : BaseMachine
    {
        // ▼ Derived properties ▼
        public int _usbPort;
        public int UsbPort // ▼ Checking '2' or '4' condition where instruction at task ▼
        {
            get { return this._usbPort; }
            set
            {
                if (value != 2 && value != 4)
                {
                    Console.WriteLine("Usb port can be only 2 or 4!");
                    this._usbPort = -1;
                }
                else
                {
                    this._usbPort = value;
                }
            }
        }
        public bool Bluetooth { get; set; }

        // ▼ ctor for defining features while creating instance of object ▼
        public Computer(string productname, string productexplanation, string opsystem, int usbcount, bool bluetooth)
        {
            ProductName = productname;
            ProductExplanation = productexplanation;
            OpSystem = opsystem;
            UsbPort = usbcount;
            Bluetooth = bluetooth;

            // ▼ For creating auto serial number increase 1 by 1
            SerialNumber = ProductName + SerialNumberCreator();
        }

        // ▼ Override DisplayInfo - Polymorphism ▼
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Count of Usb Port:{_usbPort}\nBluetooth:{Bluetooth}");
        }

        // ▼ Abstraction from base class ▼
        public override void GetName()
        {
            Console.WriteLine("Your computer name: " + ProductName);
        }
    }
}
