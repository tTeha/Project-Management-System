using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectManagementSystem.Models
{
    public class ProjectManager
    {
        [Key]
        public int managerID { get; set; }
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


        public virtual ICollection<PostComment> PostComment { get; set; }
        public virtual ICollection<PmProjectApply> PmProjectApply { get; set; }
        public virtual ICollection<leaveProjectRequest> leaveProjectRequest { get; set; }
        public virtual ICollection<PmStuffRequest> PmStuffRequest { get; set; }
        public virtual ICollection<RemoveJDbyTLrequest> RemoveJDbyTLrequest { get; set; }

    }

    public class PmStuffRequest
    {
        [Key, Column(Order = 0)]
        public int leaderID { get; set; }
        [Key, Column(Order = 1)]
        public int managerID { get; set; }

        public virtual TeamLeader teamleader { get; set; }
        public virtual ProjectManager projectmanager { get; set; }

        public string request_status { get; set; }
    }

    public class RemoveJDbyTLrequest
    {
        [Key, Column(Order = 0)]
        public int leaderID { get; set; }
        [Key, Column(Order = 1)]
        public int developerID { get; set; }
        [Key, Column(Order = 2)]
        public int managerID { get; set; }

        public virtual TeamLeader teamLeader { get; set; }
        public virtual Developer developer { get; set; }
        public virtual ProjectManager projectManager { get; set; }

        public string remove_request { get; set; }
    }
}