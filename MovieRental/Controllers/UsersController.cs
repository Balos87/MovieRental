using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieRental.Data;
using MovieRental.Models;
using MovieRental.Models.DTOs;

namespace MovieRental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly MovieRentalContext _context;

        public UsersController(MovieRentalContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetAllUsers()
        {

            var UserLists = await _context.Users.ToListAsync();
            var Users = new List<UserDTO>();

            foreach (var user in UserLists)
            {
                var userDto = new UserDTO
                {
                    UserName = user.Name,
                    Email = user.Email
                };

                Users.Add(userDto);
            }

            return Users;
        }

        [HttpPost]
        public async Task<ActionResult<User>> AddUser(User user)
        {
            var newUser = new User
            {
                Name = user.Name,
                Email = user.Email
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
