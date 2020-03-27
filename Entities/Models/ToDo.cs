using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("ToDo")]
    public class ToDo
    {
        public Guid ID { get; set; }

        [Required(ErrorMessage = "Task title is required")]
        [StringLength(100, ErrorMessage = "Task title can't be longer than 100 characters")]
        public string TaskTitle { get; set; }

        [Required(ErrorMessage = "Task is required")]
        [StringLength(1000, ErrorMessage = "Task can't be longer than 1000 characters")]
        public string Task { get; set; }

        public string OwnerAccountID { get; set; }

        public bool Complete { get; set; }
    }
}
