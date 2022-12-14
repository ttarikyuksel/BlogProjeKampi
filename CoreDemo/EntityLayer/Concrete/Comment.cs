using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentUserName { get; set; }
        public string CommentTitle { get; set; }
        public string CommnetContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }

        public int BlogScore { get; set; }

        //Navigation Prop

        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}
