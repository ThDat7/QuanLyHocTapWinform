using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class SubjectGrade
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

    //public virtual ICollection<SubjectGradeSemester>? SubjectGradeSemesters { get; set; }
    public virtual List<SubjectGradeSemester> SubjectGradeSemesters { get; set; }
}