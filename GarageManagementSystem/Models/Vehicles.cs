//using GarageManagementSystem.Models.Exceptions;
//using GarageManagementSystem.Models.NullObjects;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace GarageManagementSystem.Models
//{
//    public class Vehicles
//    {
//        public List<Vehicle> VehicleList { get; set; }

//        public Vehicle this[string licensePlate] => FindVehicle(licensePlate);

//        private Vehicle FindVehicle(string licensePlate)
//        {
//            for (int i = 0; i < VehicleList.Count; i++)
//            {
//                var current = VehicleList[i];

//                if (current.LicensePlate == licensePlate)
//                {
//                    return current;
//                }
//            }

//            throw new VehicleException($"Vehicle with license plate {licensePlate} not found");
//        }
//    }
//}
