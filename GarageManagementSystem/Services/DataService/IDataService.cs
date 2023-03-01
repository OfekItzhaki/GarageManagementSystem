using GarageManagementSystem.Models;
using GarageManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagementSystem.Services.DataService
{
    public interface IDataService
    {
        public List<Vehicle> Vehicles { get; set; }
        public int TotalProfit { get; set; }
        public void LoadData();
        public void SaveData();
        public Vehicle GetVehicle(string licensePlate);
        public void AddVehicle(Vehicle vehicle);
        public void UpdateVehicle(string licensePlate, Status status);
        public void RemoveVehicle(string licensePlate);
    }
}
