using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using corewebapi.Model;

namespace corewebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly RentalDBContext _context;

        public UserController(RentalDBContext context)
        {
            _context = context;
        }


        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<UserDet>>> GetUsers()
        //{
        //    return await _context.UserDet.Include(x => x.AddressDet)
        //                                 .ThenInclude(AddressDet => AddressDet.City)
        //                                 .Include(b => b.UserType).ToListAsync();
        //}

        //// GET: api/Courses/5
        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<UserDet>> Get(int id)
        //{
        //    //var user = await _context.UserDet.Include(x => x.AddressDet)
        //    //                             .ThenInclude(AddressDet => AddressDet.City)
        //    //                             .Include(x => x.UserType)
        //    //                            .FirstOrDefaultAsync(x => x.Id == id);

        //    //if (user == null)
        //    //{
        //    //    return NotFound();
        //    //}

        //    //return user;
        //}

        //public async Task<IActionResult> Put(UserDet user)
        //{
        //    if (user.Id == 0)
        //    {
        //        return BadRequest();
        //    }

        //    //_context.Entry(user).State = EntityState.Modified;
        //    //_context.Entry(user.AddressDet).State = EntityState.Modified;

        //    //try
        //    //{
        //    //    await _context.SaveChangesAsync();
        //    //}
        //    //catch (DbUpdateConcurrencyException)
        //    //{
        //    //    if (!UserExists(user.Id))
        //    //    {
        //    //        return NotFound();
        //    //    }
        //    //    else
        //    //    {
        //    //        throw;
        //    //    }
        //    //}

        //    return CreatedAtAction("Get", new { id = user.Id }, user);
        //}

        //[HttpPost]
        //public async Task<ActionResult> PostUser(UserDet user)
        //{
        //    //_context.UserDet.Add(user);
        //    //_context.AddressDet.Add(user.AddressDet);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetUsers", new { id = user.Id }, user);
        //}


        //[Route("{type}")]
        //public async Task<ActionResult<IEnumerable<UserType>>> GetUserType(string type)
        //{
        //    //return await _context.UserType.ToListAsync();
        //}

        //private bool UserExists(int id)
        //{
        //    return _context.UserDet.Any(e => e.Id == id);
        //}
    }
}
