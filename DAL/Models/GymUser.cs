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
    public abstract class GymUser : BaseEntity
    {
      

        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Email Required")]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Phone Required")]
        [Phone]
        public string phone { get; set; } = null!;

        public DateOnly DateOfBirth { get; set; }
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Address Required")]
        public Address Address { get; set; } = null!;
    }
}
