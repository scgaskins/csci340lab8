using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using csci340lab8.Models;
using csci340lab8.Data;

namespace csci340lab8.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly csci340lab8.Data.SchoolContext _context;

        public IndexModel(csci340lab8.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
