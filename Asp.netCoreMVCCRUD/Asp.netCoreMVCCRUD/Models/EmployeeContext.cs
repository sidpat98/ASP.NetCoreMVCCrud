using System;
using Microsoft.EntityFrameworkCore;

namespace Asp.netCoreMVCCRUD.Models
{
    public class EmployeeContext:DbContext
    {
        //constructor with parameter DbContextOptions of type employeecontext named options. After that call base constructor and pass options 
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options)
        {
            
        }

        public DbSet<Employee> Employess { get; set; }

    }
}
