using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PlantTrees.Context;
using PlantTrees.Entities;

namespace PlantTrees.Pages
{
    public class CreateTreesModel : PageModel
    {
        private readonly PlantTreesContext _context;

        public CreateTreesModel(PlantTreesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tree Tree { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            var planter = await _context.Planters.FindAsync(Tree.IdPlanter);

            _context.Trees.Add(Tree);
            planter.PlantedTrees += Tree.AmountPlanted;


            _context.SaveChanges();
            return RedirectToPage("./GetPlanters");
        }
    }
}
