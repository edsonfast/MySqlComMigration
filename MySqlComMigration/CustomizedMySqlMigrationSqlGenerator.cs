using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlComMigration {
    public class CustomizedMySqlMigrationSqlGenerator : MySqlMigrationSqlGenerator {
        private string TrimSchemaPrefix(string table) {
            if (table.StartsWith("dbo."))
                return table.Replace("dbo.", "");
            return table;
        }

        protected override MigrationStatement Generate(CreateIndexOperation op) {
            // MySql.Data.MySqlClient.MySqlException (0x80004005): Incorrect usage of spatial/fulltext/hash index and explicit index order
            // https://stackoverflow.com/questions/50047931/entity-framework-with-mysql-database-migrations-fail-when-creating-indexes/51756143#51756143
            // MySql 57
            // CREATE index  `IX_referencia` on `mdfe` (`referencia` DESC) using HASH
            // MySql 57 e 80 testado
            // CREATE  INDEX `IX_referencia` ON `mdfe` (`referencia` DESC) USING BTREE
            // ou criar os index via sql: Sql("CREATE index `IX_userId` on `Articles` (`userId` DESC)");
            var u = new MigrationStatement();
            string unique = (op.IsUnique ? "UNIQUE" : ""), columns = "";
            foreach (var col in op.Columns) {
                columns += ($"`{col}` DESC{(op.Columns.IndexOf(col) < op.Columns.Count - 1 ? ", " : "")}");
            }
            u.Sql = $"CREATE {unique} INDEX `{op.Name}` ON `{TrimSchemaPrefix(op.Table)}` ({columns}) USING BTREE";
            return u;
        }
    }
}
