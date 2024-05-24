using BackEndExam.DAL;
using BackEndExam.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Drawing;

namespace BackEndExam.Controllers
{
    public class HomeController(AppDbContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var data = await _context.Teams.Select(t => new Team
            {
                Name = t.Name,
                Id = t.Id,
                Description = t.Description,
                Image = t.Image,
                Icon = t.Icon
            }).ToListAsync();
            return View(data);
        }
    }
}
