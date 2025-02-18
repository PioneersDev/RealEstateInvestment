﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEstateInvestment.Areas.RealEstate.Models
{
    [Table("ContractType")]
    public class ContractType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "الكود")]
        public int Id { get; set; }

        [Required(ErrorMessage = "يجب عليك ادخال الاسم")]
        [Display(Name = "الاسم")]
        public string Name { get; set; }

        public ICollection<ContractModel> ContractModels { get; set; }
    }
}