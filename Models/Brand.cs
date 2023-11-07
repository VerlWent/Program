using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalApplication2.Models;

public partial class Brand
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool? Active { get; set; }
    
    public virtual ICollection<Model> Models { get; set; } = new List<Model>();
}
