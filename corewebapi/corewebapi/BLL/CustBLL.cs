using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using corewebapi.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace corewebapi.BLL
{
    public class CustBLL: IDisposable
    {
        private readonly RentalDBContext _context;
        public CustBLL(RentalDBContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<CustDet> getCustomer(int id)
        {
            List<CustDet> result = new List<CustDet>();
            using (_context)
            {
                var param = new SqlParameter("@Id", id);
                result = _context.CustDet.FromSqlRaw("GetCust @Id", param).ToList();
            }
            return result;
        }
    }
}
