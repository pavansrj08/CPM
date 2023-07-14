using System;
using System.Collections.Generic;

namespace DataFluentAPI.Entities;

public partial class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<ProductParameter> ProductParameters { get; set; } = new List<ProductParameter>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
