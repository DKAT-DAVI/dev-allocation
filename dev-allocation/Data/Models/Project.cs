using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_allocation
{
    [Table("tbl_project")]
    internal class Project
    {
        // Primary Key
        public Int64 Id { get; set; }

        [Required]
        [StringLength(35)]
        public String Name { get; set; }

        public DateTime StartIn { get; set; }
        public DateTime FinishPlannedIn { get; set; }
        public DateTime FinishIn { get; set; }        

        //-- Constructors()
        public Project() 
        {
        }
        public Project(String name, DateTime startIn, DateTime finishPlannedIn)
        {
            Name = name;
            StartIn = startIn;
            FinishPlannedIn = finishPlannedIn;
        }
        public Project(String name, DateTime startIn, DateTime finishPlannedIn, DateTime finishIn)
        {
            Name = name;
            StartIn = startIn;
            FinishPlannedIn = finishPlannedIn;
            FinishIn = finishIn;
        }
        //--//
    }
}
