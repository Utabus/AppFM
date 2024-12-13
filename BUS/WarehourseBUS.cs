using DAO;
using DTO.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class WarehourseBUS
    {
        WarehourseDAO WarehourseDAO = new WarehourseDAO();

        public IEnumerable<ProductViewmodel> Products(string? name)
        {
            return WarehourseDAO.Products(name);
        }
    }
}
