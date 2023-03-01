using GarageManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagementSystem.Models.NullObjects
{
    public class NullVehicle : Vehicle
    {
        public NullVehicle()
            : base(VehicleType.Car, "0", "problem", 0)
        {

        }
    }
}
