using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comunity2.Models
{
    public class Post
    {
        public int Id {  get; set; }
        [Required(ErrorMessage = "You must write more than 19 characters")]
        [MinLength(20)]
        public string Text { set; get; }
        public DateTime Post_Date_Created { get; set; } = DateTime.Now;

        public int Count_Likes { get; set; } = 0;
        [ForeignKey("User_Id")]
        public User User { get;set;}
        //هنا كل منشور تابع لمستخدم واحد فقط 
        public string User_Id {get;set;}
        [NotMapped]
        public ICollection<IFormFile> files { get; set;}
        //كل منشور له عدة تعليقات 
        public ICollection<Comment> Comments { get; set; }
        //كل منشور يمكن ان يكزن له عدة صور 
         public ICollection<Image>? Images { get; set; }
        //كل منشور يمكن ان يحتوي على عدة لايكات 
         public ICollection<Likies>? Likes { get; set; }
    }
}
