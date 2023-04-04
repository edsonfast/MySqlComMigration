using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MySqlComMigration.Model {
    [Table("contato")]
    public class Contato {

        public int GetPrimaryKey() {
            return this.id;
        }

        [Key]
        [Column("id")]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório!")]
        [DisplayName("Nome do contato")]
        [Column("nome")]
        public virtual string nome { get; set; }

        public virtual string email { get; set; }
        public virtual string telefone { get; set; }

        public virtual Double? salario { get; set; }

        // http://stackoverflow.com/questions/20662780/error-in-entity-framework-6-0-2-using-migration
        [DisplayFormat(DataFormatString = "{0:n2}",
                    ApplyFormatInEditMode = true,
                    NullDisplayText = "Sem Nota")]
        [Range(0, 100, ErrorMessage = "A nota deverá ser entre 0 a 100.")]
        [Required(ErrorMessage = "Informe a Nota do Aluno")]
        [Column("NotaAluno", TypeName = "decimal")]
        [DisplayName("Nota do Aluno:*")]
        public decimal dNota { get; set; }

        [ConcurrencyCheck]
        public virtual DateTime? rowversion { get; set; }
        
        // http://www.entityframeworktutorial.net/code-first/concurrencycheck-dataannotations-attribute-in-code-first.aspx
        // Erro: Sequence contains no matching element
        // http://forums.mysql.com/read.php?38,520197,520197
        //[Timestamp]
        //public virtual byte[] rowversion { get; set; }

        public virtual string obs { get; set; }

        public virtual int? id_cliente { get; set; }

        [DefaultValue(0)]
        public virtual long deleted { get; set; }

        [ForeignKey("id_cliente")]
        public virtual Pessoa Cliente { get; set; }
    }
}