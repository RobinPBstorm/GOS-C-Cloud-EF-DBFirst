using System;
using System.Collections.Generic;

namespace GOS_C_Cloud_EF_DBFirst.Models;

public partial class Section
{
    public int Id { get; set; }

    public string SectionName { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
