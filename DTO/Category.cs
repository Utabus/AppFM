using System;
using System.Collections.Generic;

namespace DTO;

public partial class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? SupplierId { get; set; }

    public string? Description { get; set; }

    public bool? Status { get; set; }

    public DateTime? Cdt { get; set; }

    public virtual ICollection<ProductType> ProductTypes { get; set; } = new List<ProductType>();

    public virtual Supplier? Supplier { get; set; }
}
