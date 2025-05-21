using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comunity2.Models
{
    public class Post
    {
        public int Id {  get; set; }
        [Required]
        [MinLength(20)]
        public string Text { set; get; }
        public DateTime Post_Date_Created { get; set; }= DateTime.Now;
        public int Count_Likes {  get; set; }=0;
        [ForeignKey("User_Id")]
        public User User { get;set;}
        //هنا كل منشور تابع لمستخدم واحد فقط 
        public string User_Id {get;set;}

    }
}
