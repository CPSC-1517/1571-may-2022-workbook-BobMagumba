using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Samples
{
    public class BasicDataManagementModel : PageModel
    {
        [BindProperty]
        public int Num { get; set; }
        public string Feedback { get; set; }
        [BindProperty]
        public int FavouriteCourse { get; set; }
        [BindProperty]
        public int MassText { get; set; }
        public void OnGet()
        {
            if (Num == 0)
            {
                Feedback = "Executing the OnGet method for the the get Requets";
            }
            else
            {
                Feedback = $"You entered the value {Num} disply by onGet";
            }

           
            
        }

        public void OnPost()
        {
            if (Num == 0)
            {
                Feedback = "Executing the OnPost method for the the get Requets";
            }
            else
            {
                Feedback = $"You entered the value {Num} disply by onPost {FavouriteCourse}";
            }
        }
    }
}
