using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FormRegister.Pages
{
    public class FormModel : PageModel
    {

        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public string Repassword { get; set; }
        [BindProperty]
        public string Gender { get; set; }
        [BindProperty]
        public String Course { get; set; }
        [BindProperty]
        public string Country { get; set; }
        public IActionResult OnGet()
        {
         

        }

        public IActionResult OnPost()
        {
            // After submitting the form, store the form values in session.
            HttpContext.Session.SetString("Username", Username);
            HttpContext.Session.SetString("Password", Password);
            HttpContext.Session.SetString("Repassword", Repassword);
            HttpContext.Session.SetString("Gender", Gender);
            HttpContext.Session.SetString("Course", Course);
            HttpContext.Session.SetString("Country", Country);

            return RedirectToPage("Display");


        }
    }
}
