using System;
using System.Collections.Generic;

namespace ScopedSingletonTransient_Crud.Models.NorthwindData;

public partial class SalesTotalsByAmount
{
    public decimal? SaleAmount { get; set; }

    public int OrderId { get; set; }

    public string CompanyName { get; set; } = null!;

    public DateTime? ShippedDate { get; set; }
}
