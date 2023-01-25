using System;
using System.Collections.Generic;

namespace week8day3.Models;

public partial class Elecproduct
{
    public int Pid { get; set; }

    public string? Pname { get; set; }

    public string? Brand { get; set; }

    public virtual ICollection<ProductPricing> ProductPricings { get; } = new List<ProductPricing>();
}
