using System.ComponentModel.DataAnnotations.Schema;

namespace Comunity2.Models
{
    public class Likies
    {
        public int Id { get; set; }
        public DateTime Like_Date_Created { get; set; }=DateTime.Now;
        [ForeignKey("User_Id")]
        public User User { get; set; }
        //  كل لايك تابع لمستخدم واحد 
        public string User_Id {  get; set; }
        public bool Status_Like { get; set; } = false;
        [ForeignKey("Post_Id")]
        public Post Post { get; set; }
        //كل لايك تابع لمنشور واحد
        public int Post_Id {  get; set; }
        [ForeignKey("Comment_Id")]
        public Comment Comment { get; set; }
        //كل لايك تابع لتعليق واحد 
        public int Comment_Id { get; set; }
    }
}
