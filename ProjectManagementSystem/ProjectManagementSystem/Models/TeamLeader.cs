using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectManagementSystem.Models
{
    public class TeamLeader
    {
        [Key]
        public int leaderID { get; set; }
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

        public virtual ICollection<PmStuffRequest> PmStuffRequest { get; set; }
        public virtual ICollection<RemoveJDbyTLrequest> RemoveJDbyTLrequest { get; set; }
        public virtual ICollection<JdEvaluationByTL> JdEvaluationByTL { get; set; }


    }

    public class JdEvaluationByTL
    {
        [Key, Column(Order = 0)]
        public int leaderID { get; set; }
        [Key, Column(Order = 1)]
        public int developerID { get; set; }

        public virtual TeamLeader teamLeader { get; set; }
        public virtual Developer developer { get; set; }

        public string evaluation { get; set; }
    }
}