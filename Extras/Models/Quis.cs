using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comunity2.Models
{
    public class Quis
    {
        public int Id {  get; set; }
        [MinLength(6,ErrorMessage = "You must write more than 6 characters")]
        [Required]
        [MaxLength(16,ErrorMessage = "You must write less than 16 characters")]

        public string Name { get; set; }
        //كل كويز تابع لشخص واحد وهو الذي انشأ هذا الكويز
        [ForeignKey("User_Id")]
        public User User { get; set; }
        public string User_Id {  get; set; }
        public DateTime Quis_Date_Created {  get; set; }
        [MinLength(15,ErrorMessage = "You must write more than 15 characters")]
        [MaxLength(50,ErrorMessage = "You must write less than 50 characters")]
        public string Description { set; get; }
        public List<Quistion> Quistions {  get; set; }
        //كل امتحان منشئ مقدم اكثر من مرة 
        public List<DoQuis> DoQuis { get; set; }  

    }
}
