using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using corewebapi.Model;
using Microsoft.Data.SqlClient;
using corewebapi.BLL;

namespace corewebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustController : ControllerBase
    {
        private readonly RentalDBContext _context;

        public CustController(RentalDBContext context)
        {
            _context = context;
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<CustDet>> Get(int id)
        {
            CustDet result = new CustDet();
            using (_context)
            {
                var param = new SqlParameter("@Id", 1);
                result = _context.CustDet.FromSqlRaw("GetCust @Id", param).ToList().FirstOrDefault();
            }
            return result;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustDet>>> GetCust()
        {
            List<CustDet> result = new List<CustDet>();
            using (_context)
            {
                var param = new SqlParameter("@Id", 1);
                result = _context.CustDet.FromSqlRaw("GetCust @Id", param).ToList();
            }
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> PostUser(UserDet user)
        {
            //_context.UserDet.Add(user);
            //_context.AddressDet.Add(user.AddressDet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsers", new { id = user.Id }, user);
        }

        // GET: api/Courses/5

    }
}
