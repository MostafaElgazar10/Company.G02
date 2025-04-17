using Company.G02.BLL.Interfaces;
using Company.G02.BLL.Repositories;
using Company.G02.DAL.FOLDER_Models;
using Company.G02.PL.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;

namespace Company.G02.PL.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly DepartmentRepository _departmentRepository;
        public DepartmentController(DepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;

        }
        [HttpGet]
        public IActionResult Index()
        {
           
           var deparments = _departmentRepository.GetAll();

            
            return View(deparments);
        }
        [HttpGet]
        public IActionResult Create()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateDepartmentDto model )
        {
            var department = new Department() 
            {
                Code = model.Code,
                Name = model.Name,
                CreateAt = model.CreateAt,
            };
            if(ModelState.IsValid) 
            {
              var count =  _departmentRepository.Add(department);
                if(count > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            
            }
            return View();
        }
        [HttpGet]
        public IActionResult Details(int? id , string viewname = "Details") 
        {
            if (id is null) return BadRequest("Id invalid");
           var department = _departmentRepository.Get(id.Value);
            if (department == null) return NotFound(new { StatusCode = 404 , message = $"Department with : {id} is not found"} );
            return View(viewname,department);
        }

        [HttpGet]
         public IActionResult Edit(int? id)
        {
     //       if (id is null) return BadRequest("Id invalid");
     //       var department = _departmentRepository.Get(id.Value);
     //       if (department is null) return NotFound(new { StatusCode = 404, message = $"Department with : {id} is not found" });
            return Details(id,"Edit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromRoute]int id,Department department)
        {
            
          if (ModelState.IsValid)
            {
               if(id == department.Id)
                {
                    var Count = _departmentRepository.Update(department);
                    if (Count > 0)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            return View(department);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            //  if (id is null) return BadRequest("Id invalid");
            //  var department = _departmentRepository.Get(id.Value);
            //  if (department is null) return NotFound(new { StatusCode = 404, message = $"Department with : {id} is not found" });
            return Details(id, "Delete");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([FromRoute] int id, Department department)
        {

            if (ModelState.IsValid)
            {
                if (id == department.Id)
                {
                    var Count = _departmentRepository.Delete(department);
                    if (Count > 0)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            return View(department);
        }
    }
}
