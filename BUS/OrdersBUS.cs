using DAO;
using DTO;
using DTO.Viewmodel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class OrdersBUS
    {
        OrdersDAO OrdersDAO = new OrdersDAO();

        public IEnumerable<OrderViewModel> Order()
        {
            var orders =  OrdersDAO.Order();

            return orders;
        }


    }
}
