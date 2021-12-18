using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ePizzaHub.WebUI.Models
{
    public class ItemModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün İsmini Giriniz.")]
        public string Name { get; set; }
        public IFormFile File { get; set; }

        [Required(ErrorMessage = "Ürün Açıklamasını Giriniz.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Ürün Fiyatını Giriniz.")]
        public decimal UnitPrice { get; set; }
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "ürün Kategorisini Seçiniz.")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Ürünü Giriniz.")]
        public int ItemTypeId { get; set; }
    }
}
