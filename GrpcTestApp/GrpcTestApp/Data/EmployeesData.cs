using Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcTestApp.Data
{
    public static class EmployeesData
    {
        public static List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id=1,
                BadgeNumber=1,
                Firstname="Meri",
                Lastname="Sahakyan"
            },
            new Employee
            {
                Id=2,
                BadgeNumber=2,
                Firstname="Meri",
                Lastname="Sahakyan"
            },
            new Employee
            {
                Id=3,
                BadgeNumber=3,
                Firstname="Meri",
                Lastname="Sahakyan"
            },
        };
    }
}
