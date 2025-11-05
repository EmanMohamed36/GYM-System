using DAL.Data;
using DAL.Models;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Classes
{
    public class MemberRepository(ApplicationDbContext _dbContext) :
        GenericRepository<Member>(_dbContext), IMemberRepository
    {
    }
}
