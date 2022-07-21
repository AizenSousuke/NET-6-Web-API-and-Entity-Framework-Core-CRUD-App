using CRUD_with_a_NET_6_Web_API_and_Entity_Framework_Core.Data;
using CRUD_with_a_NET_6_Web_API_and_Entity_Framework_Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_with_a_NET_6_Web_API_and_Entity_Framework_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly DataContext _context;
        
        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<User>> AddUser(User user)
        {
            if (!await _context.Users.AnyAsync(u => u == user))
            {
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                return View("Created", user);
            }

            return View("Existed", user);
        }
    }
}
