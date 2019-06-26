using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Restaurante.Entities
{
    [Table("VOTACAO")]
    public class Votacao
    {
        [Key]
        public int ID_VOTACAO { get; set; }
        public Restaurante ID_RESTAURANTE { get; set; }
        public Aluno ID_ALUNO { get; set; }
        public DateTime VOTACAO_DATA { get; set; }
    }
}
