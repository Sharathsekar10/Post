using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewMania.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public byte[] Image { get; set; }

        public ICollection<Post> Posts { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }

        //    public string GetPicture()
        //    {
        //        if (Image == null){


        //            return null;
        //        }
        //        var base64Image = System.Convert.ToBase64String(Image);
        //        return $"data:{};base64,{base64Image}";
        //}
    }
}