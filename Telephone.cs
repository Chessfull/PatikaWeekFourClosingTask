using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeekFourClosingTask
{
    public class Telephone:BaseMachine
    {
        // ▼ Derived properties ▼
        public bool TurkeyLicenseCheck { get; set; }

        // ▼ ctor for defining features while creating instance of object ▼
        public Telephone(string productname,string productexplanation,string opsystem, bool trlicensecheck)
        {
            ProductName = productname;
            ProductExplanation = productexplanation;
            OpSystem = opsystem;
            TurkeyLicenseCheck = trlicensecheck;

            // ▼ For creating auto serial number increase 1 by 1
            SerialNumber =ProductName+SerialNumberCreator();
        }

        // ▼ Override DisplayInfo - Polymorphism ▼
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Turkey License:{TurkeyLicenseCheck}");
        }

        // ▼ Abstraction from base class ▼
        public override void GetName()
        {
            Console.WriteLine("Your phone name: "+ProductName);
        }
    }
}
