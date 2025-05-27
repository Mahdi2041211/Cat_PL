using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comunity2.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "You must write more than 1 characters")]
        [MinLength(1)]
        public string Text {  get; set; }
        [ForeignKey("User_Id")]
        //كل تعليق صاحبه مستخدم واحد 
        public User User { get; set; }
        public string User_Id {  get; set; }
        public DateTime Comment_Date_Created { get; set; }= DateTime.Now;
        public int Count_Likes { get; set; } = 0;
        //كل تعليق تابع لمنشور واحد 
        [ForeignKey("Post_Id")]
        public Post Post { get; set; }
        public int Post_Id { get; set;}
        //كل تعليق  يمكن ان يكون له عدة لايكات 
        public ICollection<Likies>? Likes { get; set; }
    }

}
