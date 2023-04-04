using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlComMigration.Model {
    public class PessoaMap : EntityTypeConfiguration<Pessoa> {
        public PessoaMap()
        {
            // Many-To-One
            this.HasOptional(p => p.Representante)
                .WithMany()
                .HasForeignKey(p => p.id_pes_rep);

            this.HasOptional(p => p.Trabalho)
                .WithMany()
                .HasForeignKey(p => p.id_pes_tra);
        }
    }
}
