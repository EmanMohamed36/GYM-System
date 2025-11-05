using BLL.DTOs.MemberDTOs;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.MemberServices
{
    internal interface IMemberInterface
    {
        public IEnumerable<GetAllDTO> GetAllMembers();

        public GetDetailsDTO? GetMemberById(int id);

        public int CreateMember(CreateDTO createDTO);

        public int UpdateMember(UpdateDTO updateDTO);

        public int DeleteMember(int id);
    }
}
