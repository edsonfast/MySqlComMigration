using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlComMigration.Model {
    [Table("standard")]
    public class Standard {
        public Standard() {

        }
        public virtual int StandardId { get; set; }
        public virtual string StandardName { get; set; }
        public virtual ICollection<Student> Students { get; set; }

    }
}
