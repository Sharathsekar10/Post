using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewMania.Models
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }

        public ICollection<Post> Posts { get; set; }

        public int CatergoryID { get; set; }
        public Category Category { get; set; }


    }
}
