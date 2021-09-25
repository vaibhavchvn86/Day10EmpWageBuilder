using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9_LP_assignment
{
    class UC8_EmpW
    {
        public const int PartTime = 1;
        public const int FullTime = 2;
        //public const int EmpWagePerHour = 20;
        //public const int WorkingDaysPerMonth = 20;
        //public const int TotalWorkingHours = 100;
        public static int ComputeUC8(string Company,int EmpWagePerHr,int TotalWorkingDays, int TotalWorkingHrs)
        {
            int TotalEmpWage = 0;
            int EmpHrs;
            int workingday = 0;
            int workingHrs = 0;
            while (workingday < TotalWorkingDays && workingHrs <= TotalWorkingHrs)
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
                Console.WriteLine("Employee days: " + workingday + " EmpHrs: " + EmpHrs);
            }
            TotalEmpWage = workingHrs * EmpWagePerHr;
            Console.WriteLine("Employee Monthly Wage is " + TotalEmpWage +" for Company "+Company);
            return TotalEmpWage;
        }
    }
}
