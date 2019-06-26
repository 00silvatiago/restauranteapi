using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Restaurante.Entities
{
    [Table("RESTAURANTE")]
    public class Restaurante
    {
        [Key]
        public int ID_RESTAURANTE { get; set; }
        public Cardapio ID_CARDAPIO { get; set; }
        public int RESTAU_LOCAL { get; set; }
        public int RESTAU_PRECO_KILO { get; set; }
    }
}
