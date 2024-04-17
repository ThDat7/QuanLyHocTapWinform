using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Teacher
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int Id { get; set; }
    
    [Required]
    [ForeignKey("User")]
    public int UserId { get; set; }
    public virtual User User { get; set; }


    [ForeignKey("TeacherId")]
    public virtual ICollection<Teach> Teaches { get; set; }
}
