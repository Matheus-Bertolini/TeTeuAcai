using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeTeuAcai.Models;
[Table("AcaiComplemento")]
public class AcaiComplemento
{
    [Key, Column(Order = 1)]
    public int AcaiId { get; set; }
    [ForeignKey("AcaiId")]
    public Acai Acai { get; set; }

    [Key, Column(Order = 2)]
    public int ComplementoId { get; set; }
    [ForeignKey("ComplementoId")]
    public Complemento Complemento { get; set; }
}
