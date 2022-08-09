using System;
using System.ComponentModel.DataAnnotations;

namespace Luftborn.Data
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Name field is required !!!"), MaxLength(10)]
        public string Name { get; set; }
        public DateTime Created_Date { get; set; }

        [Required(ErrorMessage = "Image field is required !!!"), MaxLength(10)]
        public string Image { get; set; }
    }
}
