using AutoMapper;
using DAL;
using Entity.AppModel;
using LuftbornTest.AppAdmin.Filter;
using LuftbornTest.AppAdmin.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;

namespace LuftbornTest.AppAdmin.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly DataContext DB;
        private readonly UnitOfWork UOW;
        private readonly IMapper mapper;
        public EmployeeController(DataContext DB,UnitOfWork UOW,IMapper mapper)
        {
            this.DB = DB;
            this.UOW = UOW;
            this.mapper = mapper;
        }
        [Authorize]
        public IActionResult Index()
        {
            return View(UOW.EmployeeRepository.GetAll());
        }
        public IActionResult CreateOrEdit(int id)
        {
            EmployeeVM employeeVM = new EmployeeVM();
            ViewBag.Genders = new SelectList(UOW.GenderRepository.GetAll(), "Id", "Name");
            ViewBag.Departments = new SelectList(UOW.DepartmentRepository.GetAll(), "Id", "Name");
            if (id > 0)
            {
                Employee employee = UOW.EmployeeRepository.GetById(id);
                mapper.Map(employee, employeeVM);
                employeeVM.Id = id;
                employeeVM.ConfirmPassword = employee.Password;
            }

            return View(employeeVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOrEdit(int id,EmployeeVM employeeVM)
        {
            if (ModelState.IsValid)
            {
                Employee employee = new Employee();
                if (id > 0)
                {
                    employee = UOW.EmployeeRepository.GetById(id);
                    mapper.Map(employeeVM, employee);
                    UOW.EmployeeRepository.UpdateEntity(employee);
                    UOW.EmployeeRepository.SaveChanges();
                }
                else
                {
                    mapper.Map(employeeVM, employee);
                    UOW.EmployeeRepository.CreateEntity(employee);
                    UOW.EmployeeRepository.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Genders = new SelectList(UOW.GenderRepository.GetAll(), "Id", "Name");
            ViewBag.Departments = new SelectList(UOW.DepartmentRepository.GetAll(), "Id", "Name");

            return View(employeeVM);
        }

        public IActionResult Details(int id)
        {
            Employee employee = UOW.EmployeeRepository.GetById(id);
            return View(employee);
        }
        public IActionResult Delete(int id)
        {
            Employee employee = UOW.EmployeeRepository.GetById(id);
            return View(employee);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmDelete(int id)
        {
            Employee employee = UOW.EmployeeRepository.GetById(id);
            UOW.EmployeeRepository.Delete(employee);
            UOW.EmployeeRepository.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
