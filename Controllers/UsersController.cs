using API.Data;
using API.Emodels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Appuser>>> GetUsers()
        {
            // var Users =;
            return await _context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Appuser>> GetUser(int id)
        {
            // var Users = ;
            return await _context.Users.FindAsync(id);
        }
    }
}
