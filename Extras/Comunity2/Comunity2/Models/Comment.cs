using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comunity2.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="You Must Write A more than 19 litter")]
        [MinLength(20)]
        public string Text {  get; set; }
        [ForeignKey("User_Id")]
        public User User { get; set; }
        public string User_Id {  get; set; }
        public DateTime Comment_Date_Created { get; set; } = DateTime.Now;
        public int Count_Likes {  get; set; }

    }
}
