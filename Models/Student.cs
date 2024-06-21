using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace baithi15.Models;
[Table("Cau2")]
public class Student : Person{
    public string Diachi { get; set; }
    public int Msv { get; set; }

}
