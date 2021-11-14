using System;
using System.Collections.Generic;
using System.Text;

namespace CustomClassLibrary
{
    class Vehicle_Configuration
    {
        public List<string> lstVehicles = new List<string>();

        private string vehicleNumber { get; set; }
        private int registration_Number { get; set; }
        private string vehicleType { get ; set; }
        private string manufacture { get; set; }
        private double engineSize { get; set; }
        private double odometre_Reading { get; set; }

        public List<string> compileVehicleLst(string _vehicleNumber, int _registration_Number, string _vehicleType, string _manufacture, double _engineSize, double odometre_Reading) 
        {
            //Compile list of vehicle objects
            List<string> VehicleLst = new List<string>();

            return VehicleLst;
        }
    }
}
