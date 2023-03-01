using GarageManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagementSystem.Models
{
    [Serializable]
    public class Car : Vehicle
    {
        public Car(VehicleType type, string licensePlate, string problemDescription, int manufactureYear) 
            : base(type, licensePlate, problemDescription, manufactureYear)
        {

        }
    }
}
