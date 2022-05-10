using System;

namespace EmployeeWagesUsingSwitchCase
{
    internal class Program
    {
        public int EmpHour = 0;
        public int WagesPerHour = 20;
        public const int IsFullTime = 1;
        public const int IsPartTime = 2;
        public int EmployeeWages()
        {
            Random EmpType = new Random();
            int EmpCheck = EmpType.Next(0, 3);
            switch (EmpCheck)
            {
                case IsFullTime:
                    EmpHour = 8;
                    break;
                case IsPartTime:
                    EmpHour = 4;
                    break;
                default:
                    EmpHour = 0;
                    break;
            }
            int EmployeeWages = EmpHour * WagesPerHour;
            return EmployeeWages;
        }

        static void Main(string[] args)
        {
            Program wages = new Program();
            Console.WriteLine("wages:" + wages.EmployeeWages());
        }
    }
}
