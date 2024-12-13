using Azure.Core;
using DTO;
using DTO.Viewmodel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ShopDAO
    {
        private FmStyleDbContext _context = new FmStyleDbContext();



        public IEnumerable<Product> GetProducts(string name)
        {
            var products = _context.Products.Where(x => string.IsNullOrEmpty(name) || x.Name.ToLower().Contains(name.ToLower())).ToList();
            return products;
        }
        public Product GetProduct(int id)
        {
            var product = _context.Products.Include(x => x.ProductSizeColors).ThenInclude(x => x.Size).Include(x => x.ProductSizeColors).ThenInclude(x => x.Color)
                .Include(x => x.Images)
                .FirstOrDefault(x => x.Id == id);
            return product;
        }

        public bool CheckOut(List<CheckOutViewModel> checkOutViewModel, int Id)
        {
            try
            {
                var Order = new Order
                {
                    AccountId = Id,
                    Status = 3,
                    CreateDay = DateTime.Now,
                    Total = checkOutViewModel.Sum(x => decimal.Parse(x.Price.Replace(".", "").Replace("₫", "").Trim()) * x.Quantity)
                };
                _context.Orders.Add(Order);
                _context.SaveChanges();
                Payment payment = new Payment
                {
                    OrdersId = Order.Id,
                    PaymentMethodsId = 1,
                    Amount = Order.Total,
                    PaymentDate = DateTime.Now,
                    Status = 1
                };

                _context.Payments.Add(payment);
                foreach (var item in checkOutViewModel)
                {
                    var productsizecolor = _context.ProductSizeColors.Include(x => x.Size).Include(x => x.Color)
                        .FirstOrDefault(x => x.Color.Color1 == item.Color && x.Size.Size1 == item.Size  && x.Product.Name == item.Name);
                    var orderDetail = new OrderItem();


                    if (productsizecolor != null)
                    {

                         orderDetail = new OrderItem
                        {
                            OrderId = Order.Id, // Gán OrderId cho OrderDetail
                            ProductSizeColorId = productsizecolor.Id, // Gán ID sản phẩm
                            Quantity = item.Quantity,
                        };
                    }

                    // Thêm chi tiết đơn hàng vào context
                    _context.OrderItems.Add(orderDetail);
                }
                _context.SaveChanges();

                return true; // Hoàn thành thanh toán thành công

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


    }



}

