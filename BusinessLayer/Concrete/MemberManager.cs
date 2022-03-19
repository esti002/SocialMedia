using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.MSSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MemberManager : IMamberService
    {
        EfMemberRepo memberRepo;

        public MemberManager()
        {
            memberRepo = new EfMemberRepo();
        }

        public void GenericAdd(Member t)
        {
            memberRepo.Insert(t);
        }

        public void GenericDelete(Member t)
        {
            memberRepo.Delete(t);
        }

        public void GenericUpdate(Member t)
        {
            memberRepo.Update(t);
        }

        public Member GetById(int id)
        {
            return memberRepo.GetById(id);
        }

        public List<Member> GetList()
        {
            return memberRepo.GetAll();
        }
    }
}
