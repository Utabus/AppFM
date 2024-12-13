using DTO.Viewmodel;
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

        public IEnumerable<ProductViewmodel> Products(string? name)
        {
            var fmStyleDbContext = _context.ProductSizeColors
                .Include(p => p.Color)
                .Include(p => p.Product)
                .Include(p => p.ProductInventory)
                .Include(p => p.Size)
               .Where(x => string.IsNullOrEmpty(name) || x.Product.Name.ToLower().Contains(name.ToLower()))
                .Select(x => new ProductViewmodel
                {
                    Name = x.Product.Name,
                    Code = x.Code,
                    Size = x.Size.Size1,
                    Color = x.Color.Color1,
                    Quantity = x.ProductInventory.Quantity,
                    QuantitySold = x.ProductInventory.QuantitySold,
                })
                .ToList();

            return fmStyleDbContext;
        }

    }
}
