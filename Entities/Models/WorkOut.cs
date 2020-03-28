using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("WorkOut")]
    public class WorkOut
    {
        [Key]
        Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid Type { get; set; }
        public bool Active { get; set; }
        public Guid Organization { get; set; }
        public string Sport { get; set; }
    }
}
