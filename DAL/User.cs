﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL;
[Table("Users")]
public class User
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int UserId { get; set; }

  [Column(TypeName ="varchar(50)")]
  [Required]
  public string Name { get; set; }


  [Column(TypeName ="varchar(250)")]
  public string Address { get; set; }

  [Column(TypeName ="varchar(20)")]
  [Required]
  public string Contact { get; set; }

}
