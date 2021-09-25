using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9_LP_assignment
{
    class UC1_EmpW
    {
        public static void UC1()
        {
            int Present = 1;
            int absent = 2;
            Random Attend = new Random();
            int Attendance = Attend.Next(1, 3);
            if (Attendance == 1)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }

        }
    }

