using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;

namespace CategoriesApp.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = "";
    public int DisplayOrder { get; set; }
    public DateTime CreateDateTime { get; set; } = DateTime.Now;
}