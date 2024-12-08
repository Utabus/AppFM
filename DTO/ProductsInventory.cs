using System;
using System.Collections.Generic;

namespace DTO;

public partial class ProductsInventory
{
    public int Id { get; set; }

    public int? Quantity { get; set; }

    public int? QuantitySold { get; set; }

    public virtual ICollection<ProductSizeColor> ProductSizeColors { get; set; } = new List<ProductSizeColor>();
}
