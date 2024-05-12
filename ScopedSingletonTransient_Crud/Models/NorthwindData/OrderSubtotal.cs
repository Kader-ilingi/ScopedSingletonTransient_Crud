using System;
using System.Collections.Generic;

namespace ScopedSingletonTransient_Crud.Models.NorthwindData;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
