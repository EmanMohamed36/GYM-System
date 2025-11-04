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
    // Represent Specialization or classification  for training programs and sessions
    public class Category:BaseEntity
    {

        [Required(ErrorMessage = "Category name required")]
        public Specialties CategoryName { get; set; }

        #region OneToManyRelationWithSessions

        public ICollection<Session> Sessions { get; set; } = new List<Session>();

        #endregion
    }
}
