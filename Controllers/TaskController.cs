using Microsoft.AspNetCore.Mvc;
using TasksList.Data;
using TasksList.Models;

namespace TasksList.Controllers
{
    public class TaskController : Controller
    {
        private readonly AppDbContext _context;

        public TaskController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var task = _context.Tasks.ToList();
            return View(task);
        }


    }
}
