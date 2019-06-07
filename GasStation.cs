using System;
using System.Collections.Generic;

namespace refuelingstationforgarywholesalegarage {
    public class GasStation : IStation <CombustionEngine> {
        public int Capacity { get; set; }
        public void Refuel (List <CombustionEngine> Vehicles) {
            foreach(CombustionEngine v in Vehicles) {
                Console.WriteLine($"The {v.Name} has been refueled and has {v.WheelCount} wheels");
            }
        }
    }
}