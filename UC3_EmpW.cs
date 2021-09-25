using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9_LP_assignment
{
    class UC3_EmpW
    {
        public static void UC3()
        {
            int EmpWagePerHour = 20;
            int PartTimeHrs = 8;
            int TotalDailyWage;
            TotalDailyWage = EmpWagePerHour * PartTimeHrs;
            Console.WriteLine("Employee daily Wage is " + TotalDailyWage);
        }
    }
}
