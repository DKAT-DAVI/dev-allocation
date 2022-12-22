using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_allocation
{
    [Table("tbl_allocation")]
    internal class Allocation
    {
        public Int64 Id { get; set; }
        public DateTime StartIn { get; set; }
        public DateTime FinishIn { get; set; }
        public Byte HoursWorkPerWeek { get; set; }
        public Decimal Remuneration { get; set; }

        //-- Relationships
        public Project Project { get; set; }
        public Developer Developer { get; set; }

        [NotMapped]
        public List<Task> Tasks { get; set; }
        //--//

        //-- Constructors()
        public Allocation()
        {
            Tasks = new List<Task>();
        }
        public Allocation(DateTime startIn, DateTime finishIn, byte hoursWorkPerWeek, decimal remuneration) :this()
        {
            StartIn = startIn;
            FinishIn = finishIn;
            HoursWorkPerWeek = hoursWorkPerWeek;
            Remuneration = remuneration;
        }
        public Allocation(DateTime startIn, DateTime finishIn, byte hoursWorkPerWeek, decimal remuneration, Project project, Developer developer) : this()
        {
            StartIn = startIn;
            FinishIn = finishIn;
            HoursWorkPerWeek = hoursWorkPerWeek;
            Remuneration = remuneration;
            Project = project;
            Developer = developer;
        }

        //--//
    }
}
