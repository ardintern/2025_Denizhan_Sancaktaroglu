using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HanStore.MvsWebUI.Models
{
    public class ShippingDetails
    {
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }

        [Required(ErrorMessage = "*")]
        public string AdresBasligi { get; set; }

        [Required(ErrorMessage = "*")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "*")]
        public string Sehir { get; set; }

        [Required(ErrorMessage = "*")]
        public string Semt { get; set; }

        [Required(ErrorMessage = "*")]
        public string Mahalle { get; set; }

        public string PostKodu { get; set; }
        public Cart Cart { get; set; }

    }
}