using DAL.Models.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Trainer:GymUser
    {
        public Specialties Specialties { get; set; }
        //public DateTime HireDate { get; set; } // Date the trainer was hired

        #region OneToManyRelationWithSessions

        public ICollection<Session> Sessions { get; set; } = new List<Session>();

        #endregion
    }
}
