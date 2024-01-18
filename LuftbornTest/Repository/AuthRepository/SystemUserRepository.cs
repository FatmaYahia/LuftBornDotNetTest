using BaseRepository;
using DAL;
using Entity.AuthModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.AuthRepository
{
    public class SystemUserRepository : BaseRepository<SystemUser>
    {
        public readonly DataContext DB;
        public SystemUserRepository(DataContext DB) : base(DB)
        {
            this.DB = DB;
        }
        public bool UserExist(string Email,string Password)
        {
            bool result = DB.SystemUsers.ToList()
                .Where(s => s.Email == Email)
                .Where(s => s.Password == Password)
                .Where(s => s.IsActive == true).Any();
            return result;
        }
        public SystemUser GetByEmail(string Email)
        {
            return DB.SystemUsers.Where(s => s.Email == Email).FirstOrDefault();
        }
    }
}
