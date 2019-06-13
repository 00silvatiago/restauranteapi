using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Restaurante.Entities
{
    [Table("ALUNO")]
    public class Aluno
    {
        [Key]
        public int ID_ALUNO { get; set; }
        public string ALUNO_NOME { get; set; }
        public string ALUNO_EMAIL { get; set; }
        public int LGN_ID { get; set; }
    }
}
