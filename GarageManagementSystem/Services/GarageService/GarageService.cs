using GarageManagementSystem.Models;
using GarageManagementSystem.Models.Enums;
using GarageManagementSystem.Models.Exceptions;
using GarageManagementSystem.Services.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagementSystem.Services.GarageService
{
    public class GarageService : IGarageService
    {
        private IDataService _dataService;

        public GarageService(IDataService dataService)
        {
            _dataService = dataService;
        }
        public void InsertVehicle(Vehicle vehicle)
        {
            try
            {
                _dataService.AddVehicle(vehicle);
            }
            catch (VehicleException err)
            {
                throw new VehicleException(err.Message);
            }
        }

        public void ChangeStatus(string licensePlate, Status status)
        {
            try
            {
                _dataService.UpdateVehicle(licensePlate, status);
            }
            catch (VehicleException err)
            {
                throw new VehicleException(err.Message);
            }
        }

        public List<Vehicle> GetVehiclesSortedByYear()
        {
            return _dataService.Vehicles.OrderBy((v) => v.ManufactureYear).ToList();
        }

        public int GetTotalProfit()
        {
            return _dataService.TotalProfit;
        }

        public void Exit()
        {
            try
            {
                _dataService.SaveData();
            }
            catch (VehicleException err)
            {
                throw new VehicleException(err.Message);
            }
        }
    }
}
