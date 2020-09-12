using Entities.nhrappdata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>
    {
        public EmployeeRepository(nhrappdataContext context) : base(context)
        {
        }

        public override IEnumerable<Employee> FindAll()
        {
            using (this.context)
            {
                IQueryable<Employee> employees = from p in context.Employees
                                                  select p;
                Employee[] employeesArray = employees.ToArray();
                return employeesArray;
            }
        }
    }
}
