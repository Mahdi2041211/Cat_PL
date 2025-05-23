using System.ComponentModel.DataAnnotations.Schema;

namespace Comunity2.Models
{
    public class Image
    {
        public int Id { set; get; }
        [ForeignKey("Post_Id")]
        //كل صورة تابعة لمنشور واحد 
        public Post Post { set; get; }
        public int Post_Id {  set; get; }

    }
}
