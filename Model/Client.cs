using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Model
{
 public class Client
 {
  [Required]
  [StringLength(14, ErrorMessage = "Name is too long.")]
  public string Name { get; set; }
  public string Assunto { get; set; }
  public string Usuario { get; set; }
  public string Pessoa { get; set; }
  public string Tipo { get; set; }
 }
}