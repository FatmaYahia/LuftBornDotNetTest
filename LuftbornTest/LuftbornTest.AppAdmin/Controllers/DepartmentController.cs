using AutoMapper;
using Entity.AppModel;
using LuftbornTest.AppAdmin.Filter;
using LuftbornTest.AppAdmin.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace LuftbornTest.AppAdmin.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly UnitOfWork UOW;
        private readonly IMapper mapper;
        public DepartmentController(UnitOfWork UOW,IMapper mapper)
        {
            this.UOW = UOW;
            this.mapper = mapper;
        }
        [Authorize]
        public IActionResult Index()
        {
            return View(UOW.DepartmentRepository.GetAll());
        }
        public IActionResult CreateOrEdit(int Id)
        {
            DepartmentVM departmentVM = new DepartmentVM();
            if (Id > 0)
            {
                Department department = UOW.DepartmentRepository.GetById(Id);
                mapper.Map(department, departmentVM);
                

            }
            return View(departmentVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOrEdit(int id,DepartmentVM departmentVM)
        {
            if (ModelState.IsValid)
            {
                Department department = new Department();
                if (id > 0)
                {
                    department = UOW.DepartmentRepository.GetById(id);
                    mapper.Map(departmentVM, department);
                    UOW.DepartmentRepository.UpdateEntity(department);
                    UOW.DepartmentRepository.SaveChanges();
                }
                else
                {
                   
                    mapper.Map(departmentVM, department);
                    UOW.DepartmentRepository.CreateEntity(department);
                    UOW.DepartmentRepository.SaveChanges();
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(departmentVM);
            
        }

        public IActionResult Details(int id)
        {
            Department department = UOW.DepartmentRepository.GetById(id);
           
            return View(department);
        }
        public IActionResult Delete(int id)
        {
            Department department = UOW.DepartmentRepository.GetById(id);

            return View(department); 
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmDelete(int id)
        {
            Department department=  UOW.DepartmentRepository.GetById(id);
            UOW.DepartmentRepository.Delete(department);
            UOW.DepartmentRepository.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
