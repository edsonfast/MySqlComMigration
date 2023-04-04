namespace MySqlComMigration.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MySqlComMigration.Model.Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.EntityFramework.MySqlMigrationSqlGenerator());

            // Gerar nova atualização
            // Add-Migration MigrationV2

            // Atualizar
            // update-database -Verbose -Target:MigrationV2

            // Alterar atualizar em caso de Renomear colunas (Parameter '@columnType' must be defined.)
            // Adicionado para isso na string de conexão: "Allow User Variables=True"
            ////AddColumn("dbo.pessoa", "nome", c => c.String(nullable: false, unicode: false));
            ////DropColumn("dbo.pessoa", "nome_pess");
            //RenameColumn("dbo.pessoa", "nome_pess", "nome");

            // Gerar somente o Script
            // update-database -Script -SourceMigration:0

            // Tipo TimeStamp não suportado, fazer manual ou alterar atualização 
            // Sql("ALTER TABLE `banco_teste`.`contato` CHANGE COLUMN `rowversion` `rowversion` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP ;");
        }

        protected override void Seed(MySqlComMigration.Model.Contexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
