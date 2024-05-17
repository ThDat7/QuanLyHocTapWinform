using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Subject
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int Id { get; set; }

    //[Required]
    //[StringLength(100)]
    public string Name { get; set; }

    //[Required]
    public GradeEnum Grade { get; set; }
    public virtual List<Teacher> Teachers { get; set; }
}