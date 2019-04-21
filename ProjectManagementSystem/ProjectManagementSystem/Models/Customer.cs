using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagementSystem.Models
{
    public class Customer
    {
        [Key]
        public int customerID { get; set; }
        [Required]
        public String job_description { get; set; }
        [Required]
        public String image { get; set; }
        [Required]
        public String first_name { get; set; }
        [Required]
        public String last_name { get; set; }
        [Required]
        public String email { get; set; }
        [Required]
        public String mobile { get; set; }
    }
}