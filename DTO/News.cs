﻿using System;
using System.Collections.Generic;

namespace DTO;

public partial class News
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public string? Images { get; set; }
    public DateTime? CDT { get; set; }

    public bool? Status { get; set; }
}
