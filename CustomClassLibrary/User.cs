using System;
using System.Collections.Generic;
using System.Text;

namespace CustomClassLibrary
{
    class User
    {
        private string employeeRole;
        private string employeeResponsibility;

        public void setEmployeeRole(string _employeeRole)
        {
            employeeRole = _employeeRole;
        }

        public string getEmployeeRole() 
        {
            return employeeRole;
        }

        public void setEmployeeResponsibility(string _employeeResponsibility) 
        {
            employeeResponsibility = _employeeResponsibility;
        }

        public string getEmployeeResponsibility() 
        {
            return employeeResponsibility;
        }

        public void performTask(string _employeeRole, string _employeeResponsibility)
        {
            //Based on who the employee is this function will load the relevant page upon login in
        }

    }
}
