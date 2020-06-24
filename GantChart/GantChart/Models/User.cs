using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace GantChart.Models
{
    class User
    {
        [Key]
        [StringLength(255)]
        public string UserName { get; set; }
        [StringLength(255)]
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        [StringLength(12)]
        public string Phone { get; set; }
        [StringLength(75)]
        public string Email { get; set; }
        public byte[] ImageUrl { get; set; }
        public virtual ICollection<TaskWork> Tasks{get; set;}

    }
}