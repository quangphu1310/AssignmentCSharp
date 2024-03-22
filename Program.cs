using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap tu khoa can tim: ");
            string keyword = Console.ReadLine();
            Console.WriteLine("Tuoi tu: ");
            int ageStart = int.Parse(Console.ReadLine());
            Console.WriteLine("Den tuoi: ");
            int ageEnd = int.Parse(Console.ReadLine());
            Console.WriteLine("Vi tri: ");
            string position = Console.ReadLine();
            Console.WriteLine("Phong ban: ");
            string department = Console.ReadLine();


            var result = from e in Employee.GetEmployees()
                         join d in Department.GetDepartments()
                         on e.DepartmentID equals d.Id
                         join p in Position.GetPositions()
                         on e.PositionID equals p.Id
                         where (e.Name.Contains(keyword) || p.NamePos.Contains(keyword) || d.NameDept.Contains(keyword))
                                        && e.Age >= ageStart && e.Age <= ageEnd
                                        && d.NameDept == department && p.NamePos == position
                         select new
                         {
                             EmployeeName = e.Name,
                             EmployeeAge = e.Age,
                             PositionName = p.NamePos,
                             DepartmentName = d.NameDept
                         };
            if (result.Any() == false)
            {
                Console.WriteLine("Khong tim thay ket qua");
            }
            else
            {
                foreach (var e in result)
                {
                    Console.WriteLine($"{e.EmployeeName}, {e.EmployeeAge}, {e.PositionName}, {e.DepartmentName}");
                }
            }

            Console.ReadKey();

        }
    }
}
