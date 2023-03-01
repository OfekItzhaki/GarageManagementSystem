using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagementSystem.Models.Enums
{
    public enum VehicleType
    {
        Motorcycle = 0,
        Car = 1,
        Truck = 2,
    }

    public enum Status
    {
        New = 0,
        InProcess = 1,
        Fixed = 2,
        Released = 3,
    }

    public enum FixingPrice
    {
        Motorcycle = 1000,
        Car = 2000,
        Truck = 5000,
    }
}
