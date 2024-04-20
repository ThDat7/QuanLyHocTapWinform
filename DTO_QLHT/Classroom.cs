using System;
using System.Collections.Generic;
using System.ComponentModel;
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

    //public virtual ICollection<Student>? Students { get; set; }
    public virtual List<Student>? Students { get; set; }

    public virtual ICollection<Teach>? Teaches { get; set; }
}

public enum GradeEnum
{
    [Description("10")]
    TENTH = 10,
    [Description("11")]
    ELEVENTH = 11,
    [Description("12")]
    TWELVETH = 12
}