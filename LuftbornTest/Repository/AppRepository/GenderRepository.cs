using BaseRepository;
using DAL;
using Entity.AppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.AppRepository
{
    public class GenderRepository:BaseRepository<Gender>
    {
        private readonly DataContext DB;
        public GenderRepository(DataContext DB):base(DB)
        {
            this.DB = DB;
        }
    }
}
