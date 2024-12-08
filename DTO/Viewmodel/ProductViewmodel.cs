using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Viewmodel
{
    public class ProductViewmodel
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public int Quantity { get; set; }
        public int QuantitySold { get; set; }

    }
}
