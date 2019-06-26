using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Restaurante.Entities
{
    [Table("HISTORICO_VOTACAO")]
    public class HistoricoVotacao
    {
        [Key]
        public int ID_HISTVOT { get; set; }
        public DateTime HISTVOT_DATA { get; set; }
        public Votacao ID_VOTACAO { get; set; }
    }
}
