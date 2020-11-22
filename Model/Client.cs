using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Model
{
 public class Client
 {
  [Required]
  [StringLength(10, ErrorMessage = "Name is too long.")]
  public string Name { get; set; }
 }
}