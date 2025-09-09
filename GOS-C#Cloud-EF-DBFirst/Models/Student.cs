using System;
using System.Collections.Generic;

namespace GOS_C_Cloud_EF_DBFirst.Models;

public partial class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public int YearResult { get; set; }

    public int SectionId { get; set; }

    public bool? Active { get; set; }

    public virtual Section Section { get; set; } = null!;
}
