using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    internal class TotalWagesByCompayName
    {
        public string CompanyName;
        public int WagePerHr;
        public int FullHrPerDay;
        public int PartHrPerDay;
        public int MaxWorkHrs;
        public int MaxWorkDays;

        public TotalWagesByCompayName(string CompanyName, int WagePerHr, int FullHrPerDay, int PartHrPerDay, int MaxWorkHrs, int MaxWorkDays)
        {
            this.CompanyName = CompanyName;
            this.WagePerHr = WagePerHr;
            this.FullHrPerDay = FullHrPerDay;
            this.PartHrPerDay = PartHrPerDay;
            this.MaxWorkHrs = MaxWorkHrs;
            this.MaxWorkDays = MaxWorkDays;
        }

    }
    public interface IComputeEmployeeWage
    {
        public void AddCompany(string CompanyName, int WagePerHr, int FullHrPerDay, int PartHrPerDay, int MaxWorkHrs, int MaxWorkDays);
        public void WageCalculation(string CompanyName);
    }
    class CompanyWages_Computations : IComputeEmployeeWage
    {
        public const int FullTime = 1;
        public const int PartTime = 2;
        public Dictionary<string, TotalWagesByCompayName> Companies_Dict;
        public ArrayList Company_List;
        public int Company_Index = 0;

        public CompanyWages_Computations()
        {
            Companies_Dict = new Dictionary<string, TotalWagesByCompayName>();
            Company_List = new ArrayList();

        }

        public void AddCompany(string CompanyName, int WagePerHr, int FullHrPerDay, int PartHrPerDay, int MaxWorkHrs, int MaxWorkDays)
        {
            TotalWagesByCompayName company_obj = new TotalWagesByCompayName(CompanyName.ToLower(), WagePerHr, FullHrPerDay, PartHrPerDay, MaxWorkHrs, MaxWorkDays);
            Companies_Dict.Add(CompanyName.ToLower(), company_obj);
            Company_List.Add(CompanyName);
            Company_List.Add(WagePerHr * FullHrPerDay);

        }
        public int Check_Present()
        {
            return new Random().Next(1, 3);
        }
        public void WageCalculation(string CompanyName)
        {
            int HrPerDay = 0;
            int WagePerDay = 0;
            int PresentDays = 0;
            int TotalWorkHrs = 0;
            int MontlyWage = 0;

            if (!Companies_Dict.ContainsKey(CompanyName.ToLower()))
                throw new ArgumentNullException("Company doesn't exists");
            Companies_Dict.TryGetValue(CompanyName.ToLower(), out TotalWagesByCompayName company_obj);

            while (TotalWorkHrs < company_obj.MaxWorkHrs && PresentDays <= company_obj.MaxWorkDays)
            {
                switch (Check_Present())
                {
                    case FullTime:
                        HrPerDay = company_obj.FullHrPerDay;
                        PresentDays++;
                        break;
                    case PartTime:
                        HrPerDay = company_obj.PartHrPerDay;
                        PresentDays++;
                        break;
                    default:
                        HrPerDay = 0;
                        break;
                }
                TotalWorkHrs += HrPerDay;
                WagePerDay = (company_obj.WagePerHr * HrPerDay);
                MontlyWage += WagePerDay;
            }
            Company_List.Add(MontlyWage);

        }
        

        public void ViewWage(string CompanyName)
        {
        
            for (int i = 0; i < Company_List.Count; i += 3)
            {
                    if (String.Equals(CompanyName, (Company_List[i])))
                    {
                    Console.WriteLine("company:" + CompanyName + "==" + Company_List[i]);
                    Console.WriteLine("Dailywage:" + Company_List[i + 1]);
                    Console.WriteLine("Toatal wages: " + Company_List[i + 2]);
                    }
                    //Console.WriteLine("Daily wage and Montly Wage for {0} is {1} and {2}\n", Company_List[i], Company_List[i + 1], Company_List[i + 2]);
            }
        }
        
    }
}
