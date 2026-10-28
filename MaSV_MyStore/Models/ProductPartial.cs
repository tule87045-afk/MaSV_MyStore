using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace MaSV_MyStore.Models
{
    public partial class Product
    {
        [NotMapped]
        [RegularExpression(@"[a-zA-Z0-9\s_\.\-:])+(.png|.jpg|.gif|.PNG|.JPG|.GIF)$",
            ErrorMessage = "Chỉ chấp nhận các định dạng ảnh PNG, JPG và GIF")]
        public HttpPostedFileBase UploadImg { get; set; }
    }
}