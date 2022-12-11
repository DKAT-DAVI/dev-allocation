using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_allocation
{
    [Table("tbl_developer")]
    internal class Developer
    {
        // Primary Key
        public Int64 Id { get; set; }

        [Required]
        [StringLength(45)]
        public String Name { get; set; }

        public DateTime BirthDate { get; set; }

        /// Store the level in memory
        public Char LevelInMemoria { get; set; }

        /// Receive the level that was inserted into memory 
        /// and maps to the database
        /// 
        [Column(TypeName = "char")]
        [StringLength(1)]
        public String Level {
            get
            {
                return LevelInMemoria.ToString();
            }
            set
            {
                LevelInMemoria = value[0];
            }
        }

        // Atribut for ralation one-to-one with tbl_credential [FOREIGN KEY]
        public Credential Credential { get; set; }

        //-- Contructors()
        public Developer() { }

        public Developer(String name, DateTime birthDate, Char levelInMemoria)
        {
            Name = name;
            BirthDate = birthDate;
            LevelInMemoria = levelInMemoria;
        }
        //--//
    }
}
