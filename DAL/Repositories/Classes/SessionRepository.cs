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
    internal class SessionRepository(ApplicationDbContext _dbContext) :
        GenericRepository<Session>(_dbContext), ISessionRepository
    {
    }
}
