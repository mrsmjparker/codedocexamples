using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhotoSharingApplication.Models
{
//Class that represents properties for both Photos and Comments tables:
//SQLMIADB_Dev (dev.products.photo
//SQLAZExamPrep_PROD (products.photos table)
//Only the subject field is required after uploading photo.  
//Photos and comments may be edited after photos are in app, provided users have been authenticated

    public class Comment
    {
        public int CommentID { get; set; }
        public int PhotoID { get; set; }
        public string UserName { get; set; }
        [Required]
        [StringLength(250)]
        public string Subject { get; set; }
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
        public virtual Photo Photo { get; set; }
    }
}
