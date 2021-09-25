using Day10_LP_assignment.UC10;
using Day4.UCLast_FinalSolution;
using System;

namespace Day_9_LP_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1_EmpW.UC1();
            //UC2_EmpW.UC2();
            //UC3_EmpW.UC3();
            //UC4_EmpW.UC4();
            //UC5_EmpW.UC5();
            //UC6_EmpW.UC6();
            //UC7_EmpW.ComputeUC7();
            //UC8_EmpW.ComputeUC8("Dmart",20,10,8);

            //#region UC9
            ////UC9_EmpW EmpWObj = new UC9_EmpW();
            //UC9_EmpWageBuilderObj Dmart = new UC9_EmpWageBuilderObj("Dmart", 10, 20, 10);
            //UC9_EmpWageBuilderObj Tata = new UC9_EmpWageBuilderObj("Tata", 15, 10, 15);
            //Dmart.compute();
            //Console.WriteLine(Dmart.toString());
            //Tata.compute();
            //Console.WriteLine(Tata.toString());
            //#endregion

            //#region UC10
            //UC10_EmpWBuilderArray EmpWageBuilder = new UC10_EmpWBuilderArray();
            //EmpWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            //EmpWageBuilder.addCompanyEmpWage("Tata", 10, 15, 20);
            //EmpWageBuilder.computeWage();
            //#endregion

            #region FinalSolution
            EmpWageBuilder empWageBuild = new EmpWageBuilder();
            empWageBuild.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuild.addCompanyEmpWage("Tata", 10, 4, 20);
            empWageBuild.computeEmpWage();
            #endregion
            Console.ReadKey();
        }
    }
}