using Asp_With_MVC.DAL.DataBase;
using Microsoft.AspNetCore.Mvc;

namespace Asp_With_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        //private List<Employee> Employees;
        private readonly ApplicationDbContext Db;

        public EmployeeController()
        {
            Db = new ApplicationDbContext();
            //Employees = [
            //new Employee(1,"Ahmed",3433),
            //new Employee(2,"Hamdi",5534),
            //new Employee(3,"Ahmed",1225),
            //new Employee(4,"Mohammed",883),
            //];
        }

        public IActionResult Index()
        {
            var result = Db.Employees.ToList();

            return View(result);
        }
        public IActionResult GetEmployeeByID(int Id)
        {
            var result = Db.Employees/*.Where(e => e.Id == Id)*/.FirstOrDefault(e => e.Id == Id);

            return View(result);
        }
    }
}
