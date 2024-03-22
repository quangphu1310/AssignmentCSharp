using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCSharp
{
    public class Department
    {
        public int Id { get; set; }
        public string NameDept { get; set; }
        public static List<Department> GetDepartments()
        {
            return new List<Department>
            {
                new Department { Id = 1, NameDept = "IT"},
                new Department { Id = 2, NameDept = "Marketing"},
                new Department { Id = 3, NameDept = "HR"}
            };
        }

    }

}
