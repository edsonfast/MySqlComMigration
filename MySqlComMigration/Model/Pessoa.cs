using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlComMigration.Model {
    [Table("pessoa")]
    public partial class Pessoa {       

        [Key]
        [Column("id_pessoa")]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int id_pessoa { get; set; }

        [Required]
        public string nome { get; set; }

        public int? id_pes_rep { get; set; }
        //[ForeignKey("id_pes_rep")]
        public virtual Pessoa Representante { get; set; }


        public int? id_pes_tra { get; set; }
        //[ForeignKey("id_pes_tra")]
        public virtual Pessoa Trabalho { get; set; }

        [DefaultValue(0)]
        public virtual ETipoPessoa tipo { get; set; }
        

        public virtual IList<Contato> Contatos { get; set; }
        public virtual IList<Endereco> Enderecos { get; set; }
    }
}
