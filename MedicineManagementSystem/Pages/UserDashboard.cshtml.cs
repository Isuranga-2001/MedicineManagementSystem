using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedicineManagementSystem.Pages
{
    public class UserDashboardModel : PageModel
    {
		public void OnGetMyOnClick()
		{
			Response.Redirect("SignInPage");
		}

		protected void btnConfirm_Click(object sender, EventArgs e)
		{
			Response.Redirect("SignInPage.cshtml");
		}


	}

	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult ButtonClick()
		{
			// do some logic here
			return RedirectToAction("Confirm");
		}

		public IActionResult Confirm()
		{
			return View();
		}
	}
}
