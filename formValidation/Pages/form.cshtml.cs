using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace formValidation.Pages
{
    public class formModel : PageModel
    {
       
        public int? firstNumber {  get; set; }
     
        public int? secondNumber { get; set; }

        public string? Result { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (int.TryParse(Request.Form["firstNumber"], out int first) && int.TryParse(Request.Form["secondNumber"], out int second))
            {
                if (first < second)
                {
                    Result = "First Number must be greater than or equal to the second number.";
                }
                else
                {
                    int result = first - second;
                    Result = result.ToString();
                }
            }
            else
            {
                Result = "Please enter valid numbers.";
            }
        }
    }
}
