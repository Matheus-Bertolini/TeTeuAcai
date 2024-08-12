using System.ComponentModel.DataAnnotations;

namespace TeTeuAcai.Models;

    public class Complemento
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        
    }
