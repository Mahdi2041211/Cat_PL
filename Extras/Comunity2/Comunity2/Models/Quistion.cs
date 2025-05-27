using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comunity2.Models
{
    public class Quistion
    {
        public int Id { get; set; }
        [MinLength(20, ErrorMessage = "You must write more than 20 characters")]
        [Required]
        public string Content {  get; set; }
        [MinLength(1, ErrorMessage = "You must write more than 1 characters")]
        [MaxLength(15, ErrorMessage = "You must write less than 15 characters")]
        [Required]
        public string Answer1 {  get; set; }

        [MinLength(1, ErrorMessage = "You must write more than 1 characters")]
        [MaxLength(15, ErrorMessage = "You must write less than 15 characters")]
        [Required]
        public string Answer2 { get; set; }
        [MinLength(1, ErrorMessage = "You must write more than 1 characters")]
        [MaxLength(15, ErrorMessage = "You must write less than 15 characters")]
        [Required]
        public string Answer3 { get; set; }
        [MinLength(1, ErrorMessage = "You must write more than 1 characters")]
        [MaxLength(15, ErrorMessage = "You must write less than 15 characters")]
        [Required]
        public string Answer4 { get; set; }
        [MinLength(1, ErrorMessage = "You must write more than 1 characters")]
        [MaxLength(15, ErrorMessage = "You must write less than 15 characters")]
        [Required]
        public string Correct_Answer {  get; set; }
        [ForeignKey("Quis_Id")]
        public Quis Quis {  get; set; }
        //كل سؤال تابع لكويز واحد فقط 
        public int Quis_Id {  get; set; }


    }
}
