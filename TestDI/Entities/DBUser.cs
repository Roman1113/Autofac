using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDI.Entities
{
    [Table("tblUsers")]
    public class DbUser
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Email { get; set; }
        [Required, StringLength(255)]
        public string Password { get; set; }
    }
}
