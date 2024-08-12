using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeTeuAcai.Models;

[Table("Complemento")]
public class Complemento
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }

}
