using DAL.Models;
using DAL.Models.Shared;
using DAL.Models.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.MemberDTOs
{
    public class CreateDTO
    {
        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Email Required")]
        [EmailAddress]
        
        public string Email { get; set; } = null!; //unique

        [Required(ErrorMessage = "Phone Required")]
        [Phone]
        public string phone { get; set; } = null!; // unique // Egyption phone validation
        public string Gender { get; set; } = null!;


        public string DateOfBirth { get; set; } = null!;

        [Required(ErrorMessage = "Address Required")]
        public string Address { get; set; } = null!;

        public HealthRecord HealthRecord { get; set; } = null!;

    }
}
