using System;
using System.Collections.Generic;

namespace DTO;

public partial class CollectionProduct
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public int? CollectionId { get; set; }

    public bool? Status { get; set; }

    public string? Cdt { get; set; }

    public virtual Collection? Collection { get; set; }

    public virtual Product? Product { get; set; }
}
