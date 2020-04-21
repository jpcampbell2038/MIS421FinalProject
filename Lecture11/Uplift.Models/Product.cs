using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Uplift.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public float? Cost { get; set; }

        [DataType(DataType.Upload)]
        public byte[] ProductImage { get; set; }
    }
}
