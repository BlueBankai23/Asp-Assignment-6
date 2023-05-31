using Assignment_chapter_6.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Assignment_chapter_6.Pages
{
    public class SumMulModel : PageModel
    {
        public ArithmaticAndMath math= new ArithmaticAndMath();
        [BindProperty(SupportsGet = true)]
        public InputModel Input { get; set; }
        public int result { get; set; }

        public IActionResult OnGetSum()
        {
            if (!ModelState.IsValid) return RedirectToPage("Error");
            result = math.getSum(Input.item1, Input.item2, Input.item3);
            return Page();
        }
        public IActionResult OnGetMul()
        {
            if(!ModelState.IsValid) return RedirectToPage("Error");
            result = math.getProd(Input.item1, Input.item2, Input.item3);
            return Page();
        }
        public void OnGet()
        {
        }
    }
    public class  InputModel
    {
        public InputModel() { }
        [Required]
        public string handler { get; set; }
        [Required]
        [RegularExpression(@"^\d+$", ErrorMessage = "The item1 field must be a valid integer.")]
        public int item1 { get; set; }
        [Required]
        [RegularExpression(@"^\d+$", ErrorMessage = "The item2 field must be a valid integer.")]
        public int item2 { get; set; }
        [Required]
        [RegularExpression(@"^\d+$", ErrorMessage = "The item3 field must be a valid integer.")]
        public int item3 { get; set; }
        
    }
}
