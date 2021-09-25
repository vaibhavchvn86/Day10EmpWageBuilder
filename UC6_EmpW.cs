using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9_LP_assignment
{
    class UC6_EmpW
    {
        public const int PartTime = 1;
        public const int FullTime = 2;
        public const int EmpWagePerHour = 20;
        public const int WorkingDaysPerMonth = 20;
        public const int TotalWorkingHours = 100;
        public static void UC6()
        {
            int TotalEmpWage = 0;
            int EmpHrs;
            int workingday = 0;
            int workingHrs = 0;
            while (workingday < WorkingDaysPerMonth && workingHrs <= TotalWorkingHours)
            {
                workingday++;
                Random Attend = new Random();
                int Attendance = Attend.Next(0, 3);
                switch (Attendance)
                {
                    case PartTime:
                        EmpHrs = 4;
                        break;
                    case FullTime:
                        EmpHrs = 8;
                        break;
                    default:
                        EmpHrs = 0;
                        break;
                }
                workingHrs += EmpHrs;
                Console.WriteLine("Employee days: " +workingday + " EmpHrs: "+EmpHrs);
            }
            TotalEmpWage = workingHrs * EmpWagePerHour; 
            Console.WriteLine("Employee Monthly Wage is " + TotalEmpWage);
        }
    }
}
