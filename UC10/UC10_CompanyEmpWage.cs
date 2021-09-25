using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_LP_assignment.UC10
{
    class UC10_CompanyEmpWage
    {
        public string Company;
        public int EmpRatePerHr;
        public int TotalWorkingDays;
        public int TotalWorkingHrs;
        public int TotalEmpWage;

        public UC10_CompanyEmpWage(string Company, int EmpRatePerHr, int TotalWorkingDays, int TotalWorkingHrs)
        {
            this.Company = Company;
            this.EmpRatePerHr = EmpRatePerHr;
            this.TotalWorkingDays = TotalWorkingDays;
            this.TotalWorkingHrs = TotalWorkingHrs;
        }
        public void setTotalEmpWage(int TotalEmpWage)
        {
            this.TotalEmpWage = TotalEmpWage;
        }
        public string toString()
        {
            return "Total Employee Wage For Company" + Company + " is " + TotalEmpWage;
        }
    }
}
