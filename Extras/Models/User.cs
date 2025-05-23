using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comunity2.Models
{
    public class User:IdentityUser
    {
        [MaxLength(15,ErrorMessage="You must write less than 15 characters")]
        [MinLength(5,ErrorMessage ="You must write more than 5 characters")]
        [Required] 
        public string FirstName {  get; set; }
        [MaxLength(15, ErrorMessage = "You must write less than 15 characters")]
        [MinLength(5, ErrorMessage = "You must write more than 5 characters")]
        [Required]
        public string LastName { get; set; }
        public byte[]? Image {  get; set; }
        //كل مستخدم له عدة منشورات 
        public List<Post> ? Posts { get; set; }
        //كل مستخدم له مجموعة من  التعليقات 
        public ICollection<Comment>? comments { get; set; }
        //كل مستخدم له عدة لايكات
        public ICollection< Likies>? Likes { get; set; }
        //كل ادمن حصرا يستطيع ان ينشأ اكثر من كويز
        public List<Quis>? Quis { get; set; }
        //كل مستخدم يستطيع ان يقدم اكثر من امتحان 
        public List<DoQuis>? DoQuis { get; set; }
    }

}
