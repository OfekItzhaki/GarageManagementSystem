using GarageManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GarageManagementSystem.Models
{
    [Serializable]
    public class Vehicle : IComparable<Vehicle>
    {
        public VehicleType Type { get; set;  }
        public string LicensePlate { get; set; }
        public string ProblemDescription { get; set; }
        public int ManufactureYear { get; set; }
        public Status CurrentStatus { get; set; }
        public FixingPrice Price { get; set; }

        public Vehicle() { }

        public Vehicle(VehicleType type, string licensePlate, string problemDescription, int manufactureYear)
        {
            Type = type;
            LicensePlate = licensePlate;
            ProblemDescription = problemDescription;
            ManufactureYear = manufactureYear;
            CurrentStatus = Status.New;
            Price = FixingPrice.Car;
        }

        public Vehicle(VehicleType type, string licensePlate, string problemDescription, int manufactureYear, FixingPrice fixingPrice, Status currentStatus) 
            : this(type, licensePlate, problemDescription, manufactureYear)
        {
            CurrentStatus = currentStatus;
            Price = fixingPrice;
        }

        public override string ToString()
        {
            var s = "";
            s += $"VehicleType: {Type}, ";
            s += $"LicensePlate: {LicensePlate}, ";
            s += $"ProblemDescription: {ProblemDescription}, ";
            s += $"ManufactureYear: {ManufactureYear}, ";
            s += $"CurrentStatus: {CurrentStatus}, ";
            s += $"Price: {Price}";
            return s;
        }

        public int CompareTo(Vehicle? other)
        {
            if (this.ManufactureYear < other.ManufactureYear)
                return -1;
            else if (this.ManufactureYear == other.ManufactureYear)
                return 0;
            else
                return 1;

        }
    }
}
