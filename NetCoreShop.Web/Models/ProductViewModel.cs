using Microsoft.AspNetCore.Http;
using NetCoreShop.Web.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace NetCoreShop.Web.Models
{
    public class ProductViewModel : Product
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }

    }
}
