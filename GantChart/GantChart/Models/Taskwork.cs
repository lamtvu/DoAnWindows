using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Design;
using System.Drawing.Printing;

namespace GantChart.Models
{
    class TaskWork
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(255)]
        public string description { get; set; }
        public int PercentCompleted { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime FromDate { get; set; }
        [StringLength(10)]
        public string Priority { get; set; }
        public string Url { get; set; }
        public virtual ICollection<User> Users { get; set; }

        public string GetUsers()
        {
            string str = "";
            foreach (User item in Users)
            {
                str += item.UserName + " ";
            }
            return str;
        }

    }

}