using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePresentAbsent
{
    public class Program
    {
        public int EmpPresent = 1;
        public int FullDayHour = 8;
        public int WagesPerHour = 20;
        public void CheckEmpPresentAbsent()
        {
            Random check = new Random();
            int CheckEmp = check.Next(0, 2);

            if (EmpPresent == CheckEmp)
            {
                Console.WriteLine("Employee is Present");
                int DailyWages = FullDayHour * WagesPerHour;
                Console.WriteLine("DailyWages: " + DailyWages);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("Employee has no wages");
            }
        }
        public static void Main(string[] args)
        {
            Program Obj = new Program();
            Obj.CheckEmpPresentAbsent();
        }
    }
}