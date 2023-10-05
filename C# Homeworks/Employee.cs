using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Homeworks
{
    class Employee
    {
        public string fullName;
        public string start;
        private int salary;

        public Employee(string fullName, string start, int salary) 
        { 
            this.fullName = fullName;
            this.start = start;
            this.salary = salary;
        }

        public string FullName
        {
            get { return fullName; }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Lütfen bir isim giriniz!");
                }
                else
                {
                    start = value;
                }
            }
        }

        public string Start
        {
            get { return start; }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Lütfen bir tarih giriniz!");
                }else
                {
                     start = value; 
                }
            }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
