using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9_LP_assignment
{
    class UC5_EmpW
    {
        public const int PartTime = 1;
        public const int FullTime = 2;
        public const int EmpWagePerHour = 20;
        public const int WorkingDaysPerMonth = 20;
        public static void UC5()
        {
            int TotalEmpWage=0;
            int EmpHrs;
            int EmpWage;
            for (int day = 1; day < WorkingDaysPerMonth; day++)
            {
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
                EmpWage = EmpHrs * EmpWagePerHour;
                TotalEmpWage += EmpWage;
                Console.WriteLine("Employee daily Wage is " +EmpWage);
            }
            Console.WriteLine("Employee Monthly Wage is " + TotalEmpWage);
        }
    }
}
