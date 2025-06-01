using System.ComponentModel.DataAnnotations.Schema;

namespace Comunity2.Models
{
    [NotMapped]
    public class Role
    {
        public const string Admin = "Admin";
        public const string User = "User";
    }
}
