using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Volkau_Html_Intro.DAL.Data;
using Volkau_Html_Intro.DAL.Entities;

namespace Volkau_Html_Intro.Areas.Admin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Volkau_Html_Intro.DAL.Data.ApplicationDbContext _context;

        public IndexModel(Volkau_Html_Intro.DAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Drug> Drug { get;set; }

        public async Task OnGetAsync()
        {
            Drug = await _context.Drugs
                .Include(d => d.Group).ToListAsync();
        }
    }
}
