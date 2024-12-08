﻿using System;
using System.Collections.Generic;

namespace DTO;

public partial class Collection
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Slug { get; set; }
    public string? Title { get; set; }
    public string? Avatar { get; set; }
    public string? Baner { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<CollectionProduct> CollectionProducts { get; set; } = new List<CollectionProduct>();
}
