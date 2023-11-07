using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Tracing;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FinalApplication2.Models;

public partial class Model
{
    public int Id { get; set; }
    public int BrandId { get; set; }
    public string Name { get; set; } = null!;
    public bool? Active { get; set; }
    [BindNever]
    public virtual Brand Brand { get; set; } = null!;
}
