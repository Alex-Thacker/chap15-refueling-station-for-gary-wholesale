using System;
using System.Collections.Generic;

namespace refuelingstationforgarywholesalegarage {
    public class BatteryStation : IStation <BatteryEngine> {
        public int Capacity { get; set; }
        public void Refuel (List <BatteryEngine> Vehicles) {
            foreach(BatteryEngine v in Vehicles) {
                Console.WriteLine($"The {v.Name} has been refueled");
            }
        }
    }
}