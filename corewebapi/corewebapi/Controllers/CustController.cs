using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using corewebapi.Models;
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
                result = await _context.CustDet.Where(x => x.Id == id).Include(x => x.Address).FirstOrDefaultAsync();
            }
            return result;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustDet>>> GetCust()
        {
            List<CustDet> result = new List<CustDet>();
            using (_context)
            {
                result = await _context.CustDet.Include(x => x.Address).ToListAsync();
            }
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> PostUser(CustDet cust)
        {
            //post user
            using (_context)
            {
                // check if custid exists

                if (!CustExists(cust.Id))
                {
                    _context.CustDet.Add(cust);
                }
                else
                {
                    cust.UpdatedDt = DateTime.Now;
                    _context.Entry(cust).State = EntityState.Modified;
                }

                await _context.SaveChangesAsync();
            }

            return CreatedAtAction("GetCust", new { id = cust.Id }, cust);
        }

        // GET: api/Courses/5

        private bool CustExists(int id)
        {
            return _context.CustDet.Any(e => e.Id == id);
        }

        private bool AddressExists(AddressDet address)
        {
            bool retValue = false;
            return _context.AddressDet.Any(e => e.Zipcode == address.Zipcode && e.City == address.City && e.State == address.State
                                           && e.LeasingOfficeName == address.LeasingOfficeName && e.BldgNo == address.BldgNo
                                           && e.AddType == address.AddType && e.StreetAddress1 == address.StreetAddress1
                                           && e.StreetAddress2 == address.StreetAddress2 && e.AptNo == address.AptNo);
        }
    }
}
