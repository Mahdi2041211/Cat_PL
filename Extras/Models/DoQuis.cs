using System.ComponentModel.DataAnnotations.Schema;

namespace Comunity2.Models
{
    //هذا الجدول هو للامتحانات التي سيقدمها المستخدمين 
    public class DoQuis
    {
        public int Id { get; set; }
        [ForeignKey("User_Id")]
        //كل امتحان مجرى تابع لمستخدم واحد 
        public User User { get; set; }
        public string User_Id { get; set; }
        public DateTime DoQis_Date_Created { set; get; }=DateTime.Now;
        public double Mark { get; set; }
        [ForeignKey("Quis_Id")]
        //كل امتحان مقدم تابع لامتحان منشئ واجد 
        public Quis Quis { get; set; }
        public int Quis_Id {  get; set; }

    }
}
