using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlComMigration.Model {
    [Table("student")]
    public class Student {
        public Student() {

        }
        public virtual int StudentID { get; set; }
        public virtual string StudentName { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual byte[] Photo { get; set; }
        public virtual decimal Height { get; set; }
        public virtual float Weight { get; set; }

        //Foreign key for Standard
        public virtual int? id_standard { get; set; }

        [ForeignKey("id_standard")]
        public virtual Standard Standard { get; set; }
    }
}
