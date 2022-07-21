using CRUD_with_a_NET_6_Web_API_and_Entity_Framework_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_with_a_NET_6_Web_API_and_Entity_Framework_Core.ViewComponents.Components
{
    public class IteratorViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(List<Role> data)
        {
            return View(data);
        }
    }
}
