using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class WarehourseDAO
    {
        private FmStyleDbContext _context = new FmStyleDbContext();

        public void Products()
        {
            var fmStyleDbContext = _context.ProductSizeColors.Include(p => p.Color)
                .Include(p => p.Product)
                .Include(p => p.ProductInventory).Include(p => p.Size).ToList();




        }
    }
}
