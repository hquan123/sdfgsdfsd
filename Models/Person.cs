using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace baithi15.Models;
[Table("Cau1")]
public class Person{
    [Key]
    public int IdNhanvien { get; set; }
    public string Name { get; set; }
    public float Age { get; set; }
    
}