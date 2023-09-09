using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models.EF
{
    [Table("tb_ProductImage")]
    public class ProductImage
    {
        public int Id { get; set; }
        public string ProductID { get; set; }
        public string Image { get; set; }
        public string IsDefault { get; set; }
    }
}