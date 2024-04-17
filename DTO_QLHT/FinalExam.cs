using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class FinalExam
{
    [Key]
    [ForeignKey("Exam")]
    public int ExamId { get; set; }
    public virtual Exam Exam { get; set; }

    //[Required]
    public float Score { get; set; }
}