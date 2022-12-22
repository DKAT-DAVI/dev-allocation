using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_allocation
{
    [Table("tbl_task")]
    internal class Task
    {
        // Primary Key
        public Int64 Id { get; set; }

        [StringLength(200)]
        public String Description{ get; set; }

        // Constructors()
        public Task() { }
        public Task(String description)
        {
            Description = description;
        }

    }
}
