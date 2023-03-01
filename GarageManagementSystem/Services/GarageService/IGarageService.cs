using GarageManagementSystem.Models;
using GarageManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagementSystem.Services.GarageService
{
    public interface IGarageService
    {
        public void InsertVehicle(Vehicle vehicle);
        public void ChangeStatus(string licensePlate, Status status);
        public List<Vehicle> GetVehiclesSortedByYear();
        public int GetTotalProfit();
        public void Exit();
    }
}
