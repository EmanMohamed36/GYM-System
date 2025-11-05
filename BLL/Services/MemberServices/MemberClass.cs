using AutoMapper;
using BLL.DTOs.MemberDTOs;
using DAL.Models;
using DAL.Repositories.Interfaces;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.MemberServices
{
    internal class MemberClass(IUnitOfWork _unitOfWork ,
                               IMapper _mapper) : IMemberInterface
    {
        public int CreateMember(CreateDTO createDTO)

        {
             var MappedMember = _mapper.Map<Member>(createDTO);
            _unitOfWork.GetRepository<Member>().CreateAsync(MappedMember);
            return _unitOfWork.SaveChanges();
        }

        public int DeleteMember(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GetAllDTO> GetAllMembers()

        {
            var Members = _unitOfWork.GetRepository<Member>().GetAllAsync();
            if (Members is null) return [];
            var MappedMembers = _mapper.Map< IEnumerable<GetAllDTO>>(Members);
            return MappedMembers;
        }

        public GetDetailsDTO? GetMemberById(int id)
        {
            var member = _unitOfWork.GetRepository<Member>().GetByIdAsync(id);
            if(member is null) return null;
            var MappedMember = _mapper.Map<GetDetailsDTO>(member);

            //// Active MemberShip
            //var ActiveMemberShip = _unitOfWork.GetRepository<MembersAssignPlans>()
            //    .GetAllAsync(m => m.MemberId == member.Id && m.Status == "Active");

            //if (ActiveMemberShip is not null)
            //{
            //    foreach (var membership in ActiveMemberShip)
            //    { 
                    
            //    }
            //}
            return MappedMember;
        }

        public int UpdateMember(UpdateDTO updateDTO)
        {
            throw new NotImplementedException();
        }
    }
}
