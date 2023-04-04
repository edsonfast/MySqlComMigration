using MySqlComMigration.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace MySqlComMigration.Model {
    public class Contexto : DbContext {
        public Contexto()
            : base("Contexto") {
                this.Database.Log = Console.WriteLine;
        }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Configurations.Add(new PessoaMap());
        }

    }
}