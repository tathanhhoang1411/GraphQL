﻿using System;
using System.Collections.Generic;

namespace GPL.DBModels;

public partial class TblCategory
{
    public decimal Id { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<TblProduct> TblProducts { get; } = new List<TblProduct>();
}
