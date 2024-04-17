using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Exam
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int Id { get; set; }

    [ForeignKey("Student")]
    public int StudentId { get; set; }
    public virtual Student Student { get; set; }

    [ForeignKey("Teach")]
    public int TeachId { get; set; }
    public virtual Teach Teach { get; set; }

    public virtual ICollection<NormalExam> NormalExams { get; set; }
    public virtual FinalExam FinalExam { get; set; }
}