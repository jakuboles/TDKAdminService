//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TDKAdminService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class AppUser
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public string id { get; set; }

        [DisplayName("Email")]
        [ReadOnly(true)]
        public string email { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string userPassword { get; set; }

        [DataType(DataType.Password)]
        [HiddenInput(DisplayValue = false)]
        public string Password { get; set; }

        [HiddenInput(DisplayValue = false)]
        public byte[] version { get; set; }

        [DisplayName("Zarejestrowano")]
        [ReadOnly(true)]
        public System.DateTimeOffset createdAt { get; set; }

        [HiddenInput(DisplayValue = false)]
        public System.DateTimeOffset updatedAt { get; set; }
    }
}