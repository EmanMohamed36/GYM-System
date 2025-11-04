using DAL.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    //Represent gym membership or training plan offered to members
    public class Plan:BaseEntity
    {

        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; } = null!;

        public  string? Description { get; set; }
        [Range(1,365,ErrorMessage ="Duration Dayes Should between 1 To 365")]
        public int DurationDays { get; set; } // in days
                                              

        [Range(1,int.MaxValue,ErrorMessage ="Price Should be Positive Value")]
        public decimal Price { get; set; } // positive 

        public bool IsActive { get; set; } // indicate plan is active or not 


        #region ManyToManyRelationWithMembers
        public ICollection<MembersAssignPlans> MemberPlans { get; set; } = new List<MembersAssignPlans>();

        #endregion
    }
}
