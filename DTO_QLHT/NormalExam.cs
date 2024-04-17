using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class NormalExam
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int Id { get; set; }

    [ForeignKey("Exam")]
    public int ExamId { get; set; }
    public virtual Exam Exam { get; set; }

    //[Required]
    public FactorEnum Factor { get; set; }

    //[Required]
    public float Score { get; set; }
}

public enum FactorEnum
{
    I = 1,
    II = 2
}
