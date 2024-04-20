using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class NormalGrade
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int Id { get; set; }

    [ForeignKey("SubjectGradeSemester")]
    public int SubjectGradeSemesterId { get; set; }
    public virtual SubjectGradeSemester SubjectGradeSemester { get; set; }

    //[Required]
    public FactorEnum Factor { get; set; }

    //[Required]
    public float Score { get; set; }
}

public enum FactorEnum
{
    [Description("1")]
    I = 1,
    [Description("2")]
    II = 2
}
