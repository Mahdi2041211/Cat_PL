using System.ComponentModel.DataAnnotations;

namespace Comunity2.Models
{
    public class Exam
    {
        public int Id { get; set; }
        [MaxLength(15)]
        [MinLength(5)]
        [Required]
        public string Title { set; get; }
        public DateTime Exam_Date_Created { set; get; }=DateTime.Now;
        
    }
}
