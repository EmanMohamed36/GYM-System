using DAL.Models.Shared;
using DAL.Models.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    //Represent the Health Information associated with gym member
    public class HealthRecord:BaseEntity

    {   
        
        [Range(1, int.MaxValue, ErrorMessage = "Height Should be Positive Value")]
        public decimal Height { get; set; } //in CM // positive

                                        
        [Range(1, int.MaxValue, ErrorMessage = "Weight Should be Positive Value")]
        public decimal Weight { get; set; } // in kg //positive

        public string? Note { get; set; }

        //Blood Type
        public BloodType BloodType { get; set; }

        #region OneToOneRelationWithMember
        public int MemberId { get; set; }
        public Member Member { get; set; } = null!;
        #endregion
    }
}
