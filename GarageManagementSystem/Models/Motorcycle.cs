using GarageManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagementSystem.Models
{
    [Serializable]
    public class Motorcycle : Vehicle
    {
        public bool ExtraSeat { get; set; }
        public Motorcycle(VehicleType type, string licensePlate, string problemDescription, int manufactureYear, bool extraSeat)
            : base(type, licensePlate, problemDescription, manufactureYear)
        {
            ExtraSeat = extraSeat;
        }
    }
}
