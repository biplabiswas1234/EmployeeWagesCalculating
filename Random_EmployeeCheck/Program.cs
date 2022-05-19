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
            Console.WriteLine("9: for Total company wage");
            Console.WriteLine("10: for Multiple company total wages");
            Console.WriteLine("11: for Multiple company total wages using Interface");
            Console.WriteLine("12: for Multiple company total wages using Interface and ArrayList");
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
                case 10:
                    WageComputation computation = new WageComputation(3);
                    computation.AddCompany("TATA", 20, 8, 4, 100, 20);
                    computation.WageCalculation("tata");
                    computation.AddCompany("MAHINDRA", 30, 8, 4, 200, 20);
                    computation.WageCalculation("mahindra");
                    computation.AddCompany("HONDA", 20, 9, 5, 150, 20);
                    computation.WageCalculation("honda");
                    computation.ViewWage();
                    break;
                case 11:
                    Wage_Computation wagecompute = new Wage_Computation(3);
                    wagecompute.AddCompany("TATA", 20, 8, 4, 100, 20);
                    wagecompute.WageCalculation("tata");
                    wagecompute.AddCompany("MAHINDRA", 30, 8, 4, 200, 20);
                    wagecompute.WageCalculation("mahindra");
                    wagecompute.AddCompany("HONDA", 20, 9, 5, 150, 20);
                    wagecompute.WageCalculation("honda");
                    wagecompute.ViewWage();
                    break;
                case 12:
                    Wages_Computation wages_Computation = new Wages_Computation();
                    wages_Computation.AddCompany("TATA", 20, 8, 4, 100, 20);
                    wages_Computation.WageCalculation("tata");
                    wages_Computation.AddCompany("MAHINDRA", 30, 8, 4, 200, 20);
                    wages_Computation.WageCalculation("mahindra");
                    wages_Computation.AddCompany("HONDA", 20, 9, 5, 150, 20);
                    wages_Computation.WageCalculation("honda");
                    wages_Computation.ViewWage();
                    break;
                default:
                    Console.WriteLine("Please enter a correct number!");
                    break;

            }
        }
    }
}