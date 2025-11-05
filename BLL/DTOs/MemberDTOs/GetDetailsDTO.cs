using DAL.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.MemberDTOs
{
    internal class GetDetailsDTO
    {
        public string? Photo { get; set; }
        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Email Required")]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Phone Required")]
        [Phone]
        public string phone { get; set; } = null!;
        public string Gender { get; set; } = null!;

        public string? DateOfBirth { get; set; }


        public string? PlanName { get; set; } 
        public string? MembershipStartDate { get; set; }
        public string? MembershipEndDate { get; set; }
        public string Address { get; set; } = null!;



    }
}
