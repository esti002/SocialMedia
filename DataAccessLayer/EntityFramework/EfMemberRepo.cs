using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.MSSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMemberRepo : GenericRepository<Member>, IMemberDal
    {
    }
}
