using System;
using System.Collections.Generic;

namespace DataFluentAPI.Entities;

public partial class ProductParameter
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? ProductId { get; set; }

    public virtual Category? Product { get; set; }
}
