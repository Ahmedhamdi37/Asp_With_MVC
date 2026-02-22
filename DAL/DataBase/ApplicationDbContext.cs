using Asp_With_MVC.DAL.DataBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace Asp_With_MVC.DAL.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-0TGANBB;Initial Catalog=ITI4MonthDay2;Integrated Security=True;Trust Server Certificate=True;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
