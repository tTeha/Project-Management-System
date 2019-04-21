using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagementSystem.Models
{
    public class Developer
    {
        [Key]
        public int developerID { get; set; }
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
        [Required]
        public String qualifications { get; set; }
        [Required]
        public String experience { get; set; }

        public virtual ICollection<leaveProjectRequest> leaveProjectRequest { get; set; }
        public virtual ICollection<RemoveJDbyTLrequest> RemoveJDbyTLrequest { get; set; }
        public virtual ICollection<JdEvaluationByTL> JdEvaluationByTL { get; set; }

    }
}