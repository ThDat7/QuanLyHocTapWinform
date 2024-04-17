using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Classroom
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int Id { get; set; }

    //[Required]
    public GradeEnum Grade { get; set; }

    //[Required]
    public int Order { get; set; }

    //[Required]
    public int Year { get; set; }

    [ForeignKey("HomeroomTeacher")]
    public int? HomeroomTeacherId { get; set; }

    public virtual Teacher? HomeroomTeacher { get; set; }

    public virtual ICollection<Student>? Students { get; set; }
}

public enum GradeEnum
{
    TENTH = 10,
    ELEVENTH = 11,
    TWELVETH = 12
}