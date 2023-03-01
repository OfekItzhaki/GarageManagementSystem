using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagementSystem.Models.Exceptions
{
    public class VehicleException : Exception
    {
        public VehicleException()
        {
        }

        public VehicleException(string message)
            : base(message)
        {
        }

        public VehicleException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
