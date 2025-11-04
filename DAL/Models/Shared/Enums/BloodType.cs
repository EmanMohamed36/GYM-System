using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Shared.Enums
{
    public enum BloodType
    {
        [Display(Name = "A+")]
        A_Positive = 1,
        [Display(Name = "A-")]
        A_Negative = 2 ,
        [Display(Name = "B+")]
        B_Positive = 3,
        [Display(Name = "B-")]
        B_Negative = 4,
        [Display(Name = "O+")]
        O_Positive = 5,
        [Display(Name = "O-")]
        O_Negative = 6,
        [Display(Name = "AB+")]
        AB_Positive = 7,
        [Display(Name = "AB-")]
        AB_Negative = 8,

    }
}
