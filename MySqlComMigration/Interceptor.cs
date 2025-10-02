using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlComMigration {
    /// <summary>
    /// Filters out collations with NULL id (e.g. UCA-14.0.0) from SHOW COLLATION command
    /// </summary>
    public sealed class Interceptor : BaseCommandInterceptor {
        public override bool ExecuteReader(string sql, CommandBehavior behavior, ref MySqlDataReader returnValue) {
            if (!sql.Equals("SHOW COLLATION", StringComparison.OrdinalIgnoreCase)) {
                return false;
            }

            var command = ActiveConnection.CreateCommand();

            command.CommandText = "SHOW COLLATION WHERE id IS NOT NULL";
            returnValue = command.ExecuteReader(behavior);

            return true;
        }
    }
}
