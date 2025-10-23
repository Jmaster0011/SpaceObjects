using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceObjects
{
    // Interface for scientific instruments on probes 
    public interface IInstrument
    {
        string InstrumentName { get; }
        bool IsActive { get; set; }
        string CollectData();
        double GetBatteryLevel();
        void RechargeBattery(double amount);
    }
}
