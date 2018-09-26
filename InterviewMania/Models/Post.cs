using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewMania.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string PostName { get; set; }
        public string PostDescription { get; set; }

        public int CatergoryId { get; set; }
        public Category Category { get; set; }

        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
