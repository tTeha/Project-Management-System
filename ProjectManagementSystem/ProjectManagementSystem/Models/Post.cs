using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectManagementSystem.Models
{
    public class Post
    {
        [Key]
        [Required]
        public int postID { get; set; }
        [Required]
        public String Header { get; set; }
        [Required]
        public String description { get; set; }
        [Required]
        public DateTime created_date { get; set; }
        [Required]
        public DateTime updated_date { get; set; }
        [Required]
        public String post_status { get; set; }
        public DateTime deliever_time { get; set; }
        [Required]
        public int price { get; set; }
        [Required]
        public Customer customer { get; set; }
        public ProjectManager PM { get; set; }

        public virtual ICollection<PostComment> PostComment { get; set; }
        public virtual ICollection<PmProjectApply> PmProjectApply { get; set; }
        public virtual ICollection<leaveProjectRequest> leaveProjectRequest { get; set; }
    }


    public class PostComment
    {
        [Required]
        [Key, Column(Order = 0)]
        public int managerID { get; set; }
        [Key, Column(Order = 1)]
        public int postID { get; set; }

        public virtual ProjectManager projectManager { get; set; }
        public virtual Post post { get; set; }

        public string Comment { get; set; }
    }

    public class PmProjectApply
    {
        [Key, Column(Order = 0)]
        public int managerID { get; set; }
        [Key, Column(Order = 1)]
        public int postID { get; set; }

        public virtual ProjectManager projectManager { get; set; }
        public virtual Post post { get; set; }

        public string Response { get; set; }
    }

    public class leaveProjectRequest
    {
        [Key, Column(Order = 0)]
        public int developerID { get; set; }
        [Key, Column(Order = 1)]
        public int postID { get; set; }
        [Key, Column(Order = 2)]
        public int managerID { get; set; }

        public virtual Developer developer { get; set; }
        public virtual Post post { get; set; }
        public virtual ProjectManager projectManager { get; set; }

        public string leave_request { get; set; }
    }
}