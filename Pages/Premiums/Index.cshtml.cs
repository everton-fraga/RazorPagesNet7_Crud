using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudRazor.Models;

namespace CrudRazor.Pages_Premiums
{
    public class IndexModel : PageModel
    {
        private readonly CrudRazor.Data.ApplicationDbContext _context;

        public IndexModel(CrudRazor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Premium> Premium { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Premiums != null)
            {
                Premium = await _context.Premiums
                .Include(p => p.Student).ToListAsync();
            }
        }
    }
}
