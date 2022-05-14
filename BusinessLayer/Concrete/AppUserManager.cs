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
    public class AppUserManager : IAppUserService
    {
        EfAppUserRepo appUserRepo;

        public AppUserManager()
        {
            appUserRepo = new EfAppUserRepo();
        }

        public void GenericAdd(AppUser t)
        {
            appUserRepo.Insert(t);
        }

        public void GenericDelete(AppUser t)
        {
            appUserRepo.Delete(t);
        }

        public void GenericUpdate(AppUser t)
        {
            appUserRepo.Update(t);
        }

        public AppUser GetById(int id)
        {
            return appUserRepo.GetById(id);
        }

        public List<AppUser> GetList()
        {
            return appUserRepo.GetAll();
        }
    }
}
