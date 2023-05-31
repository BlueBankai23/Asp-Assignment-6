using Assignment_chapter_6.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Assignment_chapter_6.Pages
{
    public class MinMaxModel : PageModel
    {
        public ArithmaticAndMath math = new ArithmaticAndMath();
        [BindProperty(SupportsGet = true)]
        public InputModel Input { get; set; }
        public int result { get; set; }
        public IActionResult OnGetMax()
        {
            if (!ModelState.IsValid) return RedirectToPage("Error");
            result = math.getMax(Input.item1, Input.item2, Input.item3);
            return Page();
        }
        public IActionResult OnGetMin()
        {
            if (!ModelState.IsValid) return RedirectToPage("Error");
            result = math.getMin(Input.item1, Input.item2, Input.item3);
            return Page();
        }
        public void OnGet()
        {
        }
    }

}
