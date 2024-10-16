using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PlantTrees.Context;
using PlantTrees.Entities;



namespace PlantTrees.Pages
{
    public class CreateModel : PageModel
    {
        private readonly PlantTreesContext _context;

        public CreateModel(PlantTreesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Planter Planter { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var exists = await _context.Planters.AnyAsync(p => p.Cpf == Planter.Cpf);

            if (exists)
            {
                ModelState.AddModelError("Planter.Cpf", "Existing cpf.");
                return Page();
            }

            _context.Planters.Add(Planter);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
