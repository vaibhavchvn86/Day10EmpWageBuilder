using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9_LP_assignment
{
    class UC4_EmpW
    {
        public const int PartTime = 1;
        public const int FullTime = 2;
        public const int EmpWagePerHour = 20;
        public static void UC4()
        {
            int EmpHrs;
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
            int TotalDailyWage = EmpWagePerHour * EmpHrs;
            Console.WriteLine("Employee daily Wage is " + TotalDailyWage);
        }
    }
}
