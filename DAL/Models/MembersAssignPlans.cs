using DAL.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class MembersAssignPlans:BaseEntity
    {


        public int MemberId { get; set; }
        public Member Member { get; set; } = null!;

        public string Status
        {
            get
            {
                if (EndDate >= DateTime.Now)
                {
                    return "Expired";
                }
                else return "Active";
            }
        }

        public int PlanId { get; set; }
        public Plan Plan { get; set; } = null!;
        
        [Required]
        public DateTime EndDate { get; set; }

    }
}
