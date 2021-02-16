using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using corewebapi.Models;

namespace corewebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly RentalDBContext _context;

        public CityController(RentalDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<CityDet>>> GetCity()
        {
            return await _context.CityDet.ToListAsync();
        }

        // GET: api/Courses/5

       
    }
}
