using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Student
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int Id { get; set; }

    //[Required]
    //[StringLength(50)]
    public string LastName { get; set; }

    //[Required]
    //[StringLength(50)]
    public string FirstName { get; set; }

    //[Required]
    public DateTime? Dob { get; set; }

    //[Required]
    public SexEnum? Sex { get; set; }

    //[StringLength(100)]
    public string? Address { get; set; }

    //[StringLength(100)]
    public string? Email { get; set; }

    //[StringLength(20)]
    public string? Phone { get; set; }
}

public enum SexEnum
{
    Female,
    Male
}