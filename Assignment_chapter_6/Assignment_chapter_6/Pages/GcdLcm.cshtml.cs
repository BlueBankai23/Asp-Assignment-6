using Assignment_chapter_6.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment_chapter_6.Pages
{
    public class GcdLcmModel : PageModel
    {  
        public ArithmaticAndMath math = new ArithmaticAndMath();
        [BindProperty(SupportsGet = true)]
        public InputModel Input { get; set; }
        public int result { get; set; }
        public IActionResult OnGetGCD()
        {
            if (!ModelState.IsValid) return RedirectToPage("Error");
            result = math.gcd(Input.item1, Input.item2);
            return Page();
        }
        public IActionResult OnGetLCM()
        {
            if (!ModelState.IsValid) return RedirectToPage("Error");
            result  = math.lcm(Input.item1, Input.item2);
            return Page();  
        }
        public void OnGet()
        {
        }
    }
}
