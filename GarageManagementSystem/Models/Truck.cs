using GarageManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagementSystem.Models
{
    [Serializable]
    public class Truck : Vehicle
    {
        public int WeightLimit { get; set; }
        public Truck(VehicleType type, string licensePlate, string problemDescription, int manufactureYear, int weightLimit)
            : base(type, licensePlate, problemDescription, manufactureYear)
        {
            WeightLimit = weightLimit;
        }
    }
}
