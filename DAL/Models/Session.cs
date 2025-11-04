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
    // Represent scheduled gym session conducted by a trainer for members

    public class Session:BaseEntity
    {
  

        public string? Description { get; set; }

        [Range(1, 25, ErrorMessage = "Capacity Should between 1 to 25")]
        [Required(ErrorMessage ="Capacity required")]
        public int Capacity { get; set; } // Maximum number of members allowed 

        public DateTime StartDate { get; set; } //Date and Time session begins
        public DateTime EndDate { get; set; } //Date and Time session Ends

        #region ManyToManyRelationWithSessions

        public ICollection<MembersBookSessions> MembersBookSessions { get; set; } = new List<MembersBookSessions>();
        #endregion

        #region OneToManyRelationWithTrainer
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; } = null!;

        #endregion

        #region OneToManyRelationWithCategory

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        #endregion

    }
}
