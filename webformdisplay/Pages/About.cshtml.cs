using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webformdisplay.Pages
{
    public class AboutModel : PageModel
    {
        [BindProperty]
        public bool hasData { get; set; }
        [BindProperty]
        public string username { get; set; }
        [BindProperty]
        public string password { get; set; }
        [BindProperty]
        public string repassword { get; set; }
        [BindProperty]
        public string gender { get; set; }
        [BindProperty]
        public string[] course { get; set; }
        [BindProperty]
        public string country { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            hasData = true;
            username = Request.Form["username"];
            password = Request.Form["password"];
            repassword = Request.Form["repassword"];
            gender = Request.Form["gender"];
            course = Request.Form["course[]"];
            country = Request.Form["country"];
        }
    }
}
