using DAL.Models.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    // Represent registerd GYM member
    public class Member:GymUser
    {
      

        //public DateTime JoinDate { get; set; } // Date when The Member Joined the Gym

        #region Picture
        //photo -> profile picture
        public string? Photo { get; set; }

        #endregion


        #region OneToOneRelationWithHealthRecord
        public HealthRecord HealthRecord { get; set; } = null!;

        #endregion

        #region ManyToManyRelationWithPlans
        public ICollection<MembersAssignPlans> MemberPlans { get; set; } = new List<MembersAssignPlans>();

        #endregion

        #region ManyToManyRelationWithSessions

        public ICollection<MembersBookSessions> MembersBookSessions { get; set; } = new List<MembersBookSessions>();
        #endregion


    }
}
