using System.ComponentModel.DataAnnotations.Schema;

namespace TeTeuAcai.Models;
[Table("Acai")]
public class Acai
{
    public int Id { get; set; }
    public string Foto { get; set; }
    public double Preco { get; set; }


}
