using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeekFourClosingTask
{
    public abstract class BaseMachine
    {
        // ▼ Properties of BaseClass which common for telephone and computer objects ▼ 
        public DateTime ProductionDate { get; set; }
        public static int serialKey;
        public string SerialNumber { get; set; }
        public string ProductName { get; set; }
        public string ProductExplanation { get; set; }
        public string OpSystem { get; set; }

        // ▼ Baseclass ctor for production date ▼
        public BaseMachine()
        {
            this.ProductionDate = DateTime.Now;
        }

        //▼ Serial Number Auto Creator ▼
        public static int SerialNumberCreator()
        {
           return ++serialKey;
        }

        // ▼ Virtual method in BaseClass for overriding - Polymorphism
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Production Date: {ProductionDate}\nSerial Number:{SerialNumber}\nProduction Name:{ProductName}\nProduction explanation:{ProductExplanation}\nOP System:{OpSystem}");
        }

        // ▼ Abstract method for abstraction ▼
        public abstract void GetName();
    }
}
