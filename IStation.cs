using System;
using System.Collections.Generic;

namespace refuelingstationforgarywholesalegarage {
    public interface IStation <T>
    {
        int Capacity { get; set; }
        void Refuel (List <T> Vehicles);
    }
}