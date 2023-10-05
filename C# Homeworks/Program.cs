using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee ceyda = new Employee("Ceyda Yılmaz", "10 Aralık 2023", 20000);
            Employee sena = new Employee("Sena Arslan", "23 Kasım 2022", 23000);
            Employee zeynep = new Employee("Zeynep Bektaş", "23 Ocak 2021", 24000);
            Employee esra = new Employee("Esra Gümüşoğlu", "15 Mayıs 2023", 15000);
            Employee yusuf = new Employee("Yusuf Çağlar", "4 Ekim 2023", 30000);
            Employee alihan = new Employee("Alihan Uzun", "19 Eylül 2020", 12000);
            Employee mehmet = new Employee("Mehmet Kısa", "19 Temmuz 2022", 16500);
            Employee tuana = new Employee("Tuana Gümüş", "1 Ağustos 2020", 14000);
            Employee efe = new Employee("Efe Gökçek", "2 Nisan 2022", 18000);
            Employee deniz = new Employee("Deniz Dülgeroğlu", "5 Nisan 2021", 22750);


            Console.WriteLine(ceyda.FullName + " | " + ceyda.Start + " | " + ceyda.Salary);
            Console.WriteLine(sena.FullName + " | " + sena.Start + " | " + sena.Salary);
            Console.WriteLine(zeynep.FullName + " | " + zeynep.Start + " | " + zeynep.Salary);
            Console.WriteLine(esra.FullName + " | " + esra.Start + " | " + esra.Salary);
            Console.WriteLine(yusuf.FullName + " | " + yusuf.Start + " | " + yusuf.Salary);
            Console.WriteLine(alihan.FullName + " | " + alihan.Start + " | " + alihan.Salary);
            Console.WriteLine(mehmet.FullName + " | " + mehmet.Start + " | " + mehmet.Salary);
            Console.WriteLine(tuana.FullName + " | " + tuana.Start + " | " + tuana.Salary);
            Console.WriteLine(efe.FullName + " | " + efe.Start + " | " + efe.Salary);
            Console.WriteLine(deniz.FullName + " | " + deniz.Start + " | " + deniz.Salary);

            Manager ahmet = new Manager("Ahmet Yıldırım", "10 Kasım 2019", 30000, 4);
            Manager busra = new Manager("Büşra Kaya", "05 Haziran 2011", 53000, 6);

            Console.ReadLine();
        }
    }
}
