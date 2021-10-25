using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using csci340lab8.Data;
using csci340lab8.Models;

namespace csci340lab8.Pages.Departments
{
    public class IndexModel : PageModel
    {
        private readonly csci340lab8.Data.SchoolContext _context;

        public IndexModel(csci340lab8.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Department> Department { get;set; }

        public async Task OnGetAsync()
        {
            Department = await _context.Departments
                .Include(d => d.Administrator).ToListAsync();
        }
    }
}
