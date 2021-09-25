using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_LP_assignment.UC10
{
    class UC10_EmpWBuilderArray
    {
        public const int PartTime = 1;
        public const int FullTime = 2;

        public int NumofCompany = 0;
        private UC10_CompanyEmpWage[] CompanyWageArray;

        public UC10_EmpWBuilderArray()
        {
            this.CompanyWageArray = new UC10_CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(string Company, int EmpRatePerHr, int TotalWorkingDays, int TotalWorkingHrs)
        {
            CompanyWageArray[this.NumofCompany] = new UC10_CompanyEmpWage(Company, EmpRatePerHr, TotalWorkingDays, TotalWorkingHrs)
            NumofCompany++;
        }
        public void computeWage()
        {
            for (int i = 0; i < NumofCompany; i++)
            {
                CompanyWageArray[i].setTotalEmpWage(this.computeEmpWage(this.CompanyWageArray[i]));
                Console.WriteLine(this.CompanyWageArray[i].toString());
            }
        }
        private int computeEmpWage(UC10_CompanyEmpWage companyEmpWage)
        {
            int EmpHrs = 0, TotalEmpHrs = 0, TotalWorkingDay = 0;
            while (TotalEmpHrs <= companyEmpWage.TotalWorkingHrs && TotalWorkingDay < companyEmpWage.TotalWorkingDays)
            {
                TotalWorkingDay++;
                Random R = new Random();
                int EmpCheck = R.Next(0, 3);
                switch (EmpCheck)
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
                TotalEmpHrs += EmpHrs;
                Console.WriteLine("days: " + TotalWorkingDay + " EmpHrs " + EmpHrs);
            }
            return TotalEmpHrs * companyEmpWage.EmpRatePerHr;
        } 
    }
}
