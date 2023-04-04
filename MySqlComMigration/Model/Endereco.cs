using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlComMigration.Model {
    [Table("endereco")]
    public class Endereco {
        public virtual int id { get; set; }
        public virtual string nome { get; set; }

        public virtual int? id_cliente { get; set; }

        [ForeignKey("id_cliente")]
        public virtual Pessoa Cliente { get; set; }
    }
}
