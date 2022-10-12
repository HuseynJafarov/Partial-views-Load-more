using Embryo_Front_ToBack_.Models;
using Embryo_FrontToBack_.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Embryo_Front_ToBack_.Controllers
{
    public class AccessoriesController : Controller
    {
        private readonly AppDbContext _context;

        public AccessoriesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Accessories> accessories = await _context.Accessories.Where(m => !m.IsDeleted).Take(4).ToListAsync();
            return View(accessories);
        }
    }
}
