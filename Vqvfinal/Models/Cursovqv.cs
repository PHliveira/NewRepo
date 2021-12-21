using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vqvfinal.Models
{ [Table("Cursovqv")]
    public class Cursovqv
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "informe a descrição")]
        [StringLength(50)]
        public string Destino { get; set; }
        [Required(ErrorMessage = "informe a carga horaria")]
        public int Valor { get; set; }

    }
}
