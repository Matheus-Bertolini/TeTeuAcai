using System.ComponentModel.DataAnnotations.Schema;

namespace TeTeuAcai.Models;

[Table("Calda")]
public class Calda
{
    public int Id { get; set; }
    public string Nome { get; set; }
}
