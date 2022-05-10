using System;

namespace Day3PracticeProblem1UC4
{
    internal class Program
    {
        public int EmpHour = 0;
        public int WagesPerHour = 20;
        public const int IsFullTime = 1;
        public const int IsPartTime = 2;
        public int EmployeeDay = 1;
        public int TotalWages = 0;
        public int EmployeeWages()
        {
            while (EmployeeDay <= 20)
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

                int EmpWages = EmpHour * WagesPerHour;
                TotalWages += EmpWages;
                EmployeeDay++;

            }
            return TotalWages;
        }

        static void Main(string[] args)
        {
            Program wages = new Program();
            Console.WriteLine("wages of the month:" + wages.EmployeeWages());
        }
    }
}
