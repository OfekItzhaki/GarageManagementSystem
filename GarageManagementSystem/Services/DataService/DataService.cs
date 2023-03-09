using GarageManagementSystem.Models;
using GarageManagementSystem.Models.Enums;
using GarageManagementSystem.Models.Exceptions;
using GarageManagementSystem.Models.NullObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GarageManagementSystem.Services.DataService
{
    public class DataService : IDataService
    {
        public List<Vehicle> Vehicles { get; set; }
        public int TotalProfit { get; set; }

        public DataService()
        {
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                var workingDirectory = Environment.CurrentDirectory;
                var projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                var fileName = "DB.json";
                var fullPath = Path.Combine(projectDirectory, fileName);

                IFormatter formatter = new BinaryFormatter();
                var stream = new FileStream($@"{fullPath}", FileMode.OpenOrCreate, FileAccess.Read);
                if (stream.Length == 0)
                    Vehicles = new List<Vehicle> { new Vehicle() };
                else
                    Vehicles = (List<Vehicle>)formatter.Deserialize(stream);

                CalcTotalProfit();
                stream.Close();
            }
            catch (VehicleException err)
            {
                throw new VehicleException(err.Message);
            }
        }

        public void SaveData()
        {
            try
            {
                var workingDirectory = Environment.CurrentDirectory;
                var projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                var fileName = "DB.json";
                var fullPath = Path.Combine(projectDirectory, fileName);

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream($@"{fullPath}", FileMode.OpenOrCreate, FileAccess.Write);

                formatter.Serialize(stream, Vehicles);

                CalcTotalProfit();
                stream.Close();
            }
            catch (VehicleException err)
            {
                throw new VehicleException(err.Message);
            }
        }

        private void CalcTotalProfit()
        {
            var totalProfit = 0;
            for (int i = 0; i < Vehicles.Count; i++)
            {
                totalProfit += (int)Vehicles[i].Price;
            }

            TotalProfit = totalProfit;
        }

        public Vehicle GetVehicle(string licensePlate)
        {
            var vehicle = new NullVehicle();
            try
            {
                for (int i = 0; i < Vehicles.Count; i++)
                {
                    var current = Vehicles[i];

                    if (current.LicensePlate == licensePlate)
                    {
                        return current;
                    }
                }
            }
            catch (VehicleException err)
            {
                throw new VehicleException(err.Message);
            }

            return vehicle;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
            try
            {
                SaveData();
            }
            catch (VehicleException err)
            {
                throw new VehicleException(err.Message);
            }
        }

        public void UpdateVehicle(string licensePlate, Status status)
        {
            for (int i = 0; i < Vehicles.Count; i++)
            {
                var current = Vehicles[i];

                if (current.LicensePlate == licensePlate)
                {
                    Vehicles[i].CurrentStatus = status;
                }
            }

            try
            {
                SaveData();
            }
            catch (VehicleException err)
            {
                throw new VehicleException(err.Message);
            }
        }

        public void RemoveVehicle(string licensePlate)
        {
            for (int i = 0; i < Vehicles.Count; i++)
            {
                if (Vehicles[i].LicensePlate == licensePlate)
                    Vehicles.Remove(Vehicles[i]);
            }

            try
            {
                SaveData();
            }
            catch (VehicleException err)
            {
                throw new VehicleException(err.Message);
            }
        }
    }
}
