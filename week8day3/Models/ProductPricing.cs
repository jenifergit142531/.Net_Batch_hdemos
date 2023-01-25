using System;
using System.Collections.Generic;

namespace week8day3.Models;

public partial class ProductPricing
{
    public int Billingno { get; set; }

    public string? Pname { get; set; }

    public int? Price { get; set; }

    public int? Quantity { get; set; }

    public int? Pid { get; set; }

    public virtual Elecproduct? PidNavigation { get; set; }
}
