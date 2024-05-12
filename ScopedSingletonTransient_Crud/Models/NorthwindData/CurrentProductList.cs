using System;
using System.Collections.Generic;

namespace ScopedSingletonTransient_Crud.Models.NorthwindData;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
