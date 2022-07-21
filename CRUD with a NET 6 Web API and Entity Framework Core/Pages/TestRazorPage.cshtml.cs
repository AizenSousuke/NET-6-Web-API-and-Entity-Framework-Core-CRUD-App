using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD_with_a_NET_6_Web_API_and_Entity_Framework_Core.Pages
{
    public class TestRazorPageModel : PageModel
    {
        public string StringOnPage { get; set; } = string.Empty;
        public void OnGet()
        {
            StringOnPage = Request.Query["Id"].ToString();
        }
    }
}
