using DAO;
using DTO;
using DTO.Viewmodel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ShopBUS
    {
        ShopDAO shopDAO = new ShopDAO();

        public IEnumerable<Product> GetProducts(string name)
        {
            return shopDAO.GetProducts(name);
        }
        public Product GetProduct(int id)
        {
            return shopDAO.GetProduct(id);
        }
        public bool CheckOut(List<CheckOutViewModel> checkOutViewModels,int id)
        {
            return shopDAO.CheckOut(checkOutViewModels, id);
        }


    }
}
