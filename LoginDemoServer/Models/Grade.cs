using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LoginDemoServer.Models;

public partial class Grade
{
    [Key]
    public int TestId { get; set; }

    [StringLength(100)]
    public string? Email { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [StringLength(200)]
    public string Name { get; set; } = null!;

    [Column("Grade")]
    public int Grade1 { get; set; }

    [ForeignKey("Email")]
    [InverseProperty("Grades")]
    public virtual User? EmailNavigation { get; set; }
}
