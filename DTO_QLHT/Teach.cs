using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Teach
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int Id { get; set; }

    //[Required]
    public SemesterEnum Semester { get; set; }

    [ForeignKey("Teacher")]
    [Required]
    public int TeacherId { get; set; }
    public virtual Teacher Teacher { get; set; }

    [ForeignKey("Subject")]
    [Required]
    public int SubjectId { get; set; }
    public virtual Subject Subject { get; set; }

    [ForeignKey("Classroom")]
    [Required]
    public int ClassroomId { get; set; }
    public virtual Classroom Classroom { get; set; }
}

public enum SemesterEnum
{
    I = 1,
    II = 2
}