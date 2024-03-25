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
            //Console.WriteLine("Nhap tu khoa can tim: ");
            //string keyword = Console.ReadLine();
            //Console.WriteLine("Tuoi tu: ");
            //int ageStart = int.Parse(Console.ReadLine());
            //Console.WriteLine("Den tuoi: ");
            //int ageEnd = int.Parse(Console.ReadLine());
            //Console.WriteLine("Vi tri: ");
            //string position = Console.ReadLine();
            //Console.WriteLine("Phong ban: ");
            //string department = Console.ReadLine();


            //var result = from e in Employee.GetEmployees()
            //             join d in Department.GetDepartments()
            //             on e.DepartmentID equals d.Id
            //             join p in Position.GetPositions()
            //             on e.PositionID equals p.Id
            //             where (e.Name.Contains(keyword) || p.NamePos.Contains(keyword) || d.NameDept.Contains(keyword))
            //                            && e.Age >= ageStart && e.Age <= ageEnd
            //                            && d.NameDept == department && p.NamePos == position
            //             select new
            //             {
            //                 EmployeeName = e.Name,
            //                 EmployeeAge = e.Age,
            //                 PositionName = p.NamePos,
            //                 DepartmentName = d.NameDept
            //             };

            //if (result.Any() == false)
            //{
            //    Console.WriteLine("Khong tim thay ket qua");
            //}
            //else
            //{
            //    foreach (var e in result)
            //    {
            //        Console.WriteLine($"{e.EmployeeName}, {e.EmployeeAge}, {e.PositionName}, {e.DepartmentName}");
            //    }

            //}
            var employeeByDepartment = from d in Department.GetDepartments()
                                       join e in Employee.GetEmployees()
                                       on d.Id equals e.DepartmentID into eGroup
                                       select new
                                       {
                                           Deparment = d,
                                           Employee = eGroup
                                       };
            
            foreach(var department in employeeByDepartment)
            {
                Console.WriteLine(department.Deparment.NameDept);
                foreach(var emp in department.Employee) {
                    Console.WriteLine(" " + emp.Name);
                }
            }

            var emp2 = Department.GetDepartments().GroupJoin(Employee.GetEmployees(), 
                        d => d.Id,
                        e => e.DepartmentID,
                        (department, eGroup) => new
                        {
                            Department = department,
                            Employee = eGroup
                        });


            foreach (var department in emp2)
            {
                Console.WriteLine(department.Department.NameDept);
                foreach (var emp in department.Employee)
                {
                    Console.WriteLine(" " + emp.Name);
                }
            }


            Console.WriteLine("--------------------------");
            var emp3 = from e in Employee.GetEmployees()
                       join d in Department.GetDepartments()
                       on e.DepartmentID equals d.Id
                       select new
                       {
                           EmployeeName = e.Name,
                           DepartmentName = d.NameDept
                       };
            foreach (var emp in emp3)
            {
                Console.WriteLine($"{emp.EmployeeName}, {emp.DepartmentName}");
            }

            var emp4 = Employee.GetEmployees().Join(Department.GetDepartments(),
                        e => e.DepartmentID,
                        d => d.Id,
                        (employee, department) => new
                        {
                            EmployeeName = employee.Name,
                            DepartmentName = department.NameDept
                        });
            foreach (var emp in emp4)
            {
                Console.WriteLine($"{emp.EmployeeName}, {emp.DepartmentName}");
            }
            Console.WriteLine("--------------------------");

            var emp5 = from e in Employee.GetEmployees()
                       join d in Department.GetDepartments()
                       on e.DepartmentID equals d.Id into eGroup
                       from ed in eGroup.DefaultIfEmpty()
                       select new
                       {
                           EmployeeName = e.Name,
                           DepartmentName = ed == null ? "No Department" : ed.NameDept
                       };
            foreach (var emp in emp5)
            {
                Console.WriteLine($"{emp.EmployeeName}, {emp.DepartmentName}");
            }

            var emp6 = from d in Department.GetDepartments()
                       join e in Employee.GetEmployees()
                       on d.Id equals e.DepartmentID into eGroup
                       from e in eGroup.DefaultIfEmpty()
                       select new
                       {
                           EmployeeName = e == null ? "NaN" : e.Name,
                           DepartmentName = d.NameDept
                       };
            foreach (var emp in emp6)
            {
                Console.WriteLine($"{emp.EmployeeName}, {emp.DepartmentName}");
            }
            Console.ReadKey();

        }
    }
}
