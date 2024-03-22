using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCSharp
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
                {
                    new Employee{ Id = 1, Name= "Nguyen Van A", Age = 20, DepartmentID = 1, PositionID = 2},
                    new Employee{ Id = 2, Name= "Tran Van B", Age = 25, DepartmentID = 2, PositionID = 1},
                    new Employee{ Id = 3, Name= "Bui Van C", Age = 30, DepartmentID = 1, PositionID = 3},
                    new Employee{ Id = 4, Name= "Nguyen Van D", Age = 35, DepartmentID = 3, PositionID = 2},
                    new Employee{ Id = 5, Name= "Nguyen Van E", Age = 40, DepartmentID = 2, PositionID = 3},
                    new Employee{ Id = 6, Name= "Tran Van F", Age = 45, DepartmentID = 1, PositionID = 1},
                    new Employee{ Id = 7, Name= "Nguyen Van G", Age = 50, DepartmentID = 3, PositionID = 3}
                };
        }
    }

}
