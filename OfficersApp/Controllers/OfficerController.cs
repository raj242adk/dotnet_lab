using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficersApp.Models;

namespace OfficersApp.Controllers
{
    public class OfficerController : Controller
    {
        private readonly OfficerDbContext context;

        public OfficerController(OfficerDbContext officedbcontext)
        {
            context = officedbcontext;
            
        }

        [HttpGet]
        public IActionResult Index()
        {
            var officer = context.Officers.ToList();
            return View(officer); 
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddOfficerViewModel addOfficerRequest) {

            var officer = new Officer()
            {
                Id = addOfficerRequest.Id,
                Name = addOfficerRequest.Name,
                Gender = addOfficerRequest.Gender,
                Phone = addOfficerRequest.Phone,
                Department = addOfficerRequest.Department,
                Position = addOfficerRequest.Position


            };
            context.Add(officer);
            context.SaveChanges();
            return RedirectToAction("Index");
            


        }
        [HttpGet]
        public async Task<IActionResult> View(int id) {
            var officer = await context.Officers.FirstOrDefaultAsync(x => x.Id == id);

            if (officer != null)
            {
                var viewModel = new UpdateOfficerViewModel()
                {
                    Id = officer.Id,
                    Name = officer.Name,
                    Gender = officer.Gender,
                    Phone = officer.Phone,
                    Department = officer.Department,
                    Position = officer.Position


                };
                return await Task.Run(()=>View("View",viewModel));


            }
           
            return RedirectToAction("Index");
        
        }

        [HttpPost]
        public async Task<IActionResult> View(UpdateOfficerViewModel model)
        {
            var officer = await context.Officers.FindAsync(model.Id);
            if (officer != null)
            {
                officer.Name = model.Name;
                officer.Gender = model.Gender;  
                officer.Phone = model.Phone;
                officer.Department = model.Department;
                officer.Position = model.Position;

                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");


        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateOfficerViewModel model)
        {
            var officer=await context.Officers.FindAsync(model.Id);
            if (officer != null)
            {
                context.Officers.Remove(officer);
                await context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");

        }
    }
}
