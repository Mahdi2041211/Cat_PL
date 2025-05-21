using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Comunity2.Models
{
    public class User:IdentityUser
    {
        [MaxLength(15)]
        [MinLength(5)]
        [Required]
        public string FirstName {  get; set; }
        [MaxLength(15)]
        [Required]
        [MinLength(5)]
        public string LastName { get; set; }
        public byte[]? Image {  get; set; }
        //كل مستخدم له عدة منشورات 
        public ICollection<Post> ? Posts { get; set; }
        //كل مستخدم له مجموعة من  التعليقات 
        public ICollection<Comment>? comments { get; set; }
    }

}
