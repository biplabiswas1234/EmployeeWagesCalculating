using System;

namespace EmployeeWageComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number what do you want to select:");
            Console.WriteLine("1: for checking Employee present or absent");
            Console.WriteLine("2: for Daily Employee Wage");
            Console.WriteLine("3: for Part time Employee Wage");
            Console.WriteLine("4: for Random Employee Wage Switch Case");
            Console.WriteLine("5: for Monthly Wages");
            Console.WriteLine("6: for Employee Wages for hours and days in a month");
            Console.WriteLine("7: for Employee Wage Method");
            Console.WriteLine("8: for Company wage using dictionary");
            

            int Check = Convert.ToInt32(Console.ReadLine());
            switch (Check)
            {
                case 1:
                    EmpPresentAbsent empPresentAbsent = new EmpPresentAbsent();
                    empPresentAbsent.CheckEmpPresentAbsent();
                    break;
                case 2:
                    DailyEmpWage dailyEmpWage = new DailyEmpWage();
                    dailyEmpWage.DailyWage();
                    break;
                case 3:
                    PartTimeEmpWage partTimeEmpWage = new PartTimeEmpWage();
                    partTimeEmpWage.PartTimeWage();
                    break;
                case 4:
                    EmpWageSwitch empWageSwitch = new EmpWageSwitch();
                    empWageSwitch.EmpWage();
                    break;
                case 5:
                    MonthlyWages monthlyWages = new MonthlyWages();
                    monthlyWages.MonthWage();
                    break;
                case 6:
                    EmpWageHrsDays empWageHrsDays = new EmpWageHrsDays();
                    empWageHrsDays.CalcWage();
                    break;
                case 7:
                    EmpWageMethod empWageMethod = new EmpWageMethod();
                    empWageMethod.CalculateWage();
                    break;
                case 8:
                    EmpWageComputation empWageComputation = new EmpWageComputation();
                    empWageComputation.AddCompany("TATA", 20, 8, 4, 100, 20);
                    empWageComputation.CalcEmpWage("tata");
                    empWageComputation.AddCompany("MAHINDRA", 30, 8, 4, 200, 20);
                    empWageComputation.CalcEmpWage("mahindra");
                    break;
                case 9:
                    CompanyWage_Computation companyWageComputation = new CompanyWage_Computation();
                    companyWageComputation.Add_Company("TATA", 20, 8, 4, 100, 20);
                    companyWageComputation.Calc_CompanyWage("tata");
                    companyWageComputation.Add_Company("MAHINDRA", 30, 8, 4, 200, 20);
                    companyWageComputation.Calc_CompanyWage("mahindra");
                    break;


            }
        }
    }
}
