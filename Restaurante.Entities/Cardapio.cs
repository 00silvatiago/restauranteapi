using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Restaurante.Entities
{
    [Table("CARDAPIO")]
    public class Cardapio
    {
        [Key]           
        public int ID_CARDAPIO { get; set; }
        public int ID_RESTAURANTE { get; set; }
        public string CARDAPIO_PRATO { get; set; }
        public string CARDAPIO_PRATO_DIA { get; set; }
    }
}
