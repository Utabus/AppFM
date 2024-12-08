using DTO;
using DTO.Viewmodel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class OrdersDAO
    {
      private  FmStyleDbContext _context = new FmStyleDbContext();


        public IEnumerable<OrderViewModel> Order()
        {
            var donhang =  _context.Orders
                .Include(x => x.Account)
                .ThenInclude(x => x.Addresses).Select(x => new OrderViewModel
                {
                    Email = x.Account.Email,
                    FullName = x.Account.FullName,
                    Address = x.Account.Addresses.FirstOrDefault().Street ,
                    Phone = x.Account.Phone,
                    Total = x.Total,
                    CreateDay = x.CreateDay,
                    StatusDescription = x.Status == 5 ? "Đơn hủy"
                          : x.Status == 2 ? "Chờ xác nhận"
                          : x.Status == 3 ? "Hoàn thành"
                          : "Không xác định"
                })
                .ToList();
            return donhang;
        }


    }
}
