using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class SubjectGradeSemester
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int Id { get; set; }
    public SemesterEnum Semester { get; set; }

    [ForeignKey("SubjectGrade")]
    public int SubjectGradeId { get; set; }
    public virtual SubjectGrade SubjectGrade { get; set; }

    //public virtual ICollection<NormalGrade> NormalGrades { get; set; }
    public virtual List<NormalGrade> NormalGrades { get; set; }
    public virtual FinalGrade FinalGrade { get; set; }
}

public enum SemesterEnum
{
    [Description("1")]
    I = 1,
    [Description("2")]
    II = 2
}