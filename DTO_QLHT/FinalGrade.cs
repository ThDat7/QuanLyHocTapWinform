using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class FinalGrade
{
    [Key]
    [ForeignKey("SubjectGradeSemester")]
    public int SubjectGradeSemesterId { get; set; }
    public virtual SubjectGradeSemester SubjectGradeSemester { get; set; }

    //[Required]
    public float Score { get; set; }
}