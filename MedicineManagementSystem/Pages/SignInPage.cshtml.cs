using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedicineManagementSystem.Pages
{
    public class SignInPageModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnGetOnClick()
        {
            Response.Redirect("https://www.google.com");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hello");
        }
    }
}
