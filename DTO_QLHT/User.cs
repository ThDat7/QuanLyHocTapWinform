using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Username { get; set; }

    [Required]
    [StringLength(50)]
    public string Password { get; set; }

    //[Required]
    //[StringLength(50)]
    //public string LastName { get; set; }
    public string? LastName { get; set; }

    //[Required]
    //[StringLength(50)]
    //public string FirstName { get; set; }
    public string? FirstName { get; set; }

    //[Required]
    //public DateTime Dob { get; set; }
    public DateTime? Dob { get; set; }

    //[Required]
    //public SexEnum Sex { get; set; }
    public SexEnum? Sex { get; set; }

    //[StringLength(100)]
    //public string Address { get; set; }
    public string? Address { get; set; }

    //[StringLength(20)]
    //public string Phone { get; set; }
    public string? Phone { get; set; }

    //[Required]
    //[StringLength(100)]
    //public string Email { get; set; }
    public string? Email { get; set; }

    //[Required]
    //public RoleEnum Role { get; set; }
    public RoleEnum? Role { get; set; }
}

public enum RoleEnum
{
    ADMIN,
    STAFF,
    TEACHER
}