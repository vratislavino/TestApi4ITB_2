using Microsoft.AspNetCore.Mvc;
using TestApi4ITB_2.Data;
using TestApi4ITB_2.Models;

namespace TestApi4ITB_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext context;

        public UserController(AppDbContext context) {
            this.context = context;
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddUser(User u)
        {
            context.Users.Add(u);
            int changes = await context.SaveChangesAsync();
            if(changes > 0)
            {
                return Ok("User added successfully");
            } else
            {
                return BadRequest("Failed to add user");
            }
        }

        [HttpGet]
        [Route("get")] 
        public async void GetUsers()
        {

        }


    }
}
