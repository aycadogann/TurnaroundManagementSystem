using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnaroundManagementSystem
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
        public bool IsAvailable { get; set; }
    }
}
