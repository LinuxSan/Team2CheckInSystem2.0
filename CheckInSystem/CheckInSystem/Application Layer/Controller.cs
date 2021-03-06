﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using CheckInSystem.Domain_Layer;

namespace CheckInSystem.Application_Layer
{
    public class Controller
    {
        public CheckInRepo CheckInRepo = new CheckInRepo();
        public EmployeeRepo employeesRepo = new EmployeeRepo();
        public Person CurrentPerson;
        
        public bool VerifyPin(string pinCode)
        {
            //Checks if the parameter pinCode matches PinCode property in employees list.            
            foreach(Employee employee in employeesRepo.employees)
            {
                if (pinCode == employee.PinCode)
                {
                    CurrentPerson = new Employee();
                    CurrentPerson = employee;
                    
                    return true;
                }               
            }
            return false;          
        }
        public void UpdateCheckInTime()
        {

        }

        public void AssignMood(Mood mood)
        {
            CheckIn newCheckIn = new CheckIn();
            newCheckIn.mood = mood;
            newCheckIn.person = CurrentPerson;
            CheckInRepo.CheckIn(newCheckIn);
        }
    }
}
