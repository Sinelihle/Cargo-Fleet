using System;
using System.Collections.Generic;

namespace CustomClassLibrary
{
    class Vehicle_Administration
    {

        public List<string> dailyAppointmentList = new List<string>();
        public List<string> weeklyAppointmentList = new List<string>();

        private DateTime appointment_Time { get; set; }
        private string vehicleNumber { get; set; }
        private string servicePerfomerd { get; set; }
        private string procedureDescription { get; set; }

        public List<string> compileDailyAppointmentLst(DateTime _appointment_Time, string vehicleNumber, string _servicePerfomerd, string _procedureDescription) 
        {
            //Compile list object of vehicles adiministered daily 
            List<string> DailyAppointmentLst = new List<string>();


            return DailyAppointmentLst;
        }

        public List<string> compileWeeklyAppointmentLst(DateTime _appointment_Time, string vehicleNumber, string _servicePerfomerd, string _procedureDescription)
        {
            //Compile list object of vehicles adiministered daily 
            List<string> WeeklyAppointmentLst = new List<string>();


            return WeeklyAppointmentLst;
        }

    }
}
