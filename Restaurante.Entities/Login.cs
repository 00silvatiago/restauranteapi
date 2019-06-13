using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
//ENTITIES OU ENTIDADES SE REFERE AS TABLEAAS DO BANCO, CADA TABELA DIRÁ A RESPEITO DE UMA CLASSE(entidade)
namespace Restaurante.Entities
{
    [Table("LOGIN")]
    public class Login
    {
        [Key]
        public int LGN_ID { get; set; }
        public string LGN_LOGIN { get; set; }
        public string LGN_SENHA { get; set; }
    }
}
