using System;
using System.Collections.Generic;

namespace refuelingstationforgarywholesalegarage
{
    class Program
    {
        static void Main(string[] args)
        {
            CombustionEngine Civic = new CombustionEngine () {
                Name = "civic",
                WheelCount = 6
            };

            CombustionEngine NotCivic = new CombustionEngine () {
                Name = "notCivic",
                WheelCount = 0
            };

            List <CombustionEngine> GasPowerList = new List<CombustionEngine> () {
                Civic, NotCivic
            };

            BatteryEngine Tesla = new BatteryEngine () {
                Name = "tesssssslllalaaaaaaa",
                BatterySize = 10
            };

            BatteryEngine NotTesla = new BatteryEngine () { 
                Name = "notTesla", 
                BatterySize = 0
            };

            List <BatteryEngine> BatteryPowerList = new List<BatteryEngine> () {
                Tesla, NotTesla
            };

            GasStation Shell = new GasStation () {
                Capacity = 2
            };

            Shell.Refuel(GasPowerList);

            BatteryStation ChargeStation = new BatteryStation () ;
            ChargeStation.Capacity = 2 ; 

            ChargeStation.Refuel(BatteryPowerList); 
        }
    }
}
