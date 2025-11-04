using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Shared
{
    [Owned]
    public class Address
    {
        [Required(ErrorMessage = "BuildingNo Required")]

        public int BuildingNo { get; set; }

        [Required(ErrorMessage ="Street Required")]
        public string Street { get; set; } = null!;
        [Required(ErrorMessage = "City Required")]
        public string City { get; set; } = null!;

    }
}
