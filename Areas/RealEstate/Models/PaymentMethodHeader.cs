﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEstateInvestment.Areas.RealEstate.Models
{
    [Table("PaymentMethodHeader")]
    public class PaymentMethodHeader
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name="كود النظام")]
        public int Id { get; set; }

        [Required(ErrorMessage ="يجب عليك ادخال اسم النظام")]
        [Display(Name = "اسم النظام")]
        public string Name { get; set; }

        [Required(ErrorMessage = "يجب عليك ادخال عدد شهور النظام")]
        [Display(Name = "عدد شهور النظام")]
        public int TotalMonthPeriod { get; set; }

        public ICollection<PaymentMethodDetail> PaymentMethodDetails { get; set; }
    }
}